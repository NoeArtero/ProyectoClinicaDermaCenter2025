namespace ProyectoClinicaDermaCenter2025.Views.Atencion_Servicios
{
    partial class Servicios_View
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
            dgvServicios = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombreServicio = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            numCoste = new NumericUpDown();
            label4 = new Label();
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            chkMostrarInactivos = new CheckBox();
            btnReactivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoste).BeginInit();
            SuspendLayout();
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(12, 186);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(1189, 260);
            dgvServicios.TabIndex = 0;
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(495, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 31);
            label1.TabIndex = 1;
            label1.Text = "SERVICIOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 70);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Servicio:";
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreServicio.Location = new Point(203, 62);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(171, 23);
            txtNombreServicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(454, 70);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 253, 231);
            txtDescripcion.Location = new Point(566, 62);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(171, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // numCoste
            // 
            numCoste.BackColor = Color.FromArgb(255, 253, 231);
            numCoste.DecimalPlaces = 2;
            numCoste.Location = new Point(860, 62);
            numCoste.Name = "numCoste";
            numCoste.Size = new Size(120, 23);
            numCoste.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(789, 70);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 7;
            label4.Text = "Costo:";
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(119, 135);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(103, 23);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(346, 135);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(102, 23);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(566, 135);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(789, 135);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(102, 23);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMostrarInactivos.Location = new Point(960, 135);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(117, 19);
            chkMostrarInactivos.TabIndex = 12;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = true;
            chkMostrarInactivos.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnReactivar
            // 
            btnReactivar.Location = new Point(984, 160);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(75, 23);
            btnReactivar.TabIndex = 13;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // Servicios_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1213, 460);
            Controls.Add(btnReactivar);
            Controls.Add(chkMostrarInactivos);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegresar);
            Controls.Add(label4);
            Controls.Add(numCoste);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(txtNombreServicio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvServicios);
            Name = "Servicios_View";
            Text = "Servicios";
            Load += Servicios_View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoste).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvServicios;
        private Label label1;
        private Label label2;
        private TextBox txtNombreServicio;
        private Label label3;
        private TextBox txtDescripcion;
        private NumericUpDown numCoste;
        private Label label4;
        private Button btnRegresar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnEliminar;
        private CheckBox chkMostrarInactivos;
        private Button btnReactivar;
    }
}