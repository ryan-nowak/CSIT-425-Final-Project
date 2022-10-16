
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
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(27, 36);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(290, 23);
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
            this.btn_Backtomain.Location = new System.Drawing.Point(641, 390);
            this.btn_Backtomain.Name = "btn_Backtomain";
            this.btn_Backtomain.Size = new System.Drawing.Size(147, 48);
            this.btn_Backtomain.TabIndex = 5;
            this.btn_Backtomain.Text = "Go Back";
            this.btn_Backtomain.UseVisualStyleBackColor = true;
            this.btn_Backtomain.Click += new System.EventHandler(this.button1_Click);
            // 
            // info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Backtomain);
            this.Controls.Add(this.lbl_MemType);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "info";
            this.Text = "info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_MemType;
        private System.Windows.Forms.Button btn_Backtomain;
    }
}