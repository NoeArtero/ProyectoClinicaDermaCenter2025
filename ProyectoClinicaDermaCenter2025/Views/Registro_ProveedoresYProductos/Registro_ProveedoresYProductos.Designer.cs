namespace ProyectoClinicaDermaCenter2025.Views.Proveedores
{
    partial class Registro_ProveedoresYProductos
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
            label4 = new Label();
            txtPContacto = new TextBox();
            txtTelefono = new TextBox();
            txtNombreProveedor = new TextBox();
            btnRegresar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreDelProducto = new TextBox();
            txtDescripcion = new TextBox();
            label8 = new Label();
            dtpFechaDeVencimiento = new DateTimePicker();
            numCantidad = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(322, 23);
            label1.Name = "label1";
            label1.Size = new Size(595, 31);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO DE PROVEEDORES Y PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 100);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Proveedor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 158);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 2;
            label3.Text = "Persona de Contacto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 215);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // txtPContacto
            // 
            txtPContacto.BackColor = Color.FromArgb(255, 253, 231);
            txtPContacto.Location = new Point(187, 150);
            txtPContacto.Name = "txtPContacto";
            txtPContacto.Size = new Size(177, 23);
            txtPContacto.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(255, 253, 231);
            txtTelefono.Location = new Point(187, 212);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(177, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreProveedor.Location = new Point(187, 92);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(177, 23);
            txtNombreProveedor.TabIndex = 6;
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(870, 195);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(100, 40);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnGuardar.Location = new Point(988, 150);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 40);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1103, 195);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(95, 40);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(393, 100);
            label5.Name = "label5";
            label5.Size = new Size(117, 15);
            label5.TabIndex = 10;
            label5.Text = "Nombre del Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(393, 158);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 11;
            label6.Text = "Cantidad ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(393, 215);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 12;
            label7.Text = "Descripcion";
            // 
            // txtNombreDelProducto
            // 
            txtNombreDelProducto.BackColor = Color.FromArgb(255, 253, 231);
            txtNombreDelProducto.Location = new Point(554, 97);
            txtNombreDelProducto.Name = "txtNombreDelProducto";
            txtNombreDelProducto.Size = new Size(217, 23);
            txtNombreDelProducto.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(255, 253, 231);
            txtDescripcion.Location = new Point(554, 207);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(217, 23);
            txtDescripcion.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(857, 105);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 16;
            label8.Text = "Fecha de Vencimiento";
            // 
            // dtpFechaDeVencimiento
            // 
            dtpFechaDeVencimiento.Location = new Point(1019, 99);
            dtpFechaDeVencimiento.Name = "dtpFechaDeVencimiento";
            dtpFechaDeVencimiento.Size = new Size(200, 23);
            dtpFechaDeVencimiento.TabIndex = 17;
            // 
            // numCantidad
            // 
            numCantidad.BackColor = Color.FromArgb(255, 253, 231);
            numCantidad.Location = new Point(554, 150);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 18;
            // 
            // Registro_ProveedoresYProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1277, 280);
            Controls.Add(numCantidad);
            Controls.Add(dtpFechaDeVencimiento);
            Controls.Add(label8);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreDelProducto);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegresar);
            Controls.Add(txtNombreProveedor);
            Controls.Add(txtTelefono);
            Controls.Add(txtPContacto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registro_ProveedoresYProductos";
            Text = "Proveedores_View";
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPContacto;
        private TextBox txtTelefono;
        private TextBox txtNombreProveedor;
        private Button btnRegresar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreDelProducto;
        private TextBox txtDescripcion;
        private Label label8;
        private DateTimePicker dtpFechaDeVencimiento;
        private NumericUpDown numCantidad;
    }
}