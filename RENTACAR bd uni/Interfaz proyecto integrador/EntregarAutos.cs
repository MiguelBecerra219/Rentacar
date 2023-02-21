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
    public partial class EntregarAutos : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public EntregarAutos()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void dtv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("seleccionar_co_ve", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dtv.DataSource = tabla;
            conexion.Close();
        }
    }
}
