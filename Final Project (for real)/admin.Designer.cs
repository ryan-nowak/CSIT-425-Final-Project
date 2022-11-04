namespace Final_Project__for_real_
{
    partial class admin
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
            this.components = new System.ComponentModel.Container();
            this.customerInfoDataSet = new Final_Project__for_real_.CustomerInfoDataSet();
            this.customersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersInfoTableAdapter = new Final_Project__for_real_.CustomerInfoDataSetTableAdapters.CustomersInfoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_monthlycharge = new System.Windows.Forms.Button();
            this.btn_yearlycharge = new System.Windows.Forms.Button();
            this.btn_email = new System.Windows.Forms.Button();
            this.btn_filterpaid = new System.Windows.Forms.Button();
            this.btn_filterunpaid = new System.Windows.Forms.Button();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateAbbvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCZipCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.paidDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monthlyMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.yearlyMemberDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consecutiveMonthsLateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoDataSet
            // 
            this.customerInfoDataSet.DataSetName = "CustomerInfoDataSet";
            this.customerInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersInfoBindingSource
            // 
            this.customersInfoBindingSource.DataMember = "CustomersInfo";
            this.customersInfoBindingSource.DataSource = this.customerInfoDataSet;
            // 
            // customersInfoTableAdapter
            // 
            this.customersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.streetAddressDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.stateAbbvDataGridViewTextBoxColumn,
            this.zipCodeDataGridViewTextBoxColumn,
            this.cCNumDataGridViewTextBoxColumn,
            this.cCVDataGridViewTextBoxColumn,
            this.cCFirstNameDataGridViewTextBoxColumn,
            this.cCLastNameDataGridViewTextBoxColumn,
            this.cCZipCodeDataGridViewTextBoxColumn,
            this.currentMemberDataGridViewCheckBoxColumn,
            this.paidDataGridViewCheckBoxColumn,
            this.monthlyMemberDataGridViewCheckBoxColumn,
            this.yearlyMemberDataGridViewCheckBoxColumn,
            this.consecutiveMonthsLateDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customersInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1862, 813);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(1752, 831);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(122, 52);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "Update/Reset Data";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_monthlycharge
            // 
            this.btn_monthlycharge.Location = new System.Drawing.Point(296, 831);
            this.btn_monthlycharge.Name = "btn_monthlycharge";
            this.btn_monthlycharge.Size = new System.Drawing.Size(122, 52);
            this.btn_monthlycharge.TabIndex = 2;
            this.btn_monthlycharge.Text = "Charge Monthly Users";
            this.btn_monthlycharge.UseVisualStyleBackColor = true;
            this.btn_monthlycharge.Click += new System.EventHandler(this.btn_monthlycharge_Click);
            // 
            // btn_yearlycharge
            // 
            this.btn_yearlycharge.Location = new System.Drawing.Point(424, 831);
            this.btn_yearlycharge.Name = "btn_yearlycharge";
            this.btn_yearlycharge.Size = new System.Drawing.Size(122, 52);
            this.btn_yearlycharge.TabIndex = 3;
            this.btn_yearlycharge.Text = "Charge Yearly Users";
            this.btn_yearlycharge.UseVisualStyleBackColor = true;
            this.btn_yearlycharge.Click += new System.EventHandler(this.btn_yearlycharge_Click);
            // 
            // btn_email
            // 
            this.btn_email.Location = new System.Drawing.Point(583, 831);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(122, 52);
            this.btn_email.TabIndex = 4;
            this.btn_email.Text = "Email Consecutive Late Payments";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // btn_filterpaid
            // 
            this.btn_filterpaid.Location = new System.Drawing.Point(12, 831);
            this.btn_filterpaid.Name = "btn_filterpaid";
            this.btn_filterpaid.Size = new System.Drawing.Size(122, 52);
            this.btn_filterpaid.TabIndex = 5;
            this.btn_filterpaid.Text = "Filter Paid Users";
            this.btn_filterpaid.UseVisualStyleBackColor = true;
            this.btn_filterpaid.Click += new System.EventHandler(this.btn_filterpaid_Click);
            // 
            // btn_filterunpaid
            // 
            this.btn_filterunpaid.Location = new System.Drawing.Point(140, 831);
            this.btn_filterunpaid.Name = "btn_filterunpaid";
            this.btn_filterunpaid.Size = new System.Drawing.Size(122, 52);
            this.btn_filterunpaid.TabIndex = 6;
            this.btn_filterunpaid.Text = "Filter Unpaid + Current Users";
            this.btn_filterunpaid.UseVisualStyleBackColor = true;
            this.btn_filterunpaid.Click += new System.EventHandler(this.btn_filterunpaid_Click);
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            this.streetAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateAbbvDataGridViewTextBoxColumn
            // 
            this.stateAbbvDataGridViewTextBoxColumn.DataPropertyName = "StateAbbv";
            this.stateAbbvDataGridViewTextBoxColumn.HeaderText = "StateAbbv";
            this.stateAbbvDataGridViewTextBoxColumn.Name = "stateAbbvDataGridViewTextBoxColumn";
            this.stateAbbvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            this.zipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCNumDataGridViewTextBoxColumn
            // 
            this.cCNumDataGridViewTextBoxColumn.DataPropertyName = "CCNum";
            this.cCNumDataGridViewTextBoxColumn.HeaderText = "CCNum";
            this.cCNumDataGridViewTextBoxColumn.Name = "cCNumDataGridViewTextBoxColumn";
            this.cCNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCVDataGridViewTextBoxColumn
            // 
            this.cCVDataGridViewTextBoxColumn.DataPropertyName = "CCV";
            this.cCVDataGridViewTextBoxColumn.HeaderText = "CCV";
            this.cCVDataGridViewTextBoxColumn.Name = "cCVDataGridViewTextBoxColumn";
            this.cCVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCFirstNameDataGridViewTextBoxColumn
            // 
            this.cCFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CCFirstName";
            this.cCFirstNameDataGridViewTextBoxColumn.HeaderText = "CCFirstName";
            this.cCFirstNameDataGridViewTextBoxColumn.Name = "cCFirstNameDataGridViewTextBoxColumn";
            this.cCFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCLastNameDataGridViewTextBoxColumn
            // 
            this.cCLastNameDataGridViewTextBoxColumn.DataPropertyName = "CCLastName";
            this.cCLastNameDataGridViewTextBoxColumn.HeaderText = "CCLastName";
            this.cCLastNameDataGridViewTextBoxColumn.Name = "cCLastNameDataGridViewTextBoxColumn";
            this.cCLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cCZipCodeDataGridViewTextBoxColumn
            // 
            this.cCZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CCZipCode";
            this.cCZipCodeDataGridViewTextBoxColumn.HeaderText = "CCZipCode";
            this.cCZipCodeDataGridViewTextBoxColumn.Name = "cCZipCodeDataGridViewTextBoxColumn";
            this.cCZipCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // currentMemberDataGridViewCheckBoxColumn
            // 
            this.currentMemberDataGridViewCheckBoxColumn.DataPropertyName = "CurrentMember";
            this.currentMemberDataGridViewCheckBoxColumn.HeaderText = "CurrentMember";
            this.currentMemberDataGridViewCheckBoxColumn.Name = "currentMemberDataGridViewCheckBoxColumn";
            this.currentMemberDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // paidDataGridViewCheckBoxColumn
            // 
            this.paidDataGridViewCheckBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewCheckBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewCheckBoxColumn.Name = "paidDataGridViewCheckBoxColumn";
            this.paidDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // monthlyMemberDataGridViewCheckBoxColumn
            // 
            this.monthlyMemberDataGridViewCheckBoxColumn.DataPropertyName = "MonthlyMember";
            this.monthlyMemberDataGridViewCheckBoxColumn.HeaderText = "MonthlyMember";
            this.monthlyMemberDataGridViewCheckBoxColumn.Name = "monthlyMemberDataGridViewCheckBoxColumn";
            this.monthlyMemberDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // yearlyMemberDataGridViewCheckBoxColumn
            // 
            this.yearlyMemberDataGridViewCheckBoxColumn.DataPropertyName = "YearlyMember";
            this.yearlyMemberDataGridViewCheckBoxColumn.HeaderText = "YearlyMember";
            this.yearlyMemberDataGridViewCheckBoxColumn.Name = "yearlyMemberDataGridViewCheckBoxColumn";
            this.yearlyMemberDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // consecutiveMonthsLateDataGridViewTextBoxColumn
            // 
            this.consecutiveMonthsLateDataGridViewTextBoxColumn.DataPropertyName = "ConsecutiveMonthsLate";
            this.consecutiveMonthsLateDataGridViewTextBoxColumn.HeaderText = "ConsecutiveMonthsLate";
            this.consecutiveMonthsLateDataGridViewTextBoxColumn.Name = "consecutiveMonthsLateDataGridViewTextBoxColumn";
            this.consecutiveMonthsLateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1886, 906);
            this.Controls.Add(this.btn_filterunpaid);
            this.Controls.Add(this.btn_filterpaid);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.btn_yearlycharge);
            this.Controls.Add(this.btn_monthlycharge);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomerInfoDataSet customerInfoDataSet;
        private System.Windows.Forms.BindingSource customersInfoBindingSource;
        private CustomerInfoDataSetTableAdapters.CustomersInfoTableAdapter customersInfoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_monthlycharge;
        private System.Windows.Forms.Button btn_yearlycharge;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_filterpaid;
        private System.Windows.Forms.Button btn_filterunpaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateAbbvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCZipCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn currentMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paidDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn monthlyMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn yearlyMemberDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consecutiveMonthsLateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
    }
}