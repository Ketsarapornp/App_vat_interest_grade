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
    public partial class GRADE : Form
    {
        public GRADE()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, mid, final, sum, grade;
            s1 = Convert.ToInt32(txts1.Text);
            s2 = Convert.ToInt32(txts2.Text);
            s3 = Convert.ToInt32(txts3.Text);
            s4 = Convert.ToInt32(txts4.Text);
            mid = Convert.ToInt32(txtmid.Text);
            final = Convert.ToInt32(txtfinal.Text);
            sum = s1 + s2 + s3 + s4 + mid + final;
            txtsum.Text = sum.ToString();
            if (s1 == 0 && s2 == 0 && s3 == 0 && s4 == 0 && mid == 0 && final == 0)
            {
                MessageBox.Show("Please input all score");

            }

            else if (sum >= 80 && sum <= 100)
            {

                txtgrade.Text = "A";
            }
            else if (sum >= 70 && sum <= 79)
            {

                txtgrade.Text = "B";
            }
            else if (sum >= 60 && sum <= 69)
            {

                txtgrade.Text = "C";
            }
            else if (sum >= 50 && sum <= 59)
            {

                txtgrade.Text = "D";
            }
            else if (sum >= 0 && sum <= 49)
            {

                txtgrade.Text = "F";
            }
            else
            {
                MessageBox.Show("Please input score again!!!!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }
    }
}
