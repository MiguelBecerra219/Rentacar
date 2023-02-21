using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_proyecto_integrador
{
    public partial class Frmhome : Form
    {
        public Frmhome(string nombreUsuario)
        {
            InitializeComponent();
            bunifuLabel1.Text = $"Bienvenid@ de vuelta {nombreUsuario}";
        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            var autosmenu = new Autos();
            autosmenu.ShowDialog();
            if (autosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var segurosmenu = new seguros();
            segurosmenu.ShowDialog();
            if (segurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var clientesmenu = new clientes();
            clientesmenu.ShowDialog();
            if (clientesmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var clientesintermediariosmenu = new ClientesIntermediarios();
            clientesintermediariosmenu.ShowDialog();
            if (clientesintermediariosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var companiasegurosmenu = new CompaniaDeSeguros();
            companiasegurosmenu.ShowDialog();
            if (companiasegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var contratomenu = new Contrato();
            contratomenu.ShowDialog();
            if (contratomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
