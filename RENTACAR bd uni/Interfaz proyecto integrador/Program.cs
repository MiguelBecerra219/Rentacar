using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Micron;

namespace Interfaz_proyecto_integrador
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

         


            //MicronConfig config = new MicronConfig()
            //{
            //    Host = "localhost",
            //    DatabaseName = "login_rentacar",
            //    User = "root",
            //    Password = "6053769Ma",
            //    Port = "3306",

            //};


            //MicronDbContext.AddConnectionSetup(config);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static  string CalculateMD5Hash(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            StringBuilder sb = new StringBuilder();
            for (int i=0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }



            return sb.ToString();
        }

    }

}
