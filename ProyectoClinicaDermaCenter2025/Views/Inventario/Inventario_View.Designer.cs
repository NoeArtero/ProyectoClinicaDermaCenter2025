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
            dgvInventario = new DataGridView();
            label1 = new Label();
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
            label7 = new Label();
            chkMostrarInactivos = new CheckBox();
            btnReactivar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).BeginInit();
            SuspendLayout();
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(12, 269);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(985, 237);
            dgvInventario.TabIndex = 0;
            dgvInventario.CellClick += dgvInventario_CellClick;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(384, 9);
            label1.Name = "label1";
            label1.Size = new Size(181, 31);
            label1.TabIndex = 1;
            label1.Text = "INVENTARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 84);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre del Producto:";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreProducto.Location = new Point(170, 76);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(187, 23);
            txtNombreProducto.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(801, 125);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(74, 26);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(922, 122);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 26);
            btnRegresar.TabIndex = 5;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(401, 218);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(115, 23);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 130);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 7;
            label3.Text = "Proveedor:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(401, 84);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 9;
            label4.Text = "Cantidad:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.BackColor = Color.FromArgb(255, 253, 231);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(122, 122);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(187, 23);
            cmbProveedor.TabIndex = 11;
            cmbProveedor.SelectedIndexChanged += cmbProveedor_SelectedIndexChanged;
            // 
            // numCantidadStock
            // 
            numCantidadStock.BackColor = Color.FromArgb(255, 253, 231);
            numCantidadStock.Location = new Point(478, 76);
            numCantidadStock.Name = "numCantidadStock";
            numCantidadStock.Size = new Size(153, 23);
            numCantidadStock.TabIndex = 12;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.CalendarMonthBackground = Color.FromArgb(255, 253, 231);
            dtpFechaVencimiento.Location = new Point(810, 76);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(187, 23);
            dtpFechaVencimiento.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(665, 79);
            label5.Name = "label5";
            label5.Size = new Size(126, 15);
            label5.TabIndex = 14;
            label5.Text = "Fecha de Vencimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(401, 125);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 15;
            label6.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 253, 231);
            txtDescripcion.Location = new Point(495, 122);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(136, 23);
            txtDescripcion.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(675, 125);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 26);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(418, 188);
            label7.Name = "label7";
            label7.Size = new Size(213, 15);
            label7.TabIndex = 19;
            label7.Text = "Eliminar Producto o Reactivar Producto";
            // 
            // chkMostrarInactivos
            // 
            chkMostrarInactivos.AutoSize = true;
            chkMostrarInactivos.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkMostrarInactivos.Location = new Point(719, 221);
            chkMostrarInactivos.Name = "chkMostrarInactivos";
            chkMostrarInactivos.Size = new Size(117, 19);
            chkMostrarInactivos.TabIndex = 20;
            chkMostrarInactivos.Text = "Mostrar Inactivos";
            chkMostrarInactivos.UseVisualStyleBackColor = true;
            chkMostrarInactivos.CheckedChanged += chkMostrarInactivos_CheckedChanged;
            // 
            // btnReactivar
            // 
            btnReactivar.Location = new Point(572, 218);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(75, 23);
            btnReactivar.TabIndex = 21;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // Inventario_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1009, 518);
            Controls.Add(btnReactivar);
            Controls.Add(chkMostrarInactivos);
            Controls.Add(label7);
            Controls.Add(btnLimpiar);
            Controls.Add(txtDescripcion);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dtpFechaVencimiento);
            Controls.Add(numCantidadStock);
            Controls.Add(cmbProveedor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnEliminar);
            Controls.Add(btnRegresar);
            Controls.Add(btnActualizar);
            Controls.Add(txtNombreProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvInventario);
            Name = "Inventario_View";
            Text = "Inventario";
            Load += Inventario_View_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidadStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInventario;
        private Label label1;
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
        private Label label7;
        private CheckBox chkMostrarInactivos;
        private Button btnReactivar;
    }
}