namespace FinalProject_2014356
{
    partial class FormTemperatureConversion
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
            this.radio_from_c_to_f = new System.Windows.Forms.RadioButton();
            this.radio_from_f_to_c = new System.Windows.Forms.RadioButton();
            this.text_from = new System.Windows.Forms.TextBox();
            this.text_to = new System.Windows.Forms.TextBox();
            this.label_to = new System.Windows.Forms.Label();
            this.label_current_from = new System.Windows.Forms.Label();
            this.label_current_to = new System.Windows.Forms.Label();
            this.text_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_read_file = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_from_c_to_f
            // 
            this.radio_from_c_to_f.AutoSize = true;
            this.radio_from_c_to_f.Checked = true;
            this.radio_from_c_to_f.Location = new System.Drawing.Point(129, 29);
            this.radio_from_c_to_f.Name = "radio_from_c_to_f";
            this.radio_from_c_to_f.Size = new System.Drawing.Size(113, 24);
            this.radio_from_c_to_f.TabIndex = 0;
            this.radio_from_c_to_f.TabStop = true;
            this.radio_from_c_to_f.Text = "from C to F";
            this.radio_from_c_to_f.UseVisualStyleBackColor = true;
            this.radio_from_c_to_f.CheckedChanged += new System.EventHandler(this.radio_from_c_to_f_CheckedChanged);
            // 
            // radio_from_f_to_c
            // 
            this.radio_from_f_to_c.AutoSize = true;
            this.radio_from_f_to_c.Location = new System.Drawing.Point(129, 60);
            this.radio_from_f_to_c.Name = "radio_from_f_to_c";
            this.radio_from_f_to_c.Size = new System.Drawing.Size(113, 24);
            this.radio_from_f_to_c.TabIndex = 1;
            this.radio_from_f_to_c.Text = "from F to C";
            this.radio_from_f_to_c.UseVisualStyleBackColor = true;
            // 
            // text_from
            // 
            this.text_from.Location = new System.Drawing.Point(25, 113);
            this.text_from.Name = "text_from";
            this.text_from.Size = new System.Drawing.Size(142, 26);
            this.text_from.TabIndex = 2;
            // 
            // text_to
            // 
            this.text_to.Location = new System.Drawing.Point(234, 113);
            this.text_to.Name = "text_to";
            this.text_to.ReadOnly = true;
            this.text_to.Size = new System.Drawing.Size(142, 26);
            this.text_to.TabIndex = 3;
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Location = new System.Drawing.Point(189, 118);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(23, 20);
            this.label_to.TabIndex = 4;
            this.label_to.Text = "to";
            // 
            // label_current_from
            // 
            this.label_current_from.AutoSize = true;
            this.label_current_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_from.Location = new System.Drawing.Point(81, 146);
            this.label_current_from.Name = "label_current_from";
            this.label_current_from.Size = new System.Drawing.Size(21, 20);
            this.label_current_from.TabIndex = 5;
            this.label_current_from.Text = "C";
            // 
            // label_current_to
            // 
            this.label_current_to.AutoSize = true;
            this.label_current_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_current_to.Location = new System.Drawing.Point(290, 146);
            this.label_current_to.Name = "label_current_to";
            this.label_current_to.Size = new System.Drawing.Size(20, 20);
            this.label_current_to.TabIndex = 6;
            this.label_current_to.Text = "F";
            // 
            // text_message
            // 
            this.text_message.Location = new System.Drawing.Point(25, 225);
            this.text_message.Multiline = true;
            this.text_message.Name = "text_message";
            this.text_message.ReadOnly = true;
            this.text_message.Size = new System.Drawing.Size(351, 77);
            this.text_message.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Message:";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(278, 350);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 39);
            this.button_exit.TabIndex = 13;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_read_file
            // 
            this.button_read_file.Location = new System.Drawing.Point(153, 350);
            this.button_read_file.Name = "button_read_file";
            this.button_read_file.Size = new System.Drawing.Size(98, 39);
            this.button_read_file.TabIndex = 12;
            this.button_read_file.Text = "Read File";
            this.button_read_file.UseVisualStyleBackColor = true;
            this.button_read_file.Click += new System.EventHandler(this.button_read_file_Click);
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(25, 350);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(98, 39);
            this.button_convert.TabIndex = 11;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // FormTemperatureConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 416);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_read_file);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_message);
            this.Controls.Add(this.label_current_to);
            this.Controls.Add(this.label_current_from);
            this.Controls.Add(this.label_to);
            this.Controls.Add(this.text_to);
            this.Controls.Add(this.text_from);
            this.Controls.Add(this.radio_from_f_to_c);
            this.Controls.Add(this.radio_from_c_to_f);
            this.Name = "FormTemperatureConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temp Conv - Bala Subramanyam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_from_c_to_f;
        private System.Windows.Forms.RadioButton radio_from_f_to_c;
        private System.Windows.Forms.TextBox text_from;
        private System.Windows.Forms.TextBox text_to;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_current_from;
        private System.Windows.Forms.Label label_current_to;
        private System.Windows.Forms.TextBox text_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_read_file;
        private System.Windows.Forms.Button button_convert;
    }
}