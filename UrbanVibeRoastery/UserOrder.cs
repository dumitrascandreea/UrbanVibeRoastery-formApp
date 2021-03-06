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
    public partial class UserOrder : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public UserOrder()
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
            OrderView.DataSource = ds.Tables[0];
            con.Close();
        }
        void filterByCategory()
        {
            con.Open();
            string query = "select * from Product where Category = '" +cbCategory.SelectedItem.ToString()+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderView.DataSource = ds.Tables[0];
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Products product = new Products();
            product.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersFormcs ufm = new UsersFormcs();
            ufm.Show();
        }

        DataTable tab = new DataTable();
        decimal sum = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            tab.Columns.Add("NumberProduct", typeof(int));
            tab.Columns.Add("ProdName", typeof(string));
            tab.Columns.Add("Category", typeof(string));
            tab.Columns.Add("UnitPrice", typeof(int));
            tab.Columns.Add("TotalAmount", typeof(int));
            cart.DataSource = tab;
            txtUser.Text = Form1.user; 

        }

        int number = 0;
        decimal total, price;
        string name, category;

        private void cbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory(); 
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOrder.Text == "OrderNumber" || txtQty.Text == "Quantity" ||cbCategory.Text== "Category")
            {
                Console.WriteLine("Enter the quantity and the order number");
            }
            else
            {
                con.Open();
                decimal price1 = Convert.ToDecimal(lbTotal.Text);
                string query = "insert into Orders  values ('" + txtOrder.Text + "','" + txtUser.Text + "','" + txtQty.Text + "','" + price1 + "','" + cbCategory.SelectedItem.ToString() + "') ";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order succesfuly made");
                con.Close();
                txtQty.Text = "";
                txtOrder.Text = "";
            }
        }

       

        private void bbtnView_Click(object sender, EventArgs e)
        {
            ViewOrder view = new ViewOrder();
            view.Show();
        }

        private void txtOrder_Click(object sender, EventArgs e)
        {
            txtOrder.Text = "";
        }

        private void txtQty_Click(object sender, EventArgs e)
        {
            txtQty.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {            
                this.Hide();
                CoffeeSepciality cf = new CoffeeSepciality();
                cf.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Product where ProductName like '" +ProdName.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderView.DataSource = ds.Tables[0];
            con.Close();
            ProdName.Text = "";
        }

        private void ProdName_Click(object sender, EventArgs e)
        {
            ProdName.Text = "";
        }

        private void OrderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            name = OrderView.SelectedRows[0].Cells[2].Value.ToString();
            category = OrderView.SelectedRows[0].Cells[0].Value.ToString();
            price = Convert.ToDecimal(OrderView.SelectedRows[0].Cells[3].Value.ToString());
          }

       
        private void brnAdd_Click(object sender, EventArgs e)
        {
            if (txtQty.Text == "Quantity" || txtOrder.Text == "OrderNumber" ||cbCategory.Text=="Category")
            {
                MessageBox.Show("Introduce the quantity and the order number!");
            }
            else if (name == "0" || name == null)
            {
                MessageBox.Show("Select the product!");
            }
            else
            {
                number= number + 1;
                total = price * Convert.ToInt32(txtQty.Text);
                tab.Rows.Add(number, name, category, price, total);
                cart.DataSource = tab;
            }
            sum = sum + total;
            lbTotal.Text = "" + sum;
            

        }


    }
}
