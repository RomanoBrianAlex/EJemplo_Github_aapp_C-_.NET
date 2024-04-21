using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_2_ejercicioFormulario
{
    public partial class frDatosPersonales : Form
    {
        /*Al presionar el botón aceptar se debe validar que los text Apellido, Nombre, Edad y
         * Dirección tengan datos, en caso de estar vacíos marcarlos de color rojo.
         * Si pasa la validación los datos se deben escribir en el text de resultado (TextBox 
         * multilínea) con el siguiente formato:
         * 
         * Apellido y Nombre: XXXXXXXXXXXXXXX
         * Edad: XXX
         * Dirección: XXXXXXXXXXXXXXXXXXXXX
         * 
         * En el campo Edad solo debe aceptar Números.
         * En todos los campos limitar la cantidad de caracteres y pasarlos a mayúsculas.
         * Al presionar el botón Cancelar se debe cerrar la aplicación.         
         */
        public frDatosPersonales()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtApellido.Text == "" && txtDNI.Text == "" && txtDirección.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                txtApellido.BackColor = Color.Red;
                txtDNI.BackColor = Color.Red;
                txtDirección.BackColor = Color.Red;
            }
            else if (txtNombre.Text != "" && txtApellido.Text != "" && txtDNI.Text != "" && txtDirección.Text != "")
                {
                //Creamos la varibles para guardar los datos
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string DNI = txtDNI.Text;
                string Dirreccion = txtDirección.Text;

                //Armamos el mensaje
                string Mensaje = "Nombre: " + nombre + "\nApellido: " + apellido +  "\nDNI: " + DNI + "\nDirección: " + Dirreccion;

                //Le mandamos el mensaje armado al textbox multiline.
                txtResultado.Text = Mensaje;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8) e.Handled = true;
        }
    }
}
