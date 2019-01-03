using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dapper;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace ProjAl
{
    public partial class Form1 : MaterialForm
    {

        public string filepath = "C:\\Users\\r.zogolli\\Documents\\Visual Studio 2015\\Projects\\ProjAl\\ProjAl\\config.txt";
        public string connectionstring;
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        //private Configcs config = new Configcs();
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            //config.FillClass();
            //Form2 f2 = new Form2();
            //f2.Show();
        }



        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Configcs.FillClass();
            if (Configcs.CheckApi() && Configcs.IsServerConnected())
            {
                if (txtpassword.Text == "" && txtusername.Text == "")
                {
                    MessageBox.Show("Plotesoni Fushat");
                    logger.Info("Plotesoni Fushat username dhe password");

                }
                else
                {
                    User usr = new User();
                    var user = usr.GetUser(txtusername.Text, txtpassword.Text);
                    logger.Info("Useri po verifikohet");

                    if (user != null)
                    {
                        MessageBox.Show("Welcome");
                        logger.Info("Useri u autentifikua me sukses");
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or Password");
                        logger.Warn("Username dhe Password jane vendosur gabim");
                        txtpassword.Text = "";
                        txtusername.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Konfigurimet nuk jane ne rregull");
            }
            
            
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            logger.Info("Useri u largua !");
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Config c = new Config();
            c.Show();
        }
        
        
    }
}
