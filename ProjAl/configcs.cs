using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.IO;
using System.Data.SqlClient;
using RestSharp;

namespace ProjAl
{
        public class Configcs
        {
            public static string filepath = "C:\\Users\\r.zogolli\\Documents\\Visual Studio 2015\\Projects\\ProjAl\\ProjAl\\config.txt";
            public static string Server { get; set; }

            public static string Db { get; set; }

            public static bool windowsAuth { get; set; }

            public static string username { get; set; }

            public static string password { get; set; }

            public static string Api { get; set; }

            public static string ConnectionString { get; set; }

            public static bool CheckApi()
            {
                try
                {
                    //System.Net.WebClient client = new System.Net.WebClient();
                    //string result = client.DownloadString(txtApi.Text);
                    var client = new RestClient(Api);
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

        public static bool IsServerConnected()
        {
            using (var l_oConnection = new SqlConnection(ConnectionString))
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

        public static void FillClass()
            {
                if (File.Exists(filepath))
                {
                    string line;
                    int row = 0;
                    StreamReader file = new StreamReader(filepath);
                    while ((line = file.ReadLine()) != null)
                    {
                        int index = line.IndexOf(":");
                        string key = line.Substring(0, index);//key
                        string value = line.Substring(index + 1);//value

                        switch (key)
                        {
                            case "Server":
                                 Server = value;
                                break;
                            case "Db":
                                Db = value;
                                break;
                            case "WindowsAuth":
                                windowsAuth = Convert.ToBoolean(value);
                                break;
                            case "Username":
                                username = value;
                                break;
                            case "Password":
                                password = value;
                                break;
                            case "Api":
                                Api = value;
                                break;
                        }

                        row++;
                   }
                    file.Close();

                    if (!windowsAuth)
                    {
                        ConnectionString = "Data Source=" + Server + ";Initial Catalog=" + Db + ";User Id=" + username + ";Password=" + password + ";";
                    }
                    else
                    {
                        ConnectionString = "Data Source=" + Server + ";Initial Catalog=" + Db + ";Integrated Security=true;";
                    }
               }
           }
       }
  
}
