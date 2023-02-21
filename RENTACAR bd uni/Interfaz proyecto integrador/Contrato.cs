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
    public partial class Contrato : Form
    {
        public Contrato()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var crearcontratomenu = new CrearContrato();
            crearcontratomenu.ShowDialog();
            if (crearcontratomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarcontratomenu = new ModificarContrato();
            modificarcontratomenu.ShowDialog();
            if (modificarcontratomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarcontratomenu = new BorrarContrato();
            borrarcontratomenu.ShowDialog();
            if (borrarcontratomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            var seleccionarcontratomenu = new ConsultarContrato();
            seleccionarcontratomenu.ShowDialog();
            if (seleccionarcontratomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
