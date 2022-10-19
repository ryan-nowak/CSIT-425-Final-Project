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
            this.customerInfoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customerInfoDataSet1 = new Final_Project__for_real_.CustomerInfoDataSet1();
            this.customersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersInfoTableAdapter = new Final_Project__for_real_.CustomerInfoDataSet1TableAdapters.CustomersInfoTableAdapter();
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
            this.typeOfMembershipDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customerInfoDataSet
            // 
            this.customerInfoDataSet.DataSetName = "CustomerInfoDataSet";
            this.customerInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerInfoDataSetBindingSource
            // 
            this.customerInfoDataSetBindingSource.DataSource = this.customerInfoDataSet;
            this.customerInfoDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
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
            this.typeOfMembershipDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.customersInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1586, 847);
            this.dataGridView1.TabIndex = 0;
            // 
            // customerInfoDataSet1
            // 
            this.customerInfoDataSet1.DataSetName = "CustomerInfoDataSet1";
            this.customerInfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersInfoBindingSource
            // 
            this.customersInfoBindingSource.DataMember = "CustomersInfo";
            this.customersInfoBindingSource.DataSource = this.customerInfoDataSet1;
            // 
            // customersInfoTableAdapter
            // 
            this.customersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // streetAddressDataGridViewTextBoxColumn
            // 
            this.streetAddressDataGridViewTextBoxColumn.DataPropertyName = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.HeaderText = "StreetAddress";
            this.streetAddressDataGridViewTextBoxColumn.Name = "streetAddressDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // stateAbbvDataGridViewTextBoxColumn
            // 
            this.stateAbbvDataGridViewTextBoxColumn.DataPropertyName = "StateAbbv";
            this.stateAbbvDataGridViewTextBoxColumn.HeaderText = "StateAbbv";
            this.stateAbbvDataGridViewTextBoxColumn.Name = "stateAbbvDataGridViewTextBoxColumn";
            // 
            // zipCodeDataGridViewTextBoxColumn
            // 
            this.zipCodeDataGridViewTextBoxColumn.DataPropertyName = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.HeaderText = "ZipCode";
            this.zipCodeDataGridViewTextBoxColumn.Name = "zipCodeDataGridViewTextBoxColumn";
            // 
            // cCNumDataGridViewTextBoxColumn
            // 
            this.cCNumDataGridViewTextBoxColumn.DataPropertyName = "CCNum";
            this.cCNumDataGridViewTextBoxColumn.HeaderText = "CCNum";
            this.cCNumDataGridViewTextBoxColumn.Name = "cCNumDataGridViewTextBoxColumn";
            // 
            // cCVDataGridViewTextBoxColumn
            // 
            this.cCVDataGridViewTextBoxColumn.DataPropertyName = "CCV";
            this.cCVDataGridViewTextBoxColumn.HeaderText = "CCV";
            this.cCVDataGridViewTextBoxColumn.Name = "cCVDataGridViewTextBoxColumn";
            // 
            // cCFirstNameDataGridViewTextBoxColumn
            // 
            this.cCFirstNameDataGridViewTextBoxColumn.DataPropertyName = "CCFirstName";
            this.cCFirstNameDataGridViewTextBoxColumn.HeaderText = "CCFirstName";
            this.cCFirstNameDataGridViewTextBoxColumn.Name = "cCFirstNameDataGridViewTextBoxColumn";
            // 
            // cCLastNameDataGridViewTextBoxColumn
            // 
            this.cCLastNameDataGridViewTextBoxColumn.DataPropertyName = "CCLastName";
            this.cCLastNameDataGridViewTextBoxColumn.HeaderText = "CCLastName";
            this.cCLastNameDataGridViewTextBoxColumn.Name = "cCLastNameDataGridViewTextBoxColumn";
            // 
            // cCZipCodeDataGridViewTextBoxColumn
            // 
            this.cCZipCodeDataGridViewTextBoxColumn.DataPropertyName = "CCZipCode";
            this.cCZipCodeDataGridViewTextBoxColumn.HeaderText = "CCZipCode";
            this.cCZipCodeDataGridViewTextBoxColumn.Name = "cCZipCodeDataGridViewTextBoxColumn";
            // 
            // currentMemberDataGridViewCheckBoxColumn
            // 
            this.currentMemberDataGridViewCheckBoxColumn.DataPropertyName = "CurrentMember";
            this.currentMemberDataGridViewCheckBoxColumn.HeaderText = "CurrentMember";
            this.currentMemberDataGridViewCheckBoxColumn.Name = "currentMemberDataGridViewCheckBoxColumn";
            // 
            // typeOfMembershipDataGridViewCheckBoxColumn
            // 
            this.typeOfMembershipDataGridViewCheckBoxColumn.DataPropertyName = "TypeOfMembership";
            this.typeOfMembershipDataGridViewCheckBoxColumn.HeaderText = "TypeOfMembership";
            this.typeOfMembershipDataGridViewCheckBoxColumn.Name = "typeOfMembershipDataGridViewCheckBoxColumn";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 871);
            this.Controls.Add(this.dataGridView1);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerInfoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource customerInfoDataSetBindingSource;
        private CustomerInfoDataSet customerInfoDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CustomerInfoDataSet1 customerInfoDataSet1;
        private System.Windows.Forms.BindingSource customersInfoBindingSource;
        private CustomerInfoDataSet1TableAdapters.CustomersInfoTableAdapter customersInfoTableAdapter;
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeOfMembershipDataGridViewCheckBoxColumn;
    }
}