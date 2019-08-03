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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("go to program TAX");
            this.Hide();

            VAT v = new VAT();
            v.ShowDialog();

                
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("go to program GRADE");
            this.Hide();

            GRADE g = new GRADE();
            g.ShowDialog();
        }
      

        private void Button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("go to program INTEREST");
            this.Hide();

            INTEREST i = new INTEREST();
            i.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
