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
    public partial class Snacks : Form
    {
        private int no; private double total;
        public String item; public String item1; public String item2;
        public String item3;
        private int number = 0; private double cost = 0;
        private int number1 = 0; private double cost1 = 0;
        private int number2 = 0; private double cost2 = 0;
        private int number3; private double cost3;
        Boolean ishidden;
        int panelWidth;
        public Snacks()
        {
            InitializeComponent();
            panelWidth = panel1.Width;
            ishidden = false;
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            FoodItems food = new FoodItems();
            this.Hide();
            food.ShowDialog();
        }

        private void plusBtn1_Click(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3;
            cost = number * 3.0;
            total = cost + cost1 + cost2 + cost3;
            counter1.Text = number.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item = counter1.Text + "x Dominos Crisps     £" + cost.ToString();
            orderList.Text = item;
        }

        private void Dominosplus_Click(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3;
            cost = number * 3.0;
            total = cost + cost1 + cost2 + cost3;
            counter1.Text = number.ToString();
            stotal.Text = total.ToString();
            item = counter1.Text + "x Dominos Crisps     £" + cost.ToString();
            orderList.Text = item;
        }

        private void dominosMinus_Click(object sender, EventArgs e)
        {
            if (number > 0)
            {
                number--;
                no--;
            }
            cost = number * 3.0;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter1.Text = number.ToString();
            stotal.Text = total.ToString();
            item = counter1.Text + "x Dominos Crisps    £" + cost.ToString();
            orderList.Text = item;
        }
        private void minusBtn1_Click(object sender, EventArgs e)
        {
            if (number > 0)
            {
                number--;
                no--;
            }
            cost = number * 3.0;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;
                         
            }
            counter1.Text = number.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item = counter1.Text + "x Dominos Crisps    £" + cost.ToString();
            orderList.Text = item;
        }

        private void plusBtn2_Click(object sender, EventArgs e)
        {

            number1++;
            no = number + number1 + number2 + number3;
            cost1 = number1 * 4.10;
            total = cost + cost1 + cost2 + cost3;
            counter2.Text = number1.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item1= counter2.Text + "x Popcorn Tub     £" + cost1.ToString();
            orderList2.Text = item1;
        }
        private void popcornplus_Click(object sender, EventArgs e)
        {
            number1++;
            no = number + number1 + number2 + number3;
            cost1 = number1 * 4.10;
            total = cost + cost1 + cost2 + cost3;
            counter2.Text = number1.ToString();
            stotal.Text = total.ToString();
            item1 = counter2.Text + "x Popcorn Tub     £" + cost1.ToString();
            orderList2.Text = item1;
        }

        private void popcornminus_Click(object sender, EventArgs e)
        {

            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.10;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter2.Text = number1.ToString();
            stotal.Text = total.ToString();
            item1 = counter2.Text + "x Popcorn Tub    £" + cost1.ToString();
            orderList2.Text = item1;
        }
        private void minusBtn2_Click(object sender, EventArgs e)
        {
            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.10;
              if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter2.Text = number1.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item1= counter2.Text + "x Popcorn Tub    £" + cost1.ToString();
            orderList2.Text = item1;
        }

        private void plusBtn3_Click(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3;
            cost2 = number2 * 3.30;
            total = cost + cost1 + cost2 + cost3;
            counter3.Text = number2.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item2 = counter3.Text + "x Revels  £" + cost2.ToString();
            orderList3.Text = item2;
        }

        private void revelsplus_Click(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3;
            cost2 = number2 * 3.30;
            total = cost + cost1 + cost2 + cost3;
            counter3.Text = number2.ToString();
            stotal.Text = total.ToString();
            item2 = counter3.Text + "x Revels  £" + cost2.ToString();
            orderList3.Text = item2;
        }

        private void revelsminus_Click(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 3.30;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter3.Text = number2.ToString();
            stotal.Text = total.ToString();
            item2 = counter3.Text + "x Revels    £" + cost2.ToString();
            orderList3.Text = item2;
        }

        private void minusBtn3_Click(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 3.30;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter3.Text = number2.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item2 = counter3.Text + "x Revels    £" + cost2.ToString();
            orderList3.Text = item2;
        }

        private void plusBtn4_Click(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3;
            cost3 = number3 * 3.30;
            total = cost + cost1 + cost2 + cost3;
            counter4.Text = number3.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item3 = counter4.Text + "x Skittles £" + cost3.ToString();
            orderList4.Text = item3;
        }

        private void skittlesplus_Click(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3;
            cost3 = number3 * 3.30;
            total = cost + cost1 + cost2 + cost3;
            counter4.Text = number3.ToString();
            stotal.Text = total.ToString();
            item3 = counter4.Text + "x Skittles £" + cost3.ToString();
            orderList4.Text = item3;
        }

        private void skittlesminus_Click(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 3.30;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter4.Text = number3.ToString();
            stotal.Text = total.ToString();
            item3 = counter4.Text + "x Skittles    £" + cost3.ToString();
            orderList4.Text = item3;
        }

        private void minusBtn4_Click(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 3.30;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3;

            }
            counter4.Text = number3.ToString();
            stopNumber.Text = no.ToString();
            stotal.Text = total.ToString();
            item3 = counter4.Text + "x Skittles    £" + cost3.ToString();
            orderList4.Text = item3;
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                stopNumber.Text = no.ToString();
                lineShape6.Visible = true;

            }
            else
            {

                stopNumber.Text = "Total:";
                stotal.Text = total.ToString();
                lineShape6.Visible = false;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ishidden)
            {
                panel1.Width = panel1.Width - 650;
                if (panel1.Width <= panelWidth)
                {
                    timer1.Stop();
                    ishidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width + 650;
                if (panel1.Width >= 0)
                {
                    timer1.Stop();
                    ishidden = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                stopNumber.Text = no.ToString();
                lineShape6.Visible = true;

            }
            else
            {

                stopNumber.Text = "Total:";
                stotal.Text = total.ToString();
                lineShape6.Visible = false;


            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                stopNumber.Text = no.ToString();
                lineShape6.Visible = true;

            }
            else
            {

                stopNumber.Text = "Total:";
                stotal.Text = total.ToString();
                lineShape6.Visible = false;
            }
        }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            Confirm1 c = new Confirm1();
            c.ShowDialog();
            this.Hide();
        }

        private void cancelOrder_Click(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.ShowDialog();
        }
    }
}
