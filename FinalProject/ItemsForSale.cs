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
    public partial class ItemsForSale : Form
    {
        GetDataDataContext context = new GetDataDataContext();
        public int CustomerID = LoginPage.CustomerID;
        decimal bal = 0;
        decimal itemPrice;

        public ItemsForSale()
        {
            InitializeComponent();
            var customer = context.Customers.Select(i => i).Where(d => d.CustomerID == CustomerID);
            foreach (var b in customer)
            {
                bal = b.CustomerBalance;
            }
            

        }

        private void Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemsForSale_Load(object sender, EventArgs e)
        {
            var itemForSaleQuery = context.Items.Select(i => i);
            Items.DataSource = itemForSaleQuery.ToList();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            
            if (!isBalanceTooHigh())
            {
                int ItemID = Int32.Parse(txtItemID.Text);
                int qty = Int32.Parse(txtQty.Text);
                var items = context.Items.Select(i => i).Where(p => p.ItemID == ItemID);
                foreach (var i in items)
                {
                    itemPrice = i.Price;
                }
                var itemNameList = context.Items.Select(i => i).Where(n => n.ItemID == ItemID);
                String itemName = "about to get a name";
                foreach (var n in itemNameList)
                {
                    itemName = n.ItemName;
                }
                decimal totalPrice = itemPrice * qty;
                updateOrder(ItemID, qty, totalPrice, itemName);
                updateBalance(ItemID, qty, totalPrice);

                this.Close();
            }
            else
            {
                MessageBox.Show($"Your balance is {bal} ,you've exceeded your credit limit of 100 and cannot make any purchases at this time.");
                this.Close();
            }
        }

        private void updateOrder(int ItemID, int qty, decimal totalPrice, String itemName)
        {
            var purchases = context.Purchases.Select(o => o).Where(u => u.CustomerID == CustomerID);
            
            Purchase purch = new Purchase();
            purch.CustomerID = CustomerID;
            purch.Date = DateTime.Now;
            purch.ItemID = ItemID;
            purch.Quantity = qty;
            purch.TotalPrice = totalPrice;
            purch.ItemName = itemName;
            context.Purchases.InsertOnSubmit(purch);
            context.SubmitChanges();

        }

        private void updateBalance(int ItemID, int qty, decimal totalPrice)
        {

            var customer = context.Customers.Select(i => i).Where(d => d.CustomerID == CustomerID);
            foreach (var b in customer)
            {
                b.CustomerBalance += totalPrice;
            }
           
            context.SubmitChanges();
            MessageBox.Show($"Your bill is {totalPrice}");
        }

        private bool isBalanceTooHigh()
        {
            if (bal > 100)
                return true;
            else
                return false;
        }
    }
}
