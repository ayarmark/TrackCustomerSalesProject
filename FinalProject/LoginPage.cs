using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class LoginPage : Form
    {
        GetDataDataContext context = new GetDataDataContext();
        public static int CustomerID;
        

        public LoginPage()
        {
            InitializeComponent();

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (IsValidUser(txtUsername.Text, txtPassword.Text))
            {
                var varCustomerID = context.Customers.Select(i => i)
                    .Where(c => c.CustomerUsername == txtUsername.Text);
                foreach(var r in varCustomerID)
                {
                    CustomerID = r.CustomerID;
                }

                MDIParent1 mdi = new MDIParent1();
                mdi.Show();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private bool IsValidUser(String username, String password)
        {
            var test = context.Customers.Select(i => i)
                .Where(c => c.CustomerUsername == txtUsername.Text
                && c.CustomerPassword == txtPassword.Text);
            if (test.Any())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Username or password is invalid. Try again");
                return false;
            }

        }
    }
}
