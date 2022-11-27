namespace Final_Project__for_real_
{
    partial class newacc
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
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_streetaddress = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_ccfname = new System.Windows.Forms.TextBox();
            this.lbl_ccfname = new System.Windows.Forms.Label();
            this.txt_ccnumber = new System.Windows.Forms.TextBox();
            this.lbl_ccnumber = new System.Windows.Forms.Label();
            this.txt_cczipcode = new System.Windows.Forms.TextBox();
            this.lbl_cczipcode = new System.Windows.Forms.Label();
            this.txt_ccv = new System.Windows.Forms.TextBox();
            this.lbl_cvv = new System.Windows.Forms.Label();
            this.txt_expdate = new System.Windows.Forms.TextBox();
            this.lbl_expdate = new System.Windows.Forms.Label();
            this.lbl_choice = new System.Windows.Forms.Label();
            this.btn_Backtomain = new System.Windows.Forms.Button();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.txt_stateabbv = new System.Windows.Forms.TextBox();
            this.lbl_stateabbv = new System.Windows.Forms.Label();
            this.txt_zipcode = new System.Windows.Forms.TextBox();
            this.lbl_zipcode = new System.Windows.Forms.Label();
            this.txt_cclname = new System.Windows.Forms.TextBox();
            this.lbl_cclname = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_monthly = new System.Windows.Forms.RadioButton();
            this.btn_yearly = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(10, 16);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(564, 29);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Welcome to the AER Fitness! Enter your new account information below:";
            this.lbl_welcome.Click += new System.EventHandler(this.lbl_welcome_Click);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_create.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.Location = new System.Drawing.Point(441, 338);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(150, 42);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Create New Account";
            this.btn_create.UseCompatibleTextRendering = true;
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(8, 65);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_fname.TabIndex = 2;
            this.lbl_fname.Text = "First Name:";
            this.lbl_fname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(12, 81);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(172, 20);
            this.txt_fname.TabIndex = 3;
            this.txt_fname.TextChanged += new System.EventHandler(this.txt_fname_TextChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(216, 81);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(172, 20);
            this.txt_lname.TabIndex = 5;
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(213, 65);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 4;
            this.lbl_lname.Text = "Last Name:";
            // 
            // txt_streetaddress
            // 
            this.txt_streetaddress.Location = new System.Drawing.Point(12, 131);
            this.txt_streetaddress.Name = "txt_streetaddress";
            this.txt_streetaddress.Size = new System.Drawing.Size(265, 20);
            this.txt_streetaddress.TabIndex = 7;
            this.txt_streetaddress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(9, 115);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(79, 13);
            this.lbl_address.TabIndex = 6;
            this.lbl_address.Text = "Street Address:";
            this.lbl_address.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txt_ccfname
            // 
            this.txt_ccfname.Location = new System.Drawing.Point(15, 230);
            this.txt_ccfname.Name = "txt_ccfname";
            this.txt_ccfname.Size = new System.Drawing.Size(121, 20);
            this.txt_ccfname.TabIndex = 14;
            // 
            // lbl_ccfname
            // 
            this.lbl_ccfname.AutoSize = true;
            this.lbl_ccfname.Location = new System.Drawing.Point(12, 214);
            this.lbl_ccfname.Name = "lbl_ccfname";
            this.lbl_ccfname.Size = new System.Drawing.Size(100, 13);
            this.lbl_ccfname.TabIndex = 13;
            this.lbl_ccfname.Text = "First Name on Card:";
            this.lbl_ccfname.Click += new System.EventHandler(this.lbl_name_Click);
            // 
            // txt_ccnumber
            // 
            this.txt_ccnumber.Location = new System.Drawing.Point(15, 183);
            this.txt_ccnumber.Name = "txt_ccnumber";
            this.txt_ccnumber.Size = new System.Drawing.Size(263, 20);
            this.txt_ccnumber.TabIndex = 12;
            // 
            // lbl_ccnumber
            // 
            this.lbl_ccnumber.AutoSize = true;
            this.lbl_ccnumber.Location = new System.Drawing.Point(12, 166);
            this.lbl_ccnumber.Name = "lbl_ccnumber";
            this.lbl_ccnumber.Size = new System.Drawing.Size(102, 13);
            this.lbl_ccnumber.TabIndex = 11;
            this.lbl_ccnumber.Text = "Credit Card Number:";
            // 
            // txt_cczipcode
            // 
            this.txt_cczipcode.Location = new System.Drawing.Point(471, 183);
            this.txt_cczipcode.Name = "txt_cczipcode";
            this.txt_cczipcode.Size = new System.Drawing.Size(85, 20);
            this.txt_cczipcode.TabIndex = 20;
            // 
            // lbl_cczipcode
            // 
            this.lbl_cczipcode.AutoSize = true;
            this.lbl_cczipcode.Location = new System.Drawing.Point(468, 166);
            this.lbl_cczipcode.Name = "lbl_cczipcode";
            this.lbl_cczipcode.Size = new System.Drawing.Size(53, 13);
            this.lbl_cczipcode.TabIndex = 19;
            this.lbl_cczipcode.Text = "Zip Code:";
            // 
            // txt_ccv
            // 
            this.txt_ccv.Location = new System.Drawing.Point(395, 183);
            this.txt_ccv.Name = "txt_ccv";
            this.txt_ccv.Size = new System.Drawing.Size(41, 20);
            this.txt_ccv.TabIndex = 18;
            // 
            // lbl_cvv
            // 
            this.lbl_cvv.AutoSize = true;
            this.lbl_cvv.Location = new System.Drawing.Point(392, 166);
            this.lbl_cvv.Name = "lbl_cvv";
            this.lbl_cvv.Size = new System.Drawing.Size(31, 13);
            this.lbl_cvv.TabIndex = 17;
            this.lbl_cvv.Text = "CVV:";
            // 
            // txt_expdate
            // 
            this.txt_expdate.Location = new System.Drawing.Point(294, 183);
            this.txt_expdate.Name = "txt_expdate";
            this.txt_expdate.Size = new System.Drawing.Size(74, 20);
            this.txt_expdate.TabIndex = 16;
            // 
            // lbl_expdate
            // 
            this.lbl_expdate.AutoSize = true;
            this.lbl_expdate.Location = new System.Drawing.Point(291, 166);
            this.lbl_expdate.Name = "lbl_expdate";
            this.lbl_expdate.Size = new System.Drawing.Size(80, 13);
            this.lbl_expdate.TabIndex = 15;
            this.lbl_expdate.Text = "Expiration date:";
            // 
            // lbl_choice
            // 
            this.lbl_choice.AutoSize = true;
            this.lbl_choice.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_choice.Location = new System.Drawing.Point(96, 376);
            this.lbl_choice.Name = "lbl_choice";
            this.lbl_choice.Size = new System.Drawing.Size(113, 20);
            this.lbl_choice.TabIndex = 21;
            this.lbl_choice.Text = "Membership Choice";
            // 
            // btn_Backtomain
            // 
            this.btn_Backtomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Backtomain.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backtomain.Location = new System.Drawing.Point(442, 390);
            this.btn_Backtomain.Name = "btn_Backtomain";
            this.btn_Backtomain.Size = new System.Drawing.Size(147, 41);
            this.btn_Backtomain.TabIndex = 5;
            this.btn_Backtomain.Text = "Go Back";
            this.btn_Backtomain.UseCompatibleTextRendering = true;
            this.btn_Backtomain.UseVisualStyleBackColor = true;
            this.btn_Backtomain.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_city
            // 
            this.txt_city.Location = new System.Drawing.Point(292, 131);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(115, 20);
            this.txt_city.TabIndex = 25;
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(289, 115);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(27, 13);
            this.lbl_city.TabIndex = 24;
            this.lbl_city.Text = "City:";
            // 
            // txt_stateabbv
            // 
            this.txt_stateabbv.Location = new System.Drawing.Point(424, 131);
            this.txt_stateabbv.Name = "txt_stateabbv";
            this.txt_stateabbv.Size = new System.Drawing.Size(35, 20);
            this.txt_stateabbv.TabIndex = 27;
            // 
            // lbl_stateabbv
            // 
            this.lbl_stateabbv.AutoSize = true;
            this.lbl_stateabbv.Location = new System.Drawing.Point(421, 115);
            this.lbl_stateabbv.Name = "lbl_stateabbv";
            this.lbl_stateabbv.Size = new System.Drawing.Size(35, 13);
            this.lbl_stateabbv.TabIndex = 26;
            this.lbl_stateabbv.Text = "State:";
            this.lbl_stateabbv.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_zipcode
            // 
            this.txt_zipcode.Location = new System.Drawing.Point(483, 131);
            this.txt_zipcode.Name = "txt_zipcode";
            this.txt_zipcode.Size = new System.Drawing.Size(65, 20);
            this.txt_zipcode.TabIndex = 29;
            // 
            // lbl_zipcode
            // 
            this.lbl_zipcode.AutoSize = true;
            this.lbl_zipcode.Location = new System.Drawing.Point(481, 115);
            this.lbl_zipcode.Name = "lbl_zipcode";
            this.lbl_zipcode.Size = new System.Drawing.Size(53, 13);
            this.lbl_zipcode.TabIndex = 28;
            this.lbl_zipcode.Text = "Zip Code:";
            this.lbl_zipcode.Click += new System.EventHandler(this.lbl_zipcode_Click);
            // 
            // txt_cclname
            // 
            this.txt_cclname.Location = new System.Drawing.Point(157, 230);
            this.txt_cclname.Name = "txt_cclname";
            this.txt_cclname.Size = new System.Drawing.Size(121, 20);
            this.txt_cclname.TabIndex = 31;
            // 
            // lbl_cclname
            // 
            this.lbl_cclname.AutoSize = true;
            this.lbl_cclname.Location = new System.Drawing.Point(154, 213);
            this.lbl_cclname.Name = "lbl_cclname";
            this.lbl_cclname.Size = new System.Drawing.Size(101, 13);
            this.lbl_cclname.TabIndex = 30;
            this.lbl_cclname.Text = "Last Name on Card:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(15, 278);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(265, 20);
            this.txt_email.TabIndex = 33;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(12, 262);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 32;
            this.lbl_email.Text = "Email:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(15, 333);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(265, 20);
            this.txt_password.TabIndex = 35;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(12, 317);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 34;
            this.lbl_password.Text = "Password:";
            this.lbl_password.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btn_monthly
            // 
            this.btn_monthly.AutoSize = true;
            this.btn_monthly.Location = new System.Drawing.Point(15, 404);
            this.btn_monthly.Name = "btn_monthly";
            this.btn_monthly.Size = new System.Drawing.Size(123, 17);
            this.btn_monthly.TabIndex = 36;
            this.btn_monthly.TabStop = true;
            this.btn_monthly.Text = "Monthly ($50/month)";
            this.btn_monthly.UseVisualStyleBackColor = true;
            this.btn_monthly.CheckedChanged += new System.EventHandler(this.btn_monthly_CheckedChanged);
            // 
            // btn_yearly
            // 
            this.btn_yearly.AutoSize = true;
            this.btn_yearly.Location = new System.Drawing.Point(168, 404);
            this.btn_yearly.Name = "btn_yearly";
            this.btn_yearly.Size = new System.Drawing.Size(112, 17);
            this.btn_yearly.TabIndex = 37;
            this.btn_yearly.TabStop = true;
            this.btn_yearly.Text = "Yearly ($500/year)";
            this.btn_yearly.UseVisualStyleBackColor = true;
            this.btn_yearly.CheckedChanged += new System.EventHandler(this.btn_yearly_CheckedChanged);
            // 
            // newacc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btn_yearly);
            this.Controls.Add(this.btn_monthly);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_cclname);
            this.Controls.Add(this.lbl_cclname);
            this.Controls.Add(this.txt_zipcode);
            this.Controls.Add(this.lbl_zipcode);
            this.Controls.Add(this.txt_stateabbv);
            this.Controls.Add(this.lbl_stateabbv);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.btn_Backtomain);
            this.Controls.Add(this.lbl_choice);
            this.Controls.Add(this.txt_cczipcode);
            this.Controls.Add(this.lbl_cczipcode);
            this.Controls.Add(this.txt_ccv);
            this.Controls.Add(this.lbl_cvv);
            this.Controls.Add(this.txt_expdate);
            this.Controls.Add(this.lbl_expdate);
            this.Controls.Add(this.txt_ccfname);
            this.Controls.Add(this.lbl_ccfname);
            this.Controls.Add(this.txt_ccnumber);
            this.Controls.Add(this.lbl_ccnumber);
            this.Controls.Add(this.txt_streetaddress);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "newacc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AER Fitness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_streetaddress;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_ccfname;
        private System.Windows.Forms.Label lbl_ccfname;
        private System.Windows.Forms.TextBox txt_ccnumber;
        private System.Windows.Forms.Label lbl_ccnumber;
        private System.Windows.Forms.TextBox txt_cczipcode;
        private System.Windows.Forms.Label lbl_cczipcode;
        private System.Windows.Forms.TextBox txt_ccv;
        private System.Windows.Forms.Label lbl_cvv;
        private System.Windows.Forms.TextBox txt_expdate;
        private System.Windows.Forms.Label lbl_expdate;
        private System.Windows.Forms.Label lbl_choice;
        private System.Windows.Forms.Button btn_Backtomain;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.TextBox txt_stateabbv;
        private System.Windows.Forms.Label lbl_stateabbv;
        private System.Windows.Forms.TextBox txt_zipcode;
        private System.Windows.Forms.Label lbl_zipcode;
        private System.Windows.Forms.TextBox txt_cclname;
        private System.Windows.Forms.Label lbl_cclname;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.RadioButton btn_monthly;
        private System.Windows.Forms.RadioButton btn_yearly;
    }
}