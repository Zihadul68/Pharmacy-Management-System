namespace PharmacyManagement.Manager
{
    partial class UserControlManageInventory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbMedicineName = new System.Windows.Forms.Label();
            this.lbMedicineId = new System.Windows.Forms.Label();
            this.dgvManageInventory = new System.Windows.Forms.DataGridView();
            this.MedicineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowDetails = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInventory)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.cmbLocation);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.txtMedicineName);
            this.panel2.Controls.Add(this.txtMedicineId);
            this.panel2.Controls.Add(this.lbLocation);
            this.panel2.Controls.Add(this.lbQuantity);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.lbMedicineName);
            this.panel2.Controls.Add(this.lbMedicineId);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 200);
            this.panel2.TabIndex = 0;
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Items.AddRange(new object[] {
            "Shelf-1",
            "Shelf-2",
            "Shelf-3",
            "Shelf-4",
            "Shelf-5",
            "Shelf-6",
            "Shelf-7"});
            this.cmbLocation.Location = new System.Drawing.Point(126, 158);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(236, 21);
            this.cmbLocation.TabIndex = 9;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(126, 125);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(236, 25);
            this.txtQuantity.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(126, 94);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 25);
            this.txtPrice.TabIndex = 7;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineName.Location = new System.Drawing.Point(126, 61);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(236, 25);
            this.txtMedicineName.TabIndex = 6;
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMedicineId.Location = new System.Drawing.Point(126, 24);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(236, 25);
            this.txtMedicineId.TabIndex = 5;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocation.Location = new System.Drawing.Point(22, 161);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(57, 17);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "Location";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(22, 132);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(56, 17);
            this.lbQuantity.TabIndex = 3;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(22, 97);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 17);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // lbMedicineName
            // 
            this.lbMedicineName.AutoSize = true;
            this.lbMedicineName.BackColor = System.Drawing.Color.Transparent;
            this.lbMedicineName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicineName.Location = new System.Drawing.Point(20, 64);
            this.lbMedicineName.Name = "lbMedicineName";
            this.lbMedicineName.Size = new System.Drawing.Size(100, 17);
            this.lbMedicineName.TabIndex = 1;
            this.lbMedicineName.Text = "Medicine Name";
            // 
            // lbMedicineId
            // 
            this.lbMedicineId.AutoSize = true;
            this.lbMedicineId.BackColor = System.Drawing.Color.Transparent;
            this.lbMedicineId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMedicineId.Location = new System.Drawing.Point(22, 27);
            this.lbMedicineId.Name = "lbMedicineId";
            this.lbMedicineId.Size = new System.Drawing.Size(76, 17);
            this.lbMedicineId.TabIndex = 0;
            this.lbMedicineId.Text = "Medicine Id";
            // 
            // dgvManageInventory
            // 
            this.dgvManageInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineId,
            this.MedicineName,
            this.Quantity,
            this.Price,
            this.Location});
            this.dgvManageInventory.Location = new System.Drawing.Point(0, 209);
            this.dgvManageInventory.Name = "dgvManageInventory";
            this.dgvManageInventory.Size = new System.Drawing.Size(678, 296);
            this.dgvManageInventory.TabIndex = 1;
            // 
            // MedicineId
            // 
            this.MedicineId.DataPropertyName = "MedicineId";
            this.MedicineId.HeaderText = "Medicine Id";
            this.MedicineId.Name = "MedicineId";
            // 
            // MedicineName
            // 
            this.MedicineName.DataPropertyName = "MedicineName";
            this.MedicineName.HeaderText = "Medicine Name";
            this.MedicineName.Name = "MedicineName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location.DataPropertyName = "Location";
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dgvManageInventory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 511);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowDetails);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(383, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 200);
            this.panel3.TabIndex = 2;
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.BackColor = System.Drawing.Color.IndianRed;
            this.btnShowDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDetails.Location = new System.Drawing.Point(193, 121);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(102, 65);
            this.btnShowDetails.TabIndex = 4;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseVisualStyleBackColor = false;
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(34, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 38);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(34, 105);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 38);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(34, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 38);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(34, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(125, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // UserControlManageInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UserControlManageInventory";
            this.Size = new System.Drawing.Size(690, 514);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageInventory)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbMedicineName;
        private System.Windows.Forms.Label lbMedicineId;
        private System.Windows.Forms.DataGridView dgvManageInventory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnShowDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
    }
}
