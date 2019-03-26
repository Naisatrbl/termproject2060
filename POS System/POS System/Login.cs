using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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
            if (!(EmailLength > 0) | !(PasswordLength>0))
                MessageBox.Show("Please enter an email and/or password.");
            else
            {
                //store customer information into database
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
