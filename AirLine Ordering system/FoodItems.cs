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
    public partial class FoodItems : Form
    {
        private int no; private double total;
        public String item; public String item2; public String item3;
        public String item4; public String item5; public String item6; public String item7;
        public String item8; public String item9; public String item10;
        private int number = 0; private double cost = 0;
        private int number1 = 0; private double cost1 = 0;
        private int number2 = 0; private double cost2 = 0;
        private int number3; private double cost3;
        private int number4; private double cost4;
        private int number5; private double cost5;
        private int number6; private double cost6;
        private int number7; private double cost7;
        private int number8; private double cost8;
        private int number9; private double cost9;
        int panelWidth;
        Boolean ishidden;
        public FoodItems()
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
            drinksPanel.Visible = true;
        }

        private void plusBtn1_Click(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost = number * 2.5;
            total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter1.Text = number.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item = counter1.Text + "x Potted Shrimps    £" + cost.ToString();
            orderList.Text = item;
        }

        private void pottedplus_Click(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost = number * 2.5;
            total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter1.Text = number.ToString();
            total1.Text = total.ToString();
            item = counter1.Text + "x Potted Shrimps    £" + cost.ToString();
            orderList.Text = item;
        }

        private void pottedMinus_Click(object sender, EventArgs e)
        {
            if (number > 0)
            {
                number--;
                no--;
            }
            cost = number * 2.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter1.Text = number.ToString();
            total1.Text = total.ToString();
            item = counter1.Text + "x Potted Shrimps     £" + cost.ToString();
            orderList.Text = item;
        }

        private void minusBtn1_Click(object sender, EventArgs e)
        {
            if (number > 0)
            {
                number--;
                no--;
            }
            cost = number * 2.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter1.Text = number.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item = counter1.Text + "x Potted Shrimps     £" + cost.ToString();
            orderList.Text = item;
        }

        private void plusBtn2_Click(object sender, EventArgs e)
        {
            number1++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost1 = number1 * 4.0;
            total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter2.Text = number1.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item2 = counter2.Text + "x Native Oysters    £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void oysterplus_Click(object sender, EventArgs e)
        {
            number1++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost1 = number1 * 4.0;
            total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter2.Text = number1.ToString();
            total1.Text = total.ToString();
            item2 = counter2.Text + "x Native Oysters    £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void oysterminus_Click(object sender, EventArgs e)
        {
            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.0;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter2.Text = number1.ToString();
            total1.Text = total.ToString();
            item2 = counter1.Text + "x Native Oysters     £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void minusBtn2_Click(object sender, EventArgs e)
        {
            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.0;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter2.Text = number1.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item2 = counter1.Text + "x Native Oysters     £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void plusBtn3_Click(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost2 = number2 * 4.5;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter3.Text = number2.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item3 = counter3.Text + "x Grilled Chorizo    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void grilledplus_Click(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost2 = number2 * 4.5;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter3.Text = number2.ToString();
            total1.Text = total.ToString();
            item3 = counter3.Text + "x Grilled Chorizo    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void grilledminus_Click(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 4.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter3.Text = number2.ToString();
            total1.Text = total.ToString();
            item3 = counter3.Text + "x Grilled Chorizo     £" + cost2.ToString();
            orderList3.Text = item3;
        }
        private void minusBtn3_Click(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 4.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter3.Text = number2.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item3 = counter3.Text + "x Grilled Chorizo     £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void plusBtn4_Click(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost3 = number3 * 4.5;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter4.Text = number3.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item4 = counter4.Text + "x Chicken Wings    £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void chickenplus_Click(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost3 = number3 * 4.5;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter4.Text = number3.ToString();
            total1.Text = total.ToString();
            item4 = counter4.Text + "x Chicken Wings    £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void chickenminus_Click(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 4.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter4.Text = number3.ToString();
            total1.Text = total.ToString();
            item4 = counter4.Text + "x Chicken Wings     £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void minusBtn4_Click(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 4.5;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter4.Text = number3.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item4 = counter4.Text + "x Chicken Wings     £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void plusBtn5_Click(object sender, EventArgs e)
        {
            number4++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost4 = number4 * 14.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter5.Text = number4.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item5 = counter5.Text + "x Mega Wings    £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void megaplus_Click(object sender, EventArgs e)
        {
            number4++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost4 = number4 * 14.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter5.Text = number4.ToString();
            total1.Text = total.ToString();
            item5 = counter5.Text + "x Mega Wings    £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void megaminus_Click(object sender, EventArgs e)
        {
            if (number4 > 0)
            {
                number4--;
                no--;
            }
            cost4 = number4 * 14.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter5.Text = number4.ToString();
            total1.Text = total.ToString();
            item5 = counter5.Text + "x Mega Ribs     £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void minusBtn5_Click(object sender, EventArgs e)
        {
            if (number4 > 0)
            {
                number4--;
                no--;
            }
            cost4 = number4 * 14.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter5.Text = number4.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item5 = counter5.Text + "x Mega Ribs     £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void plusBtn6_Click(object sender, EventArgs e)
        {
            number5++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost5 = number5 * 9.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter6.Text = number5.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item6 = counter6.Text + "x Chorizo Burger    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void chorizoplus_Click(object sender, EventArgs e)
        {
            number5++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost5 = number5 * 9.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter6.Text = number5.ToString();
            total1.Text = total.ToString();
            item6 = counter6.Text + "x Chorizo Burger    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void chorizominus_Click(object sender, EventArgs e)
        {
            if (number5 > 0)
            {
                number5--;
                no--;
            }
            cost5 = number5 * 9.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter6.Text = number5.ToString();
            total1.Text = total.ToString();
            item6 = counter6.Text + "x Chorizo Burger     £" + cost5.ToString();
            orderList6.Text = item6;
        }
        private void minusBtn6_Click(object sender, EventArgs e)
        {

            if (number5 > 0)
            {
                number5--;
                no--;
            }
            cost5 = number5 * 9.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter6.Text = number5.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item6 = counter6.Text + "x Chorizo Burger     £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void plusBtn7_Click(object sender, EventArgs e)
        {
            number6++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost6 = number6 * 12.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter7.Text = number6.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item7 = counter7.Text + "x Rump Steak    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void rampplus_Click(object sender, EventArgs e)
        {
            number6++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost6 = number6 * 12.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter7.Text = number6.ToString();
            total1.Text = total.ToString();
            item7 = counter7.Text + "x Rump Steak    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void rampminus_Click(object sender, EventArgs e)
        {
            if (number6 > 0)
            {
                number6--;
                no--;
            }
            cost6 = number6 * 12.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter7.Text = number6.ToString();
            total1.Text = total.ToString();
            item7 = counter7.Text + "x Rump Steak    £" + cost6.ToString();
            orderList7.Text = item7;
        }
        private void minusBtn7_Click(object sender, EventArgs e)
        {
            if (number6 > 0)
            {
                number6--;
                no--;
            }
            cost6 = number6 * 12.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter7.Text = number6.ToString();
            total1.Text = total.ToString();
            item7 = counter7.Text + "x Rump Steak    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void plusBtn8_Click(object sender, EventArgs e)
        {
            number7++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost7 = number7 * 9.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter8.Text = number7.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item8 = counter8.Text + "x Slow Cook Pork Cheeks   £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void porkplus_Click(object sender, EventArgs e)
        {
            number7++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost7 = number7 * 9.99;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter8.Text = number7.ToString();
            total1.Text = total.ToString();
            item8 = counter8.Text + "x Slow Cook Pork Cheeks   £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void porkminus_Click(object sender, EventArgs e)
        {
            if (number7 > 0)
            {
                number7--;
                no--;
            }
            cost7 = number7 * 9.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter8.Text = number7.ToString();
            total1.Text = total.ToString();
            item8 = counter8.Text + "x Slow Cooked Pork Cheeks     £" + cost7.ToString();
            orderList8.Text = item8;
        }
        private void minusBtn8_Click(object sender, EventArgs e)
        {
            if (number7 > 0)
            {
                number7--;
                no--;
            }
            cost7 = number7 * 9.99;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter8.Text = number7.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item8 = counter8.Text + "x Slow Cooked Pork Cheeks     £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void plusBtn9_Click(object sender, EventArgs e)
        {
            number8++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost8 = number8 * 4.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter9.Text = number8.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item9 = counter9.Text + "x Fruit Salad  £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void saladplus_Click(object sender, EventArgs e)
        {
            number8++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost8 = number8 * 4.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter9.Text = number8.ToString();
            total1.Text = total.ToString();
            item9 = counter9.Text + "x Fruit Salad  £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void saladminus_Click(object sender, EventArgs e)
        {
            if (number8 > 0)
            {
                number8--;
                no--;
            }
            cost8 = number8 * 4.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter9.Text = number8.ToString();
            total1.Text = total.ToString();
            item9 = counter9.Text + "x Fruit Salad     £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void minusBtn9_Click(object sender, EventArgs e)
        {
            if (number8 > 0)
            {
                number8--;
                no--;
            }
            cost8 = number8 * 4.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter9.Text = number8.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item9 = counter9.Text + "x Fruit Salad     £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void plusBtn10_Click(object sender, EventArgs e)
        {
            number9++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost9 = number9 * 4.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter10.Text = number9.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item10 = counter10.Text + "x Velvet cake  £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void cakeplus_Click(object sender, EventArgs e)
        {
            number9++;
            no = number + number1 + number2 + number3 + number4
                + number5 + number6 + number7 + number8 + number9;
            cost9 = number9 * 4.49;
            total = cost + +cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            counter10.Text = number9.ToString();
            total1.Text = total.ToString();
            item10 = counter10.Text + "x Velvet cake  £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void cakeminus_Click(object sender, EventArgs e)
        {
            if (number9 > 0)
            {
                number9--;
                no--;
            }
            cost9 = number9 * 4.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter10.Text = number9.ToString();
            total1.Text = total.ToString();
            item10 = counter10.Text + "x Fruit Salad     £" + cost9.ToString();
            orderList10.Text = item10;
        }
        private void minusBtn10_Click(object sender, EventArgs e)
        {
            if (number9 > 0)
            {
                number9--;
                no--;
            }
            cost9 = number9 * 4.49;
            if (total > 0)
            {
                total = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6
                    + cost7 + cost8 + cost9;
            }
            counter10.Text = number9.ToString();
            topNumber.Text = no.ToString();
            total1.Text = total.ToString();
            item10 = counter10.Text + "x Fruit Salad     £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void basketBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


            }

        }

        private void snacksForward_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


            }
        }
        private void basketBtn2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


            }
        }

        private void snacksNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ishidden)
            {
                panel1.Width = panel1.Width - 660;
                if (panel1.Width <= panelWidth)
                {
                    timer1.Stop();
                    ishidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width + 660;
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
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape14.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total1.Text = total.ToString();
                lineShape14.Visible = false;


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

        private void foodNxt_Click(object sender, EventArgs e)
        {
            this.Hide();
            snacksPanel.Visible = true;
        }

        private void snacksBkn_Click(object sender, EventArgs e)
        {
            FoodItems food = new FoodItems();
            food.ShowDialog();
            snacksPanel.Visible = false;
        }

        private void drinksNext_Click(object sender, EventArgs e)
        {
            drinksPanel.Visible = false;
        }

        private void snacksBk_Click(object sender, EventArgs e)
        {
            snacksPanel.Visible = false;
        }
    }
}
