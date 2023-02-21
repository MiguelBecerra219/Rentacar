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
    public partial class clientes : Form
    {
        public clientes()
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
            var crearclientesmenu = new CrearClientes();
            crearclientesmenu.ShowDialog();
            if (crearclientesmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var modificarclientesmenu = new ModificarClientes();
            modificarclientesmenu.ShowDialog();
            if (modificarclientesmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var borrarclientesmenu = new BorrarClientes();
            borrarclientesmenu.ShowDialog();
            if (borrarclientesmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var seleccionarclientesmenu = new ConsultarCliente();
            seleccionarclientesmenu.ShowDialog();
            if (seleccionarclientesmenu.DialogResult != DialogResult.No) this.Close();
            this.Visible = true;
        }
    }
}
