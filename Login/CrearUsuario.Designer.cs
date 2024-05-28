namespace Login
{
    partial class CrearUsuario
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
            txtNuevoUsuario = new TextBox();
            txtNuevaContrasena = new TextBox();
            btnCrear = new Button();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(226, 178);
            label1.Name = "label1";
            label1.Size = new Size(163, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre De Usuario";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(278, 239);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 1;
            label2.Text = "Contrasena";
            // 
            // txtNuevoUsuario
            // 
            txtNuevoUsuario.BackColor = SystemColors.Info;
            txtNuevoUsuario.Location = new Point(395, 178);
            txtNuevoUsuario.Name = "txtNuevoUsuario";
            txtNuevoUsuario.Size = new Size(113, 23);
            txtNuevoUsuario.TabIndex = 2;
            // 
            // txtNuevaContrasena
            // 
            txtNuevaContrasena.BackColor = SystemColors.Info;
            txtNuevaContrasena.Location = new Point(395, 236);
            txtNuevaContrasena.Name = "txtNuevaContrasena";
            txtNuevaContrasena.Size = new Size(113, 23);
            txtNuevaContrasena.TabIndex = 3;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.GradientActiveCaption;
            btnCrear.FlatStyle = FlatStyle.Popup;
            btnCrear.Location = new Point(358, 299);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 23);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(310, 110);
            label4.Name = "label4";
            label4.Size = new Size(181, 30);
            label4.TabIndex = 6;
            label4.Text = "Crear Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(293, 9);
            label3.Name = "label3";
            label3.Size = new Size(198, 38);
            label3.TabIndex = 5;
            label3.Text = "PARKIANDO";
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCrear);
            Controls.Add(txtNuevaContrasena);
            Controls.Add(txtNuevoUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CrearUsuario";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtNuevoUsuario;
        private TextBox txtNuevaContrasena;
        private Button btnCrear;
        private Label label4;
        private Label label3;
    }
}