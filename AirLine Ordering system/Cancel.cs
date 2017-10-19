using System;
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
    public partial class Cancel : Form
    {
        public Cancel()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Confirm c = new Confirm();
            c.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)// Same as yes_click
        {
            Confirm c = new Confirm();
            c.ShowDialog();
        }

        private void no_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)// same as no_click
        {
            this.Close();
        }
    }
}
