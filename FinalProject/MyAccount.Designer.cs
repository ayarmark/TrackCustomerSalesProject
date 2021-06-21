
namespace FinalProject
{
    partial class MyAccount
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
            this.accountName = new System.Windows.Forms.Label();
            this.accountBalance = new System.Windows.Forms.Label();
            this.paymentLabel = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.submitPayment = new System.Windows.Forms.Button();
            this.accountBalanceVal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountName
            // 
            this.accountName.AutoSize = true;
            this.accountName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.Location = new System.Drawing.Point(253, 102);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(52, 21);
            this.accountName.TabIndex = 0;
            this.accountName.Text = "Hello";
            // 
            // accountBalance
            // 
            this.accountBalance.AutoSize = true;
            this.accountBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBalance.Location = new System.Drawing.Point(253, 165);
            this.accountBalance.Name = "accountBalance";
            this.accountBalance.Size = new System.Drawing.Size(183, 20);
            this.accountBalance.TabIndex = 1;
            this.accountBalance.Text = "Your account balance is:";
            // 
            // paymentLabel
            // 
            this.paymentLabel.AutoSize = true;
            this.paymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentLabel.Location = new System.Drawing.Point(253, 217);
            this.paymentLabel.Name = "paymentLabel";
            this.paymentLabel.Size = new System.Drawing.Size(241, 20);
            this.paymentLabel.TabIndex = 2;
            this.paymentLabel.Text = "How much would you like to pay?";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(500, 217);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(106, 20);
            this.txtPayment.TabIndex = 3;
            // 
            // submitPayment
            // 
            this.submitPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitPayment.Location = new System.Drawing.Point(331, 262);
            this.submitPayment.Name = "submitPayment";
            this.submitPayment.Size = new System.Drawing.Size(88, 38);
            this.submitPayment.TabIndex = 4;
            this.submitPayment.Text = "Pay now";
            this.submitPayment.UseVisualStyleBackColor = true;
            this.submitPayment.Click += new System.EventHandler(this.submitPayment_Click);
            // 
            // accountBalanceVal
            // 
            this.accountBalanceVal.AutoSize = true;
            this.accountBalanceVal.Location = new System.Drawing.Point(457, 171);
            this.accountBalanceVal.Name = "accountBalanceVal";
            this.accountBalanceVal.Size = new System.Drawing.Size(0, 13);
            this.accountBalanceVal.TabIndex = 5;
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.accountBalanceVal);
            this.Controls.Add(this.submitPayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.paymentLabel);
            this.Controls.Add(this.accountBalance);
            this.Controls.Add(this.accountName);
            this.Name = "MyAccount";
            this.Text = "My Account";
            this.Load += new System.EventHandler(this.MyAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountName;
        private System.Windows.Forms.Label accountBalance;
        private System.Windows.Forms.Label paymentLabel;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Button submitPayment;
        private System.Windows.Forms.Label accountBalanceVal;
    }
}