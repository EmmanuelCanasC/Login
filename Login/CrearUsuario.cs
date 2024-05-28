using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class CrearUsuario : Form
    {
        public string NombreUsuario { get; private set; }
        public string Contrasena { get; private set; }

        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            NombreUsuario = txtNuevoUsuario.Text;
            Contrasena = txtNuevaContrasena.Text;

            // Establecer el resultado del diálogo como OK y cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
