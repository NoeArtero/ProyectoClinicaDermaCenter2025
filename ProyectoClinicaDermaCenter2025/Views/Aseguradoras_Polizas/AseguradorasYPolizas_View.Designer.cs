namespace ProyectoClinicaDermaCenter2025.Views.Aseguradoras_Polizas
{
    partial class AseguradorasYPolizas_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AseguradorasYPolizas_View));
            label2 = new Label();
            label3 = new Label();
            txtNombreAseguradora = new TextBox();
            txtNumeroPoliza = new TextBox();
            btnGuardarAseguradoraPoliza = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(245, 164);
            label2.Name = "label2";
            label2.Size = new Size(179, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Aseguradora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(245, 229);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Número de Póliza";
            // 
            // txtNombreAseguradora
            // 
            txtNombreAseguradora.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreAseguradora.Location = new Point(444, 162);
            txtNombreAseguradora.Name = "txtNombreAseguradora";
            txtNombreAseguradora.Size = new Size(573, 23);
            txtNombreAseguradora.TabIndex = 3;
            // 
            // txtNumeroPoliza
            // 
            txtNumeroPoliza.BackColor = Color.FromArgb(255, 253, 231);
            txtNumeroPoliza.Location = new Point(444, 227);
            txtNumeroPoliza.Name = "txtNumeroPoliza";
            txtNumeroPoliza.Size = new Size(573, 23);
            txtNumeroPoliza.TabIndex = 4;
            // 
            // btnGuardarAseguradoraPoliza
            // 
            btnGuardarAseguradoraPoliza.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuardarAseguradoraPoliza.Location = new Point(990, 44);
            btnGuardarAseguradoraPoliza.Name = "btnGuardarAseguradoraPoliza";
            btnGuardarAseguradoraPoliza.Size = new Size(97, 39);
            btnGuardarAseguradoraPoliza.TabIndex = 5;
            btnGuardarAseguradoraPoliza.Text = "Guardar";
            btnGuardarAseguradoraPoliza.UseVisualStyleBackColor = true;
            btnGuardarAseguradoraPoliza.Click += btnGuardarAseguradoraPoliza_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiar.Location = new Point(1267, 44);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1127, 44);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(96, 39);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 121);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 18, 32);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnGuardarAseguradoraPoliza);
            panel2.Controls.Add(btnRegresar);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 121);
            panel2.TabIndex = 9;
            // 
            // AseguradorasYPolizas_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1370, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNumeroPoliza);
            Controls.Add(txtNombreAseguradora);
            Controls.Add(label3);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AseguradorasYPolizas_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AseguradorasYPolizas";
            WindowState = FormWindowState.Maximized;
            Load += AseguradorasYPolizas_View_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNombreAseguradora;
        private TextBox txtNumeroPoliza;
        private Button btnGuardarAseguradoraPoliza;
        private Button btnLimpiar;
        private Button btnRegresar;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}