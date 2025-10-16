namespace ProyectoClinicaDermaCenter2025.Views.Citas
{
    partial class Citas_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Citas_View));
            toolStripContainer1 = new ToolStripContainer();
            dgvCitas = new DataGridView();
            dtpFecha = new DateTimePicker();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            cmbMedico = new ComboBox();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            cmbEstado = new ComboBox();
            btnBuscar = new Button();
            btnListar = new Button();
            btnHoy = new Button();
            btnManiana = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cmbPaciente = new ComboBox();
            panelX = new Panel();
            panel1 = new Panel();
            btnCompletada = new Button();
            btnReprogramar = new Button();
            label10 = new Label();
            btnCancelarCita = new Button();
            txtNotas = new TextBox();
            btnCrear = new Button();
            label9 = new Label();
            txtMotivo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            errorCitas = new ErrorProvider(components);
            btnRegresar = new Button();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelX.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorCitas).BeginInit();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Size = new Size(150, 150);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(150, 175);
            toolStripContainer1.TabIndex = 0;
            // 
            // dgvCitas
            // 
            dgvCitas.AllowUserToAddRows = false;
            dgvCitas.AllowUserToDeleteRows = false;
            dgvCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvCitas.BackgroundColor = SystemColors.ControlLight;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(177, 127);
            dgvCitas.MultiSelect = false;
            dgvCitas.Name = "dgvCitas";
            dgvCitas.ReadOnly = true;
            dgvCitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCitas.Size = new Size(1000, 372);
            dgvCitas.TabIndex = 6;
            dgvCitas.SelectionChanged += dgvCitas_SelectionChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(73, 40);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 23, 42);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(16, 40);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 16;
            label6.Text = "Fecha:";
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
            // cmbMedico
            // 
            cmbMedico.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMedico.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedico.FormattingEnabled = true;
            cmbMedico.Location = new Point(370, 25);
            cmbMedico.Name = "cmbMedico";
            cmbMedico.Size = new Size(145, 23);
            cmbMedico.TabIndex = 1;
            // 
            // dtpDesde
            // 
            dtpDesde.CustomFormat = "dd/MM/yyyy";
            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.Location = new Point(671, 25);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(106, 23);
            dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            dtpHasta.CustomFormat = "dd/MM/yyyy";
            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.Location = new Point(671, 77);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(106, 23);
            dtpHasta.TabIndex = 4;
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Activa", "Cancelada", "Reprogramada", "Todos" });
            cmbEstado.Location = new Point(892, 25);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnBuscar.Location = new Point(1069, 20);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(108, 29);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnListar.Location = new Point(1237, 19);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(107, 29);
            btnListar.TabIndex = 7;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // btnHoy
            // 
            btnHoy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnHoy.Location = new Point(1069, 69);
            btnHoy.Name = "btnHoy";
            btnHoy.Size = new Size(108, 29);
            btnHoy.TabIndex = 8;
            btnHoy.Text = "Hoy";
            btnHoy.UseVisualStyleBackColor = true;
            // 
            // btnManiana
            // 
            btnManiana.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnManiana.Location = new Point(1237, 68);
            btnManiana.Name = "btnManiana";
            btnManiana.Size = new Size(107, 29);
            btnManiana.TabIndex = 9;
            btnManiana.Text = "Mañana";
            btnManiana.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(15, 23, 42);
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(282, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Médico:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(275, 79);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 11;
            label2.Text = "Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(594, 27);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 12;
            label3.Text = "Desde:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(598, 79);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 13;
            label4.Text = "Hasta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 23, 42);
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(828, 28);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Estado:";
            // 
            // cmbPaciente
            // 
            cmbPaciente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPaciente.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaciente.FormattingEnabled = true;
            cmbPaciente.Location = new Point(370, 77);
            cmbPaciente.Name = "cmbPaciente";
            cmbPaciente.Size = new Size(145, 23);
            cmbPaciente.TabIndex = 15;
            // 
            // panelX
            // 
            panelX.BackColor = Color.FromArgb(11, 18, 32);
            panelX.Controls.Add(cmbPaciente);
            panelX.Controls.Add(label5);
            panelX.Controls.Add(label4);
            panelX.Controls.Add(label3);
            panelX.Controls.Add(label2);
            panelX.Controls.Add(label1);
            panelX.Controls.Add(btnManiana);
            panelX.Controls.Add(btnHoy);
            panelX.Controls.Add(btnListar);
            panelX.Controls.Add(btnBuscar);
            panelX.Controls.Add(cmbEstado);
            panelX.Controls.Add(dtpHasta);
            panelX.Controls.Add(dtpDesde);
            panelX.Controls.Add(cmbMedico);
            panelX.Controls.Add(pictureBox1);
            panelX.Dock = DockStyle.Top;
            panelX.Location = new Point(0, 0);
            panelX.Name = "panelX";
            panelX.Size = new Size(1370, 121);
            panelX.TabIndex = 5;
            panelX.Paint += panelX_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(btnCompletada);
            panel1.Controls.Add(btnReprogramar);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(btnCancelarCita);
            panel1.Controls.Add(txtNotas);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtMotivo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 498);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 107);
            panel1.TabIndex = 17;
            // 
            // btnCompletada
            // 
            btnCompletada.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCompletada.Location = new Point(1065, 62);
            btnCompletada.Name = "btnCompletada";
            btnCompletada.Size = new Size(112, 29);
            btnCompletada.TabIndex = 25;
            btnCompletada.Text = "Completada";
            btnCompletada.UseVisualStyleBackColor = true;
            btnCompletada.Click += btnCompletada_Click;
            // 
            // btnReprogramar
            // 
            btnReprogramar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnReprogramar.Location = new Point(1227, 20);
            btnReprogramar.Name = "btnReprogramar";
            btnReprogramar.Size = new Size(112, 29);
            btnReprogramar.TabIndex = 18;
            btnReprogramar.Text = "Reprogramar";
            btnReprogramar.UseVisualStyleBackColor = true;
            btnReprogramar.Click += btnReprogramar_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(15, 23, 42);
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(751, 20);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 24;
            label10.Text = "Notas:";
            // 
            // btnCancelarCita
            // 
            btnCancelarCita.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancelarCita.Location = new Point(1227, 63);
            btnCancelarCita.Name = "btnCancelarCita";
            btnCancelarCita.Size = new Size(112, 29);
            btnCancelarCita.TabIndex = 17;
            btnCancelarCita.Text = "Cancelar";
            btnCancelarCita.UseVisualStyleBackColor = true;
            btnCancelarCita.Click += btnCancelarCita_Click;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(819, 17);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.ScrollBars = ScrollBars.Vertical;
            txtNotas.Size = new Size(223, 75);
            txtNotas.TabIndex = 23;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCrear.Location = new Point(1069, 20);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(108, 29);
            btnCrear.TabIndex = 16;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 23, 42);
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(445, 20);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 22;
            label9.Text = "Motivo:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(513, 17);
            txtMotivo.Multiline = true;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.ScrollBars = ScrollBars.Vertical;
            txtMotivo.Size = new Size(223, 75);
            txtMotivo.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 23, 42);
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(204, 71);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 20;
            label8.Text = "Hora de fin:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 23, 42);
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(185, 20);
            label7.Name = "label7";
            label7.Size = new Size(109, 20);
            label7.TabIndex = 19;
            label7.Text = "Hora de inicio:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "HH:mm";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(300, 69);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "HH:mm";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(300, 18);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // errorCitas
            // 
            errorCitas.ContainerControl = this;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1227, 416);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(117, 76);
            btnRegresar.TabIndex = 25;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Citas_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 602);
            Controls.Add(btnRegresar);
            Controls.Add(panel1);
            Controls.Add(dgvCitas);
            Controls.Add(panelX);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Citas_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Citas";
            WindowState = FormWindowState.Maximized;
            Load += Citas_View_Load;
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelX.ResumeLayout(false);
            panelX.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorCitas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private DataGridView dgvCitas;
        private DateTimePicker dtpFecha;
        private Label label6;
        private PictureBox pictureBox1;
        private ComboBox cmbMedico;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private ComboBox cmbEstado;
        private Button btnBuscar;
        private Button btnListar;
        private Button btnHoy;
        private Button btnManiana;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbPaciente;
        private Panel panelX;
        private Panel panel1;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnReprogramar;
        private Label label10;
        private Button btnCancelarCita;
        private TextBox txtNotas;
        private Button btnCrear;
        private Label label9;
        private TextBox txtMotivo;
        private ErrorProvider errorCitas;
        private Button btnRegresar;
        private Button btnCompletada;
    }
}