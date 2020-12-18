namespace FinalProject_2014356
{
    partial class FormCurrencyConversions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrencyConversions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_from_inr = new System.Windows.Forms.RadioButton();
            this.radio_from_gbp = new System.Windows.Forms.RadioButton();
            this.radio_from_eur = new System.Windows.Forms.RadioButton();
            this.radio_from_usd = new System.Windows.Forms.RadioButton();
            this.radio_from_cad = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radio_to_inr = new System.Windows.Forms.RadioButton();
            this.radio_to_gbp = new System.Windows.Forms.RadioButton();
            this.radio_to_eur = new System.Windows.Forms.RadioButton();
            this.radio_to_usd = new System.Windows.Forms.RadioButton();
            this.radio_to_cad = new System.Windows.Forms.RadioButton();
            this.text_from = new System.Windows.Forms.TextBox();
            this.text_to = new System.Windows.Forms.TextBox();
            this.button_convert = new System.Windows.Forms.Button();
            this.button_read_file = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.radio_from_inr);
            this.groupBox1.Controls.Add(this.radio_from_gbp);
            this.groupBox1.Controls.Add(this.radio_from_eur);
            this.groupBox1.Controls.Add(this.radio_from_usd);
            this.groupBox1.Controls.Add(this.radio_from_cad);
            this.groupBox1.Location = new System.Drawing.Point(38, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From";
            // 
            // radio_from_inr
            // 
            this.radio_from_inr.AutoSize = true;
            this.radio_from_inr.Location = new System.Drawing.Point(81, 209);
            this.radio_from_inr.Name = "radio_from_inr";
            this.radio_from_inr.Size = new System.Drawing.Size(62, 24);
            this.radio_from_inr.TabIndex = 4;
            this.radio_from_inr.TabStop = true;
            this.radio_from_inr.Text = "INR";
            this.radio_from_inr.UseVisualStyleBackColor = true;
            this.radio_from_inr.CheckedChanged += new System.EventHandler(this.radio_from_inr_CheckedChanged);
            // 
            // radio_from_gbp
            // 
            this.radio_from_gbp.AutoSize = true;
            this.radio_from_gbp.Location = new System.Drawing.Point(82, 165);
            this.radio_from_gbp.Name = "radio_from_gbp";
            this.radio_from_gbp.Size = new System.Drawing.Size(68, 24);
            this.radio_from_gbp.TabIndex = 3;
            this.radio_from_gbp.TabStop = true;
            this.radio_from_gbp.Text = "GBP";
            this.radio_from_gbp.UseVisualStyleBackColor = true;
            this.radio_from_gbp.CheckedChanged += new System.EventHandler(this.radio_from_gbp_CheckedChanged);
            // 
            // radio_from_eur
            // 
            this.radio_from_eur.AutoSize = true;
            this.radio_from_eur.Location = new System.Drawing.Point(81, 121);
            this.radio_from_eur.Name = "radio_from_eur";
            this.radio_from_eur.Size = new System.Drawing.Size(69, 24);
            this.radio_from_eur.TabIndex = 2;
            this.radio_from_eur.TabStop = true;
            this.radio_from_eur.Text = "EUR";
            this.radio_from_eur.UseVisualStyleBackColor = true;
            this.radio_from_eur.CheckedChanged += new System.EventHandler(this.radio_from_eur_CheckedChanged);
            // 
            // radio_from_usd
            // 
            this.radio_from_usd.AutoSize = true;
            this.radio_from_usd.Location = new System.Drawing.Point(80, 77);
            this.radio_from_usd.Name = "radio_from_usd";
            this.radio_from_usd.Size = new System.Drawing.Size(69, 24);
            this.radio_from_usd.TabIndex = 1;
            this.radio_from_usd.TabStop = true;
            this.radio_from_usd.Text = "USD";
            this.radio_from_usd.UseVisualStyleBackColor = true;
            this.radio_from_usd.CheckedChanged += new System.EventHandler(this.radio_from_usd_CheckedChanged);
            // 
            // radio_from_cad
            // 
            this.radio_from_cad.AutoSize = true;
            this.radio_from_cad.Checked = true;
            this.radio_from_cad.Location = new System.Drawing.Point(81, 34);
            this.radio_from_cad.Name = "radio_from_cad";
            this.radio_from_cad.Size = new System.Drawing.Size(68, 24);
            this.radio_from_cad.TabIndex = 0;
            this.radio_from_cad.TabStop = true;
            this.radio_from_cad.Text = "CAD";
            this.radio_from_cad.UseVisualStyleBackColor = true;
            this.radio_from_cad.CheckedChanged += new System.EventHandler(this.radio_from_cad_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.radio_to_inr);
            this.groupBox2.Controls.Add(this.pictureBox7);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.radio_to_gbp);
            this.groupBox2.Controls.Add(this.pictureBox9);
            this.groupBox2.Controls.Add(this.radio_to_eur);
            this.groupBox2.Controls.Add(this.pictureBox10);
            this.groupBox2.Controls.Add(this.radio_to_usd);
            this.groupBox2.Controls.Add(this.radio_to_cad);
            this.groupBox2.Location = new System.Drawing.Point(300, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 260);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To";
            // 
            // radio_to_inr
            // 
            this.radio_to_inr.AutoSize = true;
            this.radio_to_inr.Location = new System.Drawing.Point(84, 209);
            this.radio_to_inr.Name = "radio_to_inr";
            this.radio_to_inr.Size = new System.Drawing.Size(62, 24);
            this.radio_to_inr.TabIndex = 4;
            this.radio_to_inr.TabStop = true;
            this.radio_to_inr.Text = "INR";
            this.radio_to_inr.UseVisualStyleBackColor = true;
            this.radio_to_inr.CheckedChanged += new System.EventHandler(this.radio_to_inr_CheckedChanged);
            // 
            // radio_to_gbp
            // 
            this.radio_to_gbp.AutoSize = true;
            this.radio_to_gbp.Location = new System.Drawing.Point(84, 165);
            this.radio_to_gbp.Name = "radio_to_gbp";
            this.radio_to_gbp.Size = new System.Drawing.Size(68, 24);
            this.radio_to_gbp.TabIndex = 3;
            this.radio_to_gbp.TabStop = true;
            this.radio_to_gbp.Text = "GBP";
            this.radio_to_gbp.UseVisualStyleBackColor = true;
            this.radio_to_gbp.CheckedChanged += new System.EventHandler(this.radio_to_gbp_CheckedChanged);
            // 
            // radio_to_eur
            // 
            this.radio_to_eur.AutoSize = true;
            this.radio_to_eur.Location = new System.Drawing.Point(83, 121);
            this.radio_to_eur.Name = "radio_to_eur";
            this.radio_to_eur.Size = new System.Drawing.Size(69, 24);
            this.radio_to_eur.TabIndex = 2;
            this.radio_to_eur.TabStop = true;
            this.radio_to_eur.Text = "EUR";
            this.radio_to_eur.UseVisualStyleBackColor = true;
            this.radio_to_eur.CheckedChanged += new System.EventHandler(this.radio_to_eur_CheckedChanged);
            // 
            // radio_to_usd
            // 
            this.radio_to_usd.AutoSize = true;
            this.radio_to_usd.Checked = true;
            this.radio_to_usd.Location = new System.Drawing.Point(84, 77);
            this.radio_to_usd.Name = "radio_to_usd";
            this.radio_to_usd.Size = new System.Drawing.Size(69, 24);
            this.radio_to_usd.TabIndex = 1;
            this.radio_to_usd.TabStop = true;
            this.radio_to_usd.Text = "USD";
            this.radio_to_usd.UseVisualStyleBackColor = true;
            this.radio_to_usd.CheckedChanged += new System.EventHandler(this.radio_to_usd_CheckedChanged);
            // 
            // radio_to_cad
            // 
            this.radio_to_cad.AutoSize = true;
            this.radio_to_cad.Location = new System.Drawing.Point(84, 34);
            this.radio_to_cad.Name = "radio_to_cad";
            this.radio_to_cad.Size = new System.Drawing.Size(68, 24);
            this.radio_to_cad.TabIndex = 0;
            this.radio_to_cad.TabStop = true;
            this.radio_to_cad.Text = "CAD";
            this.radio_to_cad.UseVisualStyleBackColor = true;
            this.radio_to_cad.CheckedChanged += new System.EventHandler(this.radio_to_cad_CheckedChanged);
            // 
            // text_from
            // 
            this.text_from.Location = new System.Drawing.Point(38, 345);
            this.text_from.Name = "text_from";
            this.text_from.Size = new System.Drawing.Size(200, 26);
            this.text_from.TabIndex = 6;
            // 
            // text_to
            // 
            this.text_to.Location = new System.Drawing.Point(300, 345);
            this.text_to.Name = "text_to";
            this.text_to.ReadOnly = true;
            this.text_to.Size = new System.Drawing.Size(200, 26);
            this.text_to.TabIndex = 7;
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(38, 420);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(98, 39);
            this.button_convert.TabIndex = 8;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // button_read_file
            // 
            this.button_read_file.Location = new System.Drawing.Point(225, 420);
            this.button_read_file.Name = "button_read_file";
            this.button_read_file.Size = new System.Drawing.Size(98, 39);
            this.button_read_file.TabIndex = 9;
            this.button_read_file.Text = "Read File";
            this.button_read_file.UseVisualStyleBackColor = true;
            this.button_read_file.Click += new System.EventHandler(this.button_read_file_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(402, 420);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(98, 39);
            this.button_exit.TabIndex = 10;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(19, 157);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(59, 38);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 38);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 38);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(19, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 38);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 201);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(59, 38);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(19, 201);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 38);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(19, 113);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(59, 38);
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(19, 69);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(59, 38);
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(19, 25);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(59, 38);
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(19, 157);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(59, 38);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // FormCurrencyConversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 497);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_read_file);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.text_to);
            this.Controls.Add(this.text_from);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCurrencyConversions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyEx - Bala Subramanyam";
            this.Load += new System.EventHandler(this.FormCurrencyConversions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_from_usd;
        private System.Windows.Forms.RadioButton radio_from_cad;
        private System.Windows.Forms.RadioButton radio_from_inr;
        private System.Windows.Forms.RadioButton radio_from_gbp;
        private System.Windows.Forms.RadioButton radio_from_eur;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_to_inr;
        private System.Windows.Forms.RadioButton radio_to_gbp;
        private System.Windows.Forms.RadioButton radio_to_eur;
        private System.Windows.Forms.RadioButton radio_to_usd;
        private System.Windows.Forms.RadioButton radio_to_cad;
        private System.Windows.Forms.TextBox text_from;
        private System.Windows.Forms.TextBox text_to;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Button button_read_file;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}