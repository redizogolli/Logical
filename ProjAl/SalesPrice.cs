using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace ProjAl
{
    public class SalesPrice
    {
        public long Id { get; set; }

        public string Client { get; set; }

        public int Type { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string UoM { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public TimeSpan StartHour { get; set; }

        public TimeSpan EndHour { get; set; }

        public bool Monday { get; set; }

        public bool TuesDay { get; set; }

        public bool Wednesday { get; set; }

        public bool Thursday { get; set; }

        public bool Friday { get; set; }

        public bool Saturday { get; set; }

        public bool Sunday { get; set; }

        public decimal Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public bool Active { get; set; }

        public string LastUserModified { get; set; }

        public DateTime LastDateModified { get; set; }

        public int Tag { get; set; }

        public string CampaignCode { get; set; }

        public decimal PointMultiplier { get; set; }


        public List<SalesPrice> GetAllSalesPrices()
        {
            string query = "Select * from dbo.[SalesPrice] sp";
            using (var connection = new SqlConnection("Data Source=DB\\DESKTOP,1133;Initial Catalog=ProjAl;User Id=proj;Password=112233!;"))
            {
                var prices = connection.Query<SalesPrice>(query).ToList();
                return prices;
            }
        }

    }

}
