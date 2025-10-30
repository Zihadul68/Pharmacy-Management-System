namespace PharmacyManagement.Pharmacist
{
    partial class UserControlPhManageInventory
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
            this.pnlnventory = new System.Windows.Forms.Panel();
            this.dgvPharmacistInventory = new System.Windows.Forms.DataGridView();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbInventory = new System.Windows.Forms.Label();
            this.txtAutoSearch = new System.Windows.Forms.TextBox();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlnventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacistInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlnventory
            // 
            this.pnlnventory.Controls.Add(this.txtAutoSearch);
            this.pnlnventory.Controls.Add(this.dgvPharmacistInventory);
            this.pnlnventory.Controls.Add(this.btnShowDetails);
            this.pnlnventory.Controls.Add(this.btnSearch);
            this.pnlnventory.Controls.Add(this.txtSearch);
            this.pnlnventory.Controls.Add(this.lbInventory);
            this.pnlnventory.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlnventory.Location = new System.Drawing.Point(3, 3);
            this.pnlnventory.Name = "pnlnventory";
            this.pnlnventory.Size = new System.Drawing.Size(708, 438);
            this.pnlnventory.TabIndex = 0;
            // 
            // dgvPharmacistInventory
            // 
            this.dgvPharmacistInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvPharmacistInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPharmacistInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName,
            this.MedicineId,
            this.Price,
            this.Quantity,
            this.Location});
            this.dgvPharmacistInventory.Location = new System.Drawing.Point(-3, 114);
            this.dgvPharmacistInventory.Name = "dgvPharmacistInventory";
            this.dgvPharmacistInventory.Size = new System.Drawing.Size(714, 327);
            this.dgvPharmacistInventory.TabIndex = 4;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(605, 75);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(100, 33);
            this.btnShowDetails.TabIndex = 3;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(271, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Location = new System.Drawing.Point(111, 82);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lbInventory
            // 
            this.lbInventory.AutoSize = true;
            this.lbInventory.BackColor = System.Drawing.Color.Transparent;
            this.lbInventory.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventory.Location = new System.Drawing.Point(14, 75);
            this.lbInventory.Name = "lbInventory";
            this.lbInventory.Size = new System.Drawing.Size(91, 25);
            this.lbInventory.TabIndex = 0;
            this.lbInventory.Text = "Inventory";
            // 
            // txtAutoSearch
            // 
            this.txtAutoSearch.Location = new System.Drawing.Point(396, 83);
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.Size = new System.Drawing.Size(175, 22);
            this.txtAutoSearch.TabIndex = 5;
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // MedicineName
            // 
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            // 
            // MedicineId
            // 
            this.MedicineId.DataPropertyName = "MedicineId";
            this.MedicineId.HeaderText = "Medicine Id";
            this.MedicineId.Name = "MedicineId";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            // 
            // UserControlPhManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlnventory);
            this.Name = "UserControlPhManageInventory";
            this.Size = new System.Drawing.Size(714, 444);
            this.pnlnventory.ResumeLayout(false);
            this.pnlnventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPharmacistInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlnventory;
        private System.Windows.Forms.DataGridView dgvPharmacistInventory;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbInventory;
        private System.Windows.Forms.TextBox txtAutoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}
