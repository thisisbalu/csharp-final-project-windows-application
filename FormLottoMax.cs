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
    public partial class FormLottoMax : Form
    {
        Lotto lottoMax;
        FileReadWrite fileReadWrite;
        public FormLottoMax()
        {
            InitializeComponent();
            lottoMax = new Lotto("Max");
            fileReadWrite = new FileReadWrite();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            try
            {
                lottoMax.Generate();
                text_numbers.Text = lottoMax.GeneratedNumbersString;
                String data = lottoMax.GetDataToSave();
                fileReadWrite.SaveLottoData(data);
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nLotto Max?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button_read_file_Click(object sender, EventArgs e)
        {
            try
            {
                String data = fileReadWrite.ReadLottoFile();
                if (String.IsNullOrEmpty(data))
                {
                    MessageBox.Show("No data To Display", "Read File");
                    text_numbers.Focus();
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
