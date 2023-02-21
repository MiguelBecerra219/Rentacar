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
    public partial class Autos : Form
    {
        public Autos()
        {
            InitializeComponent();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarautosmenu = new ModificarAutos();
            modificarautosmenu.ShowDialog();
            if (modificarautosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var crearautosmenu = new CrearAutos();
            crearautosmenu.ShowDialog();
            if (crearautosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarautosmenu = new BorrarAutos();
            borrarautosmenu.ShowDialog();
            if (borrarautosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var venderautosmenu = new VenderAutos();
            venderautosmenu.ShowDialog();
            if (venderautosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var entregarautosmenu = new EntregarAutos();
            entregarautosmenu.ShowDialog();
            if (entregarautosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var ConsultarAutoMenu = new ConsultarAuto();
            ConsultarAutoMenu.ShowDialog();
            if (ConsultarAutoMenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
