using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.IO;

namespace ProjAl
{
    public partial class Config : Form
    {
        public string filepath = "C:\\Users\\r.zogolli\\Documents\\Visual Studio 2015\\Projects\\ProjAl\\ProjAl\\config.txt";
        public Config()
        {
            InitializeComponent();
            //EnableFields();
            ReadConfig();
        }

        private void EnableFields()
        {
            lblPassword.Visible = true;
            lblUsername.Visible = true;
            txtPass.Visible = true;
            txtUn.Visible = true;
        }
        private void DisableFields()
        {
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            txtPass.Visible = false;
            txtUn.Visible = false;
        }
        private bool CheckApi()
        {
            try
            {
                //System.Net.WebClient client = new System.Net.WebClient();
                //string result = client.DownloadString(txtApi.Text);
                var client = new RestClient(txtApi.Text);
                var request = new RestRequest("api/Customer", Method.POST);
                request.AddParameter("LastClientDate", "2015-12-12T10:34:10.471Z");
                request.AddParameter("LastClientId", "0");
                request.AddParameter("KodKlienti", "string");
                IRestResponse response = client.Execute(request);
            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }

        
        private void chbwindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (chbwindowsAuth.Checked)
            {
                DisableFields();
            }
            else
            {
                EnableFields();
            }
        }

        private void btnCheckDb_Click(object sender, EventArgs e)
        {
            if (chbwindowsAuth.Checked)
            {
                if(txtServer.Text.IsNullOrEmpty()&& txtDb.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Plotesoni Serverin dhe Databazen");
                }
                else
                {
                    if (IsServerConnected())
                    {
                        MessageBox.Show("Lidhja me Db Eshte ne rregull");
                    }
                    else
                    {
                        MessageBox.Show("Lidhja me Db deshtoi,Kontrolloni fushat nqs jane sakte");
                    }
                }
            }
            else
            {
                if (txtServer.Text.IsNullOrEmpty() && txtDb.Text.IsNullOrEmpty() && txtUn.Text.IsNullOrEmpty() && txtPass.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Plotesoni Fushat");
                }
                else
                {
                    if (IsServerConnected())
                    {
                        MessageBox.Show("Lidhja me Db Eshte ne rregull");
                    }
                    else
                    {
                        MessageBox.Show("Lidhja me Db deshtoi,Kontrolloni fushat nqs jane sakte");
                    }

                }
            }
        }

        public bool IsServerConnected()
        {
            //string cs ="Data Source="+txtServer.Text+";Initial Catalog="+txtDb.Text+"; User id="+txtUn+"; Password="+txtPass.Text+";";
            //string cs2 = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDb.Text + "Integrated Security=true;";
            string conn;
            if (chbwindowsAuth.Checked)
            {
                 conn = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDb.Text + "Integrated Security=true;"; 
            }
            else
            {
                 conn = "Data Source=" + txtServer.Text + ";Initial Catalog=" + txtDb.Text + "; User id=" + txtUn.Text + "; Password=" + txtPass.Text + ";";
            } 
            using (var l_oConnection = new SqlConnection(conn))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        private void BtnCheckApi_Click(object sender, EventArgs e)
        {
            if (CheckApi())
            {
                MessageBox.Show("Api eshte ne rregull");
            }
            else
            {
                MessageBox.Show("Api nuk eshte ne rregull");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            //if (IsServerConnected() && CheckApi())
            //{
                //WriteConfig();
                if (chbwindowsAuth.Checked)
                {
                    if (txtServer.Text.IsNullOrEmpty() && txtDb.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Plotesoni Serverin dhe Databazen");
                    }
                    else
                    {
                        WriteConfig();
                        MessageBox.Show("Konfigurimet u aplikuan");
                    }
                }
                else
                {
                    if (txtServer.Text.IsNullOrEmpty() && txtDb.Text.IsNullOrEmpty() && txtUn.Text.IsNullOrEmpty() && txtPass.Text.IsNullOrEmpty())
                    {
                        MessageBox.Show("Plotesoni Fushat");
                    }
                    else
                    {
                        WriteConfig();
                        MessageBox.Show("Konfigurimet u aplikuan");
                    }
                }
            //}
            //else
            //{
            //    MessageBox.Show("Kontrolloni qe lidhja me Db dhe Api jane ne rregull");
            //}
        }

        public void WriteConfig()
        {
            File.WriteAllText(filepath, String.Empty);//fshin konfig e meparshme
            using (StreamWriter sw = (File.Exists(filepath)) ? File.AppendText(filepath) : File.CreateText(filepath))
            {
                sw.WriteLine("Server:{0}", txtServer.Text);
                sw.WriteLine("Db:{0}", txtDb.Text);
                sw.WriteLine("WindowsAuth:{0}", chbwindowsAuth.Checked);
                if (!chbwindowsAuth.Checked)
                {
                    sw.WriteLine("Username:{0}", txtUn.Text);
                    sw.WriteLine("Password:{0}", txtPass.Text);
                }
                sw.WriteLine("Api:{0}", txtApi.Text);
                //append per shtim
            }
        }

        public void ReadConfig()
        {
            string line;
            int row = 0;
            StreamReader file = new StreamReader(filepath);
            while ((line = file.ReadLine()) != null)
            {
                int index = line.IndexOf(":");
                string key = line.Substring(0, index);//key
                string value = line.Substring(index + 1);//value
                //Console.WriteLine(value);
                //MessageBox.Show(key);

                switch (key)
                {
                    case "Server":
                        txtServer.Text = value;
                        break;
                    case "Db":
                        txtDb.Text = value;
                        break;
                    case "WindowsAuth":
                        chbwindowsAuth.Checked = Convert.ToBoolean(value);
                        if (Convert.ToBoolean(value))
                        {
                            DisableFields();
                        }
                        else
                        {
                            EnableFields();
                        }
                        break;
                    case "Username":
                        txtUn.Text = value;
                        break;
                    case "Password":
                        txtPass.Text = value;
                        break;
                    case "Api":
                        txtApi.Text = value;
                        break;
                }
                //if(key == "WindowsAuth" && Convert.ToBoolean(value))
                //{
                //    DisableFields();
                //}
                //else
                //{
                //    EnableFields();
                //}

                row++;
            }
            file.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
