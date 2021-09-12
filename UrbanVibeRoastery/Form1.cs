using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UrbanVibeRoastery
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Form1()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string user;

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
           CustomerOrder guest = new CustomerOrder();
            guest.Show();
        }

        private void brnLogin_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
                          if (txtUser.Text == ""|| txtPass.Text == "")
            {
                MessageBox.Show("Enter USerName or password!");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from USerLogin where UserName = '"+txtUser.Text+"' and Password ='"+txtPass.Text+"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if(dt.Rows[0][0].ToString()=="1")
                {
                    UserOrder userOrder = new UserOrder();
                     userOrder.Show();
                    this.Hide(); 
                }
                else
                {
                    MessageBox.Show("Wrong userName or Password");
                }

                con.Close();


            }

        }
    }
}
