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
    public partial class CrearSeguros : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public CrearSeguros()
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
                OracleCommand comando = new OracleCommand("insertar_tarifa_seguro", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("grupo", OracleType.VarChar).Value = txtGrupo.Text;
                comando.Parameters.Add("tar_furg", OracleType.Int32).Value = txtTF.Text;
                comando.Parameters.Add("tar_tur", OracleType.Int32).Value = txtTT.Text;
                comando.Parameters.Add("id_cia_seguro", OracleType.Int32).Value = txtIDCia.Text;

                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente creado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }
    }
}
