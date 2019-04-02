using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; // at the top
using System.Data.OleDb;

namespace POS_System
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\collinguidry\Source\Repos\termproject2060\POS System\POS System\2060 Term Project.mdb";
            connection.Open();
            /////////////////////////

            /////////////////////////
            connection.Close();
        }
        private void DBConnect (object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\collinguidry\Source\Repos\termproject2060\POS System\POS System\2060 Term Project.mdb";
            connection.Open();
            /////////////////////////

            /////////////////////////
            
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Email = textBox1.Text;
            string Password = textBox2.Text;

            int EmailLength = Email.Length;
            int PasswordLength = Password.Length;
            if (!(EmailLength > 0) | !(PasswordLength > 0))
                MessageBox.Show("Please enter an email and/or password.");
            else
            {

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\collinguidry\Source\Repos\termproject2060\POS System\POS System\2060 Term Project.mdb";
                connection.Open();
                /////////////////////////

                OleDbCommand cmd_employee = new OleDbCommand("select * from Employees where Email = @a", connection);
                cmd_employee.Parameters.AddWithValue("@a", Convert.ToString(textBox1.Text));
                OleDbDataReader DR = cmd_employee.ExecuteReader();
                Email = Convert.ToString(textBox1.Text); // employee email

                OleDbCommand cmd_user = new OleDbCommand("select * from Customers where Email = @b", connection);
                cmd_user.Parameters.AddWithValue("@b", Convert.ToString(textBox1.Text));
                OleDbDataReader DR1 = cmd_user.ExecuteReader();
                Email = Convert.ToString(textBox1.Text); // customer email


                string X = "", X1 = "";
                while (DR.Read())
                {
                    X = DR["password"].ToString(); //Read a value from query

                }

                while (DR.Read())
                {
                    X1 = DR1["password"].ToString(); //Read a value from query

                }

                DR.Close();
                DR1.Close();

                if (X == Convert.ToString(textBox2.Text)) //if password entered = password in database
                {
                    this.Hide();
                    EmployeeView form = new EmployeeView();
                    form.Show();
                }
                else
                 if (X1 == Convert.ToString(textBox2.Text))
                    {
                        this.Hide();
                        NewCustomerForm f2 = new NewCustomerForm();
                        f2.Show();
                    }
                else
                {
                    this.Hide();
                    LoginForm f1 = new LoginForm();
                    f1.Show();
                }
                
                /////////////////////////
                connection.Close();
            }

        }



        private void EmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private class Form1
        {
        }
    }
}
