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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void brnLogin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder uo = new UserOrder();
            uo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
