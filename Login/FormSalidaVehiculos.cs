using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class FormSalidaVehiculos : Form
    {
        private List<Vehiculo> vehiculosIngresados;
        private Dictionary<string, string> tipoVehiculoPorPlaca;

        public FormSalidaVehiculos(List<Vehiculo> vehiculos, Dictionary<string, string> tipos)
        {
            InitializeComponent();
            
            vehiculosIngresados = vehiculos;
            tipoVehiculoPorPlaca = tipos;
            txtHoraSalida.Text = DateTime.Now.ToString("HH:mm");
            // Hacer que el campo de texto sea de solo lectura
            txtHoraSalida.ReadOnly = true;
            // Cambiar el color de fondo del campo de texto (opcional)
            txtHoraSalida.BackColor = SystemColors.Control;
          
        }

        private void btnGenerarColill_Click(object sender, EventArgs e)
        {
            // Verificar si los objetos están inicializados
            if (tipoVehiculoPorPlaca != null && txtPlaca != null && lblTipoVehiculo != null)
            {
                // Obtener la placa del vehículo ingresada por el usuario
                string placa = txtPlaca.Text;

                // Verificar si la placa existe en el diccionario de tipos de vehículo por placa
                if (tipoVehiculoPorPlaca.ContainsKey(placa))
                {
                    // Obtener el tipo de vehículo asociado a la placa
                    string tipoVehiculo = tipoVehiculoPorPlaca[placa];


                    // Mostrar el tipo de vehículo en el formulario
                    lblTipoVehiculo.Text = $"Tipo de vehículo: {tipoVehiculo}";

                    // Aquí va tu lógica para generar la colilla...
                }
                else
                {
                    MessageBox.Show("La placa ingresada no está asociada a ningún vehículo.");
                }
            }
            else
            {
                MessageBox.Show("Algunos de los elementos no están inicializados correctamente.");
            }

           
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(vehiculosIngresados, tipoVehiculoPorPlaca);
            formMenuPrincipal.Show();
            this.Hide();
        }
    }
}
