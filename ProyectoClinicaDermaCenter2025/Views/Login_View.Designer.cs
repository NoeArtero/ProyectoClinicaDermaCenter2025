namespace ProyectoClinicaDermaCenter2025.Views
{
    partial class Login_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_View));
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            lblUsuario = new Label();
            btnCancelar = new Button();
            label2 = new Label();
            txtClave = new TextBox();
            cmbUsuario = new ComboBox();
            errorLogin = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorLogin).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.Imagen_de_WhatsApp_2025_08_31_a_las_18_50_06_feeb8cd3;
            pictureBox1.Location = new Point(248, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 169);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(15, 23, 42);
            btnIngresar.ForeColor = SystemColors.ButtonHighlight;
            btnIngresar.Location = new Point(202, 339);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(173, 42);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(248, 215);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(15, 23, 42);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(381, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(173, 42);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 277);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(308, 274);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '•';
            txtClave.Size = new Size(230, 23);
            txtClave.TabIndex = 2;
            // 
            // cmbUsuario
            // 
            cmbUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuario.FormattingEnabled = true;
            cmbUsuario.Location = new Point(308, 212);
            cmbUsuario.Name = "cmbUsuario";
            cmbUsuario.Size = new Size(230, 23);
            cmbUsuario.TabIndex = 1;
            // 
            // errorLogin
            // 
            errorLogin.ContainerControl = this;
            // 
            // Login_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbUsuario);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(btnCancelar);
            Controls.Add(lblUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_View";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login: DermaCenter";
            Load += Login_View_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnIngresar;
        private Label lblUsuario;
        private Button btnCancelar;
        private Label label2;
        private TextBox txtClave;
        private ComboBox cmbUsuario;
        private ErrorProvider errorLogin;
    }
}