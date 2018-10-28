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
    public partial class MainForm : Form
    {
        private CalculatorEngine engine = new CalculatorEngine();

        private void resetAll()
        {
            engine.resetAll();
            lblDisplay.Text = engine.Display();
        }

        public MainForm()
        {
            InitializeComponent();
            resetAll();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            string digit = ((Button)sender).Text;
            engine.Number_Click(digit);
            lblDisplay.Text = engine.Display();
        }

        private void btnUnaryOperator_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            string op = ((Button)sender).Text;
            engine.UnaryOperator_Click(op);
            lblDisplay.Text = engine.Display();
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            string op = ((Button)sender).Text;
            engine.Operator_Click(op);
            lblDisplay.Text = engine.Display();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.Equal_Click();
            lblDisplay.Text = engine.Display();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.Dot_Click();
            lblDisplay.Text = engine.Display();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.Sign_Click();
            lblDisplay.Text = engine.Display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.Back_Click();
            lblDisplay.Text = engine.Display();
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.MP_Click();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.MC_Click();
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.MM_Click();
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text is "Error")
            {
                return;
            }
            engine.MR_Click();
        }
    }
}
