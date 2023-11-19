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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        clsArchivos objBase;
        private void RegistroDeEmpleadosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistroEmpleados frmRegistroEmpleados = new frmRegistroEmpleados();
            frmRegistroEmpleados.Show();
        }

        private void ListadoEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListadoEmpleados frmListadoEmpleados = new frmListadoEmpleados();
            frmListadoEmpleados.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            objBase = new clsArchivos();
            objBase.ConectarBD();

            lblEstado.Text = objBase.estadoConexion.ToString();
        }
    }
}
