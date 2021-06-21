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
    public partial class MyOrders : Form
    {
        GetDataDataContext context = new GetDataDataContext();
        public int CustomerID = LoginPage.CustomerID;

        public MyOrders()
        {
            InitializeComponent();
        }

        private void MyOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSeeOrders_Click(object sender, EventArgs e)
        {
            decimal lowPrice = decimal.Parse(txtLow.Text);
            decimal highPrice = decimal.Parse(txtHigh.Text);
            var purchasesQuery = context.Purchases.Select(i => i).Where(c => c.CustomerID == CustomerID
                                && c.TotalPrice >= lowPrice && c.TotalPrice <= highPrice);
            Purchases.DataSource = purchasesQuery.ToList();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dateTimePicker1.Value;
            DateTime toDate = dateTimePicker2.Value;
            var purchasesQuery = context.Purchases.Select(i => i).Where(c => c.CustomerID == CustomerID
                                && c.Date >= fromDate && c.Date <= toDate);
            Purchases.DataSource = purchasesQuery.ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
