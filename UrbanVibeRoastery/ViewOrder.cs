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
    public partial class ViewOrder : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=UrbanVibeRoastery;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public ViewOrder()
        {
            InitializeComponent();
        }

        private void brnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void populate()
        {
            con.Open();
            string query = "select * from Orders";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder build = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            OrderView.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ViewOrder_Load(object sender, EventArgs e)
        {
            populate();
        }

      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("----Order Details----", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(200));
            e.Graphics.DrawString("Order Number : " + OrderView.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century", 12, FontStyle.Regular), Brushes.Black, new Point(120, 105));
            e.Graphics.DrawString("User name: " + OrderView.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 12, FontStyle.Regular), Brushes.Black, new Point(120, 125));
            e.Graphics.DrawString("Quantity : " + OrderView.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 12, FontStyle.Regular), Brushes.Black, new Point(120, 145));
            e.Graphics.DrawString("Total : " + OrderView.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 12, FontStyle.Regular), Brushes.Black, new Point(120, 165));

        }

        private void OrderView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
