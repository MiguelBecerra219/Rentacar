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
    public partial class seguros : Form
    {
        public seguros()
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
            var crearsegurosmenu = new CrearSeguros();
            crearsegurosmenu.ShowDialog();
            if (crearsegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarsegurosmenu = new ModificarSeguros();
            modificarsegurosmenu.ShowDialog();
            if (modificarsegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarsegurosmenu = new BorrarSeguros();
            borrarsegurosmenu.ShowDialog();
            if (borrarsegurosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var seleccionarseguromenu = new ConsultarSeguros();
            seleccionarseguromenu.ShowDialog();
            if (seleccionarseguromenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
