﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int carpim = 1;
            int sayi=Convert.ToInt32(txtSayi.Text);

            for (int i = 1; i <= sayi; i++)
            {
                carpim *= i;
            }
               
            
                
            
            lblCarpim.Text = carpim.ToString();
        }
    }
}
