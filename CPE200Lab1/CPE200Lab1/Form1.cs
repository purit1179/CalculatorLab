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
        float hold_num = 0, hold_num2 = 0;       //hold second number hold first number
        int mark = 0, op = 0;   //op->specify operation , mark->mark when end of operation

        public Form1()
        {
            InitializeComponent();
        }

        private void numberBnt_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)     // 8 digits
            {
                if (lblDisplay.Text == "0")     //first digit
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else if (mark == 1)     //function mark end of operation
                {
                    lblDisplay.Text = null;
                    lblDisplay.Text = ((Button)sender).Text;
                    mark = 0;
                }
                else
                {
                    lblDisplay.Text += ((Button)sender).Text;
                }
            }else if (lblDisplay.Text.Length > 9)
            {
                lblDisplay.Text = null;
                if (lblDisplay.Text == null)     //first digit
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
            }
        }      

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)     //can use one dot
            {
                lblDisplay.Text += ".";    
            }                  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "<";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "+")
            {
                hold_num = float.Parse(lblDisplay.Text);
                lblDisplay.Text = null;     //clear string
                op = 1;
            }
            else if(((Button)sender).Text == "-")
            {
                hold_num = float.Parse(lblDisplay.Text);
                lblDisplay.Text = null;     //clear string
                op = 2;
            }
            else if(((Button)sender).Text == "X")
            {
                hold_num = float.Parse(lblDisplay.Text);
                lblDisplay.Text = null;     //clear string
                op = 3;
            }
            else if(((Button)sender).Text == "÷")
            {
                hold_num = float.Parse(lblDisplay.Text);
                lblDisplay.Text = null;     //clear string
                op = 4;
            }
            else if(((Button)sender).Text == "%")
            {
                float hold_numper = 0;
                hold_numper = float.Parse(lblDisplay.Text);
                hold_num2 = (hold_numper / 100) * hold_num;
                lblDisplay.Text = hold_num2.ToString();
            }else if (((Button)sender).Text == "=")
            {
                if (op == 1)        //plus
                {
                    hold_num2 = float.Parse(lblDisplay.Text);
                    hold_num = hold_num + hold_num2;
                    hold_num = (float)Math.Round(hold_num,8);
                    if (hold_num.ToString().Length > 9)
                    {
                        lblDisplay.Text = "ERROR";
                    }
                    else
                    {
                        lblDisplay.Text = hold_num.ToString();   //convert number into string
                    }
                    op = 0;     //reset operation
                    mark = 1;   //mark end of operation
                }
                else if (op == 2)       //minus
                {
                    hold_num2 = float.Parse(lblDisplay.Text);
                    hold_num = hold_num - hold_num2;
                    hold_num = (float)Math.Round(hold_num, 8);
                    if (hold_num.ToString().Length > 9)
                    {
                        lblDisplay.Text = "ERROR";
                    }
                    else
                    {
                        lblDisplay.Text = hold_num.ToString();   //convert number into string
                    }
                    op = 0;
                    mark = 1;
                }
                else if (op == 3)       //multiply
                {
                    hold_num2 = float.Parse(lblDisplay.Text);
                    hold_num = hold_num * hold_num2;
                    hold_num = (float)Math.Round(hold_num, 8);
                    if (hold_num.ToString().Length > 9)
                    {
                        lblDisplay.Text = "ERROR";
                    }
                    else
                    {
                        lblDisplay.Text = hold_num.ToString();   //convert number into string
                    }                   
                    op = 0;
                    mark = 1;
                }
                else if (op == 4)       //divide
                {
                    hold_num2 = float.Parse(lblDisplay.Text);
                    hold_num = hold_num / hold_num2;
                    hold_num = (float)Math.Round(hold_num, 9);
                    if (hold_num.ToString().Length > 9)
                    {
                        lblDisplay.Text = "ERROR";
                    }
                    else
                    {
                        lblDisplay.Text = hold_num.ToString();   //convert number into string
                    }
                    op = 0;
                    mark = 1;
                }
            }                   
        }
    }
}