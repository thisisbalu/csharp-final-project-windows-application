namespace FinalProject_2014356
{
    partial class FormIpValidation
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_ip = new System.Windows.Forms.TextBox();
            this.button_validate = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today : ";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(190, 34);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(51, 20);
            this.label_date.TabIndex = 1;
            this.label_date.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter IP Address";
            // 
            // text_ip
            // 
            this.text_ip.Location = new System.Drawing.Point(177, 81);
            this.text_ip.Name = "text_ip";
            this.text_ip.Size = new System.Drawing.Size(183, 26);
            this.text_ip.TabIndex = 3;
            // 
            // button_validate
            // 
            this.button_validate.Location = new System.Drawing.Point(22, 159);
            this.button_validate.Name = "button_validate";
            this.button_validate.Size = new System.Drawing.Size(107, 47);
            this.button_validate.TabIndex = 4;
            this.button_validate.Text = "Validate IP";
            this.button_validate.UseVisualStyleBackColor = true;
            this.button_validate.Click += new System.EventHandler(this.button_validate_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(276, 159);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(97, 47);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(148, 159);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(104, 47);
            this.button_reset.TabIndex = 6;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // FormIpValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 245);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_validate);
            this.Controls.Add(this.text_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label1);
            this.Name = "FormIpValidation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP4 Validator - Bala Subramanyam";
            this.Load += new System.EventHandler(this.FormIpValidation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_ip;
        private System.Windows.Forms.Button button_validate;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_reset;
    }
}