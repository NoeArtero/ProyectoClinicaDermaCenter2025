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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servicios_View));
            dgvServicios = new DataGridView();
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCoste).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(80, 160);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.Size = new Size(1189, 260);
            dgvServicios.TabIndex = 0;
            dgvServicios.CellClick += dgvServicios_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(262, 18);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Servicio:";
            // 
            // txtNombreServicio
            // 
            txtNombreServicio.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreServicio.Location = new Point(422, 17);
            txtNombreServicio.Name = "txtNombreServicio";
            txtNombreServicio.Size = new Size(171, 23);
            txtNombreServicio.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(262, 68);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 253, 231);
            txtDescripcion.Location = new Point(422, 69);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(171, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // numCoste
            // 
            numCoste.BackColor = Color.FromArgb(255, 253, 231);
            numCoste.DecimalPlaces = 2;
            numCoste.Location = new Point(737, 17);
            numCoste.Name = "numCoste";
            numCoste.Size = new Size(120, 23);
            numCoste.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(658, 18);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Costo:";
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(156, 39);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(109, 26);
            btnRegresar.TabIndex = 8;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuardar.Location = new Point(383, 39);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(108, 26);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiar.Location = new Point(603, 39);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 26);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEliminar.Location = new Point(826, 39);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 26);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.BackColor = Color.FromArgb(15, 23, 42);
            chkMostrarInactivos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            chkMostrarInactivos.ForeColor = SystemColors.ButtonFace;
            chkMostrarInactivos.Location = new Point(711, 79);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(146, 24);
            chkMostrarInactivos.TabIndex = 12;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = false;
            chkMostrarInactivos.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnReactivar
            // 
            btnReactivar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReactivar.Location = new Point(1061, 39);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(81, 26);
            btnReactivar.TabIndex = 13;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtNombreServicio);
            panel1.Controls.Add(chkMostrarInactivos);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(numCoste);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 121);
            panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(1, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 18, 32);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(btnReactivar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnEliminar);
            panel2.Location = new Point(2, 502);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 121);
            panel2.TabIndex = 15;
            // 
            // Servicios_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1370, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvServicios);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Servicios_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios";
            WindowState = FormWindowState.Maximized;
            Load += Servicios_View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCoste).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvServicios;
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
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}