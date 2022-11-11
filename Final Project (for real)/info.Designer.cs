
namespace Final_Project__for_real_
{
    partial class info
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_MemType = new System.Windows.Forms.Label();
            this.btn_Backtomain = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fulladdress = new System.Windows.Forms.Label();
            this.lbl_membershiptype = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(27, 36);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(267, 36);
            this.lbl_welcome.TabIndex = 1;
            this.lbl_welcome.Text = "Current User Account Info:";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(28, 93);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name:";
            this.lbl_Name.Click += new System.EventHandler(this.info_Name_Click);
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Location = new System.Drawing.Point(28, 128);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(48, 13);
            this.lbl_Address.TabIndex = 3;
            this.lbl_Address.Text = "Address:";
            this.lbl_Address.Click += new System.EventHandler(this.lbl_Address_Click);
            // 
            // lbl_MemType
            // 
            this.lbl_MemType.AutoSize = true;
            this.lbl_MemType.Location = new System.Drawing.Point(28, 163);
            this.lbl_MemType.Name = "lbl_MemType";
            this.lbl_MemType.Size = new System.Drawing.Size(94, 13);
            this.lbl_MemType.TabIndex = 4;
            this.lbl_MemType.Text = "Membership Type:";
            this.lbl_MemType.Click += new System.EventHandler(this.lbl_MemType_Click);
            // 
            // btn_Backtomain
            // 
            this.btn_Backtomain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Backtomain.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backtomain.Location = new System.Drawing.Point(220, 292);
            this.btn_Backtomain.Name = "btn_Backtomain";
            this.btn_Backtomain.Size = new System.Drawing.Size(132, 37);
            this.btn_Backtomain.TabIndex = 5;
            this.btn_Backtomain.Text = "Go Back";
            this.btn_Backtomain.UseVisualStyleBackColor = true;
            this.btn_Backtomain.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_fulladdress
            // 
            this.lbl_fulladdress.AutoSize = true;
            this.lbl_fulladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fulladdress.Location = new System.Drawing.Point(82, 128);
            this.lbl_fulladdress.Name = "lbl_fulladdress";
            this.lbl_fulladdress.Size = new System.Drawing.Size(52, 13);
            this.lbl_fulladdress.TabIndex = 7;
            this.lbl_fulladdress.Text = "Address";
            this.lbl_fulladdress.Click += new System.EventHandler(this.lbl_fulladdress_Click);
            // 
            // lbl_membershiptype
            // 
            this.lbl_membershiptype.AutoSize = true;
            this.lbl_membershiptype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_membershiptype.Location = new System.Drawing.Point(128, 163);
            this.lbl_membershiptype.Name = "lbl_membershiptype";
            this.lbl_membershiptype.Size = new System.Drawing.Size(106, 13);
            this.lbl_membershiptype.TabIndex = 8;
            this.lbl_membershiptype.Text = "Membership Type";
            this.lbl_membershiptype.Click += new System.EventHandler(this.lbl_membershiptype_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 341);
            this.Controls.Add(this.lbl_membershiptype);
            this.Controls.Add(this.lbl_fulladdress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Backtomain);
            this.Controls.Add(this.lbl_MemType);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AER Fitness";
            this.Load += new System.EventHandler(this.info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_MemType;
        private System.Windows.Forms.Button btn_Backtomain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fulladdress;
        private System.Windows.Forms.Label lbl_membershiptype;
    }
}