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
    public partial class Categories : Form
    {
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            categoryLabel.Text = HomePage.setValueForCategories;
        }

        private void categoryBk_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)//Same as category back button
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }
        private void drinksBtn_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            this.Hide();
            drinks.ShowDialog();
        }

        private void drinksBtn2_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            this.Hide();
            drinks.ShowDialog();
        }

        private void foodBtn_Click_1(object sender, EventArgs e)
        {
            FoodItems food = new FoodItems();
            this.Hide();
            food.ShowDialog();

        }

        private void foodBtn2_Click(object sender, EventArgs e)
        {
            FoodItems food = new FoodItems();
            this.Hide();
            food.ShowDialog();
        }

        private void snacksBtn_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            this.Hide();
            s.ShowDialog();
        }

        private void snacks2_Click(object sender, EventArgs e)
        {
            Snacks s = new Snacks();
            this.Hide();
            s.ShowDialog();
        }

        private void categoriesNxt_Click(object sender, EventArgs e)
        {
            Drinks drinks = new Drinks();
            this.Hide();
            drinks.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)//Same as category next button
        {
            Drinks drinks = new Drinks();
            this.Hide();
            drinks.ShowDialog();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help h = new Help();
            h.ShowDialog();
        }
    }
}
