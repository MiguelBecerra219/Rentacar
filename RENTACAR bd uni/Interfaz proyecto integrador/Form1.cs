using System;
using Data.Models;
using Micron;
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
    public partial class Form1 : Form
    {

        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl; PASSWORD = act_rentacar; USER ID= act_rentacar; Unicode = True;");
        //MicronDbContext micron = new MicronDbContext();
        public Form1()
        {
            InitializeComponent();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(0);
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage(1);
        }

        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSingUp_Click(object sender, EventArgs e)
        {

            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("insertar", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("nom", OracleType.VarChar).Value = txtNameRegistro.Text;
                comando.Parameters.Add("cont", OracleType.VarChar).Value = txtPasswordRegistro.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro completo");
                txtNameRegistro.ResetText();
                txtPasswordRegistro.ResetText();
            }
            catch(Exception)
            {
                MessageBox.Show("Registro fallido");
            }
            conexion.Close();


            //Usuario usuario = micron.GetRecord<Usuario>($"email='{txtEmail.Text}' AND password  = MD5('{txtPassword.Text}')");

            //if (usuario != null)
            //{
            //    MessageBox.Show("El usuario ya existe");
            //    return;
            //}

            //usuario = new Usuario()
            //{
            //    nombre = txtName.Text,
            //    email = txtEmail.Text,
            //    password = Program.CalculateMD5Hash(txtPassword.Text)
            //};

            //usuario = micron.Save(usuario);
            //MessageBox.Show("Su usuario a sido creado correctamente.");
            //txtEmail.Text = txtName.Text = txtPassword.Text = string.Empty;

            //bunifuPages1.SetPage(0);

        }

        
        
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE  USUARIO= :usuario AND PASSWORD = :contra ", conexion);
                comando.Parameters.AddWithValue(":usuario", txtUsuarioEntrada.Text);
                comando.Parameters.AddWithValue(":contra", txtContraEntrada.Text);

                OracleDataReader lector = comando.ExecuteReader();
                if (lector.Read())
                {
                    //Frmhome home = new Frmhome(txtUsuarioEntrada.Text);
                    this.Visible = false;
                    var home = new Frmhome(txtUsuarioEntrada.Text);
                    home.ShowDialog();
                    if (home.DialogResult != DialogResult.No) this.Close();
                    this.Visible = true;
                    txtUsuarioEntrada.ResetText();
                    txtContraEntrada.ResetText();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña invalidos");
                }

            }
            catch(Exception)
            {
                
            }
            conexion.Close();
            //Usuario usuario = micron.GetRecord<Usuario>($"email='{bunifuTextBox1.Text}' AND password = MD5('{bunifuTextBox3.Text}')");

            //if (usuario == null)
            //{
            //    MessageBox.Show("Datos invalidos");
            //    return;
            //}

            //this.Visible = false;
            //var home = new Frmhome(usuario);
            //home.ShowDialog();
            //if (home.DialogResult != DialogResult.No) this.Close();
            //this.Visible = true;
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuarioEntrada_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
