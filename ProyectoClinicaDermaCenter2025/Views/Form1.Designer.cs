namespace ProyectoClinicaDermaCenter2025
{
    partial class DermaCenterInicio
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
            lbl_prueba = new Label();
            SuspendLayout();
            // 
            // lbl_prueba
            // 
            lbl_prueba.AutoSize = true;
            lbl_prueba.Location = new Point(304, 61);
            lbl_prueba.Name = "lbl_prueba";
            lbl_prueba.Size = new Size(114, 15);
            lbl_prueba.TabIndex = 0;
            lbl_prueba.Text = "Prueba de push/pull";
            // 
            // DermaCenterInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_prueba);
            Name = "DermaCenterInicio";
            Text = "DermaCenter: Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_prueba;
    }
}
