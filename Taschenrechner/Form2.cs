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
    public partial class Form2 : Form
    {
        double eingabe;
        double ergebnis;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            if (txtzahl1.Text == "")
            {
                ///nix machen

            }
            else //sonst (also in txtbZahl1 ist was drin)
            {

                eingabe = Convert.ToDouble(txtzahl1.Text);
                ergebnis = Math.Sqrt(eingabe);
                lblergebnis.Text = ergebnis.ToString();
            }

        }
    }
}
