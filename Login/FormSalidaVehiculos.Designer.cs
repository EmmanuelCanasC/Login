namespace Login
{
    partial class FormSalidaVehiculos
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
            label3 = new Label();
            txtPlaca = new TextBox();
            txtHoraSalida = new TextBox();
            btnGenerarColill = new Button();
            btnMenuPrincipal = new Button();
            label6 = new Label();
            lblTipoVehiculo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(201, 110);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 19;
            label1.Text = "Tipo De Vehiculo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(201, 190);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 20;
            label2.Text = "Placa del vehiculo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(201, 255);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 21;
            label3.Text = "Hora De Salida";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = SystemColors.Info;
            txtPlaca.Location = new Point(442, 185);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 23);
            txtPlaca.TabIndex = 23;
            // 
            // txtHoraSalida
            // 
            txtHoraSalida.BackColor = SystemColors.Info;
            txtHoraSalida.Location = new Point(442, 255);
            txtHoraSalida.Name = "txtHoraSalida";
            txtHoraSalida.Size = new Size(121, 23);
            txtHoraSalida.TabIndex = 24;
            // 
            // btnGenerarColill
            // 
            btnGenerarColill.BackColor = SystemColors.GradientActiveCaption;
            btnGenerarColill.FlatStyle = FlatStyle.Popup;
            btnGenerarColill.Location = new Point(201, 335);
            btnGenerarColill.Name = "btnGenerarColill";
            btnGenerarColill.Size = new Size(126, 33);
            btnGenerarColill.TabIndex = 25;
            btnGenerarColill.Text = "Generar Colilla";
            btnGenerarColill.UseVisualStyleBackColor = false;
            btnGenerarColill.Click += btnGenerarColill_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = SystemColors.GradientActiveCaption;
            btnMenuPrincipal.FlatStyle = FlatStyle.Popup;
            btnMenuPrincipal.Location = new Point(442, 335);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(121, 33);
            btnMenuPrincipal.TabIndex = 26;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(294, 28);
            label6.Name = "label6";
            label6.Size = new Size(198, 38);
            label6.TabIndex = 27;
            label6.Text = "PARKIANDO";
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipoVehiculo.Location = new Point(422, 110);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(141, 18);
            lblTipoVehiculo.TabIndex = 28;
            lblTipoVehiculo.Text = "Tipo De Vehiculo";
            // 
            // FormSalidaVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(label6);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(btnGenerarColill);
            Controls.Add(txtHoraSalida);
            Controls.Add(txtPlaca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormSalidaVehiculos";
            Text = "FormSalidaVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPlaca;
        private TextBox txtHoraSalida;
        private Button btnGenerarColill;
        private Button btnMenuPrincipal;
        private Label label6;
        private Label lblTipoVehiculo;
    }
}