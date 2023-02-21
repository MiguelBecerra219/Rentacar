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
    public partial class ModificarCompaniaSeguros : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarCompaniaSeguros()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void crearAutoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("actualizar_cia_seguro", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Int32).Value = txtId.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("inc", OracleType.DateTime).Value = txtFechaInicio.Text;
                comando.Parameters.Add("fin", OracleType.DateTime).Value = txtFechaFin.Text;
                comando.Parameters.Add("presio", OracleType.Int32).Value = txtPrecio.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Compañia de seguros modificada correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }
    }
}
