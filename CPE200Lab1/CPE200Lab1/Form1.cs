using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, num2, sum;
        string sum2, save1,save2;
        int op, op2;
        int lp=0;

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void numberBtn_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lp == 1)
                {
                    lblDisplay.Text = ((Button)sender).Text;
                    lp = 0;
                }else if (lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else 
                {
                    lblDisplay.Text += ((Button)sender).Text;
                }
            }

            
        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }

        private void btn4_Click(object sender, EventArgs e)
        {
 
        }

        private void btn5_Click(object sender, EventArgs e)
        {
 
        }

        private void btn6_Click(object sender, EventArgs e)
        {
 
        }

        private void btn7_Click(object sender, EventArgs e)
        {
 
        }

        private void btn8_Click(object sender, EventArgs e)
        {
  
        }

        private void btn9_Click(object sender, EventArgs e)
        {
  
        }

        private void btn0_Click(object sender, EventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "<";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            float nums;
            nums = float.Parse(lblDisplay.Text);
            nums = nums / 100;
            num2 = num1*nums;
            op2 = 1;
            
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (lp == 1)
            {
                lblDisplay.Text = save2;
                num1 = float.Parse(save2);
            }
            else
            {
                num1 = float.Parse(lblDisplay.Text);
            }
            save1 = lblDisplay.Text;
            lblDisplay.Text = "0";
            op = 4;
            lp = 0;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (lp == 1)
            {
                lblDisplay.Text = save2;
                num1 = float.Parse(save2);
            }
            else
            {
                num1 = float.Parse(lblDisplay.Text);
            }
            save1 = lblDisplay.Text;
            lblDisplay.Text = "0";
            op = 3;
            lp = 0;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (lp == 1)
            {
                lblDisplay.Text = save2;
                num1 = float.Parse(save2);
            }
            else
            {
                num1 = float.Parse(lblDisplay.Text);
            }
            save1 = lblDisplay.Text;
            lblDisplay.Text = "0";
            op = 2;
            lp = 0;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (lp == 1)
            {
                lblDisplay.Text = save2;
                num1 = float.Parse(save2);
            }
            else
            {
                num1 = float.Parse(lblDisplay.Text);
            }
            save1 = lblDisplay.Text;
            lblDisplay.Text = "0";
            op = 1;
            lp = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            lp = 1;
            if (op2 != 1)
            {
                num2 = float.Parse(lblDisplay.Text);
            }
            if (op == 1)
            {
                sum = num1 + num2;
                /*save1 += "+";
                save1 += lblDisplay.Text;
                if (op2 == 1) { save1 += "%"; }
                save1 += "=";*/
            }
            if (op == 2)
            {
                sum = num1 - num2;
                /*save1 += "-";
                save1 += lblDisplay.Text;
                if (op2 == 1) { save1 += "%"; }
                save1 += "=";*/
            }
            if (op == 3)
            {
                sum = num1 * num2;
                /*save1 += "x";
                save1 += lblDisplay.Text;
                if (op2 == 1) { save1 += "%"; }
                save1 += "=";*/
            }
            if (op == 4)
            {
                sum = num1 / num2;
                /*save1 += "/";
                save1 += lblDisplay.Text;
                if (op2 == 1) { save1 += "%"; }
                save1 += "=";*/
            }
            save2= sum.ToString();
            /*sum2 = save1;
            sum2 += sum.ToString();*/
            sum2 = sum.ToString();
            lblDisplay.Text = sum2;
           /* if (lblDisplay.Text.Length >= 8)
            {
                lblDisplay.Text = "Error";
            }*/

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "+-";
        }

       /* private void btnoperator_click(object under, EventArgs e)
        {
            firstoperand
        }*/
    }//hahaha
}
