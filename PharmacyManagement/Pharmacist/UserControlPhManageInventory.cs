using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void PopulateGridView(string sql = "select * from Inventory;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvPharmacistInventory.AutoGenerateColumns = false;
            this.dgvPharmacistInventory.DataSource = ds.Tables[0];
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {

            this.PopulateGridView();
        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select* from Inventory Where MedicineName like'" + this.txtAutoSearch.Text + "%'or Location like'" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            var sql = "select * from Inventory where MedicineName = '" + this.txtSearch.Text + "';";
            this.PopulateGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = @"select* from Inventory where MedicineName = '" + this.txtSearch.Text + "'; ";
            this.PopulateGridView(sql);
        }
    }
}
