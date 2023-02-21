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
    public partial class CompaniaDeSeguros : Form
    {
        public CompaniaDeSeguros()
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
            var crearcompaniasegurosmenu = new CrearCompaniaSeguros();
            crearcompaniasegurosmenu.ShowDialog();
            if (crearcompaniasegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarcompaniasegurosmenu = new ModificarCompaniaSeguros();
            modificarcompaniasegurosmenu.ShowDialog();
            if (modificarcompaniasegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarcompaniasegurosmenu = new BorrarCompaniaSeguros();
            borrarcompaniasegurosmenu.ShowDialog();
            if (borrarcompaniasegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var seleccionarciaseguromenu = new ConsultarCiaSeguros();
            seleccionarciaseguromenu.ShowDialog();
            if (seleccionarciaseguromenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
