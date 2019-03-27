using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;//needed
using System.Data.OleDb;//

namespace POS_System
{
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void EmployeeView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_2060_Term_ProjectDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._2060_Term_ProjectDataSet.Employees);



            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\collinguidry\Source\Repos\termproject2060\POS System\POS System\2060 Term Project.mdb";
            connection.Open();




            MessageBox.Show("DB Connection Successful!!");
            connection.Close();






            // TODO: This line of code loads data into the '_2060_Term_ProjectDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this._2060_Term_ProjectDataSet.Customers);
            // TODO: This line of code loads data into the '_2060_Term_ProjectDataSet.Items' table. You can move, or remove it, as needed.
            this.itemsTableAdapter.Fill(this._2060_Term_ProjectDataSet.Items);
            // TODO: This line of code loads data into the '_2060_Term_ProjectDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this._2060_Term_ProjectDataSet.Transactions);
            // TODO: This line of code loads data into the '_2060_Term_ProjectDataSet.Billing_Addresses' table. You can move, or remove it, as needed.
            this.billing_AddressesTableAdapter.Fill(this._2060_Term_ProjectDataSet.Billing_Addresses);

        }
    }
}
