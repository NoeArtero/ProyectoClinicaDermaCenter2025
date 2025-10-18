namespace ProyectoClinicaDermaCenter2025.Views.Reportes
{
    partial class ReporteQuincenalView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteQuincenalView));
            btnRegresar = new Button();
            btnExportarPDF = new Button();
            errorReportes = new ErrorProvider(components);
            btnCancelar = new Button();
            panel1 = new Panel();
            dtpDesdeReporte = new DateTimePicker();
            pictureBox1 = new PictureBox();
            panelX = new Panel();
            btnUltimos15 = new Button();
            btnAyerReporte = new Button();
            btnLimpiarFiltros = new Button();
            btnBuscarReporte = new Button();
            txtBuscarPacienteReporte = new TextBox();
            btnRefrescarGrids = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnHoyReporte = new Button();
            cmbEstadoReporte = new ComboBox();
            dtpHastaReporte = new DateTimePicker();
            tabControl = new TabControl();
            tabResumen = new TabPage();
            dgvResumen = new DataGridView();
            tabFacturas = new TabPage();
            dgvDetalleFacturas = new DataGridView();
            tabPagos = new TabPage();
            dgvDetallePagos = new DataGridView();
            statusStrip1 = new StatusStrip();
            tslStatus = new ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)errorReportes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelX.SuspendLayout();
            tabControl.SuspendLayout();
            tabResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResumen).BeginInit();
            tabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFacturas).BeginInit();
            tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePagos).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1250, 10);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 57);
            btnRegresar.TabIndex = 36;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnExportarPDF
            // 
            btnExportarPDF.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExportarPDF.Location = new Point(25, 24);
            btnExportarPDF.Name = "btnExportarPDF";
            btnExportarPDF.Size = new Size(168, 29);
            btnExportarPDF.TabIndex = 38;
            btnExportarPDF.Text = "Exportar PDF";
            btnExportarPDF.UseVisualStyleBackColor = true;
            // 
            // errorReportes
            // 
            errorReportes.ContainerControl = this;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelar.Location = new Point(234, 24);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(168, 29);
            btnCancelar.TabIndex = 39;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(btnExportarPDF);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnRegresar);
            panel1.Location = new Point(0, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 107);
            panel1.TabIndex = 35;
            // 
            // dtpDesdeReporte
            // 
            dtpDesdeReporte.CustomFormat = "dd/MM/yyyy";
            dtpDesdeReporte.Format = DateTimePickerFormat.Custom;
            dtpDesdeReporte.Location = new Point(364, 19);
            dtpDesdeReporte.Name = "dtpDesdeReporte";
            dtpDesdeReporte.Size = new Size(106, 23);
            dtpDesdeReporte.TabIndex = 3;
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
            panelX.Controls.Add(btnUltimos15);
            panelX.Controls.Add(btnAyerReporte);
            panelX.Controls.Add(btnLimpiarFiltros);
            panelX.Controls.Add(btnBuscarReporte);
            panelX.Controls.Add(txtBuscarPacienteReporte);
            panelX.Controls.Add(btnRefrescarGrids);
            panelX.Controls.Add(label5);
            panelX.Controls.Add(label4);
            panelX.Controls.Add(label3);
            panelX.Controls.Add(label2);
            panelX.Controls.Add(btnHoyReporte);
            panelX.Controls.Add(cmbEstadoReporte);
            panelX.Controls.Add(dtpHastaReporte);
            panelX.Controls.Add(dtpDesdeReporte);
            panelX.Controls.Add(pictureBox1);
            panelX.Dock = DockStyle.Top;
            panelX.Location = new Point(0, 0);
            panelX.Name = "panelX";
            panelX.Size = new Size(1370, 121);
            panelX.TabIndex = 33;
            // 
            // btnUltimos15
            // 
            btnUltimos15.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnUltimos15.Location = new Point(944, 71);
            btnUltimos15.Name = "btnUltimos15";
            btnUltimos15.Size = new Size(119, 29);
            btnUltimos15.TabIndex = 31;
            btnUltimos15.Text = "Ultimos 15 días";
            btnUltimos15.UseVisualStyleBackColor = true;
            // 
            // btnAyerReporte
            // 
            btnAyerReporte.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAyerReporte.Location = new Point(807, 71);
            btnAyerReporte.Name = "btnAyerReporte";
            btnAyerReporte.Size = new Size(120, 29);
            btnAyerReporte.TabIndex = 30;
            btnAyerReporte.Text = "Ayer";
            btnAyerReporte.UseVisualStyleBackColor = true;
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
            // 
            // btnBuscarReporte
            // 
            btnBuscarReporte.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBuscarReporte.Location = new Point(807, 17);
            btnBuscarReporte.Name = "btnBuscarReporte";
            btnBuscarReporte.Size = new Size(120, 29);
            btnBuscarReporte.TabIndex = 23;
            btnBuscarReporte.Text = "Buscar";
            btnBuscarReporte.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPacienteReporte
            // 
            txtBuscarPacienteReporte.Location = new Point(602, 74);
            txtBuscarPacienteReporte.Name = "txtBuscarPacienteReporte";
            txtBuscarPacienteReporte.ScrollBars = ScrollBars.Vertical;
            txtBuscarPacienteReporte.Size = new Size(181, 23);
            txtBuscarPacienteReporte.TabIndex = 22;
            // 
            // btnRefrescarGrids
            // 
            btnRefrescarGrids.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefrescarGrids.Location = new Point(1238, 14);
            btnRefrescarGrids.Name = "btnRefrescarGrids";
            btnRefrescarGrids.Size = new Size(117, 27);
            btnRefrescarGrids.TabIndex = 27;
            btnRefrescarGrids.Text = "Actualizar";
            btnRefrescarGrids.UseVisualStyleBackColor = true;
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
            // btnHoyReporte
            // 
            btnHoyReporte.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHoyReporte.Location = new Point(944, 17);
            btnHoyReporte.Name = "btnHoyReporte";
            btnHoyReporte.Size = new Size(119, 29);
            btnHoyReporte.TabIndex = 8;
            btnHoyReporte.Text = "Hoy";
            btnHoyReporte.UseVisualStyleBackColor = true;
            // 
            // cmbEstadoReporte
            // 
            cmbEstadoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoReporte.FormattingEnabled = true;
            cmbEstadoReporte.Items.AddRange(new object[] { "Pendiente", "Parcial", "Pagada", "Todas" });
            cmbEstadoReporte.Location = new Point(602, 19);
            cmbEstadoReporte.Name = "cmbEstadoReporte";
            cmbEstadoReporte.Size = new Size(181, 23);
            cmbEstadoReporte.TabIndex = 5;
            // 
            // dtpHastaReporte
            // 
            dtpHastaReporte.CustomFormat = "dd/MM/yyyy";
            dtpHastaReporte.Format = DateTimePickerFormat.Custom;
            dtpHastaReporte.Location = new Point(364, 71);
            dtpHastaReporte.Name = "dtpHastaReporte";
            dtpHastaReporte.Size = new Size(106, 23);
            dtpHastaReporte.TabIndex = 4;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabResumen);
            tabControl.Controls.Add(tabFacturas);
            tabControl.Controls.Add(tabPagos);
            tabControl.Location = new Point(2, 123);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(717, 369);
            tabControl.TabIndex = 40;
            // 
            // tabResumen
            // 
            tabResumen.Controls.Add(dgvResumen);
            tabResumen.Location = new Point(4, 24);
            tabResumen.Name = "tabResumen";
            tabResumen.Padding = new Padding(3);
            tabResumen.Size = new Size(709, 341);
            tabResumen.TabIndex = 0;
            tabResumen.Text = "Resumen";
            tabResumen.UseVisualStyleBackColor = true;
            // 
            // dgvResumen
            // 
            dgvResumen.AllowUserToAddRows = false;
            dgvResumen.AllowUserToDeleteRows = false;
            dgvResumen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResumen.BackgroundColor = SystemColors.ControlLight;
            dgvResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen.Location = new Point(0, 0);
            dgvResumen.MultiSelect = false;
            dgvResumen.Name = "dgvResumen";
            dgvResumen.ReadOnly = true;
            dgvResumen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvResumen.Size = new Size(589, 341);
            dgvResumen.TabIndex = 27;
            // 
            // tabFacturas
            // 
            tabFacturas.Controls.Add(dgvDetalleFacturas);
            tabFacturas.Location = new Point(4, 24);
            tabFacturas.Name = "tabFacturas";
            tabFacturas.Padding = new Padding(3);
            tabFacturas.Size = new Size(709, 341);
            tabFacturas.TabIndex = 1;
            tabFacturas.Text = "Facturas";
            tabFacturas.UseVisualStyleBackColor = true;
            // 
            // dgvDetalleFacturas
            // 
            dgvDetalleFacturas.AllowUserToAddRows = false;
            dgvDetalleFacturas.AllowUserToDeleteRows = false;
            dgvDetalleFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetalleFacturas.BackgroundColor = SystemColors.ControlLight;
            dgvDetalleFacturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleFacturas.Location = new Point(2, 0);
            dgvDetalleFacturas.MultiSelect = false;
            dgvDetalleFacturas.Name = "dgvDetalleFacturas";
            dgvDetalleFacturas.ReadOnly = true;
            dgvDetalleFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleFacturas.Size = new Size(590, 341);
            dgvDetalleFacturas.TabIndex = 28;
            // 
            // tabPagos
            // 
            tabPagos.Controls.Add(dgvDetallePagos);
            tabPagos.Location = new Point(4, 24);
            tabPagos.Name = "tabPagos";
            tabPagos.Padding = new Padding(3);
            tabPagos.Size = new Size(709, 341);
            tabPagos.TabIndex = 2;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // dgvDetallePagos
            // 
            dgvDetallePagos.AllowUserToAddRows = false;
            dgvDetallePagos.AllowUserToDeleteRows = false;
            dgvDetallePagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDetallePagos.BackgroundColor = SystemColors.ControlLight;
            dgvDetallePagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePagos.Location = new Point(2, 0);
            dgvDetallePagos.MultiSelect = false;
            dgvDetallePagos.Name = "dgvDetallePagos";
            dgvDetallePagos.ReadOnly = true;
            dgvDetallePagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallePagos.Size = new Size(590, 341);
            dgvDetallePagos.TabIndex = 28;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslStatus });
            statusStrip1.Location = new Point(0, 580);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1370, 22);
            statusStrip1.TabIndex = 41;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            tslStatus.Name = "tslStatus";
            tslStatus.Size = new Size(100, 16);
            // 
            // ReporteQuincenalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 602);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl);
            Controls.Add(panel1);
            Controls.Add(panelX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ReporteQuincenalView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)errorReportes).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelX.ResumeLayout(false);
            panelX.PerformLayout();
            tabControl.ResumeLayout(false);
            tabResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvResumen).EndInit();
            tabFacturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetalleFacturas).EndInit();
            tabPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetallePagos).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnExportarPDF;
        private ErrorProvider errorReportes;
        private Button btnCancelar;
        private Panel panel1;
        private Panel panelX;
        private Button btnLimpiarFiltros;
        private Button btnBuscarReporte;
        private TextBox txtBuscarPacienteReporte;
        private Button btnRefrescarGrids;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbEstadoReporte;
        private DateTimePicker dtpHastaReporte;
        private DateTimePicker dtpDesdeReporte;
        private PictureBox pictureBox1;
        private TabControl tabControl;
        private TabPage tabResumen;
        private TabPage tabFacturas;
        private TabPage tabPagos;
        private DataGridView dgvResumen;
        private DataGridView dgvDetalleFacturas;
        private DataGridView dgvDetallePagos;
        private Button btnUltimos15;
        private Button btnAyerReporte;
        private Button btnHoyReporte;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar tslStatus;
    }
}