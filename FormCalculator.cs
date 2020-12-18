using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_2014356
{
    public partial class FormCalculator : Form
    {
        public String displayValue = "0";
        Calculator calc = new Calculator();

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            text_display.Text = displayValue;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if(displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "1";
            text_display.Text = displayValue;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "2";
            text_display.Text = displayValue;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "3";
            text_display.Text = displayValue;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "4";
            text_display.Text = displayValue;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "5";
            text_display.Text = displayValue;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "6";
            text_display.Text = displayValue;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "7";
            text_display.Text = displayValue;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "8";
            text_display.Text = displayValue;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            displayValue = displayValue + "9";
            text_display.Text = displayValue;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if (displayValue.Equals("0"))
            {
                displayValue = "";
            }
            displayValue = displayValue + "0";
            text_display.Text = displayValue;
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if(!displayValue.Contains("."))
            {
                displayValue = displayValue + ".";
            }
            if (!displayValue.Contains(".") && displayValue.Equals("0"))
            {
                displayValue = "0.";
            }
                text_display.Text = displayValue;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            try
            {
                displayValue = "0";
                calc.Clear();
                text_display.Text = displayValue;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Add(displayValue);
                displayValue = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_sub_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Subtract(displayValue);
                displayValue = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Multiply(displayValue);
                displayValue = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            try
            {
                calc.Divide(displayValue);
                displayValue = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayValue.Equals("0"))
                {
                    calc.Equals();
                }
                else
                {
                    calc.Equals(displayValue);
                }
                text_display.Text = calc.Operand1.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nSimple Calculator?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
