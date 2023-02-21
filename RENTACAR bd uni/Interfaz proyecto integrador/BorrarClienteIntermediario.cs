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
    public partial class BorrarClienteIntermediario : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");

        public BorrarClienteIntermediario()
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
                OracleCommand comando = new OracleCommand("eliminar_cliente_intermediario", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Number).Value = Convert.ToInt64(txtCodigo.Text);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente intermediario eliminado correctamente.");
            }
            catch
            {
                MessageBox.Show("El codigo no esta registrado");
            }

            conexion.Close();
        }
    }
}
