using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrbanVibeRoastery
{
    public partial class UserOrder : Form
    {
        public UserOrder()
        {
            InitializeComponent();
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
    }
}
