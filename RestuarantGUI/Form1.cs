﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestuarantGUI
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (Chicken.Checked)
            {

            }
        }

        private void Rice_CheckedChanged(object sender, EventArgs e)
        {
            if (Rice.Checked)
                MessageBox.Show("RICE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
