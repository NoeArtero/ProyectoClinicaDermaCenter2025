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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombreAseguradora = new TextBox();
            txtNumeroPoliza = new TextBox();
            btnGuardarAseguradoraPoliza = new Button();
            btnLimpiar = new Button();
            btnRegresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(492, 23);
            label1.Name = "label1";
            label1.Size = new Size(437, 36);
            label1.TabIndex = 0;
            label1.Text = "ASEGURADORAS Y POLIZAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(245, 107);
            label2.Name = "label2";
            label2.Size = new Size(162, 16);
            label2.TabIndex = 1;
            label2.Text = "Nombre de Aseguradora";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(245, 172);
            label3.Name = "label3";
            label3.Size = new Size(121, 16);
            label3.TabIndex = 2;
            label3.Text = "Número de Póliza";
            // 
            // txtNombreAseguradora
            // 
            txtNombreAseguradora.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreAseguradora.Location = new Point(444, 105);
            txtNombreAseguradora.Name = "txtNombreAseguradora";
            txtNombreAseguradora.Size = new Size(573, 23);
            txtNombreAseguradora.TabIndex = 3;
            // 
            // txtNumeroPoliza
            // 
            txtNumeroPoliza.BackColor = Color.FromArgb(255, 253, 231);
            txtNumeroPoliza.Location = new Point(444, 170);
            txtNumeroPoliza.Name = "txtNumeroPoliza";
            txtNumeroPoliza.Size = new Size(573, 23);
            txtNumeroPoliza.TabIndex = 4;
            // 
            // btnGuardarAseguradoraPoliza
            // 
            btnGuardarAseguradoraPoliza.Location = new Point(612, 275);
            btnGuardarAseguradoraPoliza.Name = "btnGuardarAseguradoraPoliza";
            btnGuardarAseguradoraPoliza.Size = new Size(97, 39);
            btnGuardarAseguradoraPoliza.TabIndex = 5;
            btnGuardarAseguradoraPoliza.Text = "Guardar";
            btnGuardarAseguradoraPoliza.UseVisualStyleBackColor = true;
            btnGuardarAseguradoraPoliza.Click += btnGuardarAseguradoraPoliza_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(916, 275);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 39);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(347, 275);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(96, 39);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // AseguradorasYPolizas_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1451, 420);
            Controls.Add(btnRegresar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardarAseguradoraPoliza);
            Controls.Add(txtNumeroPoliza);
            Controls.Add(txtNombreAseguradora);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AseguradorasYPolizas_View";
            Text = "AseguradorasYPolizas";
            Load += AseguradorasYPolizas_View_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombreAseguradora;
        private TextBox txtNumeroPoliza;
        private Button btnGuardarAseguradoraPoliza;
        private Button btnLimpiar;
        private Button btnRegresar;
    }
}