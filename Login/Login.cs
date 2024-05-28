using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private List<Vehiculo> vehiculosIngresados = new List<Vehiculo>(); // Declarar e inicializar la lista

        private Dictionary<string, string> usuarios = new Dictionary<string, string>(); // Almacena los usuarios y contrase�as
        private Dictionary<string, string> tipoVehiculoPorPlaca = new Dictionary<string, string>(); // Diccionario para almacenar tipos de veh�culo por placa

        public Login()
        {
            InitializeComponent();

            // Agregar el usuario predefinido (admin, 1234) al diccionario
            usuarios.Add("admin", "1234");

            // Agregar tipos de veh�culo por placa 
            tipoVehiculoPorPlaca.Add("ABC123", "Carro");
            tipoVehiculoPorPlaca.Add("XYZ456", "Moto");
            tipoVehiculoPorPlaca.Add("AAA123", "Camion");
        }

      
        public void btnCrearUsuario_Click_1(object sender, EventArgs e)
        {

            {
                // Abrir un nuevo formulario para crear un usuario

                CrearUsuario formCrearUsuario = new CrearUsuario();
                if (formCrearUsuario.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el nuevo usuario y contrase�a creados
                    string nuevoUsuario = formCrearUsuario.NombreUsuario;
                    string nuevaContrasena = formCrearUsuario.Contrasena;

                    // Agregar el nuevo usuario al diccionario
                    if (!string.IsNullOrEmpty(nuevoUsuario) && !string.IsNullOrEmpty(nuevaContrasena))
                    {
                        usuarios.Add(nuevoUsuario, nuevaContrasena);
                    }
                }
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            // Obtener el nombre de usuario y la contrase�a ingresados por el usuario
            string nombreUsuarioIngresado = txtUsuario.Text;
            string contrasenaIngresada = txtContrasena.Text;

            // Verificar si el nombre de usuario y la contrase�a ingresados son correctos
            if (usuarios.ContainsKey(nombreUsuarioIngresado) && usuarios[nombreUsuarioIngresado] == contrasenaIngresada)
            {
                MessageBox.Show("Inicio de sesi�n exitoso. Bienvenido, " + nombreUsuarioIngresado + "!");

                
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(vehiculosIngresados, tipoVehiculoPorPlaca);
                formMenuPrincipal.Show();

              
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contrase�a incorrectos. Por favor, int�ntelo de nuevo.");
   
            }
        }
    }
}
