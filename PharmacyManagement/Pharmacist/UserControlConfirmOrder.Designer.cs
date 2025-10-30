namespace PharmacyManagement.Pharmacist
{
    partial class UserControlConfirmOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerPhnNo = new System.Windows.Forms.Label();
            this.lbTotalBill = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(91, 101);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(82, 13);
            this.lbCustomerName.TabIndex = 0;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // lbCustomerPhnNo
            // 
            this.lbCustomerPhnNo.AutoSize = true;
            this.lbCustomerPhnNo.Location = new System.Drawing.Point(91, 146);
            this.lbCustomerPhnNo.Name = "lbCustomerPhnNo";
            this.lbCustomerPhnNo.Size = new System.Drawing.Size(102, 13);
            this.lbCustomerPhnNo.TabIndex = 1;
            this.lbCustomerPhnNo.Text = "Customer Phone No";
            // 
            // lbTotalBill
            // 
            this.lbTotalBill.AutoSize = true;
            this.lbTotalBill.Location = new System.Drawing.Point(91, 183);
            this.lbTotalBill.Name = "lbTotalBill";
            this.lbTotalBill.Size = new System.Drawing.Size(47, 13);
            this.lbTotalBill.TabIndex = 2;
            this.lbTotalBill.Text = "Total Bill";
            this.lbTotalBill.Click += new System.EventHandler(this.lbTotalBill_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(218, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(218, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(218, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 20);
            this.textBox3.TabIndex = 5;
            // 
            // UserControlConfirmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTotalBill);
            this.Controls.Add(this.lbCustomerPhnNo);
            this.Controls.Add(this.lbCustomerName);
            this.Name = "UserControlConfirmOrder";
            this.Size = new System.Drawing.Size(550, 354);
            this.Load += new System.EventHandler(this.UserControlConfirmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerPhnNo;
        private System.Windows.Forms.Label lbTotalBill;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}
