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
    public partial class MyAccount : Form
    {
        static GetDataDataContext context = new GetDataDataContext();
        public int CustomerID = LoginPage.CustomerID;
        String name = "empty";
        decimal bal = 0;

        public MyAccount()
        {
            InitializeComponent();
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {
            
            getData();
        }

        private void submitPayment_Click(object sender, EventArgs e)
        {
            String pay = txtPayment.Text;
            decimal payment = decimal.Parse(pay);
            decimal newBalance = bal - payment;
            var customer = context.Customers.Select(i => i).Where(d => d.CustomerID == CustomerID);
            foreach (var b in customer)
            {
                b.CustomerBalance = newBalance;
            }
            context.SubmitChanges();
            bal = newBalance;
            accountBalanceVal.Text = bal.ToString();
            MessageBox.Show($"Thank you for your payment of ${payment}");
            this.Close();
        }

        private void getData()
        {
            context.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, context.Customers);
            this.Refresh();
            var customer = context.Customers.Select(i => i).Where(d => d.CustomerID == CustomerID);
            foreach (var b in customer)
            {
                bal = b.CustomerBalance;
                name = b.CustomerName;
            }
            accountName.Text = "Hello " + name + "!";
            accountBalanceVal.Text = bal.ToString();
        }

    }
}
