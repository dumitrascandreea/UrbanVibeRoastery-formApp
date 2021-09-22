using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanVibeRoastery
{
    public class AddProducts
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public string Category { get; set; }
        public int Number { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public AddProducts(string cat, int number, string prodName, decimal price)
        {
            Category = cat;
            Number = number;
            ProductName = prodName;
            Price = price;
        }
        public void  AddProduct()
        {          
            con.Open();
           
            string query = "Insert into dbo.Product (Category, Number, ProductName, Price) values ('" + Category + "','" + Number + "','" + ProductName + "','" + Price + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successful!");
            con.Close();            
        }

      
    }
}
