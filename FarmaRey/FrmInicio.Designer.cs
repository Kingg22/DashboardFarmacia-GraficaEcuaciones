namespace FarmaRey
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            lblTitulo = new Label();
            btnEnun1 = new Button();
            btnEnun2 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.MenuText;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(236, 32);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 29);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Parcial 2";
            // 
            // btnEnun1
            // 
            btnEnun1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnun1.Location = new Point(159, 173);
            btnEnun1.Name = "btnEnun1";
            btnEnun1.Size = new Size(111, 43);
            btnEnun1.TabIndex = 1;
            btnEnun1.Text = "Enunciado 1";
            btnEnun1.UseVisualStyleBackColor = true;
            btnEnun1.Click += btnEnun1_Click;
            // 
            // btnEnun2
            // 
            btnEnun2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnun2.Location = new Point(381, 193);
            btnEnun2.Name = "btnEnun2";
            btnEnun2.Size = new Size(111, 43);
            btnEnun2.TabIndex = 2;
            btnEnun2.Text = "Enunciado 2";
            btnEnun2.UseVisualStyleBackColor = true;
            btnEnun2.Click += btnEnun2_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(584, 361);
            Controls.Add(btnEnun2);
            Controls.Add(btnEnun1);
            Controls.Add(lblTitulo);
            Font = new Font("Microsoft Sans Serif", 18F);
            Margin = new Padding(5);
            Name = "FrmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Desarrollo IV - Parcial 2 Rey Acosta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnEnun1;
        private Button btnEnun2;
    }
}