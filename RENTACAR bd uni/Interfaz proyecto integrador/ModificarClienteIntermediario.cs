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
    public partial class ModificarClienteIntermediario : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarClienteIntermediario()
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
                OracleCommand comando = new OracleCommand("actualizar_cliente_agencia", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Int32).Value = txtCodigo.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("dir", OracleType.VarChar).Value = txtDireccion.Text;
                comando.Parameters.Add("pob", OracleType.VarChar).Value = txtPoblacion.Text;
                comando.Parameters.Add("nif", OracleType.Int32).Value = txtNif.Text;
                comando.Parameters.Add("comision", OracleType.Int32).Value = txtComision.Text;
                comando.Parameters.Add("per_con", OracleType.VarChar).Value = txtContactoPersona.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente intermediario actualizado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }
    }
}
