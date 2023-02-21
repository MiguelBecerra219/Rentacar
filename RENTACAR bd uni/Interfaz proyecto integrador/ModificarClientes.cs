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
    public partial class ModificarClientes : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarClientes()
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
                OracleCommand comando = new OracleCommand("actualizar_cliente_directo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("idp", OracleType.Int32).Value = txtCodigo.Text;
                comando.Parameters.Add("tar_cred", OracleType.Int32).Value = txtTarjetaCredito.Text;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("dir", OracleType.VarChar).Value = txtDireccion.Text;
                comando.Parameters.Add("tel", OracleType.Int32).Value = txtTelefono.Text;
                comando.Parameters.Add("trato", OracleType.VarChar).Value = txtTrato.Text;
                comando.Parameters.Add("pob", OracleType.VarChar).Value = txtPoblacion.Text;
                comando.Parameters.Add("fax", OracleType.VarChar).Value = txtFax.Text;
                comando.Parameters.Add("dni", OracleType.Int32).Value = txtDni.Text;
                comando.Parameters.Add("car_con", OracleType.VarChar).Value = txtCarnetConducir.Text;
                comando.Parameters.Add("tip_tar", OracleType.VarChar).Value = txtTipoTarjeta.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente modificado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }
    }
}
