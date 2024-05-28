namespace Login
{
    partial class FormMenuPrincipal
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
            label3 = new Label();
            btnIngresarVehiculo = new Button();
            btnSalidaVehiculo = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 75);
            label3.Name = "label3";
            label3.Size = new Size(198, 38);
            label3.TabIndex = 6;
            label3.Text = "PARKIANDO";
            // 
            // btnIngresarVehiculo
            // 
            btnIngresarVehiculo.BackColor = SystemColors.GradientActiveCaption;
            btnIngresarVehiculo.FlatStyle = FlatStyle.Popup;
            btnIngresarVehiculo.Location = new Point(149, 254);
            btnIngresarVehiculo.Name = "btnIngresarVehiculo";
            btnIngresarVehiculo.Size = new Size(178, 35);
            btnIngresarVehiculo.TabIndex = 9;
            btnIngresarVehiculo.Text = "INGRESO DE VEHICULOS";
            btnIngresarVehiculo.UseVisualStyleBackColor = false;
            btnIngresarVehiculo.Click += btnIngresarVehiculo_Click_1;
            // 
            // btnSalidaVehiculo
            // 
            btnSalidaVehiculo.BackColor = SystemColors.GradientActiveCaption;
            btnSalidaVehiculo.FlatStyle = FlatStyle.Popup;
            btnSalidaVehiculo.Location = new Point(456, 254);
            btnSalidaVehiculo.Name = "btnSalidaVehiculo";
            btnSalidaVehiculo.Size = new Size(171, 35);
            btnSalidaVehiculo.TabIndex = 10;
            btnSalidaVehiculo.Text = "SalidaVehiculo";
            btnSalidaVehiculo.UseVisualStyleBackColor = false;
            btnSalidaVehiculo.Click += btnSalidaVehiculo_Click_1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = SystemColors.GradientActiveCaption;
            btnCerrarSesion.FlatStyle = FlatStyle.Popup;
            btnCerrarSesion.Location = new Point(306, 347);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(178, 35);
            btnCerrarSesion.TabIndex = 11;
            btnCerrarSesion.Text = "CERRAR SESION";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += button1_Click;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnSalidaVehiculo);
            Controls.Add(btnIngresarVehiculo);
            Controls.Add(label3);
            Name = "FormMenuPrincipal";
            Text = "FormMenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnIngresarVehiculo;
        private Button btnSalidaVehiculo;
        private Button btnCerrarSesion;
    }
}