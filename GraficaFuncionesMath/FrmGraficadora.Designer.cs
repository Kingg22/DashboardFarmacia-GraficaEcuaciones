namespace GraficaFuncionesMath
{
    partial class FrmGraficadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGraficadora));
            lblTitulo = new Label();
            label1 = new Label();
            grpEntrada = new GroupBox();
            lblEcua0 = new Label();
            lblEcuaX = new Label();
            lblEcuaX2 = new Label();
            lblCoeC = new Label();
            txtCoeC = new TextBox();
            lblCoeB = new Label();
            txtCoeB = new TextBox();
            lblCoeA = new Label();
            txtCoeA = new TextBox();
            picEjemplo = new PictureBox();
            label2 = new Label();
            btnCalcular = new Button();
            plotViewGrafica = new OxyPlot.WindowsForms.PlotView();
            lblTResultado = new Label();
            lblResultadoText = new Label();
            btnLimpia = new Button();
            picGraficas = new PictureBox();
            grpEntrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picEjemplo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picGraficas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(221, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(545, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Graficadora de ecuaciones de hasta segundo grado\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(376, 65);
            label1.Name = "label1";
            label1.Size = new Size(221, 19);
            label1.TabIndex = 1;
            label1.Text = "(opción de raíces imaginarias)";
            // 
            // grpEntrada
            // 
            grpEntrada.Controls.Add(lblEcua0);
            grpEntrada.Controls.Add(lblEcuaX);
            grpEntrada.Controls.Add(lblEcuaX2);
            grpEntrada.Controls.Add(lblCoeC);
            grpEntrada.Controls.Add(txtCoeC);
            grpEntrada.Controls.Add(lblCoeB);
            grpEntrada.Controls.Add(txtCoeB);
            grpEntrada.Controls.Add(lblCoeA);
            grpEntrada.Controls.Add(txtCoeA);
            grpEntrada.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpEntrada.ForeColor = Color.WhiteSmoke;
            grpEntrada.Location = new Point(317, 139);
            grpEntrada.Name = "grpEntrada";
            grpEntrada.Size = new Size(449, 128);
            grpEntrada.TabIndex = 2;
            grpEntrada.TabStop = false;
            grpEntrada.Text = "Entrada de datos";
            // 
            // lblEcua0
            // 
            lblEcua0.AutoSize = true;
            lblEcua0.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEcua0.ForeColor = Color.White;
            lblEcua0.Location = new Point(406, 64);
            lblEcua0.Name = "lblEcua0";
            lblEcua0.Size = new Size(32, 18);
            lblEcua0.TabIndex = 12;
            lblEcua0.Text = "= 0";
            // 
            // lblEcuaX
            // 
            lblEcuaX.AutoSize = true;
            lblEcuaX.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEcuaX.ForeColor = Color.White;
            lblEcuaX.Location = new Point(270, 64);
            lblEcuaX.Name = "lblEcuaX";
            lblEcuaX.Size = new Size(16, 18);
            lblEcuaX.TabIndex = 11;
            lblEcuaX.Text = "x";
            // 
            // lblEcuaX2
            // 
            lblEcuaX2.AutoSize = true;
            lblEcuaX2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEcuaX2.ForeColor = Color.White;
            lblEcuaX2.Location = new Point(123, 64);
            lblEcuaX2.Name = "lblEcuaX2";
            lblEcuaX2.Size = new Size(23, 18);
            lblEcuaX2.TabIndex = 10;
            lblEcuaX2.Text = "x²";
            // 
            // lblCoeC
            // 
            lblCoeC.AutoSize = true;
            lblCoeC.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoeC.ForeColor = Color.Gainsboro;
            lblCoeC.Location = new Point(301, 37);
            lblCoeC.Name = "lblCoeC";
            lblCoeC.Size = new Size(101, 19);
            lblCoeC.TabIndex = 9;
            lblCoeC.Text = "Coeficiente C";
            // 
            // txtCoeC
            // 
            txtCoeC.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeC.Location = new Point(301, 59);
            txtCoeC.Name = "txtCoeC";
            txtCoeC.PlaceholderText = "1";
            txtCoeC.Size = new Size(102, 26);
            txtCoeC.TabIndex = 8;
            txtCoeC.KeyPress += txtCoeC_KeyPress;
            // 
            // lblCoeB
            // 
            lblCoeB.AutoSize = true;
            lblCoeB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoeB.ForeColor = Color.Gainsboro;
            lblCoeB.Location = new Point(165, 37);
            lblCoeB.Name = "lblCoeB";
            lblCoeB.Size = new Size(100, 19);
            lblCoeB.TabIndex = 7;
            lblCoeB.Text = "Coeficiente B";
            // 
            // txtCoeB
            // 
            txtCoeB.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeB.Location = new Point(165, 59);
            txtCoeB.Name = "txtCoeB";
            txtCoeB.PlaceholderText = "1";
            txtCoeB.Size = new Size(102, 26);
            txtCoeB.TabIndex = 6;
            txtCoeB.KeyPress += txtCoeB_KeyPress;
            // 
            // lblCoeA
            // 
            lblCoeA.AutoSize = true;
            lblCoeA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoeA.ForeColor = Color.Gainsboro;
            lblCoeA.Location = new Point(18, 37);
            lblCoeA.Name = "lblCoeA";
            lblCoeA.Size = new Size(102, 19);
            lblCoeA.TabIndex = 5;
            lblCoeA.Text = "Coeficiente A";
            // 
            // txtCoeA
            // 
            txtCoeA.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeA.Location = new Point(18, 59);
            txtCoeA.Name = "txtCoeA";
            txtCoeA.PlaceholderText = "1";
            txtCoeA.Size = new Size(102, 26);
            txtCoeA.TabIndex = 0;
            txtCoeA.KeyPress += txtCoeA_KeyPress;
            // 
            // picEjemplo
            // 
            picEjemplo.Image = (Image)resources.GetObject("picEjemplo.Image");
            picEjemplo.Location = new Point(22, 158);
            picEjemplo.Name = "picEjemplo";
            picEjemplo.Size = new Size(280, 222);
            picEjemplo.SizeMode = PictureBoxSizeMode.Zoom;
            picEjemplo.TabIndex = 3;
            picEjemplo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(22, 124);
            label2.Name = "label2";
            label2.Size = new Size(67, 19);
            label2.TabIndex = 4;
            label2.Text = "Ejemplo";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightGreen;
            btnCalcular.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(821, 151);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 44);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // plotViewGrafica
            // 
            plotViewGrafica.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plotViewGrafica.ForeColor = Color.White;
            plotViewGrafica.Location = new Point(317, 416);
            plotViewGrafica.Name = "plotViewGrafica";
            plotViewGrafica.PanCursor = Cursors.Hand;
            plotViewGrafica.Size = new Size(609, 321);
            plotViewGrafica.TabIndex = 6;
            plotViewGrafica.ZoomHorizontalCursor = Cursors.SizeWE;
            plotViewGrafica.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotViewGrafica.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // lblTResultado
            // 
            lblTResultado.AutoSize = true;
            lblTResultado.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTResultado.ForeColor = Color.White;
            lblTResultado.Location = new Point(320, 319);
            lblTResultado.Name = "lblTResultado";
            lblTResultado.Size = new Size(117, 19);
            lblTResultado.TabIndex = 7;
            lblTResultado.Text = "Resultados =";
            // 
            // lblResultadoText
            // 
            lblResultadoText.AutoSize = true;
            lblResultadoText.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoText.ForeColor = Color.White;
            lblResultadoText.Location = new Point(467, 319);
            lblResultadoText.Name = "lblResultadoText";
            lblResultadoText.Size = new Size(0, 19);
            lblResultadoText.TabIndex = 8;
            // 
            // btnLimpia
            // 
            btnLimpia.BackColor = Color.SlateGray;
            btnLimpia.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpia.Location = new Point(821, 219);
            btnLimpia.Name = "btnLimpia";
            btnLimpia.Size = new Size(105, 44);
            btnLimpia.TabIndex = 9;
            btnLimpia.Text = "Limpiar";
            btnLimpia.UseVisualStyleBackColor = false;
            btnLimpia.Click += btnLimpia_Click;
            // 
            // picGraficas
            // 
            picGraficas.Image = (Image)resources.GetObject("picGraficas.Image");
            picGraficas.Location = new Point(22, 401);
            picGraficas.Name = "picGraficas";
            picGraficas.Size = new Size(280, 307);
            picGraficas.SizeMode = PictureBoxSizeMode.Zoom;
            picGraficas.TabIndex = 10;
            picGraficas.TabStop = false;
            // 
            // FrmGraficadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(984, 761);
            Controls.Add(picGraficas);
            Controls.Add(btnLimpia);
            Controls.Add(lblResultadoText);
            Controls.Add(lblTResultado);
            Controls.Add(plotViewGrafica);
            Controls.Add(btnCalcular);
            Controls.Add(label2);
            Controls.Add(picEjemplo);
            Controls.Add(grpEntrada);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "FrmGraficadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhotoMath Beta";
            grpEntrada.ResumeLayout(false);
            grpEntrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picEjemplo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picGraficas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private GroupBox grpEntrada;
        private PictureBox picEjemplo;
        private Label label2;
        private Label lblCoeC;
        private TextBox txtCoeC;
        private Label lblCoeB;
        private TextBox txtCoeB;
        private Label lblCoeA;
        private TextBox txtCoeA;
        private Label lblEcuaX2;
        private Label lblEcua0;
        private Label lblEcuaX;
        private Button btnCalcular;
        private OxyPlot.WindowsForms.PlotView plotViewGrafica;
        private Label lblTResultado;
        private Label lblResultadoText;
        private Button btnLimpia;
        private PictureBox picGraficas;
    }
}
