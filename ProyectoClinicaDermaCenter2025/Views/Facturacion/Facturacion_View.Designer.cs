namespace ProyectoClinicaDermaCenter2025.Views.Facturacion_Pagos
{
    partial class Facturacion_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion_View));
            panelX = new Panel();
            btnBuscarFacturas = new Button();
            btnLimpiarFiltros = new Button();
            btnBuscarCitas = new Button();
            txtBuscarPaciente = new TextBox();
            btnRefrescarCitas = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnHoy = new Button();
            cmbEstadoFactura = new ComboBox();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            pictureBox1 = new PictureBox();
            dgvCitasCompletadas = new DataGridView();
            panel1 = new Panel();
            label14 = new Label();
            txtTotal = new TextBox();
            label13 = new Label();
            txtDescuento = new TextBox();
            label12 = new Label();
            txtImpuesto = new TextBox();
            label11 = new Label();
            txtSubTotal = new TextBox();
            btnAgregarServicio = new Button();
            btnQuitarServicio = new Button();
            label10 = new Label();
            txtPrecioUnidadLectura = new TextBox();
            nunCantidad = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            cmbServicio = new ComboBox();
            lblIdCitaSeleccionada = new Label();
            label1 = new Label();
            txtMedicoLectura = new TextBox();
            label9 = new Label();
            txtPacienteLectura = new TextBox();
            dtpFechaFacturacion = new DateTimePicker();
            label6 = new Label();
            errorFacturacion = new ErrorProvider(components);
            dgvDetalleFactura = new DataGridView();
            btnGenerarFactura = new Button();
            btnCancelar = new Button();
            btnRegresar = new Button();
            panelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasCompletadas).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nunCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorFacturacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).BeginInit();
            SuspendLayout();
            // 
            // panelX
            // 
            panelX.BackColor = Color.FromArgb(11, 18, 32);
            panelX.Controls.Add(btnBuscarFacturas);
            panelX.Controls.Add(btnLimpiarFiltros);
            panelX.Controls.Add(btnBuscarCitas);
            panelX.Controls.Add(txtBuscarPaciente);
            panelX.Controls.Add(btnRefrescarCitas);
            panelX.Controls.Add(label5);
            panelX.Controls.Add(label4);
            panelX.Controls.Add(label3);
            panelX.Controls.Add(label2);
            panelX.Controls.Add(btnHoy);
            panelX.Controls.Add(cmbEstadoFactura);
            panelX.Controls.Add(dtpHasta);
            panelX.Controls.Add(dtpDesde);
            panelX.Controls.Add(pictureBox1);
            panelX.Dock = DockStyle.Top;
            panelX.Location = new Point(0, 0);
            panelX.Name = "panelX";
            panelX.Size = new Size(1370, 121);
            panelX.TabIndex = 6;
            // 
            // btnBuscarFacturas
            // 
            btnBuscarFacturas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBuscarFacturas.Location = new Point(819, 74);
            btnBuscarFacturas.Name = "btnBuscarFacturas";
            btnBuscarFacturas.Size = new Size(168, 29);
            btnBuscarFacturas.TabIndex = 24;
            btnBuscarFacturas.Text = "Buscar facturas";
            btnBuscarFacturas.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarFiltros
            // 
            btnLimpiarFiltros.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiarFiltros.Location = new Point(1238, 47);
            btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            btnLimpiarFiltros.Size = new Size(117, 57);
            btnLimpiarFiltros.TabIndex = 29;
            btnLimpiarFiltros.Text = "Limpiar Filtros";
            btnLimpiarFiltros.UseVisualStyleBackColor = true;
            btnLimpiarFiltros.Click += btnLimpiarFiltros_Click;
            // 
            // btnBuscarCitas
            // 
            btnBuscarCitas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBuscarCitas.Location = new Point(819, 17);
            btnBuscarCitas.Name = "btnBuscarCitas";
            btnBuscarCitas.Size = new Size(108, 29);
            btnBuscarCitas.TabIndex = 23;
            btnBuscarCitas.Text = "Buscar";
            btnBuscarCitas.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(602, 74);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.ScrollBars = ScrollBars.Vertical;
            txtBuscarPaciente.Size = new Size(181, 23);
            txtBuscarPaciente.TabIndex = 22;
            // 
            // btnRefrescarCitas
            // 
            btnRefrescarCitas.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefrescarCitas.Location = new Point(1238, 14);
            btnRefrescarCitas.Name = "btnRefrescarCitas";
            btnRefrescarCitas.Size = new Size(117, 27);
            btnRefrescarCitas.TabIndex = 27;
            btnRefrescarCitas.Text = "Actualizar";
            btnRefrescarCitas.UseVisualStyleBackColor = true;
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
            // btnHoy
            // 
            btnHoy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHoy.Location = new Point(947, 17);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(108, 29);
            btnHoy.TabIndex = 8;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = true;
            btnHoy.Click += btnHoy_Click;
            // 
            // cmbEstadoFactura
            // 
            cmbEstadoFactura.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoFactura.FormattingEnabled = true;
            cmbEstadoFactura.Items.AddRange(new object[] { "Activa", "Cancelada", "Reprogramada", "Todos" });
            cmbEstadoFactura.Location = new Point(602, 19);
            cmbEstadoFactura.Name = "cmbEstadoFactura";
            cmbEstadoFactura.Size = new Size(181, 23);
            cmbEstadoFactura.TabIndex = 5;
            // 
            // dtpHasta
            // 
            dtpHasta.CustomFormat = "dd/MM/yyyy";
            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.Location = new Point(364, 71);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(106, 23);
            dtpHasta.TabIndex = 4;
            // 
            // dtpDesde
            // 
            dtpDesde.CustomFormat = "dd/MM/yyyy";
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.Location = new Point(364, 19);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(106, 23);
            dtpDesde.TabIndex = 3;
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
            // dgvCitasCompletadas
            // 
            dgvCitasCompletadas.AllowUserToAddRows = false;
            dgvCitasCompletadas.AllowUserToDeleteRows = false;
            dgvCitasCompletadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCitasCompletadas.BackgroundColor = SystemColors.ControlLight;
            dgvCitasCompletadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasCompletadas.Location = new Point(8, 122);
            dgvCitasCompletadas.MultiSelect = false;
            dgvCitasCompletadas.Name = "dgvCitasCompletadas";
            dgvCitasCompletadas.ReadOnly = true;
            dgvCitasCompletadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitasCompletadas.Size = new Size(591, 372);
            dgvCitasCompletadas.TabIndex = 26;
            dgvCitasCompletadas.SelectionChanged += dgvCitasCompletadas_SelectionChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(txtTotal);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(txtDescuento);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtImpuesto);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(btnAgregarServicio);
            panel1.Controls.Add(btnQuitarServicio);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtPrecioUnidadLectura);
            panel1.Controls.Add(nunCantidad);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmbServicio);
            panel1.Controls.Add(lblIdCitaSeleccionada);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtMedicoLectura);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPacienteLectura);
            panel1.Controls.Add(dtpFechaFacturacion);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 500);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 107);
            panel1.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(15, 23, 42);
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(1238, 65);
            label14.Name = "label14";
            label14.Size = new Size(46, 20);
            label14.TabIndex = 44;
            label14.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(1290, 63);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.ScrollBars = ScrollBars.Vertical;
            txtTotal.Size = new Size(68, 23);
            txtTotal.TabIndex = 43;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(15, 23, 42);
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(1199, 17);
            label13.Name = "label13";
            label13.Size = new Size(85, 20);
            label13.TabIndex = 42;
            label13.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(1290, 17);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.ScrollBars = ScrollBars.Vertical;
            txtDescuento.Size = new Size(68, 23);
            txtDescuento.TabIndex = 41;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(15, 23, 42);
            label12.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(976, 63);
            label12.Name = "label12";
            label12.Size = new Size(76, 20);
            label12.TabIndex = 40;
            label12.Text = "Impuesto:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(1058, 60);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.ReadOnly = true;
            txtImpuesto.ScrollBars = ScrollBars.Vertical;
            txtImpuesto.Size = new Size(71, 23);
            txtImpuesto.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(15, 23, 42);
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(976, 19);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 38;
            label11.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.Location = new Point(1058, 18);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.ScrollBars = ScrollBars.Vertical;
            txtSubTotal.Size = new Size(71, 23);
            txtSubTotal.TabIndex = 37;
            // 
            // btnAgregarServicio
            // 
            btnAgregarServicio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAgregarServicio.Location = new Point(731, 55);
            btnAgregarServicio.Name = "btnAgregarServicio";
            btnAgregarServicio.Size = new Size(108, 29);
            btnAgregarServicio.TabIndex = 36;
            btnAgregarServicio.Text = "Agregar";
            btnAgregarServicio.UseVisualStyleBackColor = true;
            // 
            // btnQuitarServicio
            // 
            btnQuitarServicio.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnQuitarServicio.Location = new Point(847, 55);
            btnQuitarServicio.Name = "btnQuitarServicio";
            btnQuitarServicio.Size = new Size(108, 29);
            btnQuitarServicio.TabIndex = 35;
            btnQuitarServicio.Text = "Quitar";
            btnQuitarServicio.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(15, 23, 42);
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(731, 22);
            label10.Name = "label10";
            label10.Size = new Size(110, 20);
            label10.TabIndex = 34;
            label10.Text = "Precio Unidad:";
            // 
            // txtPrecioUnidadLectura
            // 
            txtPrecioUnidadLectura.Location = new Point(847, 20);
            txtPrecioUnidadLectura.Name = "txtPrecioUnidadLectura";
            txtPrecioUnidadLectura.ReadOnly = true;
            txtPrecioUnidadLectura.ScrollBars = ScrollBars.Vertical;
            txtPrecioUnidadLectura.Size = new Size(68, 23);
            txtPrecioUnidadLectura.TabIndex = 33;
            // 
            // nunCantidad
            // 
            nunCantidad.Location = new Point(611, 58);
            nunCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nunCantidad.Name = "nunCantidad";
            nunCantidad.Size = new Size(108, 23);
            nunCantidad.TabIndex = 32;
            nunCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 23, 42);
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(531, 61);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 31;
            label8.Text = "Cantidad:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 23, 42);
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(531, 20);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 30;
            label7.Text = "Servicio:";
            // 
            // cmbServicio
            // 
            cmbServicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Items.AddRange(new object[] { "Activa", "Cancelada", "Reprogramada", "Todos" });
            cmbServicio.Location = new Point(605, 20);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(114, 23);
            cmbServicio.TabIndex = 29;
            // 
            // lblIdCitaSeleccionada
            // 
            lblIdCitaSeleccionada.AutoSize = true;
            lblIdCitaSeleccionada.BackColor = Color.FromArgb(15, 23, 42);
            lblIdCitaSeleccionada.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblIdCitaSeleccionada.ForeColor = SystemColors.ButtonFace;
            lblIdCitaSeleccionada.Location = new Point(343, 62);
            lblIdCitaSeleccionada.Name = "lblIdCitaSeleccionada";
            lblIdCitaSeleccionada.Size = new Size(0, 20);
            lblIdCitaSeleccionada.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 23, 42);
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(8, 64);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 27;
            label1.Text = "Médico:";
            // 
            // txtMedicoLectura
            // 
            txtMedicoLectura.Location = new Point(85, 62);
            txtMedicoLectura.Name = "txtMedicoLectura";
            txtMedicoLectura.ReadOnly = true;
            txtMedicoLectura.ScrollBars = ScrollBars.Vertical;
            txtMedicoLectura.Size = new Size(209, 23);
            txtMedicoLectura.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 23, 42);
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(8, 22);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 22;
            label9.Text = "Paciente:";
            // 
            // txtPacienteLectura
            // 
            txtPacienteLectura.Location = new Point(85, 20);
            txtPacienteLectura.Name = "txtPacienteLectura";
            txtPacienteLectura.ReadOnly = true;
            txtPacienteLectura.ScrollBars = ScrollBars.Vertical;
            txtPacienteLectura.Size = new Size(209, 23);
            txtPacienteLectura.TabIndex = 21;
            // 
            // dtpFechaFacturacion
            // 
            dtpFechaFacturacion.CustomFormat = "dd/MM/yyyy";
            dtpFechaFacturacion.Format = DateTimePickerFormat.Custom;
            dtpFechaFacturacion.Location = new Point(409, 42);
            dtpFechaFacturacion.Name = "dtpFechaFacturacion";
            dtpFechaFacturacion.Size = new Size(100, 23);
            dtpFechaFacturacion.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 23, 42);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(313, 19);
            label6.Name = "label6";
            label6.Size = new Size(90, 60);
            label6.TabIndex = 16;
            label6.Text = "   Fecha \r\n      de \r\nfacturación:";
            // 
            // errorFacturacion
            // 
            errorFacturacion.ContainerControl = this;
            // 
            // dgvDetalleFactura
            // 
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleFactura.BackgroundColor = SystemColors.ControlLight;
            dgvDetalleFactura.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFactura.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDetalleFactura.Location = new Point(605, 122);
            dgvDetalleFactura.MultiSelect = false;
            dgvDetalleFactura.Name = "dgvDetalleFactura";
            dgvDetalleFactura.ReadOnly = true;
            dgvDetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleFactura.Size = new Size(591, 372);
            dgvDetalleFactura.TabIndex = 30;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGenerarFactura.Location = new Point(1199, 316);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(168, 29);
            btnGenerarFactura.TabIndex = 31;
            btnGenerarFactura.Text = "Generar factura";
            btnGenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelar.Location = new Point(1199, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 29);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1225, 428);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 57);
            btnRegresar.TabIndex = 30;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Facturacion_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 602);
            Controls.Add(btnRegresar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGenerarFactura);
            Controls.Add(dgvDetalleFactura);
            Controls.Add(panel1);
            Controls.Add(dgvCitasCompletadas);
            Controls.Add(panelX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Facturacion_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Facturación";
            WindowState = FormWindowState.Maximized;
            panelX.ResumeLayout(false);
            panelX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasCompletadas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nunCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorFacturacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFactura).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelX;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnManiana;
        private Button btnHoy;
        private Button btnListar;
        private Button btnBuscarCitas;
        private Button btnBuscarFacturas;
        private Button btnLimpiarFiltros;
        private Label lblIdCitaSeleccionada;
        private TextBox txtMedicoLectura;
        private DataGridView dgvDetalleFactura;
        private ComboBox cmbServicio;
        private Label label10;
        private TextBox txtPrecioUnidadLectura;
        private NumericUpDown nunCantidad;
        private Label label8;
        private Label label7;
        private Button btnAgregarServicio;
        private Button btnQuitarServicio;
        private Label label14;
        private TextBox txtTotal;
        private Label label13;
        private TextBox txtDescuento;
        private Label label12;
        private TextBox txtImpuesto;
        private Label label11;
        private TextBox txtSubTotal;
        private Button btnCancelar;
        private Button btnGenerarFactura;
        private Button btnRegresar;
        private ComboBox cmbEstadoFactura;
        private DateTimePicker dtpHasta;
        private DateTimePicker dtpDesde;
        private ComboBox cmbMedico;
        private PictureBox pictureBox1;
        private Button btnRefrescarCitas;
        private DataGridView dgvCitasCompletadas;
        private Panel panel1;
        private Button btnCompletada;
        private Button btnReprogramar;
        private Button btnCancelarCita;
        private Button btnCrear;
        private Label label9;
        private TextBox txtPacienteLectura;
        private DateTimePicker dtpFechaFacturacion;
        private Label label6;
        private TextBox txtBuscarPaciente;
        private ErrorProvider errorFacturacion;
    }
}