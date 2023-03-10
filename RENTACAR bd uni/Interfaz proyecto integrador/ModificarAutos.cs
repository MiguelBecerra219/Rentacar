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
    public partial class ModificarAutos : Form
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        public ModificarAutos()
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
                OracleCommand comando = new OracleCommand("actualizar_vehiculo", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("MATRICULAp", OracleType.VarChar).Value = txtMatricula.Text;
                comando.Parameters.Add("CLASEp", OracleType.VarChar).Value = txtClase.Text;
                comando.Parameters.Add("MARCAp", OracleType.VarChar).Value = txtMarca.Text;
                comando.Parameters.Add("KILOMETRAJEp", OracleType.Int32).Value = txtKilometraje.Text;
                comando.Parameters.Add("GRUPOp", OracleType.VarChar).Value = txtGrupo.Text;
                comando.Parameters.Add("MODELOp", OracleType.VarChar).Value = txtModelo.Text;
                comando.Parameters.Add("FECHA_DE_COMPRAp", OracleType.DateTime).Value = txtFechaCompra.Text;
                comando.Parameters.Add("ID_TARIFA_SEGUROp", OracleType.Int32).Value = txtIdSeguro.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Vehiculo modificado correctamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Algo ha fallado.");
            }
        }
    }
}
