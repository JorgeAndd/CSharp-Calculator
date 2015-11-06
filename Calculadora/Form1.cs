using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private bool toClear = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "0";
                toClear = false;
            }
            else if (txtResult.Text != "0")
                txtResult.AppendText("0");
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "1";
                toClear = false;
            }
            else
                txtResult.AppendText("1");
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "2";
                toClear = false;
            }
            else
                txtResult.AppendText("2");
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "3";
                toClear = false;
            }
            else
                txtResult.AppendText("3");
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "4";
                toClear = false;
            }
            else
                txtResult.AppendText("4");
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "5";
                toClear = false;
            }
            else
                txtResult.AppendText("5");
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "6";
                toClear = false;
            }
            else
                txtResult.AppendText("6");
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "7";
                toClear = false;
            }
            else
                txtResult.AppendText("7");
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "8";
                toClear = false;
            }
            else
                txtResult.AppendText("8");
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            if (toClear)
            {
                txtResult.Text = "9";
                toClear = false;
            }
            else
                txtResult.AppendText("9");
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.AppendText(",");
            }
        }

        private void btnOpTimes_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = Calculator.Operate(value, "times").ToString();
            toClear = true;
        }

        private void btnOpDiv_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = Calculator.Operate(value, "div").ToString();
            toClear = true;
        }

        private void btnOpMinus_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = Calculator.Operate(value, "minus").ToString();
            toClear = true;
        }

        private void btnOpPlus_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = Calculator.Operate(value, "plus").ToString();
            toClear = true;
        }

        private void btnOpEquals_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = Calculator.Result(value).ToString();
            toClear = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Calculator.Clear();
            txtResult.Text = "0";
            toClear = true;
        }

    }
}
