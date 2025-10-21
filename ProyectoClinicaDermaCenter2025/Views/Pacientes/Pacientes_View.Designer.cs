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
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtEdad = new TextBox();
            cmbSexo = new ComboBox();
            cmbPais = new ComboBox();
            label8 = new Label();
            txtContactoF = new TextBox();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            txtDUI = new TextBox();
            btnRegresar = new Button();
            btnAseguradoraP = new Button();
            dtFechaNac = new DateTimePicker();
            txtDirrec = new TextBox();
            cmbAlergias = new ComboBox();
            label12 = new Label();
            txtOtrasAlergias = new TextBox();
            lblInstruccionAlergia = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label7 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 253, 231);
            txtNombre.Location = new Point(229, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(255, 253, 231);
            txtTelefono.Location = new Point(229, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(222, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(255, 253, 231);
            txtCorreo.Location = new Point(229, 185);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(222, 23);
            txtCorreo.TabIndex = 3;
            txtCorreo.Tag = "";
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnGuardar.Location = new Point(892, 42);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 45);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLimpiar.Location = new Point(1046, 42);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 45);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(526, 42);
            label1.Name = "label1";
            label1.Size = new Size(366, 31);
            label1.TabIndex = 10;
            label1.Text = "REGISTROS DE PACIENTES";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(15, 23, 42);
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(83, 149);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 11;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 23, 42);
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(83, 188);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 12;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 23, 42);
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(83, 229);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(15, 23, 42);
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(908, 151);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 14;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(15, 23, 42);
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(910, 185);
            label6.Name = "label6";
            label6.Size = new Size(42, 20);
            label6.TabIndex = 15;
            label6.Text = "Sexo";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(255, 253, 231);
            txtEdad.Location = new Point(961, 147);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(54, 23);
            txtEdad.TabIndex = 16;
            // 
            // cmbSexo
            // 
            cmbSexo.BackColor = Color.FromArgb(255, 253, 231);
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "M", "F" });
            cmbSexo.Location = new Point(961, 185);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(54, 23);
            cmbSexo.TabIndex = 17;
            // 
            // cmbPais
            // 
            cmbPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPais.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPais.BackColor = Color.FromArgb(255, 253, 231);
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "El Salvador", "", "Afganistán", "", "Albania", "", "Alemania", "", "Andorra", "", "Angola", "", "Antigua y Barbuda", "", "Arabia Saudita", "", "Argelia", "", "Argentina", "", "Armenia", "", "Australia", "", "Austria", "", "Azerbaiyán", "", "Bahamas", "", "Bangladés", "", "Barbados", "", "Baréin", "", "Bélgica", "", "Belice", "", "Benin", "Bielorrusia", "", "Birmania", "", "Bolivia", "", "Bosnia y Herzegovina", "", "Botsuana", "", "Brasil", "", "Brunéi", "", "Bulgaria", "", "Burkina Faso", "", "Burundi", "", "Bután", "", "Cabo Verde", "", "Camboya", "", "Camerún", "", "Canadá", "", "Catar", "", "Chad", "", "Chile", "", "China", "", "Chipre", "", "Ciudad del Vaticano", "", "Colombia", "", "Comoras", "", "Corea del Norte", "", "Corea del Sur", "", "Costa de Marfil", "", "Costa Rica", "", "Croacia", "", "Cuba", "", "Dinamarca", "", "Dominica", "", "Ecuador", "", "Egipto", "", "Emiratos Árabes Unidos", "", "Eritrea", "", "Eslovaquia", "", "Eslovenia", "", "España", "", "Estados Unidos", "", "Estonia", "", "Etiopía", "", "Filipinas", "", "Finlandia", "", "Fiyi", "", "Francia", "", "Gabón", "", "Gambia", "", "Georgia", "", "Ghana", "", "Granada", "", "Grecia", "", "Guatemala", "", "Guyana", "", "Guinea", "", "Guinea ecuatorial", "", "Guinea-Bisáu", "", "Haití", "", "Honduras", "", "Hungría", "", "India", "", "Indonesia", "", "Irak", "Irán", "", "Irlanda", "", "Islandia", "", "Islas Marshal", "l", "Islas Salomón", "", "Israel", "", "Italia", "", "Jamaica", "", "Japón", "", "Jordania", "", "Kazajistán", "", "Kenia", "", "Kirguistán", "", "Kiribati", "", "Kuwait", "", "Laos", "", "Lesoto", "", "Letonia", "", "Líbano", "", "Liberia", "", "Libia", "", "Liechtenstein", "", "Lituania", "", "Luxemburgo", "", "Macedonia del Norte", "", "Madagascar", "", "Malasia", "", "Malaui", "", "Maldivas", "", "Malí", "", "Malta", "", "Marruecos", "", "Mauricio", "", "Mauritania", "", "México", "", "Micronesia", "", "Moldavia", "", "Mónaco", "", "Mongolia", "", "Montenegro", "", "Mozambique", "", "Namibia", "", "Nauru", "", "Nepal", "", "Nicaragua", "", "Níger", "", "Nigeria", "", "Noruega", "", "Nueva Zelanda", "", "Omán", "", "Países Bajos", "", "Pakistán", "", "Palaos", "", "Panamá", "", "Papúa new Guinea", "", "Paraguay", "", "Perú", "", "Polonia", "", "Portugal", "", "Reino Unido", "", "República Centroafricana", "", "República Checa", "", "República del Congo", "", "República Democrática del Congo", "", "República Dominicana", "", "República Sudafricana", "", "Ruanda", "", "Rumania", "", "Rusia", "", "Samoa", "", "San Cristóbal y Nieves", "", "San Marino", "", "San Vicente y las Granadinas", "", "Santa Lucía", "", "Santo Tomé y Príncipe", "", "Senegal", "", "Serbia", "", "Seychelles", "", "Sierra Leona", "", "Singapur", "", "Siria", "", "Somalia", "", "Sri Lanka", "", "Suazilandia", "", "Sudán", "", "Sudán del Sur", "", "Suecia", "", "Suiza", "", "Surinam", "", "Tailandia", "", "Tanzania", "", "Tayikistán", "", "Timor Oriental", "", "Togo", "", "Tonga", "", "Trinidad y Tobago", "", "Túnez", "", "Turkmenistán", "", "Turquía", "", "Tuvalu", "", "Ucrania", "", "Uganda", "", "Uruguay", "", "Uzbekistán", "", "Vanuatu", "", "Venezuela", "", "Vietnam", "", "Yemen", "", "Yibuti", "", "Zambia", "", "Zimbabue" });
            cmbPais.Location = new Point(1150, 147);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(93, 23);
            cmbPais.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(15, 23, 42);
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(910, 222);
            label8.Name = "label8";
            label8.Size = new Size(35, 20);
            label8.TabIndex = 20;
            label8.Text = "DUI";
            // 
            // txtContactoF
            // 
            txtContactoF.BackColor = Color.FromArgb(255, 253, 231);
            txtContactoF.BorderStyle = BorderStyle.FixedSingle;
            txtContactoF.Location = new Point(732, 147);
            txtContactoF.Name = "txtContactoF";
            txtContactoF.Size = new Size(139, 23);
            txtContactoF.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(15, 23, 42);
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(493, 229);
            label9.Name = "label9";
            label9.Size = new Size(80, 20);
            label9.TabIndex = 22;
            label9.Text = "Dirreccion";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(15, 23, 42);
            label11.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(493, 151);
            label11.Name = "label11";
            label11.Size = new Size(233, 20);
            label11.TabIndex = 26;
            label11.Text = "Contacto de Emergencia Familiar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.FromArgb(15, 23, 42);
            label13.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(493, 188);
            label13.Name = "label13";
            label13.Size = new Size(134, 20);
            label13.TabIndex = 28;
            label13.Text = "Fecha/Nacimiento";
            // 
            // txtDUI
            // 
            txtDUI.BackColor = Color.FromArgb(255, 253, 231);
            txtDUI.Location = new Point(961, 221);
            txtDUI.Name = "txtDUI";
            txtDUI.Size = new Size(81, 23);
            txtDUI.TabIndex = 29;
            // 
            // btnRegresar
            // 
            btnRegresar.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRegresar.Location = new Point(1212, 42);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 45);
            btnRegresar.TabIndex = 32;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAseguradoraP
            // 
            btnAseguradoraP.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnAseguradoraP.Location = new Point(687, 51);
            btnAseguradoraP.Name = "btnAseguradoraP";
            btnAseguradoraP.Size = new Size(157, 27);
            btnAseguradoraP.TabIndex = 33;
            btnAseguradoraP.Text = "Aseguradora/Polizas";
            btnAseguradoraP.UseVisualStyleBackColor = true;
            btnAseguradoraP.Click += btnAseguradoraP_Click;
            // 
            // dtFechaNac
            // 
            dtFechaNac.CalendarMonthBackground = Color.FromArgb(255, 253, 231);
            dtFechaNac.CalendarTitleBackColor = Color.FromArgb(255, 253, 231);
            dtFechaNac.Location = new Point(732, 185);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(139, 23);
            dtFechaNac.TabIndex = 34;
            // 
            // txtDirrec
            // 
            txtDirrec.BackColor = Color.FromArgb(255, 253, 231);
            txtDirrec.Location = new Point(732, 221);
            txtDirrec.Name = "txtDirrec";
            txtDirrec.Size = new Size(139, 23);
            txtDirrec.TabIndex = 35;
            // 
            // cmbAlergias
            // 
            cmbAlergias.BackColor = Color.FromArgb(255, 253, 231);
            cmbAlergias.FormattingEnabled = true;
            cmbAlergias.Items.AddRange(new object[] { "Penicilina", "", "Aspirina (AINEs)", "", "Sulfas", "", "Mariscos", "", "Maní (Cacahuates)", "", "Lácteos", "", "Huevo", "", "Trigo (Gluten)", "", "Polen", "", "Ácaros del polvo", "", "Pelo de gato", "", "Pelo de perro", "", "Picaduras de insectos", "", "Látex", "", "Níquel (Metales)", "", "Otros..." });
            cmbAlergias.Location = new Point(1150, 184);
            cmbAlergias.Name = "cmbAlergias";
            cmbAlergias.Size = new Size(121, 23);
            cmbAlergias.TabIndex = 36;
            cmbAlergias.SelectedIndexChanged += cmbAlergias_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1076, 226);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 37;
            label12.Visible = false;
            // 
            // txtOtrasAlergias
            // 
            txtOtrasAlergias.BackColor = Color.FromArgb(255, 253, 231);
            txtOtrasAlergias.Location = new Point(1150, 226);
            txtOtrasAlergias.Name = "txtOtrasAlergias";
            txtOtrasAlergias.Size = new Size(132, 23);
            txtOtrasAlergias.TabIndex = 38;
            // 
            // lblInstruccionAlergia
            // 
            lblInstruccionAlergia.AutoSize = true;
            lblInstruccionAlergia.BackColor = Color.FromArgb(11, 18, 32);
            lblInstruccionAlergia.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblInstruccionAlergia.ForeColor = SystemColors.ButtonFace;
            lblInstruccionAlergia.Location = new Point(1060, 224);
            lblInstruccionAlergia.Name = "lblInstruccionAlergia";
            lblInstruccionAlergia.Size = new Size(0, 20);
            lblInstruccionAlergia.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(11, 18, 32);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1370, 121);
            panel1.TabIndex = 41;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 23, 42);
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(1060, 148);
            label7.Name = "label7";
            label7.Size = new Size(36, 20);
            label7.TabIndex = 41;
            label7.Text = "Pais";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.FromArgb(15, 23, 42);
            label14.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(1060, 184);
            label14.Name = "label14";
            label14.Size = new Size(64, 20);
            label14.TabIndex = 42;
            label14.Text = "Alergias";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(11, 18, 32);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnRegresar);
            panel2.Controls.Add(btnAseguradoraP);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 438);
            panel2.Name = "panel2";
            panel2.Size = new Size(1370, 121);
            panel2.TabIndex = 43;
            // 
            // Pacientes_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1370, 559);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(lblInstruccionAlergia);
            Controls.Add(txtOtrasAlergias);
            Controls.Add(label12);
            Controls.Add(cmbAlergias);
            Controls.Add(txtDirrec);
            Controls.Add(dtFechaNac);
            Controls.Add(txtDUI);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(txtContactoF);
            Controls.Add(label8);
            Controls.Add(cmbPais);
            Controls.Add(cmbSexo);
            Controls.Add(txtEdad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pacientes_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pacientes";
            WindowState = FormWindowState.Maximized;
            Load += Pacientes_View_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtEdad;
        private ComboBox cmbSexo;
        private ComboBox cmbPais;
        private Label label8;
        private TextBox txtContactoF;
        private Label label9;
        private TextBox txtDireccion;
        private TextBox txtFechaNac;
        private Label label11;
        private Label label13;
        private TextBox txtDUI;
        private Button btnRegresar;
        private Button btnAseguradoraP;
        private DateTimePicker dtFechaNac;
        private TextBox txtDirrec;
        private ComboBox cmbAlergias;
        private Label label12;
        private TextBox txtOtrasAlergias;
        private Label lblInstruccionAlergia;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label7;
        private Label label14;
        private Panel panel2;
    }
}