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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_newacc = new System.Windows.Forms.Button();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_newacc
            // 
            this.btn_newacc.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btn_newacc, "btn_newacc");
            this.btn_newacc.Name = "btn_newacc";
            this.btn_newacc.UseVisualStyleBackColor = true;
            this.btn_newacc.Click += new System.EventHandler(this.btn_newacc_Click);
            // 
            // lbl_email
            // 
            resources.ApplyResources(this.lbl_email, "lbl_email");
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Click += new System.EventHandler(this.lbl_fname_Click);
            // 
            // txt_fname
            // 
            resources.ApplyResources(this.txt_fname, "txt_fname");
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.TextChanged += new System.EventHandler(this.txt_fname_TextChanged);
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Click += new System.EventHandler(this.lbl_lname_Click);
            // 
            // txt_lname
            // 
            resources.ApplyResources(this.txt_lname, "txt_lname");
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.TextChanged += new System.EventHandler(this.txt_lname_TextChanged);
            this.txt_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lname_KeyPress);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.btn_newacc);
            this.Controls.Add(this.btn_login);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_newacc;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_lname;
    }
}

