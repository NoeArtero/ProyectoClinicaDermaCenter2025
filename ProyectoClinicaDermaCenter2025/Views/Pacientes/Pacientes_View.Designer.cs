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
            txtDocumento = new TextBox();
            txtFiltro = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
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
            // txtDocumento
            // 
            txtDocumento.BackColor = Color.FromArgb(255, 253, 231);
            txtDocumento.Location = new Point(217, 226);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new Size(222, 23);
            txtDocumento.TabIndex = 2;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.FromArgb(255, 253, 231);
            txtFiltro.Location = new Point(217, 185);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(222, 23);
            txtFiltro.TabIndex = 3;
            txtFiltro.Tag = "";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(380, 382);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(961, 457);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 253, 231);
            textBox1.Location = new Point(961, 147);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(54, 23);
            textBox1.TabIndex = 16;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 253, 231);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "M", "F" });
            comboBox1.Location = new Point(961, 185);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(54, 23);
            comboBox1.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1100, 150);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 18;
            label7.Text = "Pais";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(255, 253, 231);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1158, 148);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(93, 23);
            comboBox2.TabIndex = 19;
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
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 253, 231);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(700, 147);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 21;
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
            label10.Location = new Point(1100, 190);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 23;
            label10.Text = "Alergias ";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(255, 253, 231);
            textBox3.Location = new Point(583, 226);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 23);
            textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(255, 253, 231);
            textBox4.Location = new Point(617, 185);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(222, 23);
            textBox4.TabIndex = 25;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1100, 224);
            label12.Name = "label12";
            label12.Size = new Size(127, 15);
            label12.TabIndex = 27;
            label12.Text = "Antecedentes Medicos";
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
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(255, 253, 231);
            textBox5.Location = new Point(961, 221);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(81, 23);
            textBox5.TabIndex = 29;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(255, 253, 231);
            textBox6.Location = new Point(1158, 185);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(288, 23);
            textBox6.TabIndex = 30;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(255, 253, 231);
            textBox7.Location = new Point(1245, 221);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(201, 23);
            textBox7.TabIndex = 31;
            // 
            // Pacientes_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1483, 637);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(comboBox2);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtFiltro);
            Controls.Add(txtDocumento);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Pacientes_View";
            Text = "Pacientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtDocumento;
        private TextBox txtFiltro;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private TextBox textBox2;
        private Label label9;
        private Label label10;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}