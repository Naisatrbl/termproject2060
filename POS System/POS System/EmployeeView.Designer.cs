namespace POS_System
{
    partial class EmployeeView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oRDERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._2060_Term_ProjectDataSet = new POS_System._2060_Term_ProjectDataSet();
            this.termProjectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingAddressesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billing_AddressesTableAdapter = new POS_System._2060_Term_ProjectDataSetTableAdapters.Billing_AddressesTableAdapter();
            this.transactionsTableAdapter = new POS_System._2060_Term_ProjectDataSetTableAdapters.TransactionsTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new POS_System._2060_Term_ProjectDataSetTableAdapters.ItemsTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new POS_System._2060_Term_ProjectDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._2060_Term_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingAddressesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionIDDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.oRDERIDDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.creditCardDataGridViewTextBoxColumn,
            this.billingAddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // transactionIDDataGridViewTextBoxColumn
            // 
            this.transactionIDDataGridViewTextBoxColumn.DataPropertyName = "Transaction ID";
            this.transactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction ID";
            this.transactionIDDataGridViewTextBoxColumn.Name = "transactionIDDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "Customer Email";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "Customer Email";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // oRDERIDDataGridViewTextBoxColumn
            // 
            this.oRDERIDDataGridViewTextBoxColumn.DataPropertyName = "ORDER ID";
            this.oRDERIDDataGridViewTextBoxColumn.HeaderText = "ORDER ID";
            this.oRDERIDDataGridViewTextBoxColumn.Name = "oRDERIDDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // creditCardDataGridViewTextBoxColumn
            // 
            this.creditCardDataGridViewTextBoxColumn.DataPropertyName = "CreditCard #";
            this.creditCardDataGridViewTextBoxColumn.HeaderText = "CreditCard #";
            this.creditCardDataGridViewTextBoxColumn.Name = "creditCardDataGridViewTextBoxColumn";
            // 
            // billingAddressDataGridViewTextBoxColumn
            // 
            this.billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.HeaderText = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this._2060_Term_ProjectDataSet;
            // 
            // _2060_Term_ProjectDataSet
            // 
            this._2060_Term_ProjectDataSet.DataSetName = "_2060_Term_ProjectDataSet";
            this._2060_Term_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // termProjectDataSetBindingSource
            // 
            this.termProjectDataSetBindingSource.DataSource = this._2060_Term_ProjectDataSet;
            this.termProjectDataSetBindingSource.Position = 0;
            // 
            // billingAddressesBindingSource
            // 
            this.billingAddressesBindingSource.DataMember = "Billing Addresses";
            this.billingAddressesBindingSource.DataSource = this._2060_Term_ProjectDataSet;
            // 
            // billing_AddressesTableAdapter
            // 
            this.billing_AddressesTableAdapter.ClearBeforeFill = true;
            // 
            // transactionsTableAdapter
            // 
            this.transactionsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.inventoryQuantityDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.itemsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(32, 248);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(543, 295);
            this.dataGridView2.TabIndex = 1;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "Item Price";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "Item Price";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // inventoryQuantityDataGridViewTextBoxColumn
            // 
            this.inventoryQuantityDataGridViewTextBoxColumn.DataPropertyName = "Inventory Quantity";
            this.inventoryQuantityDataGridViewTextBoxColumn.HeaderText = "Inventory Quantity";
            this.inventoryQuantityDataGridViewTextBoxColumn.Name = "inventoryQuantityDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this._2060_Term_ProjectDataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.customersBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(588, 248);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(443, 295);
            this.dataGridView3.TabIndex = 2;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
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
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this._2060_Term_ProjectDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 554);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeView";
            this.Text = "EmployeeView";
            this.Load += new System.EventHandler(this.EmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._2060_Term_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termProjectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingAddressesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource termProjectDataSetBindingSource;
        private _2060_Term_ProjectDataSet _2060_Term_ProjectDataSet;
        private System.Windows.Forms.BindingSource billingAddressesBindingSource;
        private _2060_Term_ProjectDataSetTableAdapters.Billing_AddressesTableAdapter billing_AddressesTableAdapter;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private _2060_Term_ProjectDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oRDERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private _2060_Term_ProjectDataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private _2060_Term_ProjectDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    }
}