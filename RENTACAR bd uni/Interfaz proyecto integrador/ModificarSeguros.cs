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
    public partial class ModificarSeguros : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarSeguros()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizar_tarifa_seguro", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Int32).Value = txtId.Text;
                comando.Parameters.Add("GRUPOp", OracleType.VarChar).Value = txtGrupo.Text;
                comando.Parameters.Add("TARIFA_FURGONETAp", OracleType.Int32).Value = txtTF.Text;
                comando.Parameters.Add("TARIFA_TURISMOp", OracleType.Int32).Value = txtTT.Text;
                comando.Parameters.Add("ID_CIA_SEGUROp", OracleType.Int32).Value = txtIDCia.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Segudo modificado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }
    }
}
