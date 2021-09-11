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
    public partial class UsersFormcs : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public UsersFormcs()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserOrder userOrder = new UserOrder();
            userOrder.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

       void populate()
        {

            con.Open();
            string query = "select * from UserLogin";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            userGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void UsersFormcs_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void brnLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into dbo.UserLogin (UserName, Phone, Password) values ('" +txtUserName.Text + "','" + txtPhone.Text + "','" + txtPassword.Text + "') ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("User succesfuly created");
            con.Close();
            populate();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = userGrid.SelectedRows[0].Cells[0].Value.ToString();
            txtPhone.Text =    userGrid.SelectedRows[0].Cells[1].Value.ToString();
            txtPassword.Text = userGrid.SelectedRows[0].Cells[2].Value.ToString();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPhone.Text == "")
            {
                MessageBox.Show("Select a record to be deleted!");
            }
            else
            {
                con.Open();
                string query = "delete from UserLogin where Phone = '" + txtPhone.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted!");
                con.Close();
                populate();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text =="" || txtPhone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Fill all the fileds");
            }else
            {
                con.Open();
                string query = "Update UserLogin set UserName = '" + txtUserName.Text + "' , Phone = '" + txtPhone.Text + "'where Password =  '" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfull updated!");
                con.Close();
                populate();

            }
        }
    }
    }

