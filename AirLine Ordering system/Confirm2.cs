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
    public partial class Confirm2 : Form
    {
        public Confirm2()
        {
            InitializeComponent();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            Confirm1 c = new Confirm1();
            c.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Confirm1 c = new Confirm1();
            c.ShowDialog();
        }

        private void confirm2No_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)// Same as confirm no
        {
            this.Close();

        }
    }
}
