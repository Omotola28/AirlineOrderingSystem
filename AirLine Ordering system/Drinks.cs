using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AirLine_Ordering_system
{
    public partial class Drinks : Form
    {
        public int number = 0; public  int no = 0;
        public double cost = 0; public double total1 = 0;
        private int number1 = 0; public String item; public String item2; public String item3;
        public String item4; public String item5; public String item6; public String item7;
        public String item8; public String item9; public String item10; String item11;
        String item12; String item13; String item14; String item15; String item16;
        String item17; String item18; String item19; String item20; String item21;
        String item22; String item23; String item24;
        public double cost1 = 0; public int number2 = 0; public double cost2 = 0;
        public int number3; public double cost3;
        public int number4; public double cost4;
        public int number5; public double cost5;
        public int number6; public double cost6;
        public int number7; public double cost7;
        public int number8; public double cost8;
        public int number9; public double cost9;
        public int number10; public double cost10;
        public int number11; public double cost11;
        public int number12; public double cost12;
        public int number13; public double cost13;
        public int number14; public double cost14;
        public int number15; public double cost15;
        public int number16; public double cost16;
        public int number17; public double cost17;
        public int number18; public double cost18;
        public int number19; public double cost19;
        public int number20; public double cost20;
        public int number21; public double cost21;
        public int number22; public double cost22;
        public int number23; public double cost23;
        public int number24; public double cost24;

        List<Panel> listPanel = new List<Panel>();
        int panelWidth;
        Boolean ishidden;

        public Drinks()
        {
            InitializeComponent();
            panelWidth = panel1.Width;
            ishidden = false;
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            this.Hide();
            category.ShowDialog();
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3+ number4 + number5 + 
                number6 + number7 + number8 + number9 + number10 +number11 + number12
                +number13 + number14 + number15 + number16 + number17
                +number18 + number19 + number20 + number21 + number22 + number23
                +number24;
            cost = number * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7 
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 +cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter1.Text = number.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item = counter1.Text + "x Hieneken    £" + cost.ToString();
            orderList.Text = item;

        }

        private void HeinekenBtn_Click_1(object sender, EventArgs e)
        {
            number++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 + number12
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost = number * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter1.Text = number.ToString();
            total.Text = total1.ToString();
            item = counter1.Text + "x Hieneken    £" + cost.ToString();
            orderList.Text = item;
        }

        private void HienekenMinus_Click_1(object sender, EventArgs e)
        {
            if (number > 0)
            {
                number--;
                no--;
            }
            cost = number * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter1.Text = number.ToString();
            total.Text = total1.ToString();
            item = counter1.Text + "x Hieneken    £" + cost.ToString();
            orderList.Text = item;
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            if(number > 0)
            {
                number--;
                no--;
            }
            cost = number * 4.5;
            if(total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }     
            counter1.Text = number.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item = counter1.Text + "x Hieneken    £" + cost.ToString();
            orderList.Text = item;

        }


        private void plusBtn1_Click(object sender, EventArgs e)
        {
            number1++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 + number12
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost1 = number1 * 4.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter2.Text = number1.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item2 = counter2.Text + "x Desparados    £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void desplus_Click_1(object sender, EventArgs e)
        {
            number1++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost1 = number1 * 4.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter2.Text = number1.ToString();
            total.Text = total1.ToString();
            item2 = counter2.Text + "x Desparados    £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void desminus_Click_1(object sender, EventArgs e)
        {
            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter2.Text = number1.ToString();
            total.Text = total1.ToString();
            item2 = counter2.Text + "x Desparados    £" + cost1.ToString();
            orderList2.Text = item2;
        }

        private void minusBtn1_Click(object sender, EventArgs e)
        {
            if (number1 > 0)
            {
                number1--;
                no--;
            }
            cost1 = number1 * 4.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter2.Text = number1.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item2 = counter2.Text + "x Desparados    £" + cost1.ToString();
            orderList2.Text = item2;
        }
 
        private void plusBtn2_Click(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost2 = number2 * 5.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter3.Text = number2.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item3 = counter3.Text + "x Bulmers    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void bplus_Click_1(object sender, EventArgs e)
        {
            number2++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 + number12
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost2 = number2 * 5.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter3.Text = number2.ToString();
            total.Text = total1.ToString();
            item3 = counter3.Text + "x Bulmers    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void bminus_Click_1(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 5.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter3.Text = number2.ToString();
            total.Text = total1.ToString();
            item3 = counter3.Text + "x Bulmers    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void minusBtn2_Click(object sender, EventArgs e)
        {
            if (number2 > 0)
            {
                number2--;
                no--;
            }
            cost2 = number2 * 5.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter3.Text = number2.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item3 = counter3.Text + "x Bulmers    £" + cost2.ToString();
            orderList3.Text = item3;
        }

        private void plusBtn3_Click(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost3 = number3 * 4.50;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter4.Text = number3.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item4 = counter4.Text + "x Tiger    £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void tigersplus_Click_1(object sender, EventArgs e)
        {
            number3++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost3 = number3 * 4.50;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter4.Text = number3.ToString();
            total.Text = total1.ToString();
            item4 = counter4.Text + "x Tiger    £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void tigerminus_Click_1(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter4.Text = number3.ToString();
            total.Text = total1.ToString();
            item4 = counter4.Text + "x Tiger    £" + cost3.ToString();
            orderList4.Text = item4;
        }
      
        private void minusBtn3_Click(object sender, EventArgs e)
        {
            if (number3 > 0)
            {
                number3--;
                no--;
            }
            cost3 = number3 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter4.Text = number3.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item4 = counter4.Text + "x Tiger    £" + cost3.ToString();
            orderList4.Text = item4;
        }

        private void plusBtn4_Click(object sender, EventArgs e)
        {
            number4++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost4 = number4 * 19.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter5.Text = number4.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item5 = counter5.Text + "x Pinot Grigio    £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void pgplus_Click_1(object sender, EventArgs e)
        {
            number4++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost4 = number4 * 19.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter5.Text = number4.ToString();
            total.Text = total1.ToString();
            item5 = counter5.Text + "x Pinot Grigio    £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void pgminus_Click_1(object sender, EventArgs e)
        {
            if (number4 > 0)
            {
                number4--;
                no--;
            }
            cost4 = number4 * 19.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter5.Text = number4.ToString();
            total.Text = total1.ToString();
            item5 = counter5.Text + "x Pinot Grigio    £" + cost4.ToString();
            orderList5.Text = item5;
        }
      
        private void minusBtn4_Click(object sender, EventArgs e)
        {
            if (number4 > 0)
            {
                number4--;
                no--;
            }
            cost4 = number4 * 19.0; 
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter5.Text = number4.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item5 = counter5.Text + "x Pinot Grigio    £" + cost4.ToString();
            orderList5.Text = item5;
        }

        private void plusBtn5_Click(object sender, EventArgs e)
        {
            number5++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost5 = number5 * 20.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter6.Text = number5.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item6 = counter6.Text + "x Sauvignon Blanc    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void sbplus_Click_1(object sender, EventArgs e)
        {
            number5++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost5 = number5 * 20.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter6.Text = number5.ToString();
            total.Text = total1.ToString();
            item6 = counter6.Text + "x Sauvignon Blanc    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void sbminus_Click_1(object sender, EventArgs e)
        {
            if (number5 > 0)
            {
                number5--;
                no--;
            }
            cost5 = number5 * 20.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter6.Text = number5.ToString();
            total.Text = total1.ToString();
            item6 = counter6.Text + "x Sauvignon Blanc    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void minusBtn5_Click(object sender, EventArgs e)
        {
            if (number5 > 0)
            {
                number5--;
                no--;
            }
            cost5 = number5 * 20.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter6.Text = number5.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item6 = counter6.Text + "x Sauvignon Blanc    £" + cost5.ToString();
            orderList6.Text = item6;
        }

        private void plusBtn6_Click(object sender, EventArgs e)
        {
            number6++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost6 = number6 * 20.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter7.Text = number6.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item7 = counter7.Text + "x Zinfindel    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void zinplus_Click_1(object sender, EventArgs e)
        {
            number6++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost6 = number6 * 20.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter7.Text = number6.ToString();
            total.Text = total1.ToString();
            item7 = counter7.Text + "x Zinfindel    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void zinminus_Click_1(object sender, EventArgs e)
        {
            if (number6 > 0)
            {
                number6--;
                no--;
            }
            cost6 = number6 * 20.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter7.Text = number6.ToString();
            total.Text = total1.ToString();
            item7 = counter7.Text + "x Zinfindel    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void minusBtn6_Click(object sender, EventArgs e)
        {
            if (number6 > 0)
            {
                number6--;
                no--;
            }
            cost6 = number6 * 20.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter7.Text = number6.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item7 = counter7.Text + "x Zinfindel    £" + cost6.ToString();
            orderList7.Text = item7;
        }

        private void plusBtn7_Click(object sender, EventArgs e)
        {
            number7++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost7 = number7 * 21.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter8.Text = number7.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item8 = counter8.Text + "x Merlot    £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void merlotplus_Click_1(object sender, EventArgs e)
        {
            number7++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 + number12
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost7 = number7 * 21.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter8.Text = number7.ToString();
            total.Text = total1.ToString();
            item8 = counter8.Text + "x Merlot    £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void merlotminus_Click_1(object sender, EventArgs e)
        {
            if (number7 > 0)
            {
                number7--;
                no--;
            }
            cost7 = number7 * 21.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter8.Text = number7.ToString();
            total.Text = total1.ToString();
            item8 = counter8.Text + "x Merlot    £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void minusBtn7_Click(object sender, EventArgs e)
        {
             if (number7 > 0)
            {
                number7--;
                no--;
            }
            cost7 = number7 * 21.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter8.Text = number7.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item8 = counter8.Text + "x Merlot    £" + cost7.ToString();
            orderList8.Text = item8;
        }

        private void plusBtn8_Click(object sender, EventArgs e)
        {
            number8++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 + number12
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost8 = number8 * 2.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter9.Text = number8.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item9 = counter9.Text + "x Still Water    £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void waterplus_Click_1(object sender, EventArgs e)
        {
            number8++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost8 = number8 * 2.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter9.Text = number8.ToString();
            total.Text = total1.ToString();
            item9 = counter9.Text + "x Still Water    £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void waterminus_Click_1(object sender, EventArgs e)
        {
            if (number8 > 0)
            {
                number8--;
                no--;
            }
            cost8 = number8 * 2.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter9.Text = number8.ToString();
            total.Text = total1.ToString();
            item9 = counter9.Text + "x Still Water    £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void minusBtn8_Click(object sender, EventArgs e)
        {
            if (number8 > 0)
            {
                number8--;
                no--;
            }
            cost8 = number8 * 2.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter9.Text = number8.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item9 = counter9.Text + "x Still Water    £" + cost8.ToString();
            orderList9.Text = item9;
        }

        private void plusBtn9_Click(object sender, EventArgs e)
        {
            number9++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost9 = number9 * 2.70;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter10.Text = number9.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item10 = counter10.Text + "x Coka Cola    £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void cokeplus_Click_1(object sender, EventArgs e)
        {
            number9++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 +number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost9 = number9 * 2.70;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter10.Text = number9.ToString();
            total.Text = total1.ToString();
            item10 = counter10.Text + "x Coka Cola    £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void cokeMinus_Click(object sender, EventArgs e)
        {
            if (number9 > 0)
            {
                number9--;
                no--;
            }
            cost9 = number9 * 2.70;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter10.Text = number9.ToString();
            total.Text = total1.ToString();
            item10 = counter10.Text + "x Coka Cola    £" + cost9.ToString();
            orderList10.Text = item10;
        }

        private void minusBtn9_Click(object sender, EventArgs e)
        {
            if (number9 > 0)
            {
                number9--;
                no--;
            }
            cost9 = number9 * 2.70;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter10.Text = number9.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item10 = counter10.Text + "x Coka Cola    £" + cost9.ToString();
            orderList10.Text = item10;
        }

        //FoodItems controls 
        private void pottedPlusBtn_Click(object sender, EventArgs e)
        {
            number10++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost10 = number10 * 2.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter11.Text = number10.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item11 = counter11.Text + "x Potted Shrimps    £" + cost10.ToString();
            orderList11.Text = item11;
        }

        private void shrimpsPlus_Click_1(object sender, EventArgs e)
        {
            number10++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost10 = number10 * 2.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter11.Text = number10.ToString();
            total.Text = total1.ToString();
            item11 = counter11.Text + "x Potted Shrimps    £" + cost10.ToString();
            orderList11.Text = item11;
        }

        private void shrimpsMinus_Click(object sender, EventArgs e)
        {
            if (number10 > 0)
            {
                number10--;
                no--;
            }
            cost10 = number10 * 2.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter11.Text = number10.ToString();
            total.Text = total1.ToString();
            item11 = counter11.Text + "x Potted Shrimps     £" + cost10.ToString();
            orderList11.Text = item11;
        }

        private void pottedMinusBtn_Click(object sender, EventArgs e)
        {
            if (number10 > 0)
            {
                number10--;
                no--;
            }
            cost10 = number10 * 2.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter11.Text = number10.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item11 = counter11.Text + "x Potted Shrimps     £" + cost10.ToString();
            orderList11.Text = item11;
        }

        private void nativePlus_Click(object sender, EventArgs e)
        {
            number11++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11+ number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost11 = number11 * 4.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter12.Text = number11.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item12 = counter12.Text + "x Native Oysters    £" + cost11.ToString();
            orderList12.Text = item12;
        }

        private void oysterplus_Click_1(object sender, EventArgs e)
        {
            number11++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11 + number12
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost11 = number11 * 4.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter12.Text = number11.ToString();
            total.Text = total1.ToString();
            item12 = counter12.Text + "x Native Oysters    £" + cost11.ToString();
            orderList12.Text = item12;
        }

        private void oysterminus_Click_1(object sender, EventArgs e)
        {
            if (number11 > 0)
            {
                number11--;
                no--;
            }
            cost11 = number11 * 4.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter12.Text = number11.ToString();
            total.Text = total1.ToString();
            item12 = counter12.Text + "x Native Oysters     £" + cost11.ToString();
            orderList12.Text = item12;
        }

        private void nativeMinus_Click(object sender, EventArgs e)
        {
            if (number11 > 0)
            {
                number11--;
                no--;
            }
            cost11 = number11 * 4.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter12.Text = number11.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item12 = counter12.Text + "x Native Oysters     £" + cost11.ToString();
            orderList12.Text = item12;
        }

        private void gplus_Click(object sender, EventArgs e)
        {
            number12++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11 +number12+
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost12 = number12 * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter13.Text = number12.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item13 = counter13.Text + "x Grilled Chorizo    £" + cost12.ToString();
            orderList13.Text = item13;
        }

        private void grilledplus_Click(object sender, EventArgs e)
        {
            number12++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost12 = number12 * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter13.Text = number12.ToString();
            total.Text = total1.ToString();
            item13 = counter13.Text + "x Grilled Chorizo    £" + cost12.ToString();
            orderList13.Text = item13;
        }

        private void grilledminus_Click(object sender, EventArgs e)
        {
            if (number12 > 0)
            {
                number12--;
                no--;
            }
            cost12 = number12 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter13.Text = number12.ToString();
            total.Text = total1.ToString();
            item13 = counter13.Text + "x Grilled Chorizo     £" + cost12.ToString();
            orderList13.Text = item13;
        }

        private void gminus_Click(object sender, EventArgs e)
        {
            if (number12 > 0)
            {
                number12--;
                no--;
            }
            cost12 = number12 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter13.Text = number12.ToString();
            topNumber.Text = no.ToString();
            total.Text = total.ToString();
            item13 = counter13.Text + "x Grilled Chorizo     £" + cost12.ToString();
            orderList13.Text = item13;
        }

        private void wingsplus_Click(object sender, EventArgs e)
        {
            number13++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost13 = number13 * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter14.Text = number13.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item14 = counter14.Text + "x Chicken Wings    £" + cost13.ToString();
            orderList14.Text = item14;
        }

        private void chickenplus_Click(object sender, EventArgs e)
        {
            number13++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost13 = number13 * 4.5;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter14.Text = number13.ToString();
            total.Text = total1.ToString();
            item14 = counter14.Text + "x Chicken Wings    £" + cost13.ToString();
            orderList14.Text = item14;
        }

        private void chickenminus_Click(object sender, EventArgs e)
        {
            if (number13 > 0)
            {
                number13--;
                no--;
            }
            cost13 = number13 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter14.Text = number13.ToString();
            total.Text = total1.ToString();
            item14 = counter14.Text + "x Chicken Wings     £" + cost13.ToString();
            orderList14.Text = item14;
        }

        private void wingsMinus_Click(object sender, EventArgs e)
        {
            if (number13 > 0)
            {
                number13--;
                no--;
            }
            cost13 = number13 * 4.5;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter14.Text = number13.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item14 = counter14.Text + "x Chicken Wings     £" + cost13.ToString();
            orderList14.Text = item14;
        }

        private void ribsPlus_Click(object sender, EventArgs e)
        {
            number14++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                 number6 + number7 + number8 + number9 + number10 + number11
                 + number13 + number14 + number15 + number16 + number17
                 + number18 + number19 + number20 + number21 + number22 + number23
                 + number24;
            cost14 = number14 * 14.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter15.Text = number14.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item15 = counter15.Text + "x Mega Wings    £" + cost14.ToString();
            orderList15.Text = item15;
        }

        private void megaplus_Click(object sender, EventArgs e)
        {
            number14++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost14 = number14 * 14.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter15.Text = number14.ToString();
            total.Text = total1.ToString();
            item15 = counter15.Text + "x Mega Wings    £" + cost14.ToString();
            orderList15.Text = item15;
        }

        private void megaminus_Click(object sender, EventArgs e)
        {
            if (number14 > 0)
            {
                number14--;
                no--;
            }
            cost14 = number14 * 14.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter15.Text = number14.ToString();
            total.Text = total1.ToString();
            item15 = counter15.Text + "x Mega Ribs     £" + cost14.ToString();
            orderList15.Text = item15;
        }

        private void ribsMinus_Click(object sender, EventArgs e)
        {
            if (number14 > 0)
            {
                number14--;
                no--;
            }
            cost14 = number14 * 14.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter15.Text = number14.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item15 = counter15.Text + "x Mega Ribs     £" + cost14.ToString();
            orderList15.Text = item15;
        }

        private void burgerPlus_Click(object sender, EventArgs e)
        {
            number15++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost15 = number15 * 9.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter16.Text = number15.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item16 = counter16.Text + "x Chorizo Burger    £" + cost15.ToString();
            orderList16.Text = item16;
        }

        private void chorizoplus_Click(object sender, EventArgs e)
        {
            number15++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost15 = number15 * 9.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            counter16.Text = number15.ToString();
            total.Text = total1.ToString();
            item16 = counter16.Text + "x Chorizo Burger    £" + cost15.ToString();
            orderList16.Text = item16;
        }

        private void chorizominus_Click(object sender, EventArgs e)
        {
            if (number15 > 0)
            {
                number15--;
                no--;
            }
            cost15 = number15 * 9.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter16.Text = number15.ToString();
            total.Text = total1.ToString();
            item16 = counter16.Text + "x Chorizo Burger     £" + cost15.ToString();
            orderList16.Text = item16;
        }

        private void burgerMinus_Click(object sender, EventArgs e)
        {
            if (number15 > 0)
            {
                number15--;
                no--;
            }
            cost15 = number15 * 9.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
                + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
                + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
                + cost24;
            }
            counter16.Text = number15.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item16 = counter16.Text + "x Chorizo Burger     £" + cost15.ToString();
            orderList16.Text = item16;
        }

        private void rPlus_Click(object sender, EventArgs e)
        {
            number16++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost16 = number16 * 12.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter17.Text = number16.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item17 = counter17.Text + "x Rump Steak    £" + cost16.ToString();
            orderList17.Text = item17;
        }

        private void rumpplus_Click(object sender, EventArgs e)
        {
            number16++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost16 = number16 * 12.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter17.Text = number16.ToString();
            total.Text = total1.ToString();
            item17 = counter17.Text + "x Rump Steak    £" + cost16.ToString();
            orderList17.Text = item17;
        }

        private void rumpminus_Click(object sender, EventArgs e)
        {
            if (number16 > 0)
            {
                number16--;
                no--;
            }
            cost16 = number16 * 12.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter17.Text = number16.ToString();
            total.Text = total1.ToString();
            item17 = counter17.Text + "x Rump Steak    £" + cost16.ToString();
            orderList17.Text = item17;
        }

        private void rMinus_Click(object sender, EventArgs e)
        {
            if (number16 > 0)
            {
                number16--;
                no--;
            }
            cost16 = number16 * 12.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter17.Text = number16.ToString();
            total.Text = total1.ToString();
            item17 = counter17.Text + "x Rump Steak    £" + cost16.ToString();
            orderList17.Text = item17;
        }

        private void cheeksPlus_Click(object sender, EventArgs e)
        {
            number17++;
            no = number + number1 + number2 + number3 + number4 + number5 +
                number6 + number7 + number8 + number9 + number10 + number11
                + number13 + number14 + number15 + number16 + number17
                + number18 + number19 + number20 + number21 + number22 + number23
                + number24;
            cost17 = number17 * 9.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            counter18.Text = number17.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item18 = counter18.Text + "x Slow Cook Pork Cheeks   £" + cost17.ToString();
            orderList18.Text = item18;
        }

        private void porkplus_Click(object sender, EventArgs e)
        {
            number17++;
            no = number + number1 + number2 + number3 + number4 + number5 +
               number6 + number7 + number8 + number9 + number10 + number11
               + number13 + number14 + number15 + number16 + number17
               + number18 + number19 + number20 + number21 + number22 + number23
               + number24;
            cost17 = number17 * 9.99;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            counter18.Text = number17.ToString();
            total.Text = total1.ToString();
            item18 = counter18.Text + "x Slow Cook Pork Cheeks   £" + cost17.ToString();
            orderList18.Text = item18;
        }

        private void porkminus_Click(object sender, EventArgs e)
        {
            if (number17 > 0)
            {
                number17--;
                no--;
            }
            cost17 = number17 * 9.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
               + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
               + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
               + cost24;
            }
            counter18.Text = number17.ToString();
            total.Text = total1.ToString();
            item18 = counter18.Text + "x Slow Cooked Pork Cheeks     £" + cost17.ToString();
            orderList18.Text = item18;
        }

        private void cheeksMinus_Click(object sender, EventArgs e)
        {
            if (number17 > 0)
            {
                number17--;
                no--;
            }
            cost17 = number17 * 9.99;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            }
            counter18.Text = number17.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item18 = counter18.Text + "x Slow Cooked Pork Cheeks     £" + cost17.ToString();
            orderList18.Text = item18;
        }

        private void sPlus_Click(object sender, EventArgs e)
        {
            number18++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost18 = number18 * 4.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter19.Text = number18.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item19 = counter19.Text + "x Fruit Salad  £" + cost18.ToString();
            orderList19.Text = item19;
        }

        private void saladplus_Click(object sender, EventArgs e)
        {
            number18++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost18 = number18 * 4.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter19.Text = number18.ToString();
            total.Text = total1.ToString();
            item19 = counter19.Text + "x Fruit Salad  £" + cost18.ToString();
            orderList19.Text = item19;
        }

        private void saladminus_Click(object sender, EventArgs e)
        {
            if (number18 > 0)
            {
                number18--;
                no--;
            }
            cost18 = number18 * 4.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            }
            counter19.Text = number18.ToString();
            total.Text = total1.ToString();
            item19 = counter19.Text + "x Fruit Salad     £" + cost18.ToString();
            orderList19.Text = item19;
        }

        private void sMinus_Click(object sender, EventArgs e)
        {
            if (number18 > 0)
            {
                number18--;
                no--;
            }
            cost18 = number18 * 4.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            }
            counter19.Text = number18.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item19 = counter19.Text + "x Fruit Salad     £" + cost18.ToString();
            orderList19.Text = item19;
        }

        private void velPlus_Click(object sender, EventArgs e)
        {
            number19++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost19 = number19 * 4.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            counter20.Text = number19.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item20 = counter20.Text + "x Velvet cake  £" + cost19.ToString();
            orderList20.Text = item20;
        }

        private void cakeplus_Click(object sender, EventArgs e)
        {
            number19++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost19 = number19 * 4.49;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter20.Text = number19.ToString();
            total.Text = total1.ToString();
            item20 = counter20.Text + "x Velvet cake  £" + cost19.ToString();
            orderList20.Text = item20;
        }

        private void cakeminus_Click(object sender, EventArgs e)
        {
            if (number19 > 0)
            {
                number19--;
                no--;
            }
            cost19 = number19 * 4.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            }
            counter20.Text = number19.ToString();
            total.Text = total1.ToString();
            item20 = counter20.Text + "x Fruit Salad     £" + cost19.ToString();
            orderList20.Text = item20;
        }
        private void velMinus_Click(object sender, EventArgs e)
        {
            if (number19 > 0)
            {
                number19--;
                no--;
            }
            cost19 = number19 * 4.49;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            }
            counter20.Text = number19.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item20 = counter20.Text + "x Fruit Salad     £" + cost19.ToString();
            orderList20.Text = item20;
        }

        //Snacks Controls
        private void dPlus_Click(object sender, EventArgs e)
        {
            number20++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost20 = number20 * 3.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter21.Text = number20.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item21 = counter21.Text + "x Dominos Crisps     £" + cost20.ToString();
            orderList21.Text = item21;
        }

        private void crispsPlus_Click(object sender, EventArgs e)
        {
            number20++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost20 = number20 * 3.0;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            counter21.Text = number20.ToString();
            total.Text = total1.ToString();
            item21 = counter21.Text + "x Dominos Crisps     £" + cost20.ToString();
            orderList21.Text = item21;
        }

        private void crispsMinus_Click(object sender, EventArgs e)
        {
            if (number20 > 0)
            {
                number20--;
                no--;
            }
            cost20 = number20 * 3.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;

            }
            counter21.Text = number20.ToString();
            total.Text = total1.ToString();
            item21 = counter21.Text + "x Dominos Crisps    £" + cost20.ToString();
            orderList21.Text = item21;
        }

        private void dMinus_Click(object sender, EventArgs e)
        {
            if (number20 > 0)
            {
                number20--;
                no--;
            }
            cost20 = number20 * 3.0;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;

            }
            counter21.Text = number20.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item21 = counter21.Text + "x Dominos Crisps    £" + cost20.ToString();
            orderList21.Text = item21;
        }

        private void popPlus_Click(object sender, EventArgs e)
        {
            number21++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost21 = number21 * 4.10;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;

            counter22.Text = number21.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item22 = counter22.Text + "x Popcorn Tub     £" + cost21.ToString();
            orderList22.Text = item21;
        }

        private void tubPlus_Click(object sender, EventArgs e)
        {
            number21++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost21 = number21 * 4.10;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter22.Text = number21.ToString();
            total.Text = total1.ToString();
            item22 = counter22.Text + "x Popcorn Tub     £" + cost21.ToString();
            orderList22.Text = item22;
        }

        private void tubMinus_Click(object sender, EventArgs e)
        {
            if (number21 > 0)
            {
                number21--;
                no--;
            }
            cost21 = number21 * 4.10;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;

            }
            counter22.Text = number21.ToString();
            total.Text = total1.ToString();
            item22 = counter22.Text + "x Popcorn Tub    £" + cost21.ToString();
            orderList22.Text = item22;
        }

        private void popMinus_Click(object sender, EventArgs e)
        {
            if (number21 > 0)
            {
                number21--;
                no--;
            }
            cost21 = number21 * 4.10;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;

            }
            counter22.Text = number21.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item22 = counter22.Text + "x Popcorn Tub    £" + cost21.ToString();
            orderList22.Text = item22;
        }

        private void revelPlus_Click(object sender, EventArgs e)
        {
            number22++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost22 = number22 * 3.30;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter23.Text = number22.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item23 = counter23.Text + "x Revels  £" + cost22.ToString();
            orderList23.Text = item23;
        }

        private void revPlus_Click(object sender, EventArgs e)
        {
            number22++;
            no = number + number1 + number2 + number3 + number4 + number5 +
              number6 + number7 + number8 + number9 + number10 + number11
              + number13 + number14 + number15 + number16 + number17
              + number18 + number19 + number20 + number21 + number22 + number23
              + number24;
            cost22 = number22 * 3.30;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            counter23.Text = number22.ToString();
            total.Text = total1.ToString();
            item23 = counter23.Text + "x Revels  £" + cost22.ToString();
            orderList23.Text = item23;
        }

        private void revMinus_Click(object sender, EventArgs e)
        {
            if (number22 > 0)
            {
                number22--;
                no--;
            }
            cost22 = number22 * 3.30;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
              + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
              + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
              + cost24;
            }
            counter23.Text = number22.ToString();
            total.Text = total1.ToString();
            item23 = counter23.Text + "x Revels    £" + cost22.ToString();
            orderList23.Text = item23;
        }

        private void revelMinus_Click(object sender, EventArgs e)
        {
            if (number22 > 0)
            {
                number22--;
                no--;
            }
            cost22 = number22 * 3.30;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;
            }
            counter23.Text = number22.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item23 = counter23.Text + "x Revels    £" + cost2.ToString();
            orderList23.Text = item23;
        }

        private void skittlesPlus_Click(object sender, EventArgs e)
        {
            number23++;
            no = number + number1 + number2 + number3 + number4 + number5 +
             number6 + number7 + number8 + number9 + number10 + number11
             + number13 + number14 + number15 + number16 + number17
             + number18 + number19 + number20 + number21 + number22 + number23;
            cost23 = number23 * 3.30;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23;
            counter24.Text = number23.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item24 = counter24.Text + "x Skittles £" + cost23.ToString();
            orderList24.Text = item24;
        }

        private void skiPlus_Click(object sender, EventArgs e)
        {
            number23++;
            no = number + number1 + number2 + number3 + number4 + number5 +
             number6 + number7 + number8 + number9 + number10 + number11
             + number13 + number14 + number15 + number16 + number17
             + number18 + number19 + number20 + number21 + number22 + number23;
            cost23 = number23 * 3.30;
            total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23;
            counter24.Text = number23.ToString();
            total.Text = total1.ToString();
            item24 = counter24.Text + "x Skittles £" + cost23.ToString();
            orderList24.Text = item24;
        }

        private void skiMinus_Click(object sender, EventArgs e)
        {
            if (number23 > 0)
            {
                number23--;
                no--;
            }
            cost23 = number23 * 3.30;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;

            }
            counter24.Text = number23.ToString();
            total.Text = total1.ToString();
            item24 = counter24.Text + "x Skittles    £" + cost23.ToString();
            orderList24.Text = item24;
        }

        private void skittlesMinus_Click(object sender, EventArgs e)
        {
            if (number23 > 0)
            {
                number23--;
                no--;
            }
            cost23 = number23 * 3.30;
            if (total1 > 0)
            {
                total1 = cost + cost1 + cost2 + cost3 + cost4 + cost5 + cost6 + cost7
             + cost8 + cost9 + cost10 + cost11 + cost12 + cost13 + cost14 + cost15
             + cost16 + cost17 + cost18 + cost19 + cost20 + cost21 + cost22 + cost23
             + cost24;

            }
            counter24.Text = number23.ToString();
            topNumber.Text = no.ToString();
            total.Text = total1.ToString();
            item24 = counter24.Text + "x Skittles    £" + cost23.ToString();
            orderList24.Text = item24;
        }

        //Buttons control that do not concern listed menu
        public void basketBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if(ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;
                
            } 
            else
            {
                
                topNumber.Text = "Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void baskBtn2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = " Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void basketBtn3_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = " Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void snacksNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = " Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void label22_Click(object sender, EventArgs e)// Same as snacks next button
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = " Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = " Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(ishidden)
            {
                panel1.Width = panel1.Width  - 650;
                if(panel1.Width <= panelWidth)
                {
                    timer1.Stop();
                    ishidden = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width + 650;
                if(panel1.Width >= 0)
                {
                    timer1.Stop();
                    ishidden = true;
                    this.Refresh();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

            timer1.Start();
            if (ishidden)
            {
                topNumber.Text = no.ToString();
                lineShape2.Visible = true;

            }
            else
            {

                topNumber.Text = "Total:";
                total.Text = total1.ToString();
                lineShape2.Visible = false;
            }
            }

        private void confirmOrder_Click(object sender, EventArgs e)
        {
            Confirm2 c = new Confirm2();
            c.ShowDialog();
        }


        private void label45_Click(object sender, EventArgs e)// Same as confirm order
        {
            Confirm2 c = new Confirm2();
            c.ShowDialog();
        }

        private void cancelOrder_Click_1(object sender, EventArgs e)
        {
            Cancel c = new Cancel();
            c.ShowDialog();
        }

        private void label46_Click(object sender, EventArgs e)//Same as cancel above 
        {
            Cancel c = new Cancel();
            c.ShowDialog();
        }
        private void fpreviousBtn_Click(object sender, EventArgs e)
        {
            foodPanel.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {
            foodPanel.Visible = false;
        }

        private void drinksNextBtn_Click_1(object sender, EventArgs e)
        {
            foodPanel.Visible = true;
        }

        private void label28_Click(object sender, EventArgs e)// Same as drinks btn
        {
            foodPanel.Visible = true;
        }

        private void label28_Click_1(object sender, EventArgs e)
        {
            foodPanel.Visible = true;
        }

        private void snacksBkn_Click(object sender, EventArgs e)
        {
            snacksPanel.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)//Same as snacks back button
        {
            snacksPanel.Visible = false;
        }


        private void label47_Click(object sender, EventArgs e)
        {
            snacksPanel.Visible = false;
        }

        private void fnextBtn_Click(object sender, EventArgs e)
        {
            snacksPanel.Visible = true;
        }


        private void label26_Click(object sender, EventArgs e)//Same as food next button
        {
            snacksPanel.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            this.Hide();
            home.ShowDialog();
        }

        private void foodPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
 