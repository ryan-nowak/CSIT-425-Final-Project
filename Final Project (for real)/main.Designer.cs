namespace Final_Project__for_real_
{
    partial class main
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_information = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(320, 54);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(100, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Welcome, full name";
            this.lbl_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.Location = new System.Drawing.Point(61, 137);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(128, 67);
            this.btn_payment.TabIndex = 1;
            this.btn_payment.Text = "Make Payment";
            this.btn_payment.UseVisualStyleBackColor = true;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_information
            // 
            this.btn_information.Location = new System.Drawing.Point(305, 137);
            this.btn_information.Name = "btn_information";
            this.btn_information.Size = new System.Drawing.Size(128, 67);
            this.btn_information.TabIndex = 2;
            this.btn_information.Text = "View/Change Information";
            this.btn_information.UseVisualStyleBackColor = true;
            this.btn_information.Click += new System.EventHandler(this.btn_information_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(546, 137);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(128, 67);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_information);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.lbl_name);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_information;
        private System.Windows.Forms.Button btn_logout;
    }
}