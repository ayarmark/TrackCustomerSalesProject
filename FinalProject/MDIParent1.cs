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
    public partial class MDIParent1 : Form
    {
        //private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

       

    

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void myAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
                MyAccount childForm = new MyAccount();
                childForm.MdiParent = this;
                //childForm.Text = "Window " + childFormNumber++;
                childForm.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemsForSale childForm = new ItemsForSale();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void myOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyOrders childForm = new MyOrders();
            childForm.MdiParent = this;
            //childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }


    }
}
