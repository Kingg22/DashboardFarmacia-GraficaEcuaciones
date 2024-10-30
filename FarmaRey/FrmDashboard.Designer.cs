namespace FarmaRey
{
    partial class FrmDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            panel1 = new Panel();
            btnVentas = new Button();
            btnMedicamentos = new Button();
            btnInicio = new Button();
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            tabVenta = new TabPage();
            tableLayoutPnlForm = new TableLayoutPanel();
            flowLayoutPnlForm = new FlowLayoutPanel();
            lblMedForm = new Label();
            cmbMedicamentos = new ComboBox();
            lblTPrecio = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            lblTSubTotal = new Label();
            lblSubtotal = new Label();
            btnAgregarProd = new Button();
            btnFinalizarVenta = new Button();
            btnMostrarCar = new Button();
            btnEliminarProd = new Button();
            btnCancelarVenta = new Button();
            pnlTVenta = new Panel();
            lblTVenta = new Label();
            tabMedicamentos = new TabPage();
            dgvMedicamentos = new DataGridView();
            tlPanelBuscarMed = new TableLayoutPanel();
            btnReabstecer = new Button();
            btnActualizarInvent = new Button();
            lblTMedicamentos = new Label();
            txtBuscarMed = new TextBox();
            picBoxLupaBMed = new PictureBox();
            cmbCategorias = new ComboBox();
            lblSubTMed = new Label();
            btnAgregarMed = new Button();
            tabControlVistas = new TabControl();
            tabVistas = new TabPage();
            tableLayoutPnlInicio = new TableLayoutPanel();
            lblIngresosVentas = new Label();
            dgvMedTopVendidos = new DataGridView();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dgvMedCostosos = new DataGridView();
            dgvMedMayorInv = new DataGridView();
            dgvMedBajoInv = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            lblCantMedDisp = new Label();
            lblCantVentas = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dgvVentasRecientes = new DataGridView();
            lblIngresosMes = new Label();
            pnlTInicio = new Panel();
            btnRefreshInicio = new Button();
            lblTInicio = new Label();
            panel1.SuspendLayout();
            pnlTitulo.SuspendLayout();
            tabVenta.SuspendLayout();
            tableLayoutPnlForm.SuspendLayout();
            flowLayoutPnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            pnlTVenta.SuspendLayout();
            tabMedicamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            tlPanelBuscarMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLupaBMed).BeginInit();
            tabControlVistas.SuspendLayout();
            tabVistas.SuspendLayout();
            tableLayoutPnlInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedTopVendidos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedCostosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedMayorInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedBajoInv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentasRecientes).BeginInit();
            pnlTInicio.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnVentas);
            panel1.Controls.Add(btnMedicamentos);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(pnlTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 672);
            panel1.TabIndex = 4;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatStyle = FlatStyle.Popup;
            btnVentas.Font = new Font("Microsoft Sans Serif", 12F);
            btnVentas.ForeColor = Color.White;
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 180);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(230, 65);
            btnVentas.TabIndex = 19;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnMedicamentos
            // 
            btnMedicamentos.Dock = DockStyle.Top;
            btnMedicamentos.FlatStyle = FlatStyle.Popup;
            btnMedicamentos.Font = new Font("Microsoft Sans Serif", 12F);
            btnMedicamentos.ForeColor = Color.White;
            btnMedicamentos.Image = (Image)resources.GetObject("btnMedicamentos.Image");
            btnMedicamentos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMedicamentos.Location = new Point(0, 115);
            btnMedicamentos.Name = "btnMedicamentos";
            btnMedicamentos.Size = new Size(230, 65);
            btnMedicamentos.TabIndex = 18;
            btnMedicamentos.Text = "     Medicamentos";
            btnMedicamentos.UseVisualStyleBackColor = true;
            btnMedicamentos.Click += btnMedicamentos_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatStyle = FlatStyle.Popup;
            btnInicio.Font = new Font("Microsoft Sans Serif", 12F);
            btnInicio.ForeColor = Color.White;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 50);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(230, 65);
            btnInicio.TabIndex = 17;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // pnlTitulo
            // 
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(230, 50);
            pnlTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(10, 10, 0, 0);
            lblTitulo.Size = new Size(233, 39);
            lblTitulo.TabIndex = 9;
            lblTitulo.Text = "FarmaRey             ";
            // 
            // tabVenta
            // 
            tabVenta.BackColor = Color.FromArgb(20, 20, 20);
            tabVenta.Controls.Add(tableLayoutPnlForm);
            tabVenta.Controls.Add(pnlTVenta);
            tabVenta.Location = new Point(4, 25);
            tabVenta.Name = "tabVenta";
            tabVenta.Padding = new Padding(3);
            tabVenta.Size = new Size(1026, 643);
            tabVenta.TabIndex = 2;
            tabVenta.Text = "Venta";
            // 
            // tableLayoutPnlForm
            // 
            tableLayoutPnlForm.ColumnCount = 3;
            tableLayoutPnlForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPnlForm.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPnlForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPnlForm.Controls.Add(flowLayoutPnlForm, 1, 0);
            tableLayoutPnlForm.Dock = DockStyle.Fill;
            tableLayoutPnlForm.Location = new Point(3, 53);
            tableLayoutPnlForm.Name = "tableLayoutPnlForm";
            tableLayoutPnlForm.RowCount = 1;
            tableLayoutPnlForm.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPnlForm.Size = new Size(1020, 587);
            tableLayoutPnlForm.TabIndex = 14;
            // 
            // flowLayoutPnlForm
            // 
            flowLayoutPnlForm.AutoSize = true;
            flowLayoutPnlForm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPnlForm.Controls.Add(lblMedForm);
            flowLayoutPnlForm.Controls.Add(cmbMedicamentos);
            flowLayoutPnlForm.Controls.Add(lblTPrecio);
            flowLayoutPnlForm.Controls.Add(lblPrecio);
            flowLayoutPnlForm.Controls.Add(lblCantidad);
            flowLayoutPnlForm.Controls.Add(numCantidad);
            flowLayoutPnlForm.Controls.Add(lblTSubTotal);
            flowLayoutPnlForm.Controls.Add(lblSubtotal);
            flowLayoutPnlForm.Controls.Add(btnAgregarProd);
            flowLayoutPnlForm.Controls.Add(btnFinalizarVenta);
            flowLayoutPnlForm.Controls.Add(btnMostrarCar);
            flowLayoutPnlForm.Controls.Add(btnEliminarProd);
            flowLayoutPnlForm.Controls.Add(btnCancelarVenta);
            flowLayoutPnlForm.Dock = DockStyle.Fill;
            flowLayoutPnlForm.FlowDirection = FlowDirection.TopDown;
            flowLayoutPnlForm.Location = new Point(342, 3);
            flowLayoutPnlForm.Name = "flowLayoutPnlForm";
            flowLayoutPnlForm.Padding = new Padding(15);
            flowLayoutPnlForm.Size = new Size(336, 581);
            flowLayoutPnlForm.TabIndex = 13;
            // 
            // lblMedForm
            // 
            lblMedForm.Anchor = AnchorStyles.None;
            lblMedForm.AutoSize = true;
            lblMedForm.Font = new Font("Microsoft Sans Serif", 12F);
            lblMedForm.ForeColor = Color.White;
            lblMedForm.Location = new Point(72, 15);
            lblMedForm.Name = "lblMedForm";
            lblMedForm.Size = new Size(192, 20);
            lblMedForm.TabIndex = 4;
            lblMedForm.Text = "Seleccionar medicamento";
            // 
            // cmbMedicamentos
            // 
            cmbMedicamentos.Anchor = AnchorStyles.None;
            cmbMedicamentos.BackColor = Color.FromArgb(39, 48, 59);
            cmbMedicamentos.Font = new Font("Microsoft Sans Serif", 12F);
            cmbMedicamentos.ForeColor = Color.White;
            cmbMedicamentos.FormattingEnabled = true;
            cmbMedicamentos.Location = new Point(18, 38);
            cmbMedicamentos.Name = "cmbMedicamentos";
            cmbMedicamentos.Size = new Size(300, 28);
            cmbMedicamentos.TabIndex = 5;
            cmbMedicamentos.SelectedIndexChanged += cmbMedicamentos_SelectedIndexChanged;
            // 
            // lblTPrecio
            // 
            lblTPrecio.Anchor = AnchorStyles.None;
            lblTPrecio.AutoSize = true;
            lblTPrecio.Font = new Font("Microsoft Sans Serif", 12F);
            lblTPrecio.ForeColor = Color.White;
            lblTPrecio.Location = new Point(113, 69);
            lblTPrecio.Name = "lblTPrecio";
            lblTPrecio.Size = new Size(109, 20);
            lblTPrecio.TabIndex = 8;
            lblTPrecio.Text = "Precio unitario";
            lblTPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.None;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Microsoft Sans Serif", 12F);
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(168, 89);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 20);
            lblPrecio.TabIndex = 9;
            lblPrecio.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.None;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 12F);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(131, 109);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(73, 20);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.None;
            numCantidad.BackColor = Color.FromArgb(39, 48, 59);
            numCantidad.Font = new Font("Microsoft Sans Serif", 12F);
            numCantidad.ForeColor = Color.White;
            numCantidad.Location = new Point(108, 132);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 26);
            numCantidad.TabIndex = 7;
            numCantidad.ValueChanged += numCantidad_ValueChanged;
            // 
            // lblTSubTotal
            // 
            lblTSubTotal.Anchor = AnchorStyles.None;
            lblTSubTotal.AutoSize = true;
            lblTSubTotal.Font = new Font("Microsoft Sans Serif", 12F);
            lblTSubTotal.ForeColor = Color.White;
            lblTSubTotal.Location = new Point(131, 161);
            lblTSubTotal.Name = "lblTSubTotal";
            lblTSubTotal.Size = new Size(73, 20);
            lblTSubTotal.TabIndex = 10;
            lblTSubTotal.Text = "SubTotal";
            lblTSubTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.None;
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Microsoft Sans Serif", 12F);
            lblSubtotal.ForeColor = Color.White;
            lblSubtotal.Location = new Point(168, 181);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(0, 20);
            lblSubtotal.TabIndex = 11;
            lblSubtotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarProd
            // 
            btnAgregarProd.Anchor = AnchorStyles.None;
            btnAgregarProd.BackColor = Color.FromArgb(53, 156, 250);
            btnAgregarProd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProd.ForeColor = Color.White;
            btnAgregarProd.Location = new Point(43, 204);
            btnAgregarProd.Name = "btnAgregarProd";
            btnAgregarProd.Size = new Size(250, 35);
            btnAgregarProd.TabIndex = 8;
            btnAgregarProd.Text = "Agregar producto al carrito";
            btnAgregarProd.UseVisualStyleBackColor = false;
            btnAgregarProd.Click += btnAgregarProd_Click;
            // 
            // btnFinalizarVenta
            // 
            btnFinalizarVenta.Anchor = AnchorStyles.None;
            btnFinalizarVenta.BackColor = Color.FromArgb(76, 175, 80);
            btnFinalizarVenta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFinalizarVenta.ForeColor = Color.White;
            btnFinalizarVenta.Location = new Point(43, 245);
            btnFinalizarVenta.Name = "btnFinalizarVenta";
            btnFinalizarVenta.Size = new Size(250, 35);
            btnFinalizarVenta.TabIndex = 9;
            btnFinalizarVenta.Text = "Finalizar Venta";
            btnFinalizarVenta.UseVisualStyleBackColor = false;
            btnFinalizarVenta.Click += btnFinalizarVenta_Click;
            // 
            // btnMostrarCar
            // 
            btnMostrarCar.Anchor = AnchorStyles.None;
            btnMostrarCar.BackColor = Color.FromArgb(187, 227, 248);
            btnMostrarCar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarCar.ForeColor = Color.Black;
            btnMostrarCar.Location = new Point(43, 286);
            btnMostrarCar.Name = "btnMostrarCar";
            btnMostrarCar.Size = new Size(250, 35);
            btnMostrarCar.TabIndex = 12;
            btnMostrarCar.Text = "Mostrar Carrito";
            btnMostrarCar.UseVisualStyleBackColor = false;
            btnMostrarCar.Click += btnMostrarCar_Click;
            // 
            // btnEliminarProd
            // 
            btnEliminarProd.Anchor = AnchorStyles.None;
            btnEliminarProd.BackColor = Color.Orange;
            btnEliminarProd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProd.ForeColor = Color.White;
            btnEliminarProd.Location = new Point(43, 327);
            btnEliminarProd.Name = "btnEliminarProd";
            btnEliminarProd.Size = new Size(250, 35);
            btnEliminarProd.TabIndex = 11;
            btnEliminarProd.Text = "Eliminar producto";
            btnEliminarProd.UseVisualStyleBackColor = false;
            btnEliminarProd.Click += btnEliminarProd_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Anchor = AnchorStyles.None;
            btnCancelarVenta.BackColor = Color.FromArgb(244, 67, 54);
            btnCancelarVenta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarVenta.ForeColor = Color.White;
            btnCancelarVenta.Location = new Point(43, 368);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(250, 35);
            btnCancelarVenta.TabIndex = 10;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = false;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // pnlTVenta
            // 
            pnlTVenta.Controls.Add(lblTVenta);
            pnlTVenta.Dock = DockStyle.Top;
            pnlTVenta.Location = new Point(3, 3);
            pnlTVenta.Name = "pnlTVenta";
            pnlTVenta.Size = new Size(1020, 50);
            pnlTVenta.TabIndex = 12;
            // 
            // lblTVenta
            // 
            lblTVenta.AutoSize = true;
            lblTVenta.Dock = DockStyle.Top;
            lblTVenta.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTVenta.ForeColor = Color.White;
            lblTVenta.Location = new Point(0, 0);
            lblTVenta.Name = "lblTVenta";
            lblTVenta.Padding = new Padding(10);
            lblTVenta.Size = new Size(94, 46);
            lblTVenta.TabIndex = 11;
            lblTVenta.Text = "Venta";
            // 
            // tabMedicamentos
            // 
            tabMedicamentos.BackColor = Color.FromArgb(20, 20, 20);
            tabMedicamentos.Controls.Add(dgvMedicamentos);
            tabMedicamentos.Controls.Add(tlPanelBuscarMed);
            tabMedicamentos.Location = new Point(4, 25);
            tabMedicamentos.Name = "tabMedicamentos";
            tabMedicamentos.Padding = new Padding(3);
            tabMedicamentos.Size = new Size(1026, 643);
            tabMedicamentos.TabIndex = 1;
            tabMedicamentos.Text = "Medicamentos";
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.AllowUserToAddRows = false;
            dgvMedicamentos.AllowUserToDeleteRows = false;
            dgvMedicamentos.AllowUserToOrderColumns = true;
            dgvMedicamentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedicamentos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvMedicamentos.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Dock = DockStyle.Fill;
            dgvMedicamentos.Location = new Point(3, 155);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersVisible = false;
            dgvMedicamentos.RowHeadersWidth = 62;
            dgvMedicamentos.Size = new Size(1020, 485);
            dgvMedicamentos.TabIndex = 4;
            // 
            // tlPanelBuscarMed
            // 
            tlPanelBuscarMed.ColumnCount = 3;
            tlPanelBuscarMed.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.99999F));
            tlPanelBuscarMed.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0000076F));
            tlPanelBuscarMed.ColumnStyles.Add(new ColumnStyle());
            tlPanelBuscarMed.Controls.Add(btnReabstecer, 1, 2);
            tlPanelBuscarMed.Controls.Add(btnActualizarInvent, 0, 2);
            tlPanelBuscarMed.Controls.Add(lblTMedicamentos, 0, 0);
            tlPanelBuscarMed.Controls.Add(txtBuscarMed, 1, 1);
            tlPanelBuscarMed.Controls.Add(picBoxLupaBMed, 2, 1);
            tlPanelBuscarMed.Controls.Add(cmbCategorias, 0, 1);
            tlPanelBuscarMed.Controls.Add(lblSubTMed, 1, 0);
            tlPanelBuscarMed.Controls.Add(btnAgregarMed, 2, 2);
            tlPanelBuscarMed.Dock = DockStyle.Top;
            tlPanelBuscarMed.Location = new Point(3, 3);
            tlPanelBuscarMed.Name = "tlPanelBuscarMed";
            tlPanelBuscarMed.RowCount = 3;
            tlPanelBuscarMed.RowStyles.Add(new RowStyle());
            tlPanelBuscarMed.RowStyles.Add(new RowStyle());
            tlPanelBuscarMed.RowStyles.Add(new RowStyle());
            tlPanelBuscarMed.Size = new Size(1020, 152);
            tlPanelBuscarMed.TabIndex = 3;
            // 
            // btnReabstecer
            // 
            btnReabstecer.Anchor = AnchorStyles.None;
            btnReabstecer.BackColor = Color.FromArgb(76, 175, 80);
            btnReabstecer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReabstecer.ForeColor = Color.White;
            btnReabstecer.Image = (Image)resources.GetObject("btnReabstecer.Image");
            btnReabstecer.ImageAlign = ContentAlignment.MiddleLeft;
            btnReabstecer.Location = new Point(458, 98);
            btnReabstecer.MinimumSize = new Size(185, 50);
            btnReabstecer.Name = "btnReabstecer";
            btnReabstecer.Size = new Size(200, 50);
            btnReabstecer.TabIndex = 16;
            btnReabstecer.Text = "Guardar cambios";
            btnReabstecer.TextAlign = ContentAlignment.MiddleRight;
            btnReabstecer.UseVisualStyleBackColor = false;
            btnReabstecer.Click += btnReabstecer_Click;
            // 
            // btnActualizarInvent
            // 
            btnActualizarInvent.Anchor = AnchorStyles.None;
            btnActualizarInvent.BackColor = Color.FromArgb(187, 227, 248);
            btnActualizarInvent.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizarInvent.ForeColor = Color.Black;
            btnActualizarInvent.Image = (Image)resources.GetObject("btnActualizarInvent.Image");
            btnActualizarInvent.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizarInvent.Location = new Point(62, 98);
            btnActualizarInvent.MinimumSize = new Size(240, 50);
            btnActualizarInvent.Name = "btnActualizarInvent";
            btnActualizarInvent.Size = new Size(248, 50);
            btnActualizarInvent.TabIndex = 15;
            btnActualizarInvent.Text = "Refrescar Lista Completa";
            btnActualizarInvent.TextAlign = ContentAlignment.MiddleRight;
            btnActualizarInvent.UseVisualStyleBackColor = false;
            btnActualizarInvent.Click += btnActualizarInvent_Click;
            // 
            // lblTMedicamentos
            // 
            lblTMedicamentos.AutoSize = true;
            lblTMedicamentos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTMedicamentos.ForeColor = Color.White;
            lblTMedicamentos.Location = new Point(3, 0);
            lblTMedicamentos.Name = "lblTMedicamentos";
            lblTMedicamentos.Padding = new Padding(10);
            lblTMedicamentos.Size = new Size(186, 46);
            lblTMedicamentos.TabIndex = 1;
            lblTMedicamentos.Text = "Medicamentos";
            // 
            // txtBuscarMed
            // 
            txtBuscarMed.Anchor = AnchorStyles.None;
            txtBuscarMed.BackColor = Color.FromArgb(50, 50, 50);
            txtBuscarMed.ForeColor = Color.White;
            txtBuscarMed.Location = new Point(399, 59);
            txtBuscarMed.Name = "txtBuscarMed";
            txtBuscarMed.PlaceholderText = "Buscar medicamentos...";
            txtBuscarMed.Size = new Size(318, 23);
            txtBuscarMed.TabIndex = 0;
            // 
            // picBoxLupaBMed
            // 
            picBoxLupaBMed.BackColor = Color.FromArgb(53, 156, 250);
            picBoxLupaBMed.Image = (Image)resources.GetObject("picBoxLupaBMed.Image");
            picBoxLupaBMed.Location = new Point(747, 49);
            picBoxLupaBMed.Name = "picBoxLupaBMed";
            picBoxLupaBMed.Size = new Size(49, 43);
            picBoxLupaBMed.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxLupaBMed.TabIndex = 2;
            picBoxLupaBMed.TabStop = false;
            picBoxLupaBMed.Click += picBoxLupaBMed_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Anchor = AnchorStyles.None;
            cmbCategorias.BackColor = Color.FromArgb(39, 48, 59);
            cmbCategorias.ForeColor = Color.White;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(36, 59);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(300, 24);
            cmbCategorias.TabIndex = 3;
            // 
            // lblSubTMed
            // 
            lblSubTMed.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblSubTMed.AutoSize = true;
            lblSubTMed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubTMed.ForeColor = Color.White;
            lblSubTMed.Location = new Point(375, 30);
            lblSubTMed.Name = "lblSubTMed";
            lblSubTMed.Size = new Size(327, 16);
            lblSubTMed.TabIndex = 4;
            lblSubTMed.Text = "Buscar por categoría - nombre (tabla editable)";
            // 
            // btnAgregarMed
            // 
            btnAgregarMed.Anchor = AnchorStyles.None;
            btnAgregarMed.BackColor = Color.FromArgb(76, 175, 80);
            btnAgregarMed.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarMed.ForeColor = Color.White;
            btnAgregarMed.Image = (Image)resources.GetObject("btnAgregarMed.Image");
            btnAgregarMed.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarMed.Location = new Point(747, 98);
            btnAgregarMed.MinimumSize = new Size(260, 50);
            btnAgregarMed.Name = "btnAgregarMed";
            btnAgregarMed.Size = new Size(269, 50);
            btnAgregarMed.TabIndex = 5;
            btnAgregarMed.Text = "Agregar nuevo medicamento";
            btnAgregarMed.TextAlign = ContentAlignment.MiddleRight;
            btnAgregarMed.UseVisualStyleBackColor = false;
            btnAgregarMed.Click += btnAgregarMed_Click;
            // 
            // tabControlVistas
            // 
            tabControlVistas.Controls.Add(tabVistas);
            tabControlVistas.Controls.Add(tabMedicamentos);
            tabControlVistas.Controls.Add(tabVenta);
            tabControlVistas.Dock = DockStyle.Fill;
            tabControlVistas.Location = new Point(230, 0);
            tabControlVistas.Name = "tabControlVistas";
            tabControlVistas.SelectedIndex = 0;
            tabControlVistas.Size = new Size(1034, 672);
            tabControlVistas.TabIndex = 5;
            // 
            // tabVistas
            // 
            tabVistas.BackColor = Color.FromArgb(20, 20, 20);
            tabVistas.Controls.Add(tableLayoutPnlInicio);
            tabVistas.Controls.Add(pnlTInicio);
            tabVistas.Location = new Point(4, 25);
            tabVistas.Name = "tabVistas";
            tabVistas.Padding = new Padding(3);
            tabVistas.Size = new Size(1026, 643);
            tabVistas.TabIndex = 3;
            tabVistas.Text = "Dashboard";
            // 
            // tableLayoutPnlInicio
            // 
            tableLayoutPnlInicio.ColumnCount = 3;
            tableLayoutPnlInicio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPnlInicio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPnlInicio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPnlInicio.Controls.Add(lblIngresosVentas, 0, 5);
            tableLayoutPnlInicio.Controls.Add(dgvMedTopVendidos, 2, 5);
            tableLayoutPnlInicio.Controls.Add(label9, 2, 4);
            tableLayoutPnlInicio.Controls.Add(label8, 1, 4);
            tableLayoutPnlInicio.Controls.Add(label7, 0, 4);
            tableLayoutPnlInicio.Controls.Add(dgvMedCostosos, 2, 3);
            tableLayoutPnlInicio.Controls.Add(dgvMedMayorInv, 1, 3);
            tableLayoutPnlInicio.Controls.Add(dgvMedBajoInv, 0, 3);
            tableLayoutPnlInicio.Controls.Add(label6, 2, 2);
            tableLayoutPnlInicio.Controls.Add(label5, 1, 2);
            tableLayoutPnlInicio.Controls.Add(label4, 0, 2);
            tableLayoutPnlInicio.Controls.Add(lblCantMedDisp, 1, 1);
            tableLayoutPnlInicio.Controls.Add(lblCantVentas, 0, 1);
            tableLayoutPnlInicio.Controls.Add(label3, 2, 0);
            tableLayoutPnlInicio.Controls.Add(label1, 1, 0);
            tableLayoutPnlInicio.Controls.Add(label2, 0, 0);
            tableLayoutPnlInicio.Controls.Add(dgvVentasRecientes, 2, 1);
            tableLayoutPnlInicio.Controls.Add(lblIngresosMes, 1, 5);
            tableLayoutPnlInicio.Dock = DockStyle.Fill;
            tableLayoutPnlInicio.Location = new Point(3, 53);
            tableLayoutPnlInicio.Name = "tableLayoutPnlInicio";
            tableLayoutPnlInicio.RowCount = 6;
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle());
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle());
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle());
            tableLayoutPnlInicio.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPnlInicio.Size = new Size(1020, 587);
            tableLayoutPnlInicio.TabIndex = 14;
            // 
            // lblIngresosVentas
            // 
            lblIngresosVentas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIngresosVentas.AutoSize = true;
            lblIngresosVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresosVentas.ForeColor = Color.White;
            lblIngresosVentas.Location = new Point(3, 494);
            lblIngresosVentas.Name = "lblIngresosVentas";
            lblIngresosVentas.Size = new Size(333, 25);
            lblIngresosVentas.TabIndex = 18;
            lblIngresosVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMedTopVendidos
            // 
            dgvMedTopVendidos.AllowUserToAddRows = false;
            dgvMedTopVendidos.AllowUserToDeleteRows = false;
            dgvMedTopVendidos.AllowUserToOrderColumns = true;
            dgvMedTopVendidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedTopVendidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvMedTopVendidos.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvMedTopVendidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedTopVendidos.Dock = DockStyle.Fill;
            dgvMedTopVendidos.Location = new Point(682, 429);
            dgvMedTopVendidos.Name = "dgvMedTopVendidos";
            dgvMedTopVendidos.ReadOnly = true;
            dgvMedTopVendidos.RowHeadersVisible = false;
            dgvMedTopVendidos.RowHeadersWidth = 62;
            dgvMedTopVendidos.Size = new Size(335, 155);
            dgvMedTopVendidos.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(682, 390);
            label9.Name = "label9";
            label9.Padding = new Padding(10);
            label9.Size = new Size(335, 36);
            label9.TabIndex = 14;
            label9.Text = "Medicamentos más vendidos";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(342, 390);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(334, 36);
            label8.TabIndex = 13;
            label8.Text = "Total de Ingresos Último Mes";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 390);
            label7.Name = "label7";
            label7.Padding = new Padding(10);
            label7.Size = new Size(333, 36);
            label7.TabIndex = 12;
            label7.Text = "Total de Ingresos por Ventas";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMedCostosos
            // 
            dgvMedCostosos.AllowUserToAddRows = false;
            dgvMedCostosos.AllowUserToDeleteRows = false;
            dgvMedCostosos.AllowUserToOrderColumns = true;
            dgvMedCostosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedCostosos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvMedCostosos.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvMedCostosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedCostosos.Dock = DockStyle.Fill;
            dgvMedCostosos.Location = new Point(682, 234);
            dgvMedCostosos.Name = "dgvMedCostosos";
            dgvMedCostosos.ReadOnly = true;
            dgvMedCostosos.RowHeadersVisible = false;
            dgvMedCostosos.RowHeadersWidth = 62;
            dgvMedCostosos.Size = new Size(335, 153);
            dgvMedCostosos.TabIndex = 11;
            // 
            // dgvMedMayorInv
            // 
            dgvMedMayorInv.AllowUserToAddRows = false;
            dgvMedMayorInv.AllowUserToDeleteRows = false;
            dgvMedMayorInv.AllowUserToOrderColumns = true;
            dgvMedMayorInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedMayorInv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvMedMayorInv.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvMedMayorInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedMayorInv.Dock = DockStyle.Fill;
            dgvMedMayorInv.Location = new Point(342, 234);
            dgvMedMayorInv.Name = "dgvMedMayorInv";
            dgvMedMayorInv.ReadOnly = true;
            dgvMedMayorInv.RowHeadersVisible = false;
            dgvMedMayorInv.RowHeadersWidth = 62;
            dgvMedMayorInv.Size = new Size(334, 153);
            dgvMedMayorInv.TabIndex = 10;
            // 
            // dgvMedBajoInv
            // 
            dgvMedBajoInv.AllowUserToAddRows = false;
            dgvMedBajoInv.AllowUserToDeleteRows = false;
            dgvMedBajoInv.AllowUserToOrderColumns = true;
            dgvMedBajoInv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMedBajoInv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvMedBajoInv.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvMedBajoInv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedBajoInv.Dock = DockStyle.Fill;
            dgvMedBajoInv.Location = new Point(3, 234);
            dgvMedBajoInv.Name = "dgvMedBajoInv";
            dgvMedBajoInv.ReadOnly = true;
            dgvMedBajoInv.RowHeadersVisible = false;
            dgvMedBajoInv.RowHeadersWidth = 62;
            dgvMedBajoInv.Size = new Size(333, 153);
            dgvMedBajoInv.TabIndex = 9;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(682, 195);
            label6.Name = "label6";
            label6.Padding = new Padding(10);
            label6.Size = new Size(335, 36);
            label6.TabIndex = 8;
            label6.Text = "Medicamentos más costosos";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(342, 195);
            label5.Name = "label5";
            label5.Padding = new Padding(10);
            label5.Size = new Size(334, 36);
            label5.TabIndex = 7;
            label5.Text = "Medicamentos con mayor inventario";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 195);
            label4.Name = "label4";
            label4.Padding = new Padding(10);
            label4.Size = new Size(333, 36);
            label4.TabIndex = 6;
            label4.Text = "Medicamentos con bajo inventario";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantMedDisp
            // 
            lblCantMedDisp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCantMedDisp.AutoSize = true;
            lblCantMedDisp.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantMedDisp.ForeColor = Color.White;
            lblCantMedDisp.Location = new Point(342, 103);
            lblCantMedDisp.Name = "lblCantMedDisp";
            lblCantMedDisp.Size = new Size(334, 25);
            lblCantMedDisp.TabIndex = 4;
            lblCantMedDisp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantVentas
            // 
            lblCantVentas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblCantVentas.AutoSize = true;
            lblCantVentas.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantVentas.ForeColor = Color.White;
            lblCantVentas.Location = new Point(3, 103);
            lblCantVentas.Name = "lblCantVentas";
            lblCantVentas.Size = new Size(333, 25);
            lblCantVentas.TabIndex = 3;
            lblCantVentas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(682, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(10);
            label3.Size = new Size(335, 36);
            label3.TabIndex = 2;
            label3.Text = "Ventas Recientes";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(342, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(334, 36);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de medicamentos disponibles";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10);
            label2.Size = new Size(333, 36);
            label2.TabIndex = 1;
            label2.Text = "Total de Ventas";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvVentasRecientes
            // 
            dgvVentasRecientes.AllowUserToAddRows = false;
            dgvVentasRecientes.AllowUserToDeleteRows = false;
            dgvVentasRecientes.AllowUserToOrderColumns = true;
            dgvVentasRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasRecientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvVentasRecientes.BackgroundColor = Color.FromArgb(20, 20, 20);
            dgvVentasRecientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasRecientes.Dock = DockStyle.Fill;
            dgvVentasRecientes.Location = new Point(682, 39);
            dgvVentasRecientes.Name = "dgvVentasRecientes";
            dgvVentasRecientes.ReadOnly = true;
            dgvVentasRecientes.RowHeadersVisible = false;
            dgvVentasRecientes.RowHeadersWidth = 62;
            dgvVentasRecientes.Size = new Size(335, 153);
            dgvVentasRecientes.TabIndex = 5;
            // 
            // lblIngresosMes
            // 
            lblIngresosMes.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblIngresosMes.AutoSize = true;
            lblIngresosMes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresosMes.ForeColor = Color.White;
            lblIngresosMes.Location = new Point(342, 494);
            lblIngresosMes.Name = "lblIngresosMes";
            lblIngresosMes.Size = new Size(334, 25);
            lblIngresosMes.TabIndex = 19;
            lblIngresosMes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTInicio
            // 
            pnlTInicio.Controls.Add(btnRefreshInicio);
            pnlTInicio.Controls.Add(lblTInicio);
            pnlTInicio.Dock = DockStyle.Top;
            pnlTInicio.Location = new Point(3, 3);
            pnlTInicio.Name = "pnlTInicio";
            pnlTInicio.Size = new Size(1020, 50);
            pnlTInicio.TabIndex = 13;
            // 
            // btnRefreshInicio
            // 
            btnRefreshInicio.BackColor = Color.FromArgb(187, 227, 248);
            btnRefreshInicio.Dock = DockStyle.Right;
            btnRefreshInicio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshInicio.ForeColor = Color.Black;
            btnRefreshInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefreshInicio.Location = new Point(800, 0);
            btnRefreshInicio.Name = "btnRefreshInicio";
            btnRefreshInicio.Size = new Size(220, 50);
            btnRefreshInicio.TabIndex = 16;
            btnRefreshInicio.Text = "Refrescar Dashboard";
            btnRefreshInicio.UseVisualStyleBackColor = false;
            btnRefreshInicio.Click += btnRefreshInicio_Click;
            // 
            // lblTInicio
            // 
            lblTInicio.AutoSize = true;
            lblTInicio.Dock = DockStyle.Left;
            lblTInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTInicio.ForeColor = Color.White;
            lblTInicio.Location = new Point(0, 0);
            lblTInicio.Name = "lblTInicio";
            lblTInicio.Padding = new Padding(10);
            lblTInicio.Size = new Size(177, 46);
            lblTInicio.TabIndex = 11;
            lblTInicio.Text = "Vista General";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(1264, 672);
            Controls.Add(tabControlVistas);
            Controls.Add(panel1);
            MinimumSize = new Size(1022, 570);
            Name = "FrmDashboard";
            Text = "Dashboard FarmaRey";
            WindowState = FormWindowState.Maximized;
            FormClosing += FrmDashboard_FormClosing;
            panel1.ResumeLayout(false);
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            tabVenta.ResumeLayout(false);
            tableLayoutPnlForm.ResumeLayout(false);
            tableLayoutPnlForm.PerformLayout();
            flowLayoutPnlForm.ResumeLayout(false);
            flowLayoutPnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            pnlTVenta.ResumeLayout(false);
            pnlTVenta.PerformLayout();
            tabMedicamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            tlPanelBuscarMed.ResumeLayout(false);
            tlPanelBuscarMed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLupaBMed).EndInit();
            tabControlVistas.ResumeLayout(false);
            tabVistas.ResumeLayout(false);
            tableLayoutPnlInicio.ResumeLayout(false);
            tableLayoutPnlInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedTopVendidos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedCostosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedMayorInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMedBajoInv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentasRecientes).EndInit();
            pnlTInicio.ResumeLayout(false);
            pnlTInicio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel pnlTitulo;
        private Label lblTitulo;
        private TabPage tabVenta;
        private TableLayoutPanel tableLayoutPnlForm;
        private FlowLayoutPanel flowLayoutPnlForm;
        private Label lblMedForm;
        private ComboBox cmbMedicamentos;
        private Label lblTPrecio;
        private Label lblPrecio;
        private Label lblCantidad;
        private NumericUpDown numCantidad;
        private Label lblTSubTotal;
        private Label lblSubtotal;
        private Button btnAgregarProd;
        private Button btnFinalizarVenta;
        private Button btnMostrarCar;
        private Button btnEliminarProd;
        private Button btnCancelarVenta;
        private Panel pnlTVenta;
        private Label lblTVenta;
        private TabPage tabMedicamentos;
        private DataGridView dgvMedicamentos;
        private TableLayoutPanel tlPanelBuscarMed;
        private Button btnReabstecer;
        private Button btnActualizarInvent;
        private Label lblTMedicamentos;
        private TextBox txtBuscarMed;
        private PictureBox picBoxLupaBMed;
        private ComboBox cmbCategorias;
        private Label lblSubTMed;
        private Button btnAgregarMed;
        private TabControl tabControlVistas;
        private TabPage tabVistas;
        private Button btnVentas;
        private Button btnMedicamentos;
        private Button btnInicio;
        private Panel pnlTInicio;
        private Label lblTInicio;
        private TableLayoutPanel tableLayoutPnlInicio;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label lblCantMedDisp;
        private Label lblCantVentas;
        private DataGridView dgvVentasRecientes;
        private Button btnRefreshInicio;
        private DataGridView dgvMedCostosos;
        private DataGridView dgvMedMayorInv;
        private DataGridView dgvMedBajoInv;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label lblIngresosVentas;
        private DataGridView dgvMedTopVendidos;
        private Label lblIngresosMes;
    }
}
