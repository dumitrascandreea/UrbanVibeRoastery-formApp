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


namespace UrbanVibeRoastery
{
    public partial class CustomerOrder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public CustomerOrder()
        {
            InitializeComponent();
        }
        void populate()
        {
            con.Open();
            string query = "select * from Product";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsView.DataSource = ds.Tables[0];
            con.Close();
        }
        void filterByCategory()
        {
            con.Open();
            string query = "select * from Product where Category = '" + cbCategory.SelectedItem.ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductsView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        int number = 0;
        decimal total, price;
        string name, category;
        DataTable tab = new DataTable();
        decimal sum = 0;

        private void brnLogin_Click(object sender, EventArgs e)
        {

            if (txtQty.Text == "Quantity" || txtOrderNumber.Text =="OrderNumber" ||cbCategory.Text=="Category")
            {
                MessageBox.Show("Introduce quantity, order number and category!");
            }
            else if (name == "0" || name == null)
            {
                MessageBox.Show("Select the product!");
            }
            else
            {
                number = number + 1;
                total = price * Convert.ToDecimal(txtQty.Text);
                tab.Rows.Add(number, name, category, price, total);
                cart.DataSource = tab;
            }
            sum = sum + total;
            lbTotal.Text = "" + sum;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOrderNumber.Text == "OrderNumber" || txtQty.Text == "Quantity" ||cbCategory.Text=="Category")
            {
                Console.WriteLine("Please enter order number , quantity and cateory!");
            }
            else
            {
                con.Open();
                string query = "insert into Orders  values ('" + txtOrderNumber.Text + "','" + txtGuest.Text + "','" + txtQty.Text + "','" + lbTotal.Text + "','" + cbCategory.SelectedItem.ToString() + "') ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order succesfuly made");
                con.Close();
                txtOrderNumber.Text = "";
                txtQty.Text = "";
            }
            
        }

        private void txtOrderNumber_Click(object sender, EventArgs e)
        {
            txtOrderNumber.Text = "";
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            txtQty.Text = "";
        }

        private void ProductsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name = ProductsView.SelectedRows[0].Cells[2].Value.ToString();
            category = ProductsView.SelectedRows[0].Cells[0].Value.ToString();
            price = Convert.ToDecimal(ProductsView.SelectedRows[0].Cells[3].Value.ToString());
        }


        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            populate();
            tab.Columns.Add("NumberProduct", typeof(int));
            tab.Columns.Add("ProdName", typeof(string));
            tab.Columns.Add("Category", typeof(string));
            tab.Columns.Add("UnitPrice", typeof(int));
            tab.Columns.Add("TotalAmount", typeof(int));
            cart.DataSource = tab;
        }

        private void cbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }
    }
}
