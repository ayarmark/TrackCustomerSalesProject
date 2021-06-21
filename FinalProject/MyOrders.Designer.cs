
namespace FinalProject
{
    partial class MyOrders
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
            this.Purchases = new System.Windows.Forms.DataGridView();
            this.Instructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLow = new System.Windows.Forms.Label();
            this.lblHigh = new System.Windows.Forms.Label();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtHigh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.btnSeeOrders = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Purchases)).BeginInit();
            this.SuspendLayout();
            // 
            // Purchases
            // 
            this.Purchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Purchases.Location = new System.Drawing.Point(30, 134);
            this.Purchases.Name = "Purchases";
            this.Purchases.Size = new System.Drawing.Size(743, 304);
            this.Purchases.TabIndex = 0;
            this.Purchases.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Instructions
            // 
            this.Instructions.AutoSize = true;
            this.Instructions.Location = new System.Drawing.Point(243, 18);
            this.Instructions.Name = "Instructions";
            this.Instructions.Size = new System.Drawing.Size(287, 13);
            this.Instructions.TabIndex = 1;
            this.Instructions.Text = "View a list of purchases within a certain date or price range:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(584, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Price Range";
            // 
            // lblLow
            // 
            this.lblLow.AutoSize = true;
            this.lblLow.Location = new System.Drawing.Point(567, 36);
            this.lblLow.Name = "lblLow";
            this.lblLow.Size = new System.Drawing.Size(30, 13);
            this.lblLow.TabIndex = 3;
            this.lblLow.Text = "Low:";
            // 
            // lblHigh
            // 
            this.lblHigh.AutoSize = true;
            this.lblHigh.Location = new System.Drawing.Point(567, 62);
            this.lblHigh.Name = "lblHigh";
            this.lblHigh.Size = new System.Drawing.Size(32, 13);
            this.lblHigh.TabIndex = 4;
            this.lblHigh.Text = "High:";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(626, 36);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(65, 20);
            this.txtLow.TabIndex = 5;
            // 
            // txtHigh
            // 
            this.txtHigh.Location = new System.Drawing.Point(626, 62);
            this.txtHigh.Name = "txtHigh";
            this.txtHigh.Size = new System.Drawing.Size(65, 20);
            this.txtHigh.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date Range";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(117, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 59);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(47, 65);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(47, 103);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "End Date:";
            // 
            // btnSeeOrders
            // 
            this.btnSeeOrders.Location = new System.Drawing.Point(570, 91);
            this.btnSeeOrders.Name = "btnSeeOrders";
            this.btnSeeOrders.Size = new System.Drawing.Size(117, 23);
            this.btnSeeOrders.TabIndex = 13;
            this.btnSeeOrders.Text = "See Orders by price";
            this.btnSeeOrders.UseVisualStyleBackColor = true;
            this.btnSeeOrders.Click += new System.EventHandler(this.btnSeeOrders_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(338, 70);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(108, 23);
            this.btnDate.TabIndex = 14;
            this.btnDate.Text = "See Orders by date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnSeeOrders);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHigh);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.lblHigh);
            this.Controls.Add(this.lblLow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Instructions);
            this.Controls.Add(this.Purchases);
            this.Name = "MyOrders";
            this.Text = "MyOrders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Purchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Purchases;
        private System.Windows.Forms.Label Instructions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLow;
        private System.Windows.Forms.Label lblHigh;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Button btnSeeOrders;
        private System.Windows.Forms.Button btnDate;
    }
}