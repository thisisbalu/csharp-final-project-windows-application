using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_2014356
{
    public partial class FormCurrencyConversions : Form
    {
        private const String CAD = "CAD";
        private const String USD = "USD";
        private const String GBP = "GBP";
        private const String EUR = "EUR";
        private const String INR = "INR";

        private String from = CAD;
        private String to = USD;

        CurrencyConversion currencyConversion;

        public FormCurrencyConversions()
        {
            InitializeComponent();
        }

        private void FormCurrencyConversions_Load(object sender, EventArgs e)
        {
            text_from.Text = "1";
            currencyConversion = new CurrencyConversion(from, to, 1);
            double rate = currencyConversion.GetConversion();
            text_to.Text = rate.ToString();
        }

        private bool checkNumberRegex()
        {
            Regex regex = new Regex(@"^[0-9]\d{0,9}(\.\d{1,9})?%?$");
            return regex.IsMatch(text_from.Text);
        }

        private void convert()
        {
            try
            {
                if (!checkNumberRegex())
                {
                    MessageBox.Show("Only decimal numbers are allowed. Please try again", "Error!");
                    text_from.Focus();
                }
                else
                {
                    double fromRate = Convert.ToDouble(text_from.Text);
                    currencyConversion = new CurrencyConversion(from, to, fromRate);
                    double toRate = currencyConversion.GetConversion();
                    text_to.Text = toRate.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Exception!");
            }
        }

        private void radio_from_cad_CheckedChanged(object sender, EventArgs e)
        {
            if(radio_from_cad.Checked)
            {
                from = CAD;
                convert();
            }
        }

        private void radio_from_usd_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_from_usd.Checked)
            {
                from = USD;
                convert();
            }

        }

        private void radio_from_eur_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_from_eur.Checked)
            {
                from = EUR;
                convert();
            }
        }

        private void radio_from_gbp_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_from_gbp.Checked)
            {
                from = GBP;
                convert();
            }
        }

        private void radio_from_inr_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_from_inr.Checked)
            {
                from = INR;
                convert();
            }
        }

        private void radio_to_cad_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_to_cad.Checked)
            {
                to = CAD;
                convert();
            }
        }

        private void radio_to_usd_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_to_usd.Checked)
            {
                to = USD;
                convert();
            }
        }

        private void radio_to_eur_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_to_eur.Checked)
            {
                to = EUR;
                convert();
            }
        }

        private void radio_to_gbp_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_to_gbp.Checked)
            {
                to = GBP;
                convert();
            }
        }

        private void radio_to_inr_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_to_inr.Checked)
            {
                to = INR;
                convert();
            }
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nCurrency Conversion?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button_read_file_Click(object sender, EventArgs e)
        {
            try
            {
                String data = currencyConversion.ReadDataFromFile();
                if (String.IsNullOrEmpty(data))
                {
                    MessageBox.Show("No data To Display", "Read File");
                    text_from.Focus();
                }
                else
                {
                    MessageBox.Show(data, "Read File");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }
    }
}
