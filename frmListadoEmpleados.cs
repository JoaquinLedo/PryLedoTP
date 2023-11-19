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
    public partial class frmListadoEmpleados : Form
    {
        public frmListadoEmpleados()
        {
            InitializeComponent();
        }

        clsArchivos objBaseDatos;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarApellido(txtBuscarApellido.Text, dgvGrilla);
        }

        private void btnBuscar1_Click(object sender, EventArgs e)
        {
            objBaseDatos.BuscarCiudad(txtCiu.Text, dgvGrilla);
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
        }

        private void frmListadoEmpleados_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsArchivos();
            objBaseDatos.ConectarBD();
            objBaseDatos.TraerDatos(dgvGrilla);
        }

        public void TraerDatos(DataGridView grilla)
        {

        }
    }
}
