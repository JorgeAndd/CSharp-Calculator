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
        private bool toClear = true;
        Calculator calculator =  new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string digit = button.Text;

            if(digit == "0")
            {
                if (txtResult.Text == "0")
                    return;
                else
                {
                    txtResult.AppendText(digit);
                    return;
                }
                    
            }

            if(toClear)
            {
                txtResult.Text = digit;
                toClear = false;
            }
            else
                txtResult.AppendText(digit);
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains(","))
            {
                txtResult.AppendText(",");
            }
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string op = button.Text;
            float value = float.Parse(txtResult.Text);

            txtResult.Text = calculator.Operate(value, op).ToString();
            toClear = true;
        }

        private void btnOpEquals_Click(object sender, EventArgs e)
        {
            float value = float.Parse(txtResult.Text);
            txtResult.Text = calculator.Result(value).ToString();
            toClear = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtResult.Text = "0";
            toClear = true;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            string s = txtResult.Text;

            if (s.Length > 1)
            {
                s = s.Substring(0, s.Length - 1);
            }
            else
            {
                s = "0";
                toClear = true;
            }

            txtResult.Text = s;
        }
    }
}
