namespace FinalProject_2014356
{
    partial class FormLotto369
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exit = new System.Windows.Forms.Button();
            this.button_read_file = new System.Windows.Forms.Button();
            this.button_generate = new System.Windows.Forms.Button();
            this.text_numbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(312, 306);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 33);
            this.button_exit.TabIndex = 11;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_read_file
            // 
            this.button_read_file.Location = new System.Drawing.Point(178, 306);
            this.button_read_file.Name = "button_read_file";
            this.button_read_file.Size = new System.Drawing.Size(98, 33);
            this.button_read_file.TabIndex = 10;
            this.button_read_file.Text = "Read File";
            this.button_read_file.UseVisualStyleBackColor = true;
            this.button_read_file.Click += new System.EventHandler(this.button_read_file_Click);
            // 
            // button_generate
            // 
            this.button_generate.Location = new System.Drawing.Point(45, 306);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(98, 33);
            this.button_generate.TabIndex = 9;
            this.button_generate.Text = "Generate";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // text_numbers
            // 
            this.text_numbers.Location = new System.Drawing.Point(295, 30);
            this.text_numbers.Multiline = true;
            this.text_numbers.Name = "text_numbers";
            this.text_numbers.Size = new System.Drawing.Size(88, 233);
            this.text_numbers.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "The winning numbers are :";
            // 
            // FormLotto369
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 369);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_read_file);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.text_numbers);
            this.Controls.Add(this.label1);
            this.Name = "FormLotto369";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto 369 - Bala Subramanyam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_read_file;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.TextBox text_numbers;
        private System.Windows.Forms.Label label1;
    }
}