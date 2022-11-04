namespace Final_Project__for_real_
{
    partial class payment_nonactive
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
            this.lbl_paymentinfo = new System.Windows.Forms.Label();
            this.btn_monthly = new System.Windows.Forms.RadioButton();
            this.btn_yearly = new System.Windows.Forms.RadioButton();
            this.btn_Backtomain = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_paymentinfo
            // 
            this.lbl_paymentinfo.AutoSize = true;
            this.lbl_paymentinfo.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentinfo.Location = new System.Drawing.Point(57, 44);
            this.lbl_paymentinfo.Name = "lbl_paymentinfo";
            this.lbl_paymentinfo.Size = new System.Drawing.Size(732, 20);
            this.lbl_paymentinfo.TabIndex = 14;
            this.lbl_paymentinfo.Text = "You are a non-current member of the gym. Please choose a membership type below, a" +
    "nd the amount shown will be charged to your account.";
            // 
            // btn_monthly
            // 
            this.btn_monthly.AutoSize = true;
            this.btn_monthly.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monthly.Location = new System.Drawing.Point(209, 128);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(135, 24);
            this.btn_monthly.TabIndex = 15;
            this.btn_monthly.TabStop = true;
            this.btn_monthly.Text = "Monthly ($50/month)";
            this.btn_monthly.UseVisualStyleBackColor = true;
            this.btn_monthly.CheckedChanged += new System.EventHandler(this.btn_monthly_CheckedChanged);
            // 
            // btn_yearly
            // 
            this.btn_yearly.AutoSize = true;
            this.btn_yearly.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_yearly.Location = new System.Drawing.Point(426, 128);
            this.btn_yearly.Name = "btn_yearly";
            this.btn_yearly.Size = new System.Drawing.Size(114, 24);
            this.btn_yearly.TabIndex = 16;
            this.btn_yearly.TabStop = true;
            this.btn_yearly.Text = "Yearly ($500/year)";
            this.btn_yearly.UseVisualStyleBackColor = true;
            this.btn_yearly.CheckedChanged += new System.EventHandler(this.btn_yearly_CheckedChanged);
            // 
            // btn_Backtomain
            // 
            this.btn_Backtomain.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backtomain.Location = new System.Drawing.Point(641, 390);
            this.btn_Backtomain.Name = "btn_Backtomain";
            this.btn_Backtomain.Size = new System.Drawing.Size(147, 48);
            this.btn_Backtomain.TabIndex = 18;
            this.btn_Backtomain.Text = "Go Back";
            this.btn_Backtomain.UseVisualStyleBackColor = true;
            this.btn_Backtomain.Click += new System.EventHandler(this.btn_Backtomain_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.Location = new System.Drawing.Point(641, 336);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(147, 48);
            this.btn_submit.TabIndex = 17;
            this.btn_submit.Text = "Submit Payment";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // payment_nonactive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Backtomain);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_yearly);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.lbl_paymentinfo);
            this.Name = "payment_nonactive";
            this.Text = "AER Fitness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_paymentinfo;
        private System.Windows.Forms.RadioButton btn_monthly;
        private System.Windows.Forms.RadioButton btn_yearly;
        private System.Windows.Forms.Button btn_Backtomain;
        private System.Windows.Forms.Button btn_submit;
    }
}