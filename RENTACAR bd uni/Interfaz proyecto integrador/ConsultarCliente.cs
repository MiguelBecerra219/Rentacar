using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Interfaz_proyecto_integrador
{
    public partial class ConsultarCliente : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {

            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionarClienteDirecto", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            comando.Parameters.Add("pnombre", OracleType.VarChar).Value = txtNombre.Text;

            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtv.DataSource = tabla;

            conexion.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
