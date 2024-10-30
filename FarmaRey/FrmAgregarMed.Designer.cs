namespace FarmaRey
{
    partial class FrmAgregarMed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ofdImagen = new OpenFileDialog();
            flowLayoutPnlForm = new FlowLayoutPanel();
            lblTMedicamentos = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            numCantidad = new NumericUpDown();
            label3 = new Label();
            cmbCategorias = new ComboBox();
            label4 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            btnSelectImage = new Button();
            picProducto = new PictureBox();
            btnGuardar = new Button();
            flowLayoutPnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picProducto).BeginInit();
            SuspendLayout();
            // 
            // ofdImagen
            // 
            ofdImagen.Filter = "Image Files|*.jpg;*.png;*.jpeg;*.bmp;*.svg";
            // 
            // flowLayoutPnlForm
            // 
            flowLayoutPnlForm.Controls.Add(lblTMedicamentos);
            flowLayoutPnlForm.Controls.Add(label1);
            flowLayoutPnlForm.Controls.Add(txtNombre);
            flowLayoutPnlForm.Controls.Add(label2);
            flowLayoutPnlForm.Controls.Add(numCantidad);
            flowLayoutPnlForm.Controls.Add(label3);
            flowLayoutPnlForm.Controls.Add(cmbCategorias);
            flowLayoutPnlForm.Controls.Add(label4);
            flowLayoutPnlForm.Controls.Add(txtPrecio);
            flowLayoutPnlForm.Controls.Add(label5);
            flowLayoutPnlForm.Controls.Add(btnSelectImage);
            flowLayoutPnlForm.Controls.Add(picProducto);
            flowLayoutPnlForm.Controls.Add(btnGuardar);
            flowLayoutPnlForm.Dock = DockStyle.Fill;
            flowLayoutPnlForm.FlowDirection = FlowDirection.TopDown;
            flowLayoutPnlForm.Location = new Point(0, 0);
            flowLayoutPnlForm.Name = "flowLayoutPnlForm";
            flowLayoutPnlForm.Padding = new Padding(10);
            flowLayoutPnlForm.Size = new Size(584, 561);
            flowLayoutPnlForm.TabIndex = 0;
            // 
            // lblTMedicamentos
            // 
            lblTMedicamentos.AutoSize = true;
            lblTMedicamentos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            lblTMedicamentos.ForeColor = Color.White;
            lblTMedicamentos.Location = new Point(13, 10);
            lblTMedicamentos.Name = "lblTMedicamentos";
            lblTMedicamentos.Padding = new Padding(10);
            lblTMedicamentos.Size = new Size(249, 46);
            lblTMedicamentos.TabIndex = 2;
            lblTMedicamentos.Text = "Nuevo Medicamento";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 56);
            label1.Name = "label1";
            label1.Size = new Size(559, 17);
            label1.TabIndex = 3;
            label1.Text = "Nombre del medicamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BackColor = Color.FromArgb(39, 48, 59);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(13, 76);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Nombre...";
            txtNombre.Size = new Size(559, 23);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 102);
            label2.Name = "label2";
            label2.Size = new Size(559, 17);
            label2.TabIndex = 5;
            label2.Text = "Cantidad disponible en inventario";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            numCantidad.BackColor = Color.FromArgb(39, 48, 59);
            numCantidad.ForeColor = Color.White;
            numCantidad.Location = new Point(13, 122);
            numCantidad.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(559, 23);
            numCantidad.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(13, 148);
            label3.Name = "label3";
            label3.Size = new Size(559, 17);
            label3.TabIndex = 7;
            label3.Text = "Categoría del medicamento";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCategorias
            // 
            cmbCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbCategorias.BackColor = Color.FromArgb(39, 48, 59);
            cmbCategorias.ForeColor = Color.White;
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(13, 168);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(559, 24);
            cmbCategorias.TabIndex = 11;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 195);
            label4.Name = "label4";
            label4.Size = new Size(559, 17);
            label4.TabIndex = 12;
            label4.Text = "Precio por unidad";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrecio.BackColor = Color.FromArgb(39, 48, 59);
            txtPrecio.ForeColor = Color.White;
            txtPrecio.Location = new Point(13, 215);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PlaceholderText = "Precio...";
            txtPrecio.Size = new Size(559, 23);
            txtPrecio.TabIndex = 13;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(13, 241);
            label5.Name = "label5";
            label5.Size = new Size(559, 17);
            label5.TabIndex = 14;
            label5.Text = "Imagen del producto";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Anchor = AnchorStyles.None;
            btnSelectImage.BackColor = Color.FromArgb(187, 227, 248);
            btnSelectImage.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectImage.ForeColor = Color.Black;
            btnSelectImage.Location = new Point(13, 261);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(559, 35);
            btnSelectImage.TabIndex = 15;
            btnSelectImage.Text = "Buscar Imagen";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // picProducto
            // 
            picProducto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            picProducto.Location = new Point(13, 302);
            picProducto.Name = "picProducto";
            picProducto.Size = new Size(559, 204);
            picProducto.SizeMode = PictureBoxSizeMode.Zoom;
            picProducto.TabIndex = 16;
            picProducto.TabStop = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.None;
            btnGuardar.BackColor = Color.FromArgb(76, 175, 80);
            btnGuardar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(167, 512);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(250, 35);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmAgregarMed
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 20, 20);
            ClientSize = new Size(584, 561);
            Controls.Add(flowLayoutPnlForm);
            Name = "FrmAgregarMed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar Medicamento";
            Load += FrmAgregarMed_Load;
            flowLayoutPnlForm.ResumeLayout(false);
            flowLayoutPnlForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)picProducto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog ofdImagen;
        private FlowLayoutPanel flowLayoutPnlForm;
        private Label lblTMedicamentos;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private NumericUpDown numCantidad;
        private Button btnGuardar;
        private ComboBox cmbCategorias;
        private Label label4;
        private TextBox txtPrecio;
        private Label label5;
        private Button btnSelectImage;
        private PictureBox picProducto;
    }
}