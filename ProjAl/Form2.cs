using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using RestSharp;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using NLog;
using System.Linq.Dynamic;
using System.Data.Entity.SqlServer;
using System.Diagnostics;
using System.Threading;

namespace ProjAl
{
    public partial class Form2 : MaterialForm
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        List<Item> listitems =new List<Item>();
        List<Customer> listcustomers = new List<Customer>();
        List<SalesPrice> listsaleprices = new List<SalesPrice>();
      
        public Form2()
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

            listitems = null;
            listcustomers = null;
            listsaleprices = null;
        }

        public void fillCombo()
        {
            comboBox1.Items.Clear();
            for (int i = 0; i < grid.Columns.Count; i++)
            {
               // string header = grid.Columns[i].HeaderText;
                //MessageBox.Show(header);
                comboBox1.Items.Add(grid.Columns[i].HeaderText);
            }
            comboBox1.SelectedIndex = 0;
        }

        
        
        private void syncItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //krijimi threadit te ri
            Thread _myThread = new Thread(new ThreadStart(showGif));
            _myThread.Start();
            logger.Info("Krijojme 1 thread te ri per te shfaqur loading");

            //thirrja Api
            var client = new RestClient("http://192.168.23.52/FashionAPI");
            var request = new RestRequest("api/Item", Method.POST);
            request.AddParameter("LastClientDate", "2015-12-12T10:34:10.471Z");
            request.AddParameter("LastClientId", "0");
            request.AddParameter("KodKlienti", "string");


            try
            {
                //Thread _myThread = new Thread(new ThreadStart(showGif));
               
                //new Thread(() => new loading().ShowDialog()).Start();
                IRestResponse response = client.Execute(request);

                logger.Info("therritet Api");

                var content = response.Content; // raw content as string

                JavaScriptSerializer js = new JavaScriptSerializer();

                Item[] items = js.Deserialize<Item[]>(content);

                string deletequery = "delete from [dbo].[item]";
                string query = "Insert into [dbo].[item] ([ID],[No],[No__2],[Description],[Search_Description],[LongDescription],[Base_Unit_of_Measure],[Barcode],[Item_Category_Code],[Item_Group_Code],[Item_Category_3],[Item_Category_4],[Item_Category_5],[Item_Category_6],[Item_Category_7],[Item_Category_8],[Item_Category_9],[Item_Category_10],[Ingredients],[V_Weight],[ShelfLife],[Tare],[Label_NO],[BOM],[Warranty_Period_in_Months],[WarrantyforComponents],[Allow_Invoice_Disc_],[VendorNO],[Purchase_Price],[Unit_Price],[Unit_Price_No_VAT],[VAT],[Last_DateTime_Modified],[Blocked],[Picture],[Min],[Max],[LastSyncDate],[Coefficient])  Values(@ID,@No,@No__2,@Description,@Search_Description,@LongDescription,@Base_Unit_of_Measure,@Barcode,@Item_Category_Code,@Item_Group_Code,@Item_Category_3,@Item_Category_4,@Item_Category_5,@Item_Category_6,@Item_Category_7,@Item_Category_8,@Item_Category_9,@Item_Category_10,@Ingredients,@V_Weight,@ShelfLife,@Tare,@Label_NO,@BOM,@Warranty_Period_in_Months,@WarrantyforComponents,@Allow_Invoice_Disc_,@VendorNO,@Purchase_Price,@Unit_Price,@Unit_Price_No_VAT,@VAT,@Last_DateTime_Modified,@Blocked,@Picture,@Min,@Max,@LastSyncDate,@Coefficient)";
                //loading gif = new loading();
                //gif.Show();
                //new Thread(() => new loading().ShowDialog()).Start();
                
                
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    var deleteresult = db.Execute(deletequery);
                    logger.Info("fshihen produktet e meparshme ");
                
                    foreach (var item in items)
                    {
                        var result = db.Execute(query, new
                        {
                            ID = item.ID,
                            No = item.No,
                            No__2 = item.No__2,
                            Description = item.Description,
                            Search_Description = item.Search_Description,
                            LongDescription = item.LongDescription,
                            Base_Unit_of_Measure = item.Base_Unit_of_Measure,
                            Barcode = item.Barcode,
                            Item_Category_Code = item.Item_Category_Code,
                            Item_Group_Code = item.Item_Group_Code,
                            Item_Category_3 = item.Item_Category_3,
                            Item_Category_4 = item.Item_Category_4,
                            Item_Category_5 = item.Item_Category_5,
                            Item_Category_6 = item.Item_Category_6,
                            Item_Category_7 = item.Item_Category_7,
                            Item_Category_8 = item.Item_Category_8,
                            Item_Category_9 = item.Item_Category_9,
                            Item_Category_10 = item.Item_Category_10,
                            Ingredients = item.Ingredients,
                            V_Weight = item.V_Weight,
                            ShelfLife = item.ShelfLife,
                            Tare = item.Tare,
                            Label_NO = item.Label_NO,
                            BOM = item.BOM,
                            Warranty_Period_in_Months = item.Warranty_Period_in_Months,
                            WarrantyforComponents = item.WarrantyforComponents,
                            Allow_Invoice_Disc_ = item.Allow_Invoice_Disc_,
                            VendorNO = item.VendorNO,
                            Purchase_Price = Convert.ToDouble(item.Purchase_Price),
                            Unit_Price = Convert.ToDouble(item.Unit_Price),
                            Unit_Price_No_VAT = Convert.ToDouble(item.Unit_Price_No_VAT),
                            VAT = Convert.ToDouble(item.VAT),
                            Last_DateTime_Modified = item.Last_DateTime_Modified,
                            Blocked = item.Blocked,
                            Picture = item.Picture,
                            Min = item.Min,
                            Max = item.Max,
                            LastSyncDate = item.LastSyncDate,
                            Coefficient = item.Coefficient

                        });
                    }
                }
     

                _myThread.Abort();
                logger.Info("Abort threadi");

                logger.Info("Insertohen ne db rekordet e reja");
                MessageBox.Show("Sinkronizimi i produkteve perfundoi me sukses");
                
                Item itm = new Item();
                //items=itm.GetAllItems();
                listitems = itm.GetAllItems();
                logger.Info("Merren rekordet e reja dhe i shfaqim ne gride");
                lblGridHead.Text = "Lista e Produkteve";
                grid.DataSource = listitems;
                fillCombo();
                listcustomers = null;
                listsaleprices = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dicka shkoi Gabim! Ju lutem provojeni perseri");
                logger.Error(ex,"Ndodhi nje gabim gjate sinkronizimit te produkteve");
            }
            _myThread.Abort();
        }

        private void syncCustomers_Click(object sender, EventArgs e)
        {
     
            //thirrja Api

            var client = new RestClient("http://192.168.23.52/FashionAPI");
            var request = new RestRequest("api/Customer", Method.POST);
            request.AddParameter("LastClientDate", "2015-12-12T10:34:10.471Z");
            request.AddParameter("LastClientId", "0");
            request.AddParameter("KodKlienti", "string");

            try
            {
                //krijimi threadit te ri
                Thread _myThread = new Thread(new ThreadStart(showGif));
                _myThread.Start();
                logger.Info("Krijojme 1 thread te ri per te shfaqur loading");


                IRestResponse response = client.Execute(request);
                logger.Info("therritet Api i klienteve");
                var content = response.Content; // raw content as string

                JavaScriptSerializer js = new JavaScriptSerializer();

                Customer[] customers = js.Deserialize<Customer[]>(content);
                string deletequery = "delete from [dbo].[customer]";
                string query = "Insert into [dbo].[customer] ([ID],[No],[Name],[Name_2],[Address],[City],[Contact],[Phone_No_],[AccountNo],[Territory_Code],"+
                    "[ChainName],[BudgetedAmount],[CreditLimit],[CustomerPostingGroup],[Currency_Code],[Customer_Price_Group],[Language_Code],[Payment_Terms_Code],"+
                    "[SalespersonCode],[Shipment_Method_Code],[Amount],[Last_Date_Modified],[Location_Code],[VAT_Registration_No_],[Area],[Active]) " +
                    "Values(@ID,@No,@Name,@Name_2,@Address,@City,@Contact,@Phone_No_,@AccountNo,@Territory_Code,@ChainName,@BudgetedAmount,@CreditLimit," +
                   "@CustomerPostingGroup,@Currency_Code,@Customer_Price_Group,@Language_Code,@Payment_Terms_Code,@SalespersonCode,@Shipment_Method_Code,"+
                    "@Amount,@Last_Date_Modified,@Location_Code,@VAT_Registration_No_,@Area,@Active)";



                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    var deleteresult = db.Execute(deletequery);
                    logger.Info("Fshihen Klientet nga databaza");
                    foreach (var cust in customers)
                    {
                        //Console.Write(cust.ID + " Name: " + cust.Name + "<br/>");
                        var result = db.Execute(query, new
                        {
                            ID = cust.ID,
                            No = cust.No,
                            Name = cust.Name,
                            Name_2 = cust.Name_2,
                            Address = cust.Address,
                            City = cust.City,
                            Contact = cust.Contact,
                            Phone_No_ = cust.Phone_No_,
                            AccountNo = cust.AccountNo,
                            Territory_Code = cust.Territory_Code,
                            ChainName = cust.ChainName,
                            BudgetedAmount = cust.BudgetedAmount,
                            CreditLimit = cust.CreditLimit,
                            CustomerPostingGroup = cust.CustomerPostingGroup,
                            Currency_Code = cust.Currency_Code,
                            Customer_Price_Group = cust.Customer_Price_Group,
                            Language_Code = cust.Language_Code,
                            Payment_Terms_Code = cust.Payment_Terms_Code,
                            SalespersonCode = cust.SalespersonCode,
                            Shipment_Method_Code = cust.Shipment_Method_Code,
                            Amount = cust.Amount,
                            Last_Date_Modified = cust.Last_Date_Modified,
                            Location_Code = cust.Location_Code,
                            VAT_Registration_No_ = cust.VAT_Registration_No_,
                            Area = cust.Area,
                            Active = cust.Active

                        });
                    }

                }
                _myThread.Abort();
                logger.Info("Abort threadi");
                MessageBox.Show("Sinkronizimi i klienteve perfundoi me sukses");
                logger.Info("Shtohen klientet e marre ne db");
                Customer custom = new Customer();
                listcustomers = custom.GetAllCustomers();
                lblGridHead.Text = "Lista e Klienteve";
                logger.Info("Merren Klientet nga databaza dhe i shfaqim ne gride");
                grid.DataSource = listcustomers;
                fillCombo();
                listitems = null;
                listsaleprices = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dicka shkoi Gabim! Ju lutem provojeni perseri" );
                logger.Error(ex,"Ndodhi nje problem gjate sinkronizimit te klienteve");
            }
         
        }

        private void syncPrices_Click(object sender, EventArgs e)
        {
            

            //thirrja Api

            var client = new RestClient("http://192.168.23.52/FashionAPI");
            var request = new RestRequest("api/SalesPrice", Method.POST);
            request.AddParameter("LastClientDate", "2015-12-12T10:34:10.471Z");
            request.AddParameter("LastClientId", "0");
            request.AddParameter("KodKlienti", "string");

            try
            {
                //krijimi threadit te ri
                Thread _myThread = new Thread(new ThreadStart(showGif));
                _myThread.Start();
                logger.Info("Krijojme 1 thread te ri per te shfaqur loading");

                IRestResponse response = client.Execute(request);
                logger.Info("Therritet Api i cmimeve");

                var content = response.Content; // raw content as string

                JavaScriptSerializer js = new JavaScriptSerializer();

                SalesPrice[] prices = js.Deserialize<SalesPrice[]>(content);

                string deletequery = "delete from [dbo].[salesprice]";

                string query = "Insert into [dbo].[salesprice] ([Id],[Client],[Type],[Code],[Description],[UoM],[StartDate],[EndDate],[StartHour],[EndHour]," +
                    "[Monday],[TuesDay],[Wednesday],[Thursday],[Friday],[Saturday],[Sunday],[Quantity]," +
                    "[UnitPrice],[Active],[LastUserModified],[LastDateModified],[Tag],[CampaignCode],[PointMultiplier]) " +
                    "Values(@Id,@Client,@Type,@Code,@Description,@UoM,@StartDate,@EndDate,@StartHour,@EndHour,@Monday,@TuesDay,@Wednesday," +
                   "@Thursday,@Friday,@Saturday,@Sunday,@Quantity,@UnitPrice,@Active," +
                    "@LastUserModified,@LastDateModified,@Tag,@CampaignCode,@PointMultiplier)";


                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString))
                {
                    var deleteresult = db.Execute(deletequery);
                    logger.Info("Fshihen te gjitha cmimet e meparshme nga databaza");
                    foreach (var price in prices)
                    {
                        //Console.Write(cust.ID + " Name: " + cust.Name + "<br/>");
                        var result = db.Execute(query, new
                        {
                            Id = price.Id,
                            Client = price.Client,
                            Type = price.Type,
                            Code = price.Code,
                            Description = price.Description,
                            UoM = price.UoM,
                            StartDate = price.StartDate,
                            EndDate = price.EndDate,
                            StartHour = price.StartHour,
                            EndHour = price.EndHour,
                            Monday = price.Monday,
                            TuesDay = price.TuesDay,
                            Wednesday = price.Wednesday,
                            Thursday = price.Thursday,
                            Friday = price.Friday,
                            Saturday = price.Saturday,
                            Sunday = price.Sunday,
                            Quantity = price.Quantity,
                            UnitPrice = price.UnitPrice,
                            Active = price.Active,
                            LastUserModified = price.LastUserModified,
                            LastDateModified = price.LastDateModified,
                            Tag = price.Tag,
                            CampaignCode = price.CampaignCode,
                            PointMultiplier = price.PointMultiplier

                        });
                    }

                }
                _myThread.Abort();
                logger.Info("Abort threadi");
                MessageBox.Show("Sinkronizimi i cmimeve perfundoi me sukses");
                logger.Info("Shtohen cmimet e reja ne db");
                SalesPrice sp = new SalesPrice();
                listsaleprices = sp.GetAllSalesPrices();
                lblGridHead.Text = "Lista e Cmimeve";
                grid.DataSource = listsaleprices;
                fillCombo();
                logger.Info("Merren cmimet e reja dhe vendosen shfaqen ne gride");
                listitems = null;
                listcustomers = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Dicka shkoi Gabim! Ju lutem provojeni perseri");
                logger.Error(ex,"Ndodhi nje problem gjate sinkronizimit te cmimeve");
            }
            
        }

        private void search()
        {
            //MessageBox.Show(comboBox1.SelectedItem.ToString());
            var col = comboBox1.SelectedItem.ToString();
            var txt = txtemri.Text;
            if (listitems != null)
            {
                //Item itm = new Item();
                //var items = itm.GetAllItems();
                var query = listitems.Where(col + ".toString().ToLower().Contains(@0)", txtemri.Text.ToLower());
                grid.DataSource = query.ToList();
            }
            else if (listcustomers != null)
            {
                var query = listcustomers.Where(col + ".toString().ToLower().Contains(@0)", txtemri.Text.ToLower());
                grid.DataSource = query.ToList();
            }
            else
            {
                var query = listsaleprices.Where(col + ".toString().ToLower().Contains(@0)", txtemri.Text.ToLower());
                grid.DataSource = query.ToList();
            }
            
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex != -1)&& (txtemri.Text != "" && txtemri.Text != null))
            {
                search();
            }
            else
            {
                if (listitems != null)
                {
                    grid.DataSource = listitems;
                }
                else if (listcustomers != null)
                {
                    grid.DataSource = listcustomers;
                }
                else if(listsaleprices!=null)
                {
                    grid.DataSource = listsaleprices;
                }
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\r.zogolli\Documents\Visual Studio 2015\Projects\ProjAl\ProjAl\bin\Debug");
        }

        private static void showGif()
        {
            loading gif = new loading();
            //gif.Show();
            Application.Run(gif);
        }
    }
}
