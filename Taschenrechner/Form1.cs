﻿using System;
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
    public partial class Form1 : Form
    {

        double zahl1;
        double zahl2;
        double ergebnis;

        public Form1()
        {
            InitializeComponent();


        }

        private void btngleich_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(txtbZahl1.Text);
            zahl2 = Convert.ToDouble(txtbZahl2.Text);
            if (listbOperationen.SelectedItems.Count > 0)
            {
                if (listbOperationen.SelectedItem.ToString() == "+")
                {
                    ergebnis = zahl1 + zahl2;
                   
                }
                if (listbOperationen.SelectedItem.ToString() == "-")
                {
                    ergebnis = zahl1 - zahl2;
                }
                if (listbOperationen.SelectedItem.ToString() == "*")
                {
                    ergebnis = zahl1 * zahl2;
                }
                if (listbOperationen.SelectedItem.ToString() == ":")
                {
                    ergebnis = zahl1 / zahl2;
                }
                txtbergebnis.Text = ergebnis.ToString();


            }
            else
            {
               
            }



        }



        private void btnkomma_Click(object sender, EventArgs e)
        {

        }
        private void btn0_Click(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }
        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {

        }
        private void btn5_Click(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {

        }
        private void btn7_Click(object sender, EventArgs e)
        {

        }

        private void btn8_Click(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {

        }















    }
}
