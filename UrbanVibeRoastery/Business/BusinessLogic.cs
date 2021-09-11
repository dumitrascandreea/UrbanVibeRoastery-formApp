using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrbanVibeRoastery.DataAccessCl;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace UrbanVibeRoastery.Business
{

    public class BusinessLogic
    {


        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public BusinessLogic()
        {

        }


        public void Populate()
        {
            UsersFormcs uf = new UsersFormcs();
            con.Open();
            string query = "select * from UserLogin";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            uf.userGrid.DataSource = ds.Tables[0];
            con.Close();

        }

        public void DeleteRow()
        {
            UsersFormcs uf = new UsersFormcs();

            if (uf.txtPhone.Text == " ")
            {
                MessageBox.Show("Select a record to be deleted!");
            }
            else
            {
                con.Open();
                string query = "delete from UserLogin where Phone = '" + uf.txtPhone.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User successfully deleted!");
                con.Close();
                Populate();
            }

        }
    }
}