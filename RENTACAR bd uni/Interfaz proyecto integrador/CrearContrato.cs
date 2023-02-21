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
    public partial class CrearContrato : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public CrearContrato()
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
                OracleCommand comando = new OracleCommand("insertar_contrato", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("sub_alq", OracleType.Int32).Value = txtSubTotAlq.Text;
                comando.Parameters.Add("can_ren", OracleType.Int32).Value = txtCantRentVehi.Text;
                comando.Parameters.Add("fec", OracleType.DateTime).Value = txtFecha.Text;
                comando.Parameters.Add("tot_imp", OracleType.Int32).Value = txtTotImport.Text;
                comando.Parameters.Add("iva", OracleType.Int32).Value = txtIVA.Text;
                comando.Parameters.Add("fech_ent", OracleType.DateTime).Value = txtFechaEnt.Text;
                comando.Parameters.Add("sub_tot_com", OracleType.VarChar).Value = txtSUBTOTCOMP.Text;
                comando.Parameters.Add("val_ext", OracleType.Int32).Value = txtValDiasExtras.Text;
                comando.Parameters.Add("val_dia_veh", OracleType.Int32).Value = txtvalvehi.Text;
                comando.Parameters.Add("combustible", OracleType.Int32).Value = txtCombustible.Text;
                comando.Parameters.Add("can_dia_ext", OracleType.Int32).Value = txtDiasDExtras.Text=="" ? (object)DBNull.Value : txtDiasDExtras.Text;
                comando.Parameters.Add("descuento", OracleType.Int32).Value = txtDescuento.Text=="" ? (object)DBNull.Value : txtDescuento.Text;
                comando.Parameters.Add("sucursal", OracleType.VarChar).Value = txtSucursal.Text;
                comando.Parameters.Add("hora", OracleType.Int32).Value = txtHora.Text;
                comando.Parameters.Add("cod_cli_dir", OracleType.Int32).Value = txtCliente.Text=="" ? (object)DBNull.Value : txtCliente.Text;
                comando.Parameters.Add("cod_cli_age", OracleType.Int32).Value= txtCodigoIntermediario.Text == "" ? (object)DBNull.Value : txtCodigoIntermediario.Text;
                comando.Parameters.Add("mat_veh", OracleType.VarChar).Value = txtMatricula.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Contrato creado correctamente.");
                
                txtMatricula.ResetText();
                txtCliente.ResetText();
                txtCodigocliente.ResetText();
                txtCantRentVehi.ResetText();
                txtCombustible.ResetText();
                txtDescuento.ResetText();
                txtCodigoIntermediario.ResetText();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Algo ha fallado."+ex);
            }
            conexion.Close();
        }

        private void txtNoContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubTotAlq_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void txtCantRentVehi_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaEnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtIVA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotImport_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtCombustible_TextChanged(object sender, EventArgs e)
        {

        }

        private void CrearContrato_Load(object sender, EventArgs e)
        {

        }

        private void txtSUBTOTCOMP_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel15_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel20_Click(object sender, EventArgs e)
        {

        }

        private void txtDiasDExtras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel17_Click(object sender, EventArgs e)
        {

        }

        private void txtHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel16_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigocliente_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
