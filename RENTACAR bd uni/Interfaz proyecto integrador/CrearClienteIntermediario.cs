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
    public partial class CrearClienteIntermediario : Form
    {
        
        public CrearClienteIntermediario()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuGradientPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        private void crearAutoBoton_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertar_cliente_agencia", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;  
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNombre.Text;
                comando.Parameters.Add("dir", OracleType.VarChar).Value = txtDireccion.Text;
                comando.Parameters.Add("pob", OracleType.VarChar).Value = txtPoblacion.Text;
                comando.Parameters.Add("nif", OracleType.Int32).Value = txtNif.Text;
                comando.Parameters.Add("comision", OracleType.Int32).Value = txtComision.Text;
                comando.Parameters.Add("per_con", OracleType.VarChar).Value = txtContactoPersona.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente intermediario creado correctamente.");
            }
            catch(Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactoPersona_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPoblacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
