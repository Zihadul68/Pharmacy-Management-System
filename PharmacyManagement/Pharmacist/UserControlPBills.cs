using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement.Pharmacist
{
    public partial class UserControlPBills : UserControl
    {
        int GrandPrice = 0;
        int priceTotal = 0;
        int Price = 0;
        int Quantity = 0;
        private string userName { get; set; }
        private DataAccess Da { get; set; }

        public UserControlPBills()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGidView();
        }

        public UserControlPBills(string userName) : this()
        {
            this.userName = userName;
        }
        public void PopulateGidView()
        {
            var ds = this.Da.ExecuteQuery("SELECT * FROM Inventory;");

            this.dgvMedicineInfo.AutoGenerateColumns = false;
            this.dgvMedicineInfo.DataSource = ds.Tables[0];
        }

        private void dgvMedicineInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtMedicineName.Text = this.dgvMedicineInfo.CurrentRow.Cells[0].Value.ToString();
            this.txtMedicineId.Text = this.dgvMedicineInfo.CurrentRow.Cells[1].Value.ToString();
            this.cmbLocation.Text = this.dgvMedicineInfo.CurrentRow.Cells[4].Value.ToString();
            this.txtPrice.Text = this.dgvMedicineInfo.CurrentRow.Cells[3].Value.ToString();

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs before proceeding
                if (!IsValidTOAdd())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                // Retrieve the available quantity from the DataGridView
                int tableQuantity = Convert.ToInt32(dgvMedicineInfo.CurrentRow.Cells[2].Value);
                if (tableQuantity == 0)
                {
                    MessageBox.Show("Product Not available");
                    return;
                }

                // Assign quantity and price values
                Quantity = Convert.ToInt32(txtQuantity.Text);
                Price = Convert.ToInt32(txtPrice.Text);

                // Ensure requested quantity is available
                if (!BillingCalculator.CanFulfil(Quantity, tableQuantity))
                {
                    MessageBox.Show("Not enough stock available!");
                    return;
                }

                // Calculate the total price
                priceTotal = BillingCalculator.CalculateLineTotal(Quantity, Price);


                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvCartInfo);
                row.Cells[0].Value = txtMedicineName.Text;
                row.Cells[1].Value = Quantity;
                row.Cells[2].Value = priceTotal;
                dgvCartInfo.Rows.Add(row);


                // Update grand total
                GrandPrice += priceTotal;
                lblTotalBill.Text = GrandPrice.ToString();

                // Clear inputs after adding to cart
                ClearAll();
            }
            catch (Exception ex)
            {
                Logger.Error("Unable to add medicine to the cart.", ex);
                MessageBox.Show("Unable to add medicine to the cart. See the application log for details.");
            }
        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (!IsValidTOAdd())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                // Retrieve stock quantity
                int tableQuantity = Convert.ToInt32(dgvMedicineInfo.CurrentRow.Cells[2].Value);
                if (tableQuantity == 0)
                {
                    MessageBox.Show("Product Not available");
                    return;
                }

                // Assign values
                Quantity = Convert.ToInt32(txtQuantity.Text);
                Price = Convert.ToInt32(txtPrice.Text);

                // Check if requested quantity is available
                if (!BillingCalculator.CanFulfil(Quantity, tableQuantity))
                {
                    MessageBox.Show("Not enough stock available!");
                    return;
                }

                // Calculate total price
                priceTotal = BillingCalculator.CalculateLineTotal(Quantity, Price);


                // Add to cart
                dgvCartInfo.Rows.Add(txtMedicineName.Text, Quantity, priceTotal);

                // Update grand total
                GrandPrice += priceTotal;
                lblTotalBill.Text = GrandPrice.ToString();

                // Clear inputs
                ClearAll();
            }
            catch (Exception ex)
            {
                Logger.Error("Unable to add medicine to the cart.", ex);
                MessageBox.Show("Unable to add medicine to the cart. See the application log for details.");
            }
        }



        private bool IsValidTOAdd()
        {
            if (String.IsNullOrEmpty(this.txtMedicineName.Text) || String.IsNullOrEmpty(this.txtPrice.Text)
            || String.IsNullOrEmpty(this.txtMedicineId.Text) || String.IsNullOrEmpty(this.cmbLocation.Text) || string.IsNullOrEmpty(this.txtQuantity.Text))
                return false;
            else
                return true;
        }
        private void ClearAll()
        {
            this.txtMedicineName.Clear();
            this.txtMedicineId.Text = "";
            this.txtPrice.Clear();
            this.cmbLocation.SelectedIndex = -1;
            this.txtQuantity.Clear();

        }
        private bool IsValid()
        {
            if (String.IsNullOrEmpty(this.txtCustomerName.Text) || String.IsNullOrEmpty(this.txtCustomerPhnNo.Text))
                return false;
            else
                return true;
        }

        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValid())
                {
                    MessageBox.Show("Please Fill Customer Information");
                    return;
                }
                const string query = "INSERT INTO RecordTable VALUES (@customerName, @customerPhone, @userName, @orderDate, @total);";
                var count = this.Da.ExecuteDMLQuery(query,
                    new SqlParameter("@customerName", this.txtCustomerName.Text),
                    new SqlParameter("@customerPhone", this.txtCustomerPhnNo.Text),
                    new SqlParameter("@userName", (object)userName ?? DBNull.Value),
                    new SqlParameter("@orderDate", DateTime.Now),
                    new SqlParameter("@total", Convert.ToInt32(this.lblTotalBill.Text)));


                if (count == 1)
                {
                    MessageBox.Show("Order Completed\nTotal Amount :" + this.lblTotalBill.Text + "\n Customer Name: " + this.txtCustomerName.Text + " \nCustomer Phone Number: " + this.txtCustomerPhnNo.Text + " ");
                    GrandPrice = 0;
                    this.lblTotalBill.Text = " ";
                    this.dgvCartInfo.Rows.Clear();
                    this.txtCustomerPhnNo.Clear();
                    this.txtCustomerName.Clear();

                }
                int tableQuantity = Convert.ToInt32(this.dgvMedicineInfo.CurrentRow.Cells[2].Value.ToString());
                string id = this.dgvMedicineInfo.CurrentRow.Cells[1].Value.ToString();

                if (tableQuantity == 0)
                {
                    MessageBox.Show("Product Not available");
                    return;
                }
                int finalQuantity = tableQuantity - Quantity;
                const string updateQuery = "UPDATE Inventory SET Quantity = @quantity WHERE MedicineId = @id;";
                this.Da.ExecuteDMLQuery(updateQuery,
                    new SqlParameter("@quantity", finalQuantity),
                    new SqlParameter("@id", id));
                this.PopulateGidView();
            }
            catch (Exception ex)
            {
                Logger.Error("Unable to confirm order.", ex);
                MessageBox.Show("Unable to confirm order. See the application log for details.");
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.dgvCartInfo.Rows.Clear();
        }

        private void btnConfirmOrder_Click_1(object sender, EventArgs e)
        {

        }
    }
}
