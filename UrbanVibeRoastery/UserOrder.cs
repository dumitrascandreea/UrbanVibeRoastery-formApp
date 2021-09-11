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
        int flag = 0;
        private void UserOrder_Load(object sender, EventArgs e)
        {
            populate();
            //orderjos. sus item
            tab.Columns.Add("NumberProduct", typeof(int));
            tab.Columns.Add("ProdName", typeof(string));
            tab.Columns.Add("Category", typeof(string));
            tab.Columns.Add("UnitPrice", typeof(int));
            tab.Columns.Add("TotalAmount", typeof(int));
            OrderView.DataSource = tab;
        }

        int number = 0;
        int total, price;
        string name, category;

        //private void OrderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    txtOrder .Text = OrderView.SelectedRows[0].Cells[0].Value.ToString();
        //    txtUser.Text = OrderView.SelectedRows[0].Cells[1].Value.ToString();
        //    txtQty.Text = OrderView.SelectedRows[0].Cells[2].Value.ToString();
        //}

        private void brnLogin_Click(object sender, EventArgs e)
        {
            if(txtQty.Text == "")
            {
                MessageBox.Show("Introduce the quantity!");
            }
            else if( flag == 0)
            {
                MessageBox.Show("Select the product!");
            }else
            {
                number += 1;
                total = price * Convert.ToInt32(txtQty.Text);
                tab.Rows.Add(number, ProdName, category,price, total);
                OrderView.DataSource = tab;
                flag = 0;
            }
        }

       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            name = OrderView.SelectedRows[0].Cells[2].Value.ToString();
            category = OrderView.SelectedRows[0].Cells[0].Value.ToString();
            price = Convert.ToInt32(OrderView.SelectedRows[4].Cells[3].Value.ToString());
            flag = 1;
           
        
        }
    }
}
