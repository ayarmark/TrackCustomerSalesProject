
namespace FinalProject
{
    partial class ItemsForSale
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
            this.Items = new System.Windows.Forms.DataGridView();
            this.lblItemID = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.purchase = new System.Windows.Forms.Button();
            this.lblItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Items)).BeginInit();
            this.SuspendLayout();
            // 
            // Items
            // 
            this.Items.AllowUserToAddRows = false;
            this.Items.AllowUserToDeleteRows = false;
            this.Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Items.Location = new System.Drawing.Point(23, 47);
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            this.Items.Size = new System.Drawing.Size(370, 336);
            this.Items.TabIndex = 0;
            this.Items.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Items_CellContentClick);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(426, 193);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(69, 13);
            this.lblItemID.TabIndex = 1;
            this.lblItemID.Text = "Enter Item ID";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Location = new System.Drawing.Point(423, 280);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(72, 13);
            this.lblqty.TabIndex = 2;
            this.lblqty.Text = "Enter quantity";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(535, 190);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 20);
            this.txtItemID.TabIndex = 3;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(535, 273);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 4;
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(481, 328);
            this.purchase.Name = "purchase";
            this.purchase.Size = new System.Drawing.Size(75, 23);
            this.purchase.TabIndex = 5;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            this.purchase.Click += new System.EventHandler(this.purchase_Click);
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(156, 20);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(77, 13);
            this.lblItems.TabIndex = 6;
            this.lblItems.Text = "Items For Sale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Please enter the item number and quantity you wish to purchase:";
            // 
            // ItemsForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.purchase);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.lblItemID);
            this.Controls.Add(this.Items);
            this.Name = "ItemsForSale";
            this.Text = "ItemsForSale";
            this.Load += new System.EventHandler(this.ItemsForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Items;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button purchase;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label label1;
    }
}