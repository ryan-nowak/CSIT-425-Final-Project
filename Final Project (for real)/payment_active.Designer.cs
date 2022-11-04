namespace Final_Project__for_real_
{
    partial class payment_active
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_Backtomain = new System.Windows.Forms.Button();
            this.lbl_paymentinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(641, 336);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(147, 48);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "Submit Payment";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Backtomain
            // 
            this.btn_Backtomain.Location = new System.Drawing.Point(641, 390);
            this.btn_Backtomain.Name = "btn_Backtomain";
            this.btn_Backtomain.Size = new System.Drawing.Size(147, 48);
            this.btn_Backtomain.TabIndex = 12;
            this.btn_Backtomain.Text = "Go Back";
            this.btn_Backtomain.UseVisualStyleBackColor = true;
            this.btn_Backtomain.Click += new System.EventHandler(this.btn_Backtomain_Click);
            // 
            // lbl_paymentinfo
            // 
            this.lbl_paymentinfo.AutoSize = true;
            this.lbl_paymentinfo.Location = new System.Drawing.Point(37, 76);
            this.lbl_paymentinfo.Name = "lbl_paymentinfo";
            this.lbl_paymentinfo.Size = new System.Drawing.Size(53, 13);
            this.lbl_paymentinfo.TabIndex = 13;
            this.lbl_paymentinfo.Text = "blank text";
            this.lbl_paymentinfo.Click += new System.EventHandler(this.lbl_paymentinfo_Click);
            // 
            // payment_active
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_paymentinfo);
            this.Controls.Add(this.btn_Backtomain);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.label2);
            this.Name = "payment_active";
            this.Text = "AER Fitness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_Backtomain;
        private System.Windows.Forms.Label lbl_paymentinfo;
    }
}