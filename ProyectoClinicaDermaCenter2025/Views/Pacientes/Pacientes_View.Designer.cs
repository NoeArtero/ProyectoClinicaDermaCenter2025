namespace ProyectoClinicaDermaCenter2025.Views.Pacientes
{
    partial class Pacientes_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pacientes_View));
            dgvPacientes = new DataGridView();
            txtNombre = new TextBox();
            txtDocumento = new TextBox();
            txtFiltro = new TextBox();
            btnListar = new Button();
            btnBuscar = new Button();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // dgvPacientes
            // 
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(12, 146);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.Size = new Size(776, 273);
            dgvPacientes.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(58, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new Point(262, 29);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(160, 23);
            txtDocumento.TabIndex = 2;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(466, 29);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(160, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.Tag = "";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(58, 117);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 4;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(186, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(293, 117);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(374, 117);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(455, 117);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(536, 117);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Pacientes_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Controls.Add(btnListar);
            Controls.Add(txtFiltro);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Controls.Add(dgvPacientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pacientes_View";
            Text = "Pacientes";
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPacientes;
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtFiltro;
        private Button btnListar;
        private Button btnBuscar;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
    }
}