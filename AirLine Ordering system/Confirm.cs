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
    public partial class Confirm : Form
    {
        public Confirm()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categories c = new Categories();
            c.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)//Same as click ok 
        {
            this.Hide();
            Categories c = new Categories();
            c.ShowDialog();
        }
    }
}
