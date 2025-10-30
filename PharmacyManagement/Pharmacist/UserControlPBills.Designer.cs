namespace PharmacyManagement.Pharmacist
{
    partial class UserControlPBills
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
            this.pnlBill1 = new System.Windows.Forms.Panel();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtMedicineName = new System.Windows.Forms.TextBox();
            this.txtMedicineId = new System.Windows.Forms.TextBox();
            this.lblMedicineDetails = new System.Windows.Forms.Label();
            this.dgvMedicineInfo = new System.Windows.Forms.DataGridView();
            this.MedicineName_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineId_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location_Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lblMedicineId = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBill2 = new System.Windows.Forms.Panel();
            this.btnBill = new System.Windows.Forms.Button();
            this.lblTotalBillShow = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.txtCustomerPhnNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerInfo = new System.Windows.Forms.Label();
            this.lblCustPhnNo = new System.Windows.Forms.Label();
            this.dgvCartInfo = new System.Windows.Forms.DataGridView();
            this.MedicineName_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Cart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCartInfo = new System.Windows.Forms.Label();
            this.pnlBill1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineInfo)).BeginInit();
            this.pnlBill2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBill1
            // 
            this.pnlBill1.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBill1.Controls.Add(this.cmbLocation);
            this.pnlBill1.Controls.Add(this.txtQuantity);
            this.pnlBill1.Controls.Add(this.txtPrice);
            this.pnlBill1.Controls.Add(this.txtMedicineName);
            this.pnlBill1.Controls.Add(this.txtMedicineId);
            this.pnlBill1.Controls.Add(this.lblMedicineDetails);
            this.pnlBill1.Controls.Add(this.dgvMedicineInfo);
            this.pnlBill1.Controls.Add(this.btnAddToCart);
            this.pnlBill1.Controls.Add(this.lblMedicineId);
            this.pnlBill1.Controls.Add(this.lblPrice);
            this.pnlBill1.Controls.Add(this.lblQuantity);
            this.pnlBill1.Controls.Add(this.lblLocation);
            this.pnlBill1.Controls.Add(this.lblName);
            this.pnlBill1.Controls.Add(this.flowLayoutPanel1);
            this.pnlBill1.Location = new System.Drawing.Point(2, 2);
            this.pnlBill1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBill1.Name = "pnlBill1";
            this.pnlBill1.Size = new System.Drawing.Size(512, 355);
            this.pnlBill1.TabIndex = 1;
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
            this.cmbLocation.Location = new System.Drawing.Point(144, 112);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(132, 21);
            this.cmbLocation.TabIndex = 20;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(144, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(132, 20);
            this.txtQuantity.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(144, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 20);
            this.txtPrice.TabIndex = 18;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Location = new System.Drawing.Point(144, 8);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(131, 20);
            this.txtMedicineName.TabIndex = 17;
            // 
            // txtMedicineId
            // 
            this.txtMedicineId.Location = new System.Drawing.Point(144, 34);
            this.txtMedicineId.Name = "txtMedicineId";
            this.txtMedicineId.Size = new System.Drawing.Size(132, 20);
            this.txtMedicineId.TabIndex = 16;
            // 
            // lblMedicineDetails
            // 
            this.lblMedicineDetails.AutoSize = true;
            this.lblMedicineDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineDetails.Location = new System.Drawing.Point(7, 133);
            this.lblMedicineDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicineDetails.Name = "lblMedicineDetails";
            this.lblMedicineDetails.Size = new System.Drawing.Size(151, 20);
            this.lblMedicineDetails.TabIndex = 15;
            this.lblMedicineDetails.Text = "Medicine Details :";
            // 
            // dgvMedicineInfo
            // 
            this.dgvMedicineInfo.AllowUserToAddRows = false;
            this.dgvMedicineInfo.AllowUserToDeleteRows = false;
            this.dgvMedicineInfo.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dgvMedicineInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicineInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName_Details,
            this.MedicineId_Details,
            this.MedicinePrice,
            this.MedicineQuantity,
            this.Location_Details});
            this.dgvMedicineInfo.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvMedicineInfo.Location = new System.Drawing.Point(0, 153);
            this.dgvMedicineInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedicineInfo.Name = "dgvMedicineInfo";
            this.dgvMedicineInfo.ReadOnly = true;
            this.dgvMedicineInfo.RowHeadersWidth = 51;
            this.dgvMedicineInfo.RowTemplate.Height = 24;
            this.dgvMedicineInfo.Size = new System.Drawing.Size(510, 201);
            this.dgvMedicineInfo.TabIndex = 14;
            // 
            // MedicineName_Details
            // 
            this.MedicineName_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName_Details.DataPropertyName = "MedicineName";
            this.MedicineName_Details.HeaderText = "Medicine Name ";
            this.MedicineName_Details.MinimumWidth = 6;
            this.MedicineName_Details.Name = "MedicineName_Details";
            this.MedicineName_Details.ReadOnly = true;
            // 
            // MedicineId_Details
            // 
            this.MedicineId_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineId_Details.DataPropertyName = "MedicineId";
            this.MedicineId_Details.HeaderText = "MedicineId";
            this.MedicineId_Details.MinimumWidth = 6;
            this.MedicineId_Details.Name = "MedicineId_Details";
            this.MedicineId_Details.ReadOnly = true;
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.DataPropertyName = "Price";
            this.MedicinePrice.HeaderText = "Price";
            this.MedicinePrice.Name = "MedicinePrice";
            this.MedicinePrice.ReadOnly = true;
            // 
            // MedicineQuantity
            // 
            this.MedicineQuantity.DataPropertyName = "Quantity";
            this.MedicineQuantity.HeaderText = "Quantity";
            this.MedicineQuantity.Name = "MedicineQuantity";
            this.MedicineQuantity.ReadOnly = true;
            // 
            // Location_Details
            // 
            this.Location_Details.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Location_Details.DataPropertyName = "Location";
            this.Location_Details.HeaderText = "Location";
            this.Location_Details.MinimumWidth = 6;
            this.Location_Details.Name = "Location_Details";
            this.Location_Details.ReadOnly = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToCart.Location = new System.Drawing.Point(302, 34);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(112, 50);
            this.btnAddToCart.TabIndex = 13;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lblMedicineId
            // 
            this.lblMedicineId.AutoSize = true;
            this.lblMedicineId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicineId.Location = new System.Drawing.Point(8, 34);
            this.lblMedicineId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMedicineId.Name = "lblMedicineId";
            this.lblMedicineId.Size = new System.Drawing.Size(106, 20);
            this.lblMedicineId.TabIndex = 6;
            this.lblMedicineId.Text = "Medicine Id ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(8, 60);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(8, 86);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(8, 113);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(78, 20);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(8, 8);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(131, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Medicine Name";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(346, 418);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(6, 6);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlBill2
            // 
            this.pnlBill2.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlBill2.Controls.Add(this.btnBill);
            this.pnlBill2.Controls.Add(this.lblTotalBillShow);
            this.pnlBill2.Controls.Add(this.btnRemove);
            this.pnlBill2.Controls.Add(this.lblTotalBill);
            this.pnlBill2.Controls.Add(this.btnConfirmOrder);
            this.pnlBill2.Controls.Add(this.txtCustomerPhnNo);
            this.pnlBill2.Controls.Add(this.txtCustomerName);
            this.pnlBill2.Controls.Add(this.lblCustomerName);
            this.pnlBill2.Controls.Add(this.lblCustomerInfo);
            this.pnlBill2.Controls.Add(this.lblCustPhnNo);
            this.pnlBill2.Controls.Add(this.dgvCartInfo);
            this.pnlBill2.Controls.Add(this.lblCartInfo);
            this.pnlBill2.Location = new System.Drawing.Point(518, 2);
            this.pnlBill2.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBill2.Name = "pnlBill2";
            this.pnlBill2.Size = new System.Drawing.Size(255, 355);
            this.pnlBill2.TabIndex = 2;
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.Cyan;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(43, 149);
            this.btnBill.Margin = new System.Windows.Forms.Padding(2);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(60, 30);
            this.btnBill.TabIndex = 27;
            this.btnBill.Text = "Total";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // lblTotalBillShow
            // 
            this.lblTotalBillShow.AutoSize = true;
            this.lblTotalBillShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBillShow.ForeColor = System.Drawing.Color.White;
            this.lblTotalBillShow.Location = new System.Drawing.Point(88, 190);
            this.lblTotalBillShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBillShow.Name = "lblTotalBillShow";
            this.lblTotalBillShow.Size = new System.Drawing.Size(28, 17);
            this.lblTotalBillShow.TabIndex = 26;
            this.lblTotalBillShow.Text = "....";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Cyan;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(131, 149);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(81, 30);
            this.btnRemove.TabIndex = 25;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(9, 190);
            this.lblTotalBill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(72, 15);
            this.lblTotalBill.TabIndex = 24;
            this.lblTotalBill.Text = "Total Bill :";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.HotPink;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnConfirmOrder.Location = new System.Drawing.Point(43, 285);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(152, 33);
            this.btnConfirmOrder.TabIndex = 23;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click_1);
            // 
            // txtCustomerPhnNo
            // 
            this.txtCustomerPhnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhnNo.Location = new System.Drawing.Point(91, 260);
            this.txtCustomerPhnNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerPhnNo.Name = "txtCustomerPhnNo";
            this.txtCustomerPhnNo.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerPhnNo.TabIndex = 21;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(91, 234);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerName.TabIndex = 20;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(9, 237);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(45, 15);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Name";
            // 
            // lblCustomerInfo
            // 
            this.lblCustomerInfo.AutoSize = true;
            this.lblCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInfo.Location = new System.Drawing.Point(2, 207);
            this.lblCustomerInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerInfo.Name = "lblCustomerInfo";
            this.lblCustomerInfo.Size = new System.Drawing.Size(123, 20);
            this.lblCustomerInfo.TabIndex = 18;
            this.lblCustomerInfo.Text = "Customer Info";
            // 
            // lblCustPhnNo
            // 
            this.lblCustPhnNo.AutoSize = true;
            this.lblCustPhnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustPhnNo.Location = new System.Drawing.Point(9, 263);
            this.lblCustPhnNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustPhnNo.Name = "lblCustPhnNo";
            this.lblCustPhnNo.Size = new System.Drawing.Size(70, 15);
            this.lblCustPhnNo.TabIndex = 17;
            this.lblCustPhnNo.Text = "Phone No";
            // 
            // dgvCartInfo
            // 
            this.dgvCartInfo.AllowUserToAddRows = false;
            this.dgvCartInfo.AllowUserToDeleteRows = false;
            this.dgvCartInfo.BackgroundColor = System.Drawing.Color.Thistle;
            this.dgvCartInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MedicineName_Cart,
            this.Quantity_Cart,
            this.Price_Cart});
            this.dgvCartInfo.Location = new System.Drawing.Point(0, 30);
            this.dgvCartInfo.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCartInfo.Name = "dgvCartInfo";
            this.dgvCartInfo.ReadOnly = true;
            this.dgvCartInfo.RowHeadersWidth = 51;
            this.dgvCartInfo.RowTemplate.Height = 24;
            this.dgvCartInfo.Size = new System.Drawing.Size(253, 115);
            this.dgvCartInfo.TabIndex = 15;
            // 
            // MedicineName_Cart
            // 
            this.MedicineName_Cart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MedicineName_Cart.DataPropertyName = "MedicineName";
            this.MedicineName_Cart.HeaderText = "Medicine Name";
            this.MedicineName_Cart.MinimumWidth = 6;
            this.MedicineName_Cart.Name = "MedicineName_Cart";
            this.MedicineName_Cart.ReadOnly = true;
            // 
            // Quantity_Cart
            // 
            this.Quantity_Cart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity_Cart.DataPropertyName = "Quantity";
            this.Quantity_Cart.HeaderText = "Medicine Quantity";
            this.Quantity_Cart.MinimumWidth = 6;
            this.Quantity_Cart.Name = "Quantity_Cart";
            this.Quantity_Cart.ReadOnly = true;
            // 
            // Price_Cart
            // 
            this.Price_Cart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price_Cart.DataPropertyName = "Price";
            this.Price_Cart.HeaderText = "Price";
            this.Price_Cart.MinimumWidth = 6;
            this.Price_Cart.Name = "Price_Cart";
            this.Price_Cart.ReadOnly = true;
            // 
            // lblCartInfo
            // 
            this.lblCartInfo.AutoSize = true;
            this.lblCartInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.lblCartInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartInfo.Location = new System.Drawing.Point(75, 8);
            this.lblCartInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCartInfo.Name = "lblCartInfo";
            this.lblCartInfo.Size = new System.Drawing.Size(85, 20);
            this.lblCartInfo.TabIndex = 14;
            this.lblCartInfo.Text = " Cart Info";
            // 
            // UserControlPBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBill2);
            this.Controls.Add(this.pnlBill1);
            this.Name = "UserControlPBills";
            this.Size = new System.Drawing.Size(775, 366);
            this.pnlBill1.ResumeLayout(false);
            this.pnlBill1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicineInfo)).EndInit();
            this.pnlBill2.ResumeLayout(false);
            this.pnlBill2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBill1;
        private System.Windows.Forms.Label lblMedicineDetails;
        private System.Windows.Forms.DataGridView dgvMedicineInfo;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lblMedicineId;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlBill2;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Label lblTotalBillShow;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.TextBox txtCustomerPhnNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerInfo;
        private System.Windows.Forms.Label lblCustPhnNo;
        private System.Windows.Forms.DataGridView dgvCartInfo;
        private System.Windows.Forms.Label lblCartInfo;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtMedicineName;
        private System.Windows.Forms.TextBox txtMedicineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Cart;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineName_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineId_Details;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location_Details;
    }
}
