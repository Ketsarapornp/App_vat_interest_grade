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
    public partial class INTEREST : Form
    {
        public INTEREST()
        {
            InitializeComponent();
        }

        private void INTEREST_Load(object sender, EventArgs e)
        {
            


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double principal_amt, rate, simple_interest;
            int time;
            principal_amt = Convert.ToInt32(txtmoney.Text);
            rate = Convert.ToInt32(txtint.Text);
            time = Convert.ToInt32(txttime.Text);
             int d = 1;
               while(d<=time)
               {
                simple_interest = (principal_amt * time * d) / 100;


               // txtinterast.Text = "Year = " + d + " Amount on deposit = " + simple_interest;
                txtinterast.Text += "Year = "+d+ " Amount on deposit = "+simple_interest.ToString()+"\n";
                d = d + 1;
               }
        

        }

        private void Txtinterast_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
