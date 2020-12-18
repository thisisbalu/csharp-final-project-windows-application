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
    public partial class FormMain : Form
    {
        FileReadWrite readWrite;
        public FormMain()
        {
            InitializeComponent();
            readWrite = new FileReadWrite();
            readWrite.DeleteDirectoryIfExists();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button_lotto_max_Click(object sender, EventArgs e)
        {
            FormLottoMax formLottoMax = new FormLottoMax();
            formLottoMax.Show();
        }

        private void button_lotto_649_Click(object sender, EventArgs e)
        {
            FormLotto369 formLotto369 = new FormLotto369();
            formLotto369.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button_main_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button_calculator_Click(object sender, EventArgs e)
        {
            FormCalculator calculator = new FormCalculator();
            calculator.Show();
        }

        private void button_currency_convert_Click(object sender, EventArgs e)
        {
            FormCurrencyConversions formCurrencyConversions = new FormCurrencyConversions();
            formCurrencyConversions.Show();
        }

        private void button_temperature_convert_Click(object sender, EventArgs e)
        {
            FormTemperatureConversion formTemperatureConversion = new FormTemperatureConversion();
            formTemperatureConversion.Show();
        }

        private void button_ip_validate_Click(object sender, EventArgs e)
        {
            FormIpValidation formIpValidation = new FormIpValidation();
            formIpValidation.Show();
        }
    }
}
