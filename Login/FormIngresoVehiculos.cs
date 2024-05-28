using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class FormIngresoVehiculos : Form
    {
        // Lista para almacenar los detalles de los vehículos ingresados
        private List<Vehiculo> vehiculosIngresados = new List<Vehiculo>();
        private Dictionary<string, string> tipoVehiculoPorPlaca;

        public FormIngresoVehiculos(Dictionary<string, string> tipoVehiculoPorPlaca)
        {
            InitializeComponent();
            cmbTipoVehiculo.Items.AddRange(new string[] { "Camion", "Carro", "Moto" });

            // Mostrar la hora actual en el TextBox de hora de entrada
            txtHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
            // Hacer que el TextBox sea no editable
            txtHoraEntrada.ReadOnly = true;
            // Cambiar el color de fondo del TextBox para indicar que no es editable (opcional)
            txtHoraEntrada.BackColor = SystemColors.Control;

            // Asignar el diccionario tipoVehiculoPorPlaca
            this.tipoVehiculoPorPlaca = tipoVehiculoPorPlaca;

        }

     
    


    private void LimpiarCampos_()
        {
            // Limpiar los campos de texto y restablecer los ComboBox
            cmbTipoVehiculo.SelectedIndex = -1;
            txtPlaca.Clear();

            // Mostrar la hora actual en el TextBox de hora de entrada
            txtHoraEntrada.Text = DateTime.Now.ToString("HH:mm");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Obtener los datos del vehículo ingresados por el usuario
            string tipoVehiculo = cmbTipoVehiculo.SelectedItem?.ToString();
            string placa = txtPlaca.Text;
            string horaEntrada = txtHoraEntrada.Text; // Utilizar la hora actual mostrada en el TextBox

            // Crear un objeto Vehiculo con los datos ingresados
            Vehiculo nuevoVehiculo = new Vehiculo(tipoVehiculo, placa, horaEntrada);

            // Agregar el nuevo vehículo a la lista de vehículos ingresados
            vehiculosIngresados.Add(nuevoVehiculo);

            // Mostrar un mensaje de confirmación
            string mensaje = $"Vehículo ingresado:\n" +
                             $"Tipo de vehículo: {tipoVehiculo}\n" +
                             $"Placa: {placa}\n" +
                             $"Hora de entrada: {horaEntrada}\n";
            MessageBox.Show(mensaje);

            // Limpiar los campos después de guardar los datos
            LimpiarCampos_();
        }

        private void LimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos_();
        }

     

        // Método para obtener la lista de vehículos ingresados
        public List<Vehiculo> ObtenerVehiculosIngresados()
        {
            return vehiculosIngresados;
        }

        private void btnMenuPrincipal_Click_1(object sender, EventArgs e)
        {
            // Crear una instancia de FormMenuPrincipal y pasar la lista de vehículos ingresados y el diccionario de tipos de vehículo por placa
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(vehiculosIngresados, tipoVehiculoPorPlaca);
            formMenuPrincipal.Show();
            // Opcionalmente, puedes ocultar este formulario si lo deseas
            this.Hide();
        }
    }

    // Clase para representar un vehículo
    public class Vehiculo
    {
        public string Tipo { get; set; }
        public string Placa { get; set; }
        public string HoraEntrada { get; set; }

        public Vehiculo(string tipo, string placa, string horaEntrada)
        {
            Tipo = tipo;
            Placa = placa;
            HoraEntrada = horaEntrada;
        }
    }
}
