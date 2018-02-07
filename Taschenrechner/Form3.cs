using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Pythagoras : Form
    {
        double a;
        double b;
        double c;


        public Pythagoras()
        {
            InitializeComponent();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
           
            if (txtb.Text == "" || txtc.Text == "")
            {

            }
            
            else
            {
                b = Convert.ToDouble(txtb.Text);
                c = Convert.ToDouble(txtc.Text);
                a = Math.Sqrt((c * c) - (b * b));
                txtba.Text = a.ToString();
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            
            if (txtb.Text == "" || txtc.Text == "")
            {



            }
            else
            {
                a = Convert.ToDouble(txtba.Text);
                c = Convert.ToDouble(txtc.Text);
                b = Math.Sqrt((c * c) - (a * a));
                txtb.Text = b.ToString();
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            
            if (txtb.Text == "" || txtba.Text == "")
            {

            }

            else
            {
                b = Convert.ToDouble(txtb.Text);
                a = Convert.ToDouble(txtba.Text);
                c = Math.Sqrt((a * a) + (b * b));
                txtc.Text = c.ToString();
            }
        }
        private void Form3_Clear_Click(object sender, EventArgs e)
        {
            txtba.Text = "";
            txtb.Text = ""; 
            txtc.Text = "";
        }
    }
}

