namespace Final_Project__for_real_
{
    partial class login
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_newacc = new System.Windows.Forms.Button();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(383, 303);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(80, 42);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_newacc
            // 
            this.btn_newacc.Location = new System.Drawing.Point(509, 303);
            this.btn_newacc.Name = "btn_newacc";
            this.btn_newacc.Size = new System.Drawing.Size(80, 42);
            this.btn_newacc.TabIndex = 5;
            this.btn_newacc.Text = "Make New Account";
            this.btn_newacc.UseVisualStyleBackColor = true;
            this.btn_newacc.Click += new System.EventHandler(this.btn_newacc_Click);
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(380, 163);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(60, 13);
            this.lbl_fname.TabIndex = 7;
            this.lbl_fname.Text = "First Name:";
            this.lbl_fname.Click += new System.EventHandler(this.lbl_fname_Click);
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(383, 179);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(206, 20);
            this.txt_fname.TabIndex = 6;
            this.txt_fname.TextChanged += new System.EventHandler(this.txt_fname_TextChanged);
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(380, 235);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(61, 13);
            this.lbl_lname.TabIndex = 9;
            this.lbl_lname.Text = "Last Name:";
            this.lbl_lname.Click += new System.EventHandler(this.lbl_lname_Click);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(383, 251);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(206, 20);
            this.txt_lname.TabIndex = 8;
            this.txt_lname.TextChanged += new System.EventHandler(this.txt_lname_TextChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 633);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.btn_newacc);
            this.Controls.Add(this.btn_login);
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_newacc;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.TextBox txt_lname;
    }
}

