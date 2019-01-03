using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace ProjAl
{
    public class Customer
    {
        public long ID { get; set; }

        public string No { get; set; }

        public string Name { get; set; }

        public string Name_2 { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Contact { get; set; }

        public string Phone_No_ { get; set; }

        public string AccountNo { get; set; }

        public string Territory_Code { get; set; }

        public string ChainName { get; set; }

        public decimal BudgetedAmount { get; set; }

        public decimal CreditLimit { get; set; }

        public string CustomerPostingGroup { get; set; }

        public string Currency_Code { get; set; }

        public string Customer_Price_Group { get; set; }

        public string Language_Code { get; set; }

        public string Payment_Terms_Code { get; set; }

        public string SalespersonCode { get; set; }

        public string Shipment_Method_Code { get; set; }

        public decimal Amount { get; set; }

        public DateTime Last_Date_Modified { get; set; }

        public string Location_Code { get; set; }

        public string VAT_Registration_No_ { get; set; }

        public string Area { get; set; }

        public bool Active { get; set; }


        public List<Customer> GetAllCustomers()
        {
            string query = "Select * from dbo.[customer] c";
            using (var connection = new SqlConnection("Data Source=DB\\DESKTOP,1133;Initial Catalog=ProjAl;User Id=proj;Password=112233!;"))
            {
                var customers = connection.Query<Customer>(query).ToList();
                return customers;
            }
        }

    }
}
