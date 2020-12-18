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
    public partial class FormLotto369 : Form
    {
        Lotto lotto369;
        FileReadWrite fileReadWrite;

        public FormLotto369()
        {
            InitializeComponent();
            lotto369 = new Lotto("369");
            fileReadWrite = new FileReadWrite();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            try
            {
                lotto369.Generate();
                text_numbers.Text = lotto369.GeneratedNumbersString;
                String data = lotto369.GetDataToSave();
                fileReadWrite.SaveLottoData(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want\nto quit the application\nLotto 369?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception!");
            }
        }
    }
}
