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
    public partial class ClientesIntermediarios : Form
    {
        public ClientesIntermediarios()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var crearclientesintermediariosmenu = new CrearClienteIntermediario();
            crearclientesintermediariosmenu.ShowDialog();
            if (crearclientesintermediariosmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarclienteintermediariomenu = new ModificarClienteIntermediario();
            modificarclienteintermediariomenu.ShowDialog();
            if (modificarclienteintermediariomenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarclienteintermediaromenu = new BorrarClienteIntermediario();
            borrarclienteintermediaromenu.ShowDialog();
            if (borrarclienteintermediaromenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var seleccionarclientesinmenu = new ConsultarClientesIntermediarios();
            seleccionarclientesinmenu.ShowDialog();
            if (seleccionarclientesinmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
