namespace ProyectoClinicaDermaCenter2025.Views.Pagos
{
    partial class Pagos_View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos_View));
            errorFacturacion = new ErrorProvider(components);
            btnRegresar = new Button();
            dgvPagosFactura = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            panel1 = new Panel();
            btnRegistrarPago = new Button();
            btnCancelarPago = new Button();
            nudMontoPago = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            cmbMetodoPago = new ComboBox();
            dgvFacturas = new DataGridView();
            dtpDesdePagos = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panelX = new Panel();
            btnLimpiarFiltrosPagos = new Button();
            btnBuscarPagos = new Button();
            txtBuscarPacientePagos = new TextBox();
            btnActualizarPagos = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnHoyPagos = new Button();
            cmbEstadoPago = new ComboBox();
            dtpHastaPagos = new DateTimePicker();
            label1 = new Label();
            dtpFechaPago = new DateTimePicker();
            txtCambio = new TextBox();
            label6 = new Label();
            txtPacienteSel = new TextBox();
            label9 = new Label();
            txtEstadoSel = new TextBox();
            label10 = new Label();
            txtTotalSel = new TextBox();
            label11 = new Label();
            txtPagadoSel = new TextBox();
            label12 = new Label();
            txtSaldoSel = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorFacturacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagosFactura).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoPago).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelX.SuspendLayout();
            SuspendLayout();
            // 
            // errorFacturacion
            // 
            errorFacturacion.ContainerControl = this;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1227, 22);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 57);
            btnRegresar.TabIndex = 36;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // dgvPagosFactura
            // 
            dgvPagosFactura.AllowUserToAddRows = false;
            dgvPagosFactura.AllowUserToDeleteRows = false;
            dgvPagosFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPagosFactura.BackgroundColor = SystemColors.ControlLight;
            dgvPagosFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagosFactura.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPagosFactura.Location = new Point(605, 123);
            dgvPagosFactura.MultiSelect = false;
            dgvPagosFactura.Name = "dgvPagosFactura";
            dgvPagosFactura.ReadOnly = true;
            dgvPagosFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPagosFactura.Size = new Size(591, 372);
            dgvPagosFactura.TabIndex = 37;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(txtCambio);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpFechaPago);
            panel1.Controls.Add(btnRegresar);
            panel1.Controls.Add(btnRegistrarPago);
            panel1.Controls.Add(btnCancelarPago);
            panel1.Controls.Add(nudMontoPago);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbMetodoPago);
            panel1.Location = new Point(0, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 107);
            panel1.TabIndex = 35;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegistrarPago.Location = new Point(550, 12);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(108, 29);
            btnRegistrarPago.TabIndex = 36;
            btnRegistrarPago.Text = "Registrar";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            // 
            // btnCancelarPago
            // 
            btnCancelarPago.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelarPago.Location = new Point(550, 55);
            btnCancelarPago.Name = "btnCancelarPago";
            btnCancelarPago.Size = new Size(108, 29);
            btnCancelarPago.TabIndex = 35;
            btnCancelarPago.Text = "Cancelar";
            btnCancelarPago.UseVisualStyleBackColor = true;
            // 
            // nudMontoPago
            // 
            nudMontoPago.DecimalPlaces = 2;
            nudMontoPago.Location = new Point(139, 56);
            nudMontoPago.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMontoPago.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            nudMontoPago.Name = "nudMontoPago";
            nudMontoPago.Size = new Size(108, 23);
            nudMontoPago.TabIndex = 32;
            nudMontoPago.ThousandsSeparator = true;
            nudMontoPago.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 23, 42);
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(59, 59);
            label8.Name = "label8";
            label8.Size = new Size(59, 20);
            label8.TabIndex = 31;
            label8.Text = "Monto:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 23, 42);
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(59, 18);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 30;
            label7.Text = "Método:";
            // 
            // cmbMetodoPago
            // 
            cmbMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMetodoPago.FormattingEnabled = true;
            cmbMetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia", "Otro" });
            cmbMetodoPago.Location = new Point(133, 18);
            cmbMetodoPago.Name = "cmbMetodoPago";
            cmbMetodoPago.Size = new Size(114, 23);
            cmbMetodoPago.TabIndex = 29;
            // 
            // dgvFacturas
            // 
            dgvFacturas.AllowUserToAddRows = false;
            dgvFacturas.AllowUserToDeleteRows = false;
            dgvFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvFacturas.BackgroundColor = SystemColors.ControlLight;
            dgvFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFacturas.Location = new Point(8, 120);
            dgvFacturas.MultiSelect = false;
            dgvFacturas.Name = "dgvFacturas";
            dgvFacturas.ReadOnly = true;
            dgvFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFacturas.Size = new Size(591, 372);
            dgvFacturas.TabIndex = 34;
            // 
            // dtpDesdePagos
            // 
            dtpDesdePagos.CustomFormat = "dd/MM/yyyy";
            dtpDesdePagos.Format = DateTimePickerFormat.Custom;
            dtpDesdePagos.Location = new Point(364, 19);
            dtpDesdePagos.Name = "dtpDesdePagos";
            dtpDesdePagos.Size = new Size(106, 23);
            dtpDesdePagos.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelX
            // 
            panelX.BackColor = Color.FromArgb(11, 18, 32);
            panelX.Controls.Add(btnLimpiarFiltrosPagos);
            panelX.Controls.Add(btnBuscarPagos);
            panelX.Controls.Add(txtBuscarPacientePagos);
            panelX.Controls.Add(btnActualizarPagos);
            panelX.Controls.Add(label5);
            panelX.Controls.Add(label4);
            panelX.Controls.Add(label3);
            panelX.Controls.Add(label2);
            panelX.Controls.Add(btnHoyPagos);
            panelX.Controls.Add(cmbEstadoPago);
            panelX.Controls.Add(dtpHastaPagos);
            panelX.Controls.Add(dtpDesdePagos);
            panelX.Controls.Add(pictureBox1);
            panelX.Dock = DockStyle.Top;
            panelX.Location = new Point(0, 0);
            panelX.Name = "panelX";
            panelX.Size = new Size(1370, 121);
            panelX.TabIndex = 33;
            // 
            // btnLimpiarFiltrosPagos
            // 
            btnLimpiarFiltrosPagos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiarFiltrosPagos.Location = new Point(1238, 47);
            btnLimpiarFiltrosPagos.Name = "btnLimpiarFiltrosPagos";
            btnLimpiarFiltrosPagos.Size = new Size(117, 57);
            btnLimpiarFiltrosPagos.TabIndex = 29;
            btnLimpiarFiltrosPagos.Text = "Limpiar Filtros";
            btnLimpiarFiltrosPagos.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPagos
            // 
            btnBuscarPagos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBuscarPagos.Location = new Point(819, 17);
            btnBuscarPagos.Name = "btnBuscarPagos";
            btnBuscarPagos.Size = new Size(108, 29);
            btnBuscarPagos.TabIndex = 23;
            btnBuscarPagos.Text = "Buscar";
            btnBuscarPagos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPacientePagos
            // 
            txtBuscarPacientePagos.Location = new Point(602, 74);
            txtBuscarPacientePagos.Name = "txtBuscarPacientePagos";
            txtBuscarPacientePagos.ScrollBars = ScrollBars.Vertical;
            txtBuscarPacientePagos.Size = new Size(181, 23);
            txtBuscarPacientePagos.TabIndex = 22;
            // 
            // btnActualizarPagos
            // 
            btnActualizarPagos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnActualizarPagos.Location = new Point(1238, 14);
            btnActualizarPagos.Name = "btnActualizarPagos";
            btnActualizarPagos.Size = new Size(117, 27);
            btnActualizarPagos.TabIndex = 27;
            btnActualizarPagos.Text = "Actualizar";
            btnActualizarPagos.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 23, 42);
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(508, 21);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(291, 73);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 13;
            label4.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(287, 21);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(508, 73);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 11;
            label2.Text = "Paciente:";
            // 
            // btnHoyPagos
            // 
            btnHoyPagos.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHoyPagos.Location = new Point(953, 17);
            btnHoyPagos.Name = "btnHoyPagos";
            btnHoyPagos.Size = new Size(108, 29);
            btnHoyPagos.TabIndex = 8;
            btnHoyPagos.Text = "Hoy";
            btnHoyPagos.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoPago
            // 
            cmbEstadoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoPago.FormattingEnabled = true;
            cmbEstadoPago.Items.AddRange(new object[] { "Pendiente", "Parcial", "Pagada", "Todas" });
            cmbEstadoPago.Location = new Point(602, 19);
            cmbEstadoPago.Name = "cmbEstadoPago";
            cmbEstadoPago.Size = new Size(181, 23);
            cmbEstadoPago.TabIndex = 5;
            // 
            // dtpHastaPagos
            // 
            dtpHastaPagos.CustomFormat = "dd/MM/yyyy";
            dtpHastaPagos.Format = DateTimePickerFormat.Custom;
            dtpHastaPagos.Location = new Point(364, 71);
            dtpHastaPagos.Name = "dtpHastaPagos";
            dtpHastaPagos.Size = new Size(106, 23);
            dtpHastaPagos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 23, 42);
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(287, 22);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 38;
            label1.Text = "Fecha de pago:";
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.CustomFormat = "dd/MM/yyyy";
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.Location = new Point(406, 19);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.Size = new Size(106, 23);
            dtpFechaPago.TabIndex = 37;
            // 
            // txtCambio
            // 
            txtCambio.Location = new Point(407, 60);
            txtCambio.Name = "txtCambio";
            txtCambio.ReadOnly = true;
            txtCambio.ScrollBars = ScrollBars.Vertical;
            txtCambio.Size = new Size(106, 23);
            txtCambio.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 23, 42);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(314, 63);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 39;
            label6.Text = "Cambio:";
            // 
            // txtPacienteSel
            // 
            txtPacienteSel.Location = new Point(1202, 176);
            txtPacienteSel.Name = "txtPacienteSel";
            txtPacienteSel.ReadOnly = true;
            txtPacienteSel.ScrollBars = ScrollBars.Vertical;
            txtPacienteSel.Size = new Size(156, 23);
            txtPacienteSel.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 23, 42);
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(1238, 144);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 41;
            label9.Text = "Paciente:";
            // 
            // txtEstadoSel
            // 
            txtEstadoSel.Location = new Point(1202, 249);
            txtEstadoSel.Name = "txtEstadoSel";
            txtEstadoSel.ReadOnly = true;
            txtEstadoSel.ScrollBars = ScrollBars.Vertical;
            txtEstadoSel.Size = new Size(156, 23);
            txtEstadoSel.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(15, 23, 42);
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(1238, 217);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 43;
            label10.Text = "Estado:";
            // 
            // txtTotalSel
            // 
            txtTotalSel.Location = new Point(1202, 320);
            txtTotalSel.Name = "txtTotalSel";
            txtTotalSel.ReadOnly = true;
            txtTotalSel.ScrollBars = ScrollBars.Vertical;
            txtTotalSel.Size = new Size(156, 23);
            txtTotalSel.TabIndex = 46;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(15, 23, 42);
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(1238, 288);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 45;
            label11.Text = "Total:";
            // 
            // txtPagadoSel
            // 
            txtPagadoSel.Location = new Point(1202, 390);
            txtPagadoSel.Name = "txtPagadoSel";
            txtPagadoSel.ReadOnly = true;
            txtPagadoSel.ScrollBars = ScrollBars.Vertical;
            txtPagadoSel.Size = new Size(156, 23);
            txtPagadoSel.TabIndex = 48;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(15, 23, 42);
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(1238, 358);
            label12.Name = "label12";
            label12.Size = new Size(65, 20);
            label12.TabIndex = 47;
            label12.Text = "Pagado:";
            // 
            // txtSaldoSel
            // 
            txtSaldoSel.Location = new Point(1202, 459);
            txtSaldoSel.Name = "txtSaldoSel";
            txtSaldoSel.ReadOnly = true;
            txtSaldoSel.ScrollBars = ScrollBars.Vertical;
            txtSaldoSel.Size = new Size(156, 23);
            txtSaldoSel.TabIndex = 50;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(15, 23, 42);
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(1238, 427);
            label13.Name = "label13";
            label13.Size = new Size(51, 20);
            label13.TabIndex = 49;
            label13.Text = "Saldo:";
            // 
            // Pagos_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 602);
            Controls.Add(txtSaldoSel);
            Controls.Add(label13);
            Controls.Add(txtPagadoSel);
            Controls.Add(label12);
            Controls.Add(txtTotalSel);
            Controls.Add(label11);
            Controls.Add(txtEstadoSel);
            Controls.Add(label10);
            Controls.Add(txtPacienteSel);
            Controls.Add(label9);
            Controls.Add(dgvPagosFactura);
            Controls.Add(panel1);
            Controls.Add(dgvFacturas);
            Controls.Add(panelX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pagos_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)errorFacturacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagosFactura).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMontoPago).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFacturas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelX.ResumeLayout(false);
            panelX.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorFacturacion;
        private Button btnRegresar;
        private DataGridView dgvPagosFactura;
        private Panel panel1;
        private Button btnRegistrarPago;
        private Button btnCancelarPago;
        private NumericUpDown nudMontoPago;
        private Label label8;
        private Label label7;
        private ComboBox cmbMetodoPago;
        private DataGridView dgvFacturas;
        private Panel panelX;
        private Button btnLimpiarFiltrosPagos;
        private Button btnBuscarPagos;
        private TextBox txtBuscarPacientePagos;
        private Button btnActualizarPagos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnHoyPagos;
        private ComboBox cmbEstadoPago;
        private DateTimePicker dtpHastaPagos;
        private DateTimePicker dtpDesdePagos;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private TextBox txtCambio;
        private Label label6;
        private Label label1;
        private DateTimePicker dtpFechaPago;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox4;
        private Label label12;
        private TextBox textBox3;
        private Label label11;
        private TextBox textBox2;
        private TextBox txtPacienteSel;
        private Label label9;
        private TextBox txtEstadoSel;
        private Label label10;
        private TextBox txtSaldoSel;
        private TextBox txtPagadoSel;
        private TextBox txtTotalSel;
    }
}