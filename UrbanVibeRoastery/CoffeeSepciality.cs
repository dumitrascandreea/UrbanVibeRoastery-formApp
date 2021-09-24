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
    public partial class CoffeeSepciality : Form
    {
        public CoffeeSepciality()
        {
            InitializeComponent();
        }

        public int getNum()
        {
            Random rand = new Random();
            int num = rand.Next(1, 100);
            return num;
        }
           
        private void button1_Click(object sender, EventArgs e)
        {            
            AddProducts p1 = new AddProducts("Coffee",getNum(), "Colombia", 9.50m);
            p1.AddProduct();           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            Products pd = new Products();
            pd.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Brazil", 9.45m);
            p1.AddProduct();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Costa Rica", 7.50m);
            p1.AddProduct();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "San Domingo", 6.50m);
            p1.AddProduct();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Guatemala", 6.95m);
            p1.AddProduct();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Ethiopia", 10.50m);
            p1.AddProduct();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Panama", 9.50m);
            p1.AddProduct();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddProducts p1 = new AddProducts("Coffee", getNum(), "Kenya", 7.50m);
            p1.AddProduct();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserOrder us = new UserOrder();
            us.Show();

        }
    }
}
