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
            label7 = new Label();
            cmbPais = new ComboBox();
            label8 = new Label();
            txtContactoF = new TextBox();
            label9 = new Label();
            label10 = new Label();
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
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(255, 253, 231);
            txtNombre.Location = new Point(217, 148);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(222, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.FromArgb(255, 253, 231);
            txtTelefono.Location = new Point(217, 226);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(222, 23);
            txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(255, 253, 231);
            txtCorreo.Location = new Point(217, 185);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(222, 23);
            txtCorreo.TabIndex = 3;
            txtCorreo.Tag = "";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(646, 406);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 45);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(840, 406);
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
            label2.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 149);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 11;
            label2.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 188);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 12;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(82, 229);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 13;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(908, 151);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 14;
            label5.Text = "Edad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(910, 185);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1076, 151);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 18;
            label7.Text = "Pais";
            // 
            // cmbPais
            // 
            cmbPais.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbPais.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbPais.BackColor = Color.FromArgb(255, 253, 231);
            cmbPais.FormattingEnabled = true;
            cmbPais.Items.AddRange(new object[] { "El Salvador", "", "Afganistán", "", "Albania", "", "Alemania", "", "Andorra", "", "Angola", "", "Antigua y Barbuda", "", "Arabia Saudita", "", "Argelia", "", "Argentina", "", "Armenia", "", "Australia", "", "Austria", "", "Azerbaiyán", "", "Bahamas", "", "Bangladés", "", "Barbados", "", "Baréin", "", "Bélgica", "", "Belice", "", "Benin", "Bielorrusia", "", "Birmania", "", "Bolivia", "", "Bosnia y Herzegovina", "", "Botsuana", "", "Brasil", "", "Brunéi", "", "Bulgaria", "", "Burkina Faso", "", "Burundi", "", "Bután", "", "Cabo Verde", "", "Camboya", "", "Camerún", "", "Canadá", "", "Catar", "", "Chad", "", "Chile", "", "China", "", "Chipre", "", "Ciudad del Vaticano", "", "Colombia", "", "Comoras", "", "Corea del Norte", "", "Corea del Sur", "", "Costa de Marfil", "", "Costa Rica", "", "Croacia", "", "Cuba", "", "Dinamarca", "", "Dominica", "", "Ecuador", "", "Egipto", "", "Emiratos Árabes Unidos", "", "Eritrea", "", "Eslovaquia", "", "Eslovenia", "", "España", "", "Estados Unidos", "", "Estonia", "", "Etiopía", "", "Filipinas", "", "Finlandia", "", "Fiyi", "", "Francia", "", "Gabón", "", "Gambia", "", "Georgia", "", "Ghana", "", "Granada", "", "Grecia", "", "Guatemala", "", "Guyana", "", "Guinea", "", "Guinea ecuatorial", "", "Guinea-Bisáu", "", "Haití", "", "Honduras", "", "Hungría", "", "India", "", "Indonesia", "", "Irak", "Irán", "", "Irlanda", "", "Islandia", "", "Islas Marshal", "l", "Islas Salomón", "", "Israel", "", "Italia", "", "Jamaica", "", "Japón", "", "Jordania", "", "Kazajistán", "", "Kenia", "", "Kirguistán", "", "Kiribati", "", "Kuwait", "", "Laos", "", "Lesoto", "", "Letonia", "", "Líbano", "", "Liberia", "", "Libia", "", "Liechtenstein", "", "Lituania", "", "Luxemburgo", "", "Macedonia del Norte", "", "Madagascar", "", "Malasia", "", "Malaui", "", "Maldivas", "", "Malí", "", "Malta", "", "Marruecos", "", "Mauricio", "", "Mauritania", "", "México", "", "Micronesia", "", "Moldavia", "", "Mónaco", "", "Mongolia", "", "Montenegro", "", "Mozambique", "", "Namibia", "", "Nauru", "", "Nepal", "", "Nicaragua", "", "Níger", "", "Nigeria", "", "Noruega", "", "Nueva Zelanda", "", "Omán", "", "Países Bajos", "", "Pakistán", "", "Palaos", "", "Panamá", "", "Papúa new Guinea", "", "Paraguay", "", "Perú", "", "Polonia", "", "Portugal", "", "Reino Unido", "", "República Centroafricana", "", "República Checa", "", "República del Congo", "", "República Democrática del Congo", "", "República Dominicana", "", "República Sudafricana", "", "Ruanda", "", "Rumania", "", "Rusia", "", "Samoa", "", "San Cristóbal y Nieves", "", "San Marino", "", "San Vicente y las Granadinas", "", "Santa Lucía", "", "Santo Tomé y Príncipe", "", "Senegal", "", "Serbia", "", "Seychelles", "", "Sierra Leona", "", "Singapur", "", "Siria", "", "Somalia", "", "Sri Lanka", "", "Suazilandia", "", "Sudán", "", "Sudán del Sur", "", "Suecia", "", "Suiza", "", "Surinam", "", "Tailandia", "", "Tanzania", "", "Tayikistán", "", "Timor Oriental", "", "Togo", "", "Tonga", "", "Trinidad y Tobago", "", "Túnez", "", "Turkmenistán", "", "Turquía", "", "Tuvalu", "", "Ucrania", "", "Uganda", "", "Uruguay", "", "Uzbekistán", "", "Vanuatu", "", "Venezuela", "", "Vietnam", "", "Yemen", "", "Yibuti", "", "Zambia", "", "Zimbabue" });
            cmbPais.Location = new Point(1132, 146);
            cmbPais.Name = "cmbPais";
            cmbPais.Size = new Size(93, 23);
            cmbPais.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(910, 229);
            label8.Name = "label8";
            label8.Size = new Size(26, 15);
            label8.TabIndex = 20;
            label8.Text = "DUI";
            // 
            // txtContactoF
            // 
            txtContactoF.BackColor = Color.FromArgb(255, 253, 231);
            txtContactoF.BorderStyle = BorderStyle.FixedSingle;
            txtContactoF.Location = new Point(700, 147);
            txtContactoF.Name = "txtContactoF";
            txtContactoF.Size = new Size(139, 23);
            txtContactoF.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(493, 229);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 22;
            label9.Text = "Dirreccion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1076, 188);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 23;
            label10.Text = "Alergias ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(493, 151);
            label11.Name = "label11";
            label11.Size = new Size(183, 15);
            label11.TabIndex = 26;
            label11.Text = "Contacto de Emergencia Familiar";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(493, 188);
            label13.Name = "label13";
            label13.Size = new Size(102, 15);
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
            btnRegresar.Location = new Point(435, 406);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(121, 45);
            btnRegresar.TabIndex = 32;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnAseguradoraP
            // 
            btnAseguradoraP.Location = new Point(630, 265);
            btnAseguradoraP.Name = "btnAseguradoraP";
            btnAseguradoraP.Size = new Size(157, 23);
            btnAseguradoraP.TabIndex = 33;
            btnAseguradoraP.Text = "Aseguradora/Polizas";
            btnAseguradoraP.UseVisualStyleBackColor = true;
            btnAseguradoraP.Click += btnAseguradoraP_Click;
            // 
            // dtFechaNac
            // 
            dtFechaNac.CalendarMonthBackground = Color.FromArgb(255, 253, 231);
            dtFechaNac.CalendarTitleBackColor = Color.FromArgb(255, 253, 231);
            dtFechaNac.Location = new Point(617, 182);
            dtFechaNac.Name = "dtFechaNac";
            dtFechaNac.Size = new Size(222, 23);
            dtFechaNac.TabIndex = 34;
            // 
            // txtDirrec
            // 
            txtDirrec.BackColor = Color.FromArgb(255, 253, 231);
            txtDirrec.Location = new Point(617, 221);
            txtDirrec.Name = "txtDirrec";
            txtDirrec.Size = new Size(222, 23);
            txtDirrec.TabIndex = 35;
            // 
            // cmbAlergias
            // 
            cmbAlergias.BackColor = Color.FromArgb(255, 253, 231);
            cmbAlergias.FormattingEnabled = true;
            cmbAlergias.Items.AddRange(new object[] { "Penicilina", "", "Aspirina (AINEs)", "", "Sulfas", "", "Mariscos", "", "Maní (Cacahuates)", "", "Lácteos", "", "Huevo", "", "Trigo (Gluten)", "", "Polen", "", "Ácaros del polvo", "", "Pelo de gato", "", "Pelo de perro", "", "Picaduras de insectos", "", "Látex", "", "Níquel (Metales)", "", "Otros..." });
            cmbAlergias.Location = new Point(1134, 182);
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
            txtOtrasAlergias.Location = new Point(1190, 216);
            txtOtrasAlergias.Name = "txtOtrasAlergias";
            txtOtrasAlergias.Size = new Size(132, 23);
            txtOtrasAlergias.TabIndex = 38;
            // 
            // lblInstruccionAlergia
            // 
            lblInstruccionAlergia.AutoSize = true;
            lblInstruccionAlergia.Location = new Point(1076, 224);
            lblInstruccionAlergia.Name = "lblInstruccionAlergia";
            lblInstruccionAlergia.Size = new Size(0, 15);
            lblInstruccionAlergia.TabIndex = 39;
            // 
            // Pacientes_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1449, 559);
            Controls.Add(lblInstruccionAlergia);
            Controls.Add(txtOtrasAlergias);
            Controls.Add(label12);
            Controls.Add(cmbAlergias);
            Controls.Add(txtDirrec);
            Controls.Add(dtFechaNac);
            Controls.Add(btnAseguradoraP);
            Controls.Add(btnRegresar);
            Controls.Add(txtDUI);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtContactoF);
            Controls.Add(label8);
            Controls.Add(cmbPais);
            Controls.Add(label7);
            Controls.Add(cmbSexo);
            Controls.Add(txtEdad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pacientes_View";
            Text = "Pacientes";
            Load += Pacientes_View_Load;
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
        private Label label7;
        private ComboBox cmbPais;
        private Label label8;
        private TextBox txtContactoF;
        private Label label9;
        private Label label10;
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
    }
}