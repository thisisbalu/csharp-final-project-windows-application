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
    public partial class FormTemperatureConversion : Form
    {
        private const String CELSUIS = "C";
        private const String FARENHEIT = "F";

        private String fromType = CELSUIS;
        private String toType = FARENHEIT;
        private float fromValue;

        TemperatureConversion temperatureConversion;

        public FormTemperatureConversion()
        {
            InitializeComponent();
            temperatureConversion = new TemperatureConversion(fromType, toType);
        }

        private void button_read_file_Click(object sender, EventArgs e)
        {
            try
            {
                String data = temperatureConversion.ReadDataFromFile();
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

        private void button_convert_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nTemperature Conversion?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void convert()
        {
            try
            {
                if (!checkNumberRegex())
                {
                    MessageBox.Show("Only decimal numbers are allowed. Please try again", "Error!");
                }
                else
                {
                    fromValue = float.Parse(text_from.Text);
                    temperatureConversion = new TemperatureConversion(fromType, toType);
                    temperatureConversion.Convert(fromValue);
                    text_to.Text = temperatureConversion.ToValue.ToString();
                    text_message.Text = temperatureConversion.Message;
                }
            } 
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Exception!");
            }
        }

        private bool checkNumberRegex()
        {
            Regex regex = new Regex(@"^-?[0-9]\d{0,9}(\.\d{1,9})?%?$");
            return String.IsNullOrEmpty(text_from.Text) ? true : regex.IsMatch(text_from.Text);
        }

        private void radio_from_c_to_f_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_from_c_to_f.Checked)
            {
                label_current_from.Text = CELSUIS;
                label_current_to.Text = FARENHEIT;
                String temp = text_from.Text;
                text_from.Text = text_to.Text;
                text_to.Text = temp;
                fromType = CELSUIS;
                toType = FARENHEIT;
            } else
            {
                label_current_from.Text = FARENHEIT;
                label_current_to.Text = CELSUIS;
                String temp = text_from.Text;
                text_from.Text = text_to.Text;
                text_to.Text = temp;
                fromType = FARENHEIT;
                toType = CELSUIS;
            }
            if (!String.IsNullOrEmpty(text_from.Text))
            {
                convert();
            }
        }
    }
}
