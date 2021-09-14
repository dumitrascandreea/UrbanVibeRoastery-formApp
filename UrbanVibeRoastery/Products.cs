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
    public partial class Products : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

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
        public Products()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uo = new UserOrder();
            uo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersFormcs us = new UsersFormcs();
            us.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void ProductsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // cbCategory.SelectedItem = ProductsView.SelectedRows[0].Cells[0].Value.ToString();
           // txtNumber.Text = ProductsView.SelectedRows[0].Cells[1].Value.ToString();
            //txtItemName.Text = ProductsView.SelectedRows[0].Cells[2].Value.ToString();
           // txtPrice.Text = ProductsView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtItemName.Text == "")
            {
                MessageBox.Show("Select a record to be deleted!");
            }
            else
            {
                con.Open();
                string query = "delete from Product where ProductName = '" + txtItemName.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product successfully deleted!");
                con.Close();
                populate();
            }
        }

        private void brnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtNumber.Text == "" || txtItemName.Text == "" || txtPrice.Text == ""||cbCategory.Text== "Category")
            {
                MessageBox.Show("Fill all the fileds!");
            }
            con.Open();
            string query = "Insert into dbo.Product (Category, Number, ProductName, Price) values ('" + cbCategory.SelectedItem.ToString() + "','" + txtNumber.Text + "','" + txtItemName.Text + "','" + (txtPrice.Text) + "')";
        
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added successful!");
            con.Close();
            populate();
            txtNumber.Text = "";
            txtItemName.Text = "";
            txtPrice.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "" || txtNumber.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Fill all the fileds");
            }
            else
            {
                con.Open();
                string query = "Update Product set ProductName = '" + txtItemName.Text + "' , Price = '" + txtPrice.Text + "',Category = '" + cbCategory.SelectedItem.ToString() +
                    "'where Number =  '" + txtNumber.Text + "'";
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull updated!");
                con.Close();
                populate();
            }
        }

        private void ProductsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumber.Text = ProductsView.SelectedRows[0].Cells[1].Value.ToString();
            txtItemName.Text = ProductsView.SelectedRows[0].Cells[2].Value.ToString();
            txtPrice.Text = ProductsView.SelectedRows[0].Cells[3].Value.ToString();
            cbCategory.Text = ProductsView.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
