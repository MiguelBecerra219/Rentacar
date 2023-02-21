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
    
    public partial class ModificarContrato : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarContrato()
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
                OracleCommand comando = new OracleCommand("actualizar_contrato", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NO_DE_CONTRATOp", OracleType.Int32).Value = txtNoContrato.Text;
                comando.Parameters.Add("SUBTOTAL_ALQUILERp", OracleType.Int32).Value = txtSubTotAlq.Text;
                comando.Parameters.Add("CANTIDAD__RENTA__VEHICULOp", OracleType.Int32).Value = txtCantRentVehi.Text;
                comando.Parameters.Add("FECHAp", OracleType.DateTime).Value = txtFecha.Text;
                comando.Parameters.Add("TOTAL_IMPORTEp", OracleType.Int32).Value = txtTotImport.Text;
                comando.Parameters.Add("IVAp", OracleType.Int32).Value = txtIVA.Text;
                comando.Parameters.Add("FECHA_DE_ENTREGAp", OracleType.DateTime).Value = txtFechaEnt.Text;
                comando.Parameters.Add("SUBTOTAL_COMPLEMENTOSp", OracleType.VarChar).Value = txtSUBTOTCOMP.Text;
                comando.Parameters.Add("VALOR_POR_DIA_DE_EXTRASp", OracleType.Int32).Value = txtValDiasExtras.Text;
                comando.Parameters.Add("VALOR_POR_DIA_DEL_VEHICULOp", OracleType.Int32).Value = txtvalvehi.Text;
                comando.Parameters.Add("COMBUSTIBLEp", OracleType.Int32).Value = txtCombustible.Text;
                comando.Parameters.Add("CANTIDAD_DE_DIAS_DE_EXTRASp", OracleType.Int32).Value = txtDiasDExtras.Text;
                comando.Parameters.Add("DESCUENTOp", OracleType.Int32).Value = txtDescuento.Text;
                comando.Parameters.Add("SUCURSALp", OracleType.VarChar).Value = txtSucursal.Text;
                comando.Parameters.Add("HORAp", OracleType.Int32).Value = txtHora.Text;
                comando.Parameters.Add("CODIGO_CLIENTE_DIRECTOp", OracleType.Int32).Value = txtCliente.Text;
                comando.Parameters.Add("CODIGO_CLIENTE_AGENCIAp", OracleType.Int32).Value = txtCodigoIntermediario.Text;
                comando.Parameters.Add("MATRICULA_VEHICULOp", OracleType.VarChar).Value = txtMatricula.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Contrato modificado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
            conexion.Close();
        }

        private void ModificarContrato_Load(object sender, EventArgs e)
        {

        }
    }
}
