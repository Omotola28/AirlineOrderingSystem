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
    public partial class HomePage : Form
    {
        public static String setValueForCategories = "";

        public HomePage()
        {
            InitializeComponent();
        }

        private void button01A_Click(object sender, EventArgs e)
        {
            setValueForCategories = button01A.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button05B_Click(object sender, EventArgs e)
        {
            setValueForCategories = button05B.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button02A_Click(object sender, EventArgs e)
        {
            setValueForCategories = button02A.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button06B_Click(object sender, EventArgs e)
        {
            setValueForCategories = button06B.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button03A_Click(object sender, EventArgs e)
        {
            setValueForCategories = button03A.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button07B_Click(object sender, EventArgs e)
        {
            setValueForCategories = button07B.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button04A_Click(object sender, EventArgs e)
        {
            setValueForCategories = button04A.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button08B_Click(object sender, EventArgs e)
        {
            setValueForCategories = button08B.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button09C_Click(object sender, EventArgs e)
        {
            setValueForCategories = button09C.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button12D_Click(object sender, EventArgs e)
        {
            setValueForCategories = button12D.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button10C_Click(object sender, EventArgs e)
        {
            setValueForCategories = button10C.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button13D_Click(object sender, EventArgs e)
        {
            setValueForCategories = button13D.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button11C_Click(object sender, EventArgs e)
        {
            setValueForCategories = button11C.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button14D_Click(object sender, EventArgs e)
        {
            setValueForCategories = button14D.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button15E_Click(object sender, EventArgs e)
        {
            setValueForCategories = button15E.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button17F_Click(object sender, EventArgs e)
        {
            setValueForCategories = button17F.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button16E_Click(object sender, EventArgs e)
        {
            setValueForCategories = button16E.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void button18F_Click(object sender, EventArgs e)
        {
            setValueForCategories = button18F.Text;
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void nextBtn_Click_1(object sender, EventArgs e)
        {
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)// Same as application exit
        {
            Application.Exit();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            History h = new History();
            h.ShowDialog();
            this.Close();
        }
    }
}
