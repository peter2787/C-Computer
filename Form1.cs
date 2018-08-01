using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer
{
    public partial class Form1 : Form
    {
        Rules R = new Rules();
        int i = 0;
        double Sum = 0;
        double NumberStay = 0;
        double Result = 0;
        string SumString;

        public Form1()
        {
            InitializeComponent();
            LabelSum.Text = "0";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SumString += 1;
            LabelSum.Text = (SumString);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SumString += 2;
            LabelSum.Text = (SumString);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SumString += 3;
            LabelSum.Text = (SumString);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            SumString += 4;
            LabelSum.Text = (SumString);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            SumString += 5;
            LabelSum.Text = (SumString);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            SumString += 6;
            LabelSum.Text = (SumString);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            SumString += 7;
            LabelSum.Text = (SumString);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            SumString += 8;
            LabelSum.Text = (SumString);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            SumString += 9;
            LabelSum.Text = (SumString);
        }
        private void button0_Click(object sender, EventArgs e)
        {
            SumString += 0;
            LabelSum.Text = (SumString);
        }
        private void PointButton_Click_1(object sender, EventArgs e)
        {
            if (Double.Parse(LabelSum.Text)%1 == 0 )
            {
                SumString += ".";
                LabelSum.Text = (SumString);
            }
        }


        private void Plus_Click(object sender, EventArgs e)
        {
            //將現在的字串轉數字
            Sum = Double.Parse(SumString);
            NumberStay = Sum;

            //判斷為加法
            i = 1;
            
            //數字存取器與字串存取器重制
            Sum.ToString("");
            SumString = "";

        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            //將現在的字串轉數字
            Sum = Double.Parse(SumString);
            NumberStay = Sum;

            //判斷為減法
            i = 2;

            //數字存取器與字串存取器重制
            Sum.ToString("");
            SumString = "";
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            //將現在的字串轉數字
            Sum = Double.Parse(SumString);
            NumberStay = Sum;

            //判斷為乘法
            i = 3;

            //數字存取器與字串存取器重制
            Sum.ToString("");
            SumString = "";
        }
        private void DividedButton_Click(object sender, EventArgs e)
        {
            //將現在的字串轉數字
            Sum = Double.Parse(SumString); 
            NumberStay = Sum;

            //判斷為乘法
            i = 4;

            //數字存取器與字串存取器重制
            Sum.ToString("");
            SumString = "";
        }
        private void RemainButton_Click(object sender, EventArgs e)
        {
            //將現在的字串轉數字
            Sum = Double.Parse(SumString);
            NumberStay = Sum;

            //判斷為乘法
            i = 5;

            //數字存取器與字串存取器重制
            Sum.ToString("");
            SumString = "";
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            SumString = "";
            LabelSum.Text = SumString;
            Result = 0;
        }
        private void CE_Click(object sender, EventArgs e)
        {
            SumString = "";
            LabelSum.Text = SumString;
        }


        private void Equals_Click(object sender, EventArgs e)
        {
            Sum = Double.Parse(SumString); 

            switch (i)
            {
                case 1: //加法

                    //開始計算
                    Result = NumberStay + Sum;

                    //印出結果
                    SumString = (""+Result);
                    LabelSum.Text = SumString;

                    //數值重制
                    Sum = 0;
                    NumberStay = 0;
                    
                        break;

                case 2: //減法

                    //開始計算
                    Result = NumberStay - Sum;

                    //印出結果
                    SumString = ("" + Result);
                    LabelSum.Text = SumString;

                    //數值重制
                    Sum = 0;
                    NumberStay = 0;

                    break;

                case 3: //乘法

                    //開始計算
                    Result = NumberStay * Sum;

                    //印出結果
                    SumString = ("" + Result);
                    LabelSum.Text = SumString;

                    //數值重制
                    Sum = 0;
                    NumberStay = 0;

                    break;
                    
                case 4: //除法

                    //開始計算
                    Result = NumberStay / Sum;

                    //印出結果
                    SumString = ("" + Result);
                    LabelSum.Text = SumString;

                    //數值重制
                    Sum = 0;
                    NumberStay = 0;

                    break;

                case 5: //求餘數

                    //開始計算
                    Result = NumberStay % Sum;

                    //印出結果
                    SumString = ("" + Result);
                    LabelSum.Text = SumString;

                    //數值重制
                    Sum = 0;
                    NumberStay = 0;

                    break;

            }
        }
    }

}
