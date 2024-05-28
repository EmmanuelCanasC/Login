using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Login; // O el espacio de nombres adecuado donde está definida Vehiculo


namespace Login
{
    public partial class FormMenuPrincipal : Form
    {
        private List<Vehiculo> vehiculosIngresados;
        private Dictionary<string, string> tipoVehiculoPorPlaca = new Dictionary<string, string>();

        public FormMenuPrincipal(List<Vehiculo> vehiculos, Dictionary<string, string> tipos)
        {
            InitializeComponent();
            vehiculosIngresados = vehiculos;
            tipoVehiculoPorPlaca = tipos;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Mostrar el formulario de inicio de sesión
            Login formLogin = new Login();
            formLogin.Show();
            // Cerrar este formulario
            this.Close();
        }

        private void btnIngresarVehiculo_Click_1(object sender, EventArgs e)
        {
            // Crear el formulario de ingreso de vehículos y pasar tipoVehiculoPorPlaca al constructor
            FormIngresoVehiculos formIngresoVehiculos = new FormIngresoVehiculos(tipoVehiculoPorPlaca);
            formIngresoVehiculos.Show();
            // Opcionalmente, puedes ocultar este formulario si lo deseas
            this.Hide();
        }

        private void btnSalidaVehiculo_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de FormSalidaVehiculos y pasar la lista de vehículos ingresados y el diccionario de tipos de vehículo por placa
            FormSalidaVehiculos formSalidaVehiculos = new FormSalidaVehiculos(vehiculosIngresados, tipoVehiculoPorPlaca);
            formSalidaVehiculos.Show();
            // Opcionalmente, puedes ocultar este formulario si lo deseas
            this.Hide();
        }

    }
}
