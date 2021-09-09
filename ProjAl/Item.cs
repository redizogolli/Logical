using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace ProjAl
{
    public class Item
    {
        public long ID { get; set; }

        public string No { get; set; }

        public string No__2 { get; set; }

        public string Description { get; set; }

        public string Search_Description { get; set; }

        public string LongDescription { get; set; }

        public string Base_Unit_of_Measure { get; set; }

        public string Barcode { get; set; }

        public string Item_Category_Code { get; set; }

        public string Item_Group_Code { get; set; }

        public string Item_Category_3 { get; set; }

        public string Item_Category_4 { get; set; }

        public string Item_Category_5 { get; set; }

        public string Item_Category_6 { get; set; }

        public string Item_Category_7 { get; set; }

        public string Item_Category_8 { get; set; }

        public string Item_Category_9 { get; set; }

        public string Item_Category_10 { get; set; }

        public string Ingredients { get; set; }

        public decimal V_Weight { get; set; }

        public decimal ShelfLife { get; set; }

        public decimal Tare { get; set; }

        public string Label_NO { get; set; }

        public bool BOM { get; set; }

        public int Warranty_Period_in_Months { get; set; }

        public bool WarrantyforComponents { get; set; }

        public int Allow_Invoice_Disc_ { get; set; }

        public string VendorNO { get; set; }

        public decimal Purchase_Price { get; set; }

        public decimal Unit_Price { get; set; }

        public decimal Unit_Price_No_VAT { get; set; }

        public decimal VAT { get; set; }

        public DateTime Last_DateTime_Modified { get; set; }

        public bool Blocked { get; set; }

        public byte[] Picture { get; set; }

        public decimal Min { get; set; }

        public decimal Max { get; set; }

        public DateTime LastSyncDate { get; set; }

        public decimal Coefficient { get; set; }


        public List<Item> GetAllItems()
        {
            string query = "Select * from dbo.[item] i";
            using (var connection = new SqlConnection(Configcs.ConnectionString))
            {
                var items = connection.Query<Item>(query).ToList();
                return items;
            }
        }

    }

    
}
