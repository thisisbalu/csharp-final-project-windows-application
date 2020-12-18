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
    public partial class FormIpValidation : Form
    {

        IpValidator ipValidator;

        public FormIpValidation()
        {
            InitializeComponent();
        }

        private void FormIpValidation_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label_date.Text = now.ToLongDateString();
        }

        private void button_validate_Click(object sender, EventArgs e)
        {
            text_ip.Text = text_ip.Text.Trim();
            if(String.IsNullOrEmpty(text_ip.Text))
            {
                MessageBox.Show("IP Address is empty.\nPlease input IP Address");
                text_ip.Focus();
                return;
            }
            ipValidator = new IpValidator(text_ip.Text);
            bool isValid = ipValidator.validateIP();
            if(isValid)
            {
                MessageBox.Show(text_ip.Text + "\nThis IP is correct", "Valid IP");
                text_ip.Focus();
            }
            else
            {
                MessageBox.Show(text_ip.Text + "\nThe IP must have 4 bytes\ninteger number between 0 and 255\nseperated by a dot(255.255.255.255)", "Error");
                text_ip.Focus();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            text_ip.Text = "";
            text_ip.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nIP validation?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
