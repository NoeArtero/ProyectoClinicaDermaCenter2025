namespace ProyectoClinicaDermaCenter2025.Views.Inventario
{
    partial class Inventario_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario_View));
            dgvInventario = new DataGridView();
            label2 = new Label();
            txtNombreProducto = new TextBox();
            btnActualizar = new Button();
            btnRegresar = new Button();
            btnEliminar = new Button();
            label3 = new Label();
            label4 = new Label();
            cmbProveedor = new ComboBox();
            numCantidadStock = new NumericUpDown();
            dtpFechaVencimiento = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtDescripcion = new TextBox();
            btnLimpiar = new Button();
            chkMostrarInactivos = new CheckBox();
            btnReactivar = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(119, 159);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(1098, 306);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellClick += dgvInventario_CellClick;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(250, 15);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreProducto.Location = new Point(418, 12);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(187, 23);
            txtNombreProducto.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnActualizar.ForeColor = SystemColors.ActiveCaptionText;
            btnActualizar.Location = new Point(789, 57);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(87, 30);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegresar.Location = new Point(935, 57);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(88, 30);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(256, 60);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(128, 27);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(250, 61);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 7;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(623, 14);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "Cantidad:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(255, 253, 231);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(418, 62);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(187, 23);
            cmbProveedor.TabIndex = 11;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // numCantidadStock
            // 
            numCantidadStock.BackColor = Color.FromArgb(255, 253, 231);
            numCantidadStock.Location = new Point(743, 12);
            numCantidadStock.Name = "numCantidadStock";
            numCantidadStock.Size = new Size(136, 23);
            numCantidadStock.TabIndex = 12;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.CalendarMonthBackground = Color.FromArgb(255, 253, 231);
            dtpFechaVencimiento.Location = new Point(1058, 12);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(187, 23);
            dtpFechaVencimiento.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 23, 42);
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(889, 15);
            label5.Name = "label5";
            label5.Size = new Size(163, 20);
            label5.TabIndex = 14;
            label5.Text = "Fecha de Vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 23, 42);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(623, 62);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 15;
            label6.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 253, 231);
            txtDescripcion.Location = new Point(743, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(136, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpiar.Location = new Point(614, 57);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(99, 30);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.BackColor = Color.FromArgb(15, 23, 42);
            chkMostrarInactivos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            chkMostrarInactivos.ForeColor = SystemColors.ButtonFace;
            chkMostrarInactivos.Location = new Point(906, 60);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(146, 24);
            chkMostrarInactivos.TabIndex = 20;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = false;
            chkMostrarInactivos.CheckedChanged += chkMostrarInactivos_CheckedChanged;
            // 
            // btnReactivar
            // 
            btnReactivar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReactivar.ForeColor = SystemColors.ActiveCaptionText;
            btnReactivar.Location = new Point(463, 57);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(88, 30);
            btnReactivar.TabIndex = 21;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(chkMostrarInactivos);
            panel1.Controls.Add(txtNombreProducto);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cmbProveedor);
            panel1.Controls.Add(numCantidadStock);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtpFechaVencimiento);
            panel1.Controls.Add(txtDescripcion);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 121);
            panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 18, 32);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnReactivar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(btnActualizar);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.FromArgb(11, 18, 32);
            panel2.Location = new Point(0, 481);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 121);
            panel2.TabIndex = 23;
            // 
            // Inventario_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1370, 602);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dgvInventario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inventario_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            WindowState = FormWindowState.Maximized;
            Load += Inventario_View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInventario;
        private Label label2;
        private TextBox txtNombreProducto;
        private Button btnActualizar;
        private Button btnRegresar;
        private Button btnEliminar;
        private Label label3;
        private Label label4;
        private ComboBox cmbProveedor;
        private NumericUpDown numCantidadStock;
        private DateTimePicker dtpFechaVencimiento;
        private Label label5;
        private Label label6;
        private TextBox txtDescripcion;
        private Button btnLimpiar;
        private CheckBox chkMostrarInactivos;
        private Button btnReactivar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}