﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paroimparwf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1R_Click(object sender, EventArgs e)
        {
            int numero;
            numero = Convert.ToInt32(textBox1.Text);
            if (numero % 2 == 0)
            {
                MessageBox.Show("El numero es par");
            }
            else
            {
                MessageBox.Show("El numero es impar");
            }
        }
    }
}
