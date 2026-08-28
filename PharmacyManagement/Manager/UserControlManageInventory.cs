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

namespace PharmacyManagement.Manager
{
    public partial class UserControlManageInventory : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlManageInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        public void PopulateGridView()
        {
            var ds = this.Da.ExecuteQuery("SELECT * FROM Inventory;");

            this.dgvManageInventory.AutoGenerateColumns = false;
            this.dgvManageInventory.DataSource = ds.Tables[0];
        }

        //ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToAdd())
                {
                    MessageBox.Show("Please fill all the text fields");
                    return;
                }
                if (!this.checkMedicineName())
                {
                    return;
                }

                const string query = "INSERT INTO Inventory VALUES (@medicineName, @medicineId, @price, @quantity, @location);";
                var count = this.Da.ExecuteDMLQuery(query,
                    new SqlParameter("@medicineName", this.txtMedicineName.Text),
                    new SqlParameter("@medicineId", this.txtMedicineId.Text),
                    new SqlParameter("@price", Convert.ToInt32(this.txtPrice.Text)),
                    new SqlParameter("@quantity", Convert.ToInt32(this.txtQuantity.Text)),
                    new SqlParameter("@location", this.cmbLocation.Text));

                if (count == 1)
                    MessageBox.Show("1 product has been added properly");
                else
                    MessageBox.Show("Product can't be added"); ;
                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                Logger.Error("Unable to modify inventory.", exc);
                MessageBox.Show("Unable to modify inventory. See the application log for details.");
            }
        }


        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.txtMedicineId.Text) || String.IsNullOrEmpty(this.txtMedicineName.Text)
            || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtQuantity.Text)
            || String.IsNullOrEmpty(this.cmbLocation.Text))
                return false;
            else
                return true;
        }

        private bool checkMedicineName()
        {
            try
            {
                const string sql = "SELECT MedicineName FROM Inventory WHERE MedicineName = @medicineName;";
                var check = Da.ExecuteQuery(sql, new SqlParameter("@medicineName", this.txtMedicineName.Text));

                if (check.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("This name is alrady exist");
                    return false;
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Unable to access inventory.", ex);
                MessageBox.Show("Unable to access inventory. See the application log for details.");
            }
            return true;
        }
        //ADDend

        //REMOVE
        private void btnRemove_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (this.dgvManageInventory.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove the data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure to remove the data?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var MedicineId = this.dgvManageInventory.CurrentRow.Cells[0].Value.ToString();
                var MedicineName = this.dgvManageInventory.CurrentRow.Cells[1].Value.ToString();
                //MessageBox.Show(id+title);
                const string query = "DELETE FROM Inventory WHERE MedicineId = @medicineId;";
                var count = this.Da.ExecuteDMLQuery(query, new SqlParameter("@medicineId", MedicineId));

                if (count == 1)
                    MessageBox.Show(MedicineName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Inventory data remove failed");

                this.PopulateGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                Logger.Error("Unable to modify inventory.", exc);
                MessageBox.Show("Unable to modify inventory. See the application log for details.");
            }
        }
        //Remove

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                const string updateQuery = "UPDATE Inventory SET MedicineName = @medicineName, Price = @price, Quantity = @quantity, Location = @location WHERE MedicineId = @medicineId;";
                if (this.Da.ExecuteDMLQuery(updateQuery,
                    new SqlParameter("@medicineName", this.txtMedicineName.Text),
                    new SqlParameter("@price", Convert.ToInt32(this.txtPrice.Text)),
                    new SqlParameter("@quantity", Convert.ToInt32(this.txtQuantity.Text)),
                    new SqlParameter("@location", this.cmbLocation.Text),
                    new SqlParameter("@medicineId", this.txtMedicineId.Text)) == 1)
                    MessageBox.Show("Product Data has been update properly");
                else
                {
                    MessageBox.Show("Product Data update failed");
                    return;
                }


            }
            catch (Exception ex)
            {
                Logger.Error("Unable to access inventory.", ex);
                MessageBox.Show("Unable to access inventory. See the application log for details.");
            }
            this.txtMedicineId.ReadOnly = false;

            this.ClearAll();

            this.PopulateGridView();
            this.dgvManageInventory.ClearSelection();
        }


        //Clear
        private void ClearAll()
        {
            this.txtMedicineName.Clear();
            this.txtMedicineId.Text = "";
            this.txtPrice.Clear();
            this.txtQuantity.Clear();
            this.cmbLocation.SelectedIndex = -1;

            this.dgvManageInventory.ClearSelection();

            this.AutoIdGenerate();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }
        //Clear

        ////
        private void dgvManagerInventory_DoubleClick(object sender, EventArgs e)
        {
            //enableAutoIdGeneration = false;
            this.txtMedicineName.Text = this.dgvManageInventory.CurrentRow.Cells[0].Value.ToString();
            this.txtMedicineId.Text = this.dgvManageInventory.CurrentRow.Cells[1].Value.ToString();
            this.txtPrice.Text = this.dgvManageInventory.CurrentRow.Cells[3].Value.ToString();
            this.txtQuantity.Text = this.dgvManageInventory.CurrentRow.Cells[4].Value.ToString();            this.cmbLocation.Text = this.dgvManageInventory.CurrentRow.Cells[2].Value.ToString();

            this.txtMedicineId.ReadOnly = true;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();   
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            this.ClearAll();
            this.AutoIdGenerate();
        }

        private void cmbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AutoIdGenerate()
        {
            var query = "select max(MedicineId) from Inventory;";
            var dt = this.Da.ExecuteQueryTable(query);
            var oldMedicineId = dt.Rows.Count == 0 ? null : dt.Rows[0][0].ToString();
            var nextNumber = 1;
            if (!string.IsNullOrWhiteSpace(oldMedicineId))
            {
                var parts = oldMedicineId.Split('-');
                int existingNumber;
                if (parts.Length == 2 && int.TryParse(parts[1], out existingNumber))
                {
                    nextNumber = existingNumber + 1;
                }
            }

            this.txtMedicineId.Text = "m-" + nextNumber.ToString("d3");
        }



    }
}
