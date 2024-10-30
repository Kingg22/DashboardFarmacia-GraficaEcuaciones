using FarmaRey.contexts;
using FarmaRey.models;
using FarmaRey.presentation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;

namespace FarmaRey
{
    public partial class FrmDashboard : Form
    {
        private readonly IServiceProvider serviceProvider;
        private readonly ApplicationDbContext applicationDbContext;
        private readonly LogsFarma logs;
        private CarritoVenta? CarritoVenta;

        public FrmDashboard(ApplicationDbContext applicationDbContext, IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            this.applicationDbContext = applicationDbContext;
            this.logs = new LogsFarma(typeof(FrmDashboard));
            InitializeComponent();
            // Mostrar el Page de Inicio al empezar
            btnInicio_Click(null, null);
            // Necesario para no detener el renderizado del forms (en FormsLoad), pero asegurar que carguen los datos
            _ = cargarPlaceHolders();
            logs.Informacion("Iniciando forms");
        }

        // Tab Menu
        private void limpiarTabs()
        {
            tabMedicamentos.Parent = null;
            tabVenta.Parent = null;
            tabVistas.Parent = null;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            limpiarTabs();
            tabControlVistas.TabPages.Add(tabVistas);
            tabControlVistas.SelectedTab = tabVistas;

        }

        private void btnMedicamentos_Click(object sender, EventArgs e)
        {
            limpiarTabs();
            tabControlVistas.TabPages.Add(tabMedicamentos);
            tabControlVistas.SelectedTab = tabMedicamentos;
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            limpiarTabs();
            tabControlVistas.TabPages.Add(tabVenta);
            tabControlVistas.SelectedTab = tabVenta;
        }

        private async void picBoxLupaBMed_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando hacer query para buscar medicamento");
            // Buscar medicamento
            string nombre = txtBuscarMed.Text.Trim().ToLower();
            Guid idCategoria = Guid.Empty;
            bool filters = false;

            if (cmbCategorias.SelectedValue != null)
            {
                idCategoria = (Guid)cmbCategorias.SelectedValue;
            }
            // Hacer una query condicional si categoria fue dado o no
            var query = applicationDbContext.Medicamentos.AsQueryable();
            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(med => med.Nombre.ToLower().Contains(nombre));
                filters = true;
            }

            if (idCategoria != Guid.Empty)
            {
                query = query.Where(med => med.Categoria.Id == idCategoria);
                filters = true;
            }

            if (!filters)
            {
                logs.Advertencia("Rechazado intento de busqueda de medicamentos sin parámetros");
                dgvMedicamentos.DataSource = null;
                MessageBox.Show("No fueron dados parámetros para búscar el medicamento.\n Tip: Refrescar toda la lista y/o la categoría es opcional", "Consulta inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            logs.Depuracion((string)"Query de buscar medicamento: ".Concat(query.ToQueryString()));
            var listaResult = await query.ToListAsync();
            cargarMedicamentosDgv(ref dgvMedicamentos, listaResult);
        }

        private void numCantidad_ValueChanged(object sender, EventArgs e)
        {
            lblSubtotal.Text = string.Empty;
            string precioText = lblPrecio.Text;
            // calcular solo para el display el subtotal
            if (!string.IsNullOrEmpty(precioText))
            {
                if (decimal.TryParse(lblPrecio.Text, out decimal precio))
                {
                    int cantidad = (int)numCantidad.Value;
                    lblSubtotal.Text = ((decimal)precio * cantidad).ToString();
                }
                else
                {
                    logs.Errores("Error en TryParse cantidad de productos a vender");
                    MessageBox.Show("Ha ocurrido un error. Intente nuevamente la cantidad a vender", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando agregar producto al carrito de venta");
            Medicamento medicamento;
            int cantidad = (int)numCantidad.Value;
            var item = cmbMedicamentos.SelectedItem;

            if (CarritoVenta == null)
            {
                logs.Depuracion("No existía carrito, creando uno nuevo");
                this.CarritoVenta = new CarritoVenta();
            }

            if (item != null)
            {
                medicamento = (Medicamento)item;
            }
            else
            {
                MessageBox.Show("Seleccione un medicamento para agregar", "Producto Carrito de venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cantidad < 1)
            {
                MessageBox.Show("La cantidad no puede ser menor a 1. \nVerificar stock disponible", "Cantidad de producto Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.CarritoVenta.AgregarProducto(medicamento, cantidad);
            limpiarFormVenta();
            MessageBox.Show("Producto agregado con éxito");
        }

        private void cmbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrecio.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
            var selectedItem = cmbMedicamentos.SelectedItem;
            if (selectedItem != null)
            {
                var item = (Medicamento)selectedItem;
                // colocar precio unitario al label
                lblPrecio.Text = item.PrecioUnidad.ToString();
                // Limitar la cantidad a vender al stock disponible
                numCantidad.Maximum = item.CantidadDisponible;
                numCantidad.Value = 0;
                numCantidad_ValueChanged(sender, e);
                // Llamar al evento de calcular el subtotal para asegurar el cálculo
            }
        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando guardar carrito de ventas en la bd");
            if (CarritoVenta == null)
            {
                MessageBox.Show("No hay carrito de venta creado, ingrese productos primero", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (CarritoVenta.CantidadProductos() == 0)
            {
                MessageBox.Show("No hay productos en el carrito, ingrese productos primero", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using var transaction = await applicationDbContext.Database.BeginTransactionAsync();
            try
            {
                // Limpiar el seguimiento de entities para no tener conflictos si alguna entity esta siendo tracked
                applicationDbContext.ChangeTracker.Clear();

                logs.Depuracion("Guardando venta");
                var venta = new Venta()
                {
                    Id = CarritoVenta.IdVenta,
                    Fecha = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified)
                };
                await applicationDbContext.Ventas.AddAsync(venta);
                await applicationDbContext.SaveChangesAsync();
                logs.Depuracion("Guardando detalles de venta");

                var productosDetalles = CarritoVenta.GetDetallesVentas();
                await applicationDbContext.DetalleVenta.AddRangeAsync(productosDetalles);
                await applicationDbContext.SaveChangesAsync();

                logs.Depuracion("Intentando guardar toda la transacción");
                await transaction.CommitAsync();
                CarritoVenta = null;
                limpiarFormVenta();
                MessageBox.Show("Venta guardada de forma exitosa", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
                logs.Informacion("Venta guardada de forma exitosa en la BD");
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                logs.Excepciones(ex, "Excepción al intentar guardar el carrito de venta. RollbackTransaction");
                MessageBox.Show("Ha ocurrido un error, vuelva a intentarlo");
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            CarritoVenta = null;
            MessageBox.Show("Carrito de venta cancelado", "Acción irreversible", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando eliminar productos del carrito de venta");
            if (CarritoVenta != null)
            {
                var lista = CarritoVenta.ListDetalleVenta
                    .Select(x => new DetalleVentaDto(x.Id, x.Medicamento.Nombre, x.Medicamento.PrecioUnidad, x.Cantidad))
                    .ToList();
                logs.Depuracion($"Mostrando a {typeof(FrmSelectData)}");
                using var dialog = new FrmSelectData(lista);
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    List<object> selectedItems = dialog.SelectedItems;
                    logs.Depuracion("Dialogo cerrado de forma exitosa");
                    foreach (var item in selectedItems)
                    {
                        logs.Informacion($"Eliminando del carrito el producto: {item.ToString()}");
                        if (item != null && Guid.TryParse(item.ToString(), out Guid id))
                        {
                            CarritoVenta.EliminarProducto(id);
                        }
                        else
                        {
                            logs.Errores($"Error en TryParse al eliminar el producto: {item}");
                            MessageBox.Show("Ha ocurrido un error para eliminar el producto. \nIntente nuevamente", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("El carrito está vacío. Ingrese productos primero", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnMostrarCar_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando mostrar carrito de venta");
            if (CarritoVenta != null)
            {
                var lista = CarritoVenta.ListDetalleVenta
                    .Select(x => new DetalleVentaDto(x.Id, x.Medicamento.Nombre, x.Medicamento.PrecioUnidad, x.Cantidad))
                    .ToList();
                using var dialog = new FrmSelectData(lista);
                logs.Depuracion($"Mostrando carrito de venta en {typeof(FrmSelectData)}");
                dialog.dgvData.Columns["Select"].Visible = false;
                dialog.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("El carrito está vacío. Ingrese productos primero", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void limpiarFormVenta()
        {
            cmbMedicamentos.SelectedItem = null;
            numCantidad.Value = 0;
            lblPrecio.Text = string.Empty;
            lblSubtotal.Text = string.Empty;
        }

        private void cargarMedicamentosDgv(ref DataGridView dgv, List<Medicamento> medicamentos)
        {
            logs.Depuracion($"Intentando cargar lista de medicamentos a dgv: {dgv.ToString()}");
            dgv.DataSource = medicamentos;
            if (medicamentos == null) { return; }
            dgv.Columns["Id"].Visible = false;
            dgv.Columns["CategoriaId"].Visible = false;
            dgv.Columns["Categoria"].Visible = false;
            dgv.Columns["ImagenData"].Visible = false;
            // Añade la columna de la imagen si no existe
            if (!dgv.Columns.Contains("Image"))
            {
                dgv.Columns.Add(new DataGridViewImageColumn()
                {
                    Name = "Image",
                    HeaderText = "Imagen del producto",
                    ImageLayout = DataGridViewImageCellLayout.Zoom,
                    DefaultCellStyle = new DataGridViewCellStyle() { NullValue = null }
                });
            }

            if (medicamentos.Count == 0) { return; }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                var med = (Medicamento)row.DataBoundItem;
                if (med != null && med.ImagenData != null)
                {
                    logs.Depuracion("Intentando agregar imagen existente en la BD");
                    try
                    {
                        using var ms = new MemoryStream(med.ImagenData);
                        Image image = Image.FromStream(ms);
                        row.Cells["Image"].Value = image;
                    }
                    catch (Exception ex)
                    {
                        logs.Excepciones(ex, $"Error al cargar la imagen de este medicamento: {med}");
                        MessageBox.Show("Ha ocurrido un error al cargar la imagen. Intente nuevamente", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    logs.Depuracion($"No existe imagen del medicamento: {med}");
                    row.Cells["Image"].Value = null;
                }
            }
        }

        private void btnAgregarMed_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentando agregar un nuevo medicamento");
            var formMed = serviceProvider.GetRequiredService<FrmAgregarMed>();
            using var dialog = formMed;
            logs.Depuracion($"Abriendo {typeof(FrmAgregarMed)}");
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                logs.Depuracion("Dialog cerrado de forma exitosa");
                MessageBox.Show("Medicamento guardado", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnActualizarInvent_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Intentado actualizar lista de medicamentos");
            if (applicationDbContext.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show("Hay cambios sin guardar \n¿Está seguro de actualizar?", string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    logs.Informacion("Actualizar lista cancelada por el usuario, tiene cambios sin guardar");
                    return;
                }
            }
            applicationDbContext.ChangeTracker.Clear();
            var listaInventario = await applicationDbContext.Medicamentos.OrderBy(med => med.Nombre).ToListAsync();
            cargarMedicamentosDgv(ref dgvMedicamentos, listaInventario);
            dgvMedicamentos.Columns["CreatedAt"].Visible = false;
            dgvMedicamentos.Columns["UpdatedAt"].Visible = false;
        }

        private async void btnReabstecer_Click(object sender, EventArgs e)
        {
            using var transaction = await applicationDbContext.Database.BeginTransactionAsync();
            try
            {
                logs.Informacion("Intentando guardar cambios en medicamentos");
                if (applicationDbContext.ChangeTracker.HasChanges())
                {
                    // Se guardan los cambios hechos, no hubo necesidad de insertar en AbastecerProductos
                    await applicationDbContext.SaveChangesAsync();
                    await transaction.CommitAsync();
                    logs.Informacion("Se guardaron cambios de dgv medicamentos en la BD");
                    btnActualizarInvent_Click(sender, e);
                    MessageBox.Show("Se han guardando los cambios correctamente", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logs.Informacion("No hay cambios para guardar en la BD");
                    MessageBox.Show("No hay cambios para guardar. \nTip: Refrescar esta vista solamente antes de hacer cambios.", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                logs.Excepciones(ex, "Error al guardar cambios en dgv medicamentos. Rollback Transaction");
                MessageBox.Show("Ha ocurrido un error al guardar los cambios. Intente nuevamente", "Medicamentos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarDashboard()
        {
            lblCantMedDisp.Text = string.Empty;
            lblCantVentas.Text = string.Empty;
            lblIngresosMes.Text = string.Empty;
            lblIngresosVentas.Text = string.Empty;

            dgvVentasRecientes.DataSource = null;
            dgvMedCostosos.DataSource = null;
            dgvMedMayorInv.DataSource = null;
            dgvMedTopVendidos.DataSource = null;
            dgvMedBajoInv.DataSource = null;
        }

        private async Task cargarPlaceHolders()
        {
            logs.Depuracion("Intentando cargar información a los comboBox");
            var listaMedicamentos = await applicationDbContext.Medicamentos.OrderBy(med => med.Nombre).ToListAsync();
            var listaCategorias = await applicationDbContext.Categorias.OrderBy(cat => cat.Nombre).ToListAsync();
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = listaCategorias;
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";

            cmbMedicamentos.DataSource = null;
            cmbMedicamentos.DataSource = listaMedicamentos;
            cmbMedicamentos.DisplayMember = "Nombre";
            cmbMedicamentos.ValueMember = "Id";

            // Se intenta cambiar el seleccionado a ninguno
            cmbCategorias.SelectedItem = null;
            cmbMedicamentos.SelectedItem = null;
            limpiarFormVenta();
        }

        private async void btnRefreshInicio_Click(object sender, EventArgs e)
        {
            logs.Depuracion("Refrescando el dashboard de inicio");
            limpiarDashboard();
            await cargarPlaceHolders();
            lblCantMedDisp.Text = (await applicationDbContext.Medicamentos.Where(med => med.CantidadDisponible > 0).CountAsync()).ToString();
            lblCantVentas.Text = (await applicationDbContext.Ventas.CountAsync()).ToString();
            dgvVentasRecientes.DataSource = await applicationDbContext.Ventas.OrderByDescending(venta => venta.Fecha).Take(10).ToListAsync();
            dgvVentasRecientes.Columns["Id"].Visible = false;

            var listMedCostosos = await applicationDbContext.Medicamentos
                                                            .Where(med => med.CantidadDisponible > 0)
                                                            .OrderByDescending(med => med.PrecioUnidad)
                                                            .Take(10)
                                                            .ToListAsync();
            cargarMedicamentosDgv(ref dgvMedCostosos, listMedCostosos);
            dgvMedCostosos.Columns["CreatedAt"].Visible = false;
            dgvMedCostosos.Columns["UpdatedAt"].Visible = false;
            dgvMedCostosos.Columns["Image"].Visible = false;

            var listMedBajoInv = await applicationDbContext.Medicamentos.Where(med => med.CantidadDisponible < 5).ToListAsync();
            cargarMedicamentosDgv(ref dgvMedBajoInv, listMedBajoInv);
            dgvMedBajoInv.Columns["CreatedAt"].Visible = false;
            dgvMedBajoInv.Columns["UpdatedAt"].Visible = false;
            dgvMedBajoInv.Columns["Image"].Visible = false;

            var listMedAltoInv = await applicationDbContext.Medicamentos
                                                            .Where(med => med.CantidadDisponible > 0)
                                                            .OrderByDescending(med => med.CantidadDisponible)
                                                            .Take(10)
                                                            .ToListAsync();
            cargarMedicamentosDgv(ref dgvMedMayorInv, listMedAltoInv);
            dgvMedMayorInv.Columns["CreatedAt"].Visible = false;
            dgvMedMayorInv.Columns["UpdatedAt"].Visible = false;
            dgvMedMayorInv.Columns["Image"].Visible = false;

            lblIngresosVentas.Text = (await applicationDbContext.Ventas.SumAsync(venta => venta.Total)).ToString();

            lblIngresosMes.Text = (await applicationDbContext.Ventas
                                                            .Where(venta => venta.Fecha >= DateTime.Today.AddDays(-30))
                                                            .SumAsync(venta => venta.Total))
                                                            .ToString();

            var listMedTopVendidos = await applicationDbContext.DetalleVenta
                                                                .Include(detalle => detalle.Medicamento)
                                                                .Where(detalle => detalle.Medicamento != null)
                                                                .GroupBy(detalle => detalle.Medicamento)
                                                                .Select(d => new NombreCantidadDto()
                                                                {
                                                                    Nombre = d.Key.Nombre,
                                                                    Cantidad = d.Sum(d => d.Cantidad)
                                                                })
                                                                .OrderByDescending(detalle => detalle.Cantidad)
                                                                .Take(10)
                                                                .ToListAsync();
            dgvMedTopVendidos.DataSource = listMedTopVendidos;

            // Limpiar la memoria ya que podía llegar a Gb (por un par de segundos hasta el GC de C# limpie)
            // si se actualiza seguido el dashboard
            logs.Informacion("Limpiando memoria RAM con GC");
            GC.Collect();
        }

        private void FrmDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            logs.Informacion("Intentando cerrar formulario");
            if (applicationDbContext.ChangeTracker.HasChanges())
            {
                if (MessageBox.Show("Hay cambios sin guardar \n¿Está seguro de cerrar?", "Cerrar Forms", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    logs.Informacion("El usuario a cancelado cerrar ya que tiene cambios sin guardar");
                    e.Cancel = true;
                }
            }
            if (CarritoVenta != null)
            {
                if (MessageBox.Show("Hay una venta sin guardar \n¿Está seguro de cerrar?", "Cerrar Forms", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    logs.Informacion("El usuario ha cancelado cerrar ya que tiene una venta sin guardar");
                    e.Cancel = true;
                }
            }
        }
    }
}
