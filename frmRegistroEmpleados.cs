using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLedoTP
{
    public partial class frmRegistroEmpleados : Form
    {
        public frmRegistroEmpleados()
        {
            InitializeComponent();
        }

        clsArchivos grabar = new clsArchivos();


        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            string[] datosEmpleado = new string[] { txtNombre.Text, txtApellido.Text, dtpFechaNacimiento.Value.Date.ToString("dd-MM-yyyy"), txtDireccion.Text, txtCiudad.Text, txtNumero.Text };
            string datosConcatenados = string.Join(";", datosEmpleado);
            grabar.Grabar(datosConcatenados);

            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtCiudad.Clear();
            txtNumero.Clear();
            MessageBox.Show("Empleado cargado correctamente");

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();

        }
    }
}
