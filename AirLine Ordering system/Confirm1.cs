﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine_Ordering_system
{
    public partial class Confirm1 : Form
    {
        public Confirm1()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories c = new Categories();
            c.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)// Same as close btn
        {
            this.Hide();
            Categories c = new Categories();
            c.ShowDialog();
        }
    }
}
