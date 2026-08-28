using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
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
                const string data = "SELECT u.Name, u.Email, u.Address, u.JoiningDate, l.UserId, l.Password FROM UserInfo u INNER JOIN LoginInfo l ON u.Id = l.UniqueId WHERE l.UserId = @userId;";
                var ds = this.Da.ExecuteQuery(data, new SqlParameter("@userId", UserId));
                this.txtMName.Text = ds.Tables[0].Rows[0][0].ToString();

                this.txtMEmail.Text = ds.Tables[0].Rows[0][1].ToString();

                this.txtMAddress.Text = ds.Tables[0].Rows[0][2].ToString();

                this.dtpMJoiningDate.Text = ds.Tables[0].Rows[0][3].ToString();

                this.txtMUserId.Text = ds.Tables[0].Rows[0][4].ToString();

                this.txtMPassword.Text = ds.Tables[0].Rows[0][5].ToString();

            }
            catch (Exception ex)
            {
                Logger.Error("Unable to update manager profile.", ex);
                MessageBox.Show("Unable to update manager profile. See the application log for details.");
            }
            
          

        }

        private void btnMUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                const string data = "SELECT u.UserID FROM UserInfoo u INNER JOIN LoginInfoo l ON u.Id = l.UniqueId WHERE l.UserId = @userId;";
                var ds = this.Da.ExecuteQuery(data, new SqlParameter("@userId", UserId));
                var UniqueId = ds.Tables[0].Rows[0][0].ToString();

                const string updateUser = "UPDATE UserInfoo SET Name = @name, Email = @email, Address = @address, JoiningDate = @joiningDate WHERE UserID = @uniqueId;";
                const string updateLogin = "UPDATE LoginInfoo SET Password = @password WHERE UserId = @userId;";

                if (this.Da.ExecuteDMLQuery(updateUser,
                    new SqlParameter("@name", this.txtMName.Text),
                    new SqlParameter("@email", this.txtMEmail.Text),
                    new SqlParameter("@address", this.txtMAddress.Text),
                    new SqlParameter("@joiningDate", this.dtpMJoiningDate.Value),
                    new SqlParameter("@uniqueId", UniqueId)) == 1 &&
                    this.Da.ExecuteDMLQuery(updateLogin,
                    new SqlParameter("@password", this.txtMPassword.Text),
                    new SqlParameter("@userId", UserId)) == 1)
                    MessageBox.Show("Data has been update properly");
                else
                {
                    MessageBox.Show("Data update failed");
                    return;
                }
            }
            catch (Exception ex)
            {
                Logger.Error("Unable to update manager profile.", ex);
                MessageBox.Show("Unable to update manager profile. See the application log for details.");
            }
           
        }

        private void txtMUserId_TextChanged(object sender, EventArgs e)
        {

            
        }
       
    }
}
