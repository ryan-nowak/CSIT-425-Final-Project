namespace Final_Project__for_real_
{
    partial class payment
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
            this.lbl_ccnumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ccnumber = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_expdate = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_cvv = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lbl_zip = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ccnumber
            // 
            this.lbl_ccnumber.AutoSize = true;
            this.lbl_ccnumber.Location = new System.Drawing.Point(29, 40);
            this.lbl_ccnumber.Name = "lbl_ccnumber";
            this.lbl_ccnumber.Size = new System.Drawing.Size(99, 13);
            this.lbl_ccnumber.TabIndex = 0;
            this.lbl_ccnumber.Text = "Credit card number:";
            this.lbl_ccnumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // txt_ccnumber
            // 
            this.txt_ccnumber.Location = new System.Drawing.Point(32, 57);
            this.txt_ccnumber.Name = "txt_ccnumber";
            this.txt_ccnumber.Size = new System.Drawing.Size(263, 20);
            this.txt_ccnumber.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(29, 104);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(77, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name on card:";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 189);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lbl_expdate
            // 
            this.lbl_expdate.AutoSize = true;
            this.lbl_expdate.Location = new System.Drawing.Point(29, 172);
            this.lbl_expdate.Name = "lbl_expdate";
            this.lbl_expdate.Size = new System.Drawing.Size(80, 13);
            this.lbl_expdate.TabIndex = 5;
            this.lbl_expdate.Text = "Expiration date:";
            this.lbl_expdate.Click += new System.EventHandler(this.lbl_expdate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(263, 20);
            this.textBox3.TabIndex = 8;
            // 
            // lbl_cvv
            // 
            this.lbl_cvv.AutoSize = true;
            this.lbl_cvv.Location = new System.Drawing.Point(29, 238);
            this.lbl_cvv.Name = "lbl_cvv";
            this.lbl_cvv.Size = new System.Drawing.Size(31, 13);
            this.lbl_cvv.TabIndex = 7;
            this.lbl_cvv.Text = "CVV:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(32, 323);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(263, 20);
            this.textBox4.TabIndex = 10;
            // 
            // lbl_zip
            // 
            this.lbl_zip.AutoSize = true;
            this.lbl_zip.Location = new System.Drawing.Point(29, 306);
            this.lbl_zip.Name = "lbl_zip";
            this.lbl_zip.Size = new System.Drawing.Size(52, 13);
            this.lbl_zip.TabIndex = 9;
            this.lbl_zip.Text = "Zip code:";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(31, 383);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lbl_zip);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lbl_cvv);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_expdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_ccnumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ccnumber);
            this.Name = "payment";
            this.Text = "payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ccnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ccnumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_expdate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbl_cvv;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lbl_zip;
        private System.Windows.Forms.Button btn_submit;
    }
}