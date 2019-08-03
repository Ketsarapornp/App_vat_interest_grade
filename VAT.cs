using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application
{
    public partial class VAT : Form
    {
        public VAT()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            const double TAX = 0.07;
            double price, tax, total;
            price = Convert.ToDouble(txtprice.Text);
            tax = price * TAX;
            total = price + tax;
            txtvat.Text = tax.ToString("#,###.##");
            txttotal.Text = total.ToString("#,###.##");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void VAT_Load(object sender, EventArgs e)
        {
           
        }
    }
}
