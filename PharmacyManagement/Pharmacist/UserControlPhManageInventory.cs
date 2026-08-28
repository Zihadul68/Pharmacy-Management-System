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
    public partial class UserControlPhManageInventory : UserControl
    {
        private DataAccess Da { get; set; }
        public UserControlPhManageInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();

        }

        public void PopulateGridView(string sql = "SELECT * FROM Inventory;", params SqlParameter[] parameters)
        {
            var ds = this.Da.ExecuteQuery(sql, parameters);

            this.dgvPharmacistInventory.AutoGenerateColumns = false;
            this.dgvPharmacistInventory.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            const string sql = "SELECT * FROM Inventory WHERE MedicineName LIKE @search OR Location LIKE @search;";
            this.PopulateGridView(sql, new SqlParameter("@search", this.txtAutoSearch.Text + "%"));
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            const string sql = "SELECT * FROM Inventory WHERE MedicineName = @medicineName;";
            this.PopulateGridView(sql, new SqlParameter("@medicineName", this.txtSearch.Text));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            const string sql = "SELECT * FROM Inventory WHERE MedicineName = @medicineName;";
            this.PopulateGridView(sql, new SqlParameter("@medicineName", this.txtSearch.Text));
        }
    }
}
