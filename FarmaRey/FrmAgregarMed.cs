using FarmaRey.contexts;
using FarmaRey.models;
using Microsoft.EntityFrameworkCore;

namespace FarmaRey
{
    public partial class FrmAgregarMed : Form
    {
        private readonly ApplicationDbContext applicationDbContext;
        private readonly LogsFarma log;
        private string? imagePath;

        public FrmAgregarMed(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
            this.log = new LogsFarma(typeof(FrmAgregarMed));
            InitializeComponent();
            log.Informacion("Iniciando Form");
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            log.Depuracion("Intentando guardar un nuevo medicamento");
            byte[]? imageBytes = null;
            string nombre = txtNombre.Text.Trim();
            decimal precio = decimal.Zero;
            Guid? categoria = null;
            int cantidad = (int)numCantidad.Value;

            if (cmbCategorias.SelectedValue != null)
            {
                categoria = (Guid)cmbCategorias.SelectedValue;
            }
            if (!string.IsNullOrEmpty(imagePath))
            {
                imageBytes = await File.ReadAllBytesAsync(imagePath);
            }
            if (string.IsNullOrEmpty(nombre))
            {
                log.Errores($"Nombre del medicamento vacio o null: '{nombre}'");
                MessageBox.Show("El nombre es requerido");
                return;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                log.Depuracion($"TextField de precio vacio o null: '{txtPrecio.Text}'");
                MessageBox.Show("El precio por unidad es requerido");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                log.Errores("TryParse de precio nuevo");
                MessageBox.Show("El precio por unidad debe ser un número válido");
                return;
            }
            if (precio < 0)
            {
                MessageBox.Show("El precio por unidad no puede ser negativo");
                return;
            }
            var medBd = await applicationDbContext.Medicamentos.FirstOrDefaultAsync(med => med.Nombre.ToLower().Contains(nombre.ToLower()));
            if (medBd != null)
            {
                log.Errores($"Error al crear existe un medicamento con el nombre {medBd}");
                MessageBox.Show("Ya existe un medicamento con este nombre. \nSi desea actualizar escriba directamente en la tabla de medicamentos", "Crear Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Medicamento med = new()
            {
                Nombre = nombre,
                ImagenData = imageBytes,
                CategoriaId = categoria,
                PrecioUnidad = precio,
                CantidadDisponible = cantidad,
                CreatedAt = DateTime.SpecifyKind(DateTime.UtcNow, DateTimeKind.Unspecified)
            };
            log.Depuracion("Intentando guardar nuevo medicamento");
            await applicationDbContext.Medicamentos.AddAsync(med);
            await applicationDbContext.SaveChangesAsync();
            log.Informacion("Cerrando forms de forma exitosa");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using OpenFileDialog file = ofdImagen;
            if (file.ShowDialog() == DialogResult.OK)
            {
                log.Depuracion("Dialogo de buscar imagen cerrado de forma exitosa");
                imagePath = file.FileName;
                log.Depuracion($"Archivo dado con nombre: {imagePath}, mostrando al usuario");
                picProducto.Image = new Bitmap(imagePath);
            }
        }

        private async void FrmAgregarMed_Load(object sender, EventArgs e)
        {
            log.Depuracion("Intentando cargar categorías en comboBox");
            var lista = await applicationDbContext.Categorias.ToListAsync();
            cmbCategorias.DataSource = lista;
            cmbCategorias.DisplayMember = "Nombre";
            cmbCategorias.ValueMember = "Id";
            cmbCategorias.SelectedItem = null;
        }

        public static void NumeroDecimal(in TextBox cajaDeTexto, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) || Char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !cajaDeTexto.Text.Contains('.'))
            {
                return;
            }
            if (e.KeyChar == '-' && !cajaDeTexto.Text.Contains('-'))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumeroDecimal(in txtPrecio, e);
        }
    }
}
