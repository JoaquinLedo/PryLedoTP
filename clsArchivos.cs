using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;

namespace PryLedoTP
{
    internal class clsArchivos
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD; //indica que quiero traer de las tablas
        OleDbDataReader lectorBD; //carga info para desp leer

        public string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ..\\..\\Resources\\EMPLEADO.accdb";

        public string estadoConexion = "";

        public string datosTabla = "";
        
        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = Convert.ToString(DateTime.Now);
            }
            catch (Exception ex)
            {

                estadoConexion = "Error: " + ex.Message;
            }

        }

        public void TraerDatos(DataGridView grilla)
        {
            comandoBD = new OleDbCommand();

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = System.Data.CommandType.TableDirect;  //q tipo de operacion quierp hacer y que me traiga TOD la tabla con el tabledirect
            comandoBD.CommandText = "DATOS PERSONALES";

            lectorBD = comandoBD.ExecuteReader();

            grilla.Columns.Add("Nombre", "Nombre");
            grilla.Columns.Add("Apellido", "Apellido");
            grilla.Columns.Add("direccion", "direccion");
            grilla.Columns.Add("ciudad", "ciudad");
            grilla.Columns.Add("telefono", "telefono");
            grilla.Columns.Add("Ingreso", "Ingreso");


            if (lectorBD.HasRows)
            {
                while (lectorBD.Read())
                {
                    datosTabla += "-" + lectorBD[0];
                    grilla.Rows.Add(lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[5], lectorBD[6]);
                }
            }


        }

    }
}
