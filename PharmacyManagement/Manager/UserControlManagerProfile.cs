using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagement
{
    public partial class UserControlManagerProfile : UserControl
    {
        

        private string UserId { get; set; }
        private DataAccess Da { get; set; }
        

        public UserControlManagerProfile()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }
        public UserControlManagerProfile(string UserId) : this()
        {
            this.UserId = UserId;
            ShowData();

        }
        private void ShowData()
        {
            try
            {
                var data = "select u.Name,u.Email,u.Address,u.JoiningDate,l.UserId,l.Password from UserInfo u,LoginInfo l where u.Id = l.UniqueId and l.UserId = '" + UserId + "';";
                var ds = this.Da.ExecuteQuery(data);
                this.txtMName.Text = ds.Tables[0].Rows[0][0].ToString();

                this.txtMEmail.Text = ds.Tables[0].Rows[0][1].ToString();

                this.txtMAddress.Text = ds.Tables[0].Rows[0][2].ToString();

                this.dtpMJoiningDate.Text = ds.Tables[0].Rows[0][3].ToString();

                this.txtMUserId.Text = ds.Tables[0].Rows[0][4].ToString();

                this.txtMPassword.Text = ds.Tables[0].Rows[0][5].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
            
          

        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                var data = "select u.UserID from UserInfoo u,LoginInfoo l where u.Id = l.UniqueId and l.UserId = '" + UserId + "'";
                var ds = this.Da.ExecuteQuery(data);
                var UniqueId = ds.Tables[0].Rows[0][0].ToString();

                var updateQuary = "update UserInfoo set Name = '" + this.txtMName.Text + "'," +
                                  "Email = '" + this.txtMEmail.Text + "',Address = " + this.txtMAddress.Text + ", " +
                                  "JoiningDate = '" + this.dtpMJoiningDate.Text + "' " +
                                  "where UserID = '" + UniqueId + "';";
                var updateQuary2 = "update LoginInfoo set Password = '" + this.txtMPassword.Text + "' where UserId = '" + UserId + "'";

                if (this.Da.ExecuteDMLQuery(updateQuary) == 1 && this.Da.ExecuteDMLQuery(updateQuary2) == 1)
                    MessageBox.Show("Data has been update properly");
                else
                {
                    MessageBox.Show("Data update failed");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error has occured" + ex.Message);
            }
           
        }

        private void txtMUserId_TextChanged(object sender, EventArgs e)
        {

            
        }
       
    }
}
