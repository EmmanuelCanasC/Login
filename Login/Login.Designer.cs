namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Usuario = new Label();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            btnIniciarSesion = new Button();
            btnCrearUsuario = new Button();
            label6 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // Usuario
            // 
            Usuario.AutoSize = true;
            Usuario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Usuario.Location = new Point(282, 176);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(70, 18);
            Usuario.TabIndex = 0;
            Usuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(282, 233);
            label1.Name = "label1";
            label1.Size = new Size(102, 18);
            label1.TabIndex = 1;
            label1.Text = "Contrasena";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Info;
            txtUsuario.Location = new Point(390, 176);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            txtContrasena.BackColor = SystemColors.Info;
            txtContrasena.Location = new Point(390, 233);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 3;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = SystemColors.GradientActiveCaption;
            btnIniciarSesion.FlatStyle = FlatStyle.Popup;
            btnIniciarSesion.Location = new Point(241, 294);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(114, 23);
            btnIniciarSesion.TabIndex = 4;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.BackColor = SystemColors.GradientActiveCaption;
            btnCrearUsuario.FlatStyle = FlatStyle.Popup;
            btnCrearUsuario.Location = new Point(418, 294);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(114, 23);
            btnCrearUsuario.TabIndex = 5;
            btnCrearUsuario.Text = "Crear Usuario";
            btnCrearUsuario.UseVisualStyleBackColor = false;
            btnCrearUsuario.Click += btnCrearUsuario_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(292, 26);
            label6.Name = "label6";
            label6.Size = new Size(198, 38);
            label6.TabIndex = 14;
            label6.Text = "PARKIANDO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(309, 108);
            label4.Name = "label4";
            label4.Size = new Size(178, 30);
            label4.TabIndex = 15;
            label4.Text = "Iniciar Sesion";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(btnCrearUsuario);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(Usuario);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label Usuario;
        public Label label1;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnIniciarSesion;
        private Button btnCrearUsuario;
        private Label label6;
        private Label label4;
    }
}