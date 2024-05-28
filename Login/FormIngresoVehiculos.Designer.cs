namespace Login
{
    partial class FormIngresoVehiculos
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
            label2 = new Label();
            txtPlaca = new TextBox();
            label3 = new Label();
            Guardar = new Button();
            LimpiarCampos = new Button();
            label6 = new Label();
            label1 = new Label();
            cmbTipoVehiculo = new ComboBox();
            txtHoraEntrada = new TextBox();
            btnMenuPrincipal = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(200, 176);
            label2.Name = "label2";
            label2.Size = new Size(152, 18);
            label2.TabIndex = 2;
            label2.Text = "Placa del vehiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.BackColor = SystemColors.Info;
            txtPlaca.Location = new Point(369, 176);
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 23);
            txtPlaca.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(200, 237);
            label3.Name = "label3";
            label3.Size = new Size(141, 18);
            label3.TabIndex = 5;
            label3.Text = "Hora De Entrada";
            // 
            // Guardar
            // 
            Guardar.BackColor = SystemColors.GradientActiveCaption;
            Guardar.FlatStyle = FlatStyle.Popup;
            Guardar.Location = new Point(200, 333);
            Guardar.Name = "Guardar";
            Guardar.Size = new Size(111, 23);
            Guardar.TabIndex = 8;
            Guardar.Text = "Guardar";
            Guardar.UseVisualStyleBackColor = false;
            Guardar.Click += button1_Click;
            // 
            // LimpiarCampos
            // 
            LimpiarCampos.BackColor = SystemColors.GradientActiveCaption;
            LimpiarCampos.FlatStyle = FlatStyle.Popup;
            LimpiarCampos.Location = new Point(505, 333);
            LimpiarCampos.Name = "LimpiarCampos";
            LimpiarCampos.Size = new Size(115, 23);
            LimpiarCampos.TabIndex = 9;
            LimpiarCampos.Text = "Limpiar Campos";
            LimpiarCampos.UseVisualStyleBackColor = false;
            LimpiarCampos.Click += LimpiarCampos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Britannic Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(292, 35);
            label6.Name = "label6";
            label6.Size = new Size(198, 38);
            label6.TabIndex = 13;
            label6.Text = "PARKIANDO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(200, 115);
            label1.Name = "label1";
            label1.Size = new Size(141, 18);
            label1.TabIndex = 18;
            label1.Text = "Tipo De Vehiculo";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.BackColor = SystemColors.Info;
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(369, 112);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 19;
            // 
            // txtHoraEntrada
            // 
            txtHoraEntrada.BackColor = SystemColors.Info;
            txtHoraEntrada.Location = new Point(369, 232);
            txtHoraEntrada.Name = "txtHoraEntrada";
            txtHoraEntrada.Size = new Size(121, 23);
            txtHoraEntrada.TabIndex = 20;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = SystemColors.GradientActiveCaption;
            btnMenuPrincipal.FlatStyle = FlatStyle.Popup;
            btnMenuPrincipal.Location = new Point(340, 391);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(129, 23);
            btnMenuPrincipal.TabIndex = 21;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click_1;
            // 
            // FormIngresoVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(txtHoraEntrada);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(LimpiarCampos);
            Controls.Add(Guardar);
            Controls.Add(label3);
            Controls.Add(txtPlaca);
            Controls.Add(label2);
            Name = "FormIngresoVehiculos";
            Text = "FormIngresoVehiculos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtPlaca;
        private Label label3;
        private Button Guardar;
        private Button LimpiarCampos;
        private Label label6;
        private Label label1;
        private ComboBox cmbTipoVehiculo;
        private TextBox txtHoraEntrada;
        private Button btnMenuPrincipal;
    }
}