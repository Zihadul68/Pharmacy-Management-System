using PharmacyManagement.Manager;
using PharmacyManagement.Pharmacist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PharmacyManagement
{
    public partial class FormPharmacist : Form

    {

        private UserControl uControl;
        private FormLogin FP { get; set; }
        private string UserId { set; get; }

        public FormPharmacist()
        {
            InitializeComponent();
        }
        public FormPharmacist(string text, FormLogin fp) : this()
        {
            this.UserId = text;
            this.FP = fp;
        }

        private void ViewUserControl(UserControl control)
        {
            if (uControl != null)
            {
                pnlPharmacistProfile.Controls.Remove(uControl);
                uControl.Dispose();
            }
            uControl = control;
            control.Dock = DockStyle.Fill;
            pnlPharmacistProfile.Controls.Add(control);
            control.Visible = true;
        }
        
        private void btnPharmacistProfile_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManagerProfile(UserId));
        }

        

        private void btnPInventory_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlPhManageInventory());
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            ViewUserControl(new Pharmacist.UserControlPBills(UserId));
        }

        private void btnPResetPassword_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlResetPassword());
        }
        private void btnPLogout_Click(object sender, EventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            MessageBox.Show("Logged out from the system");
            this.Hide();
        }
        private void FormPharmacist_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.FP.Show();

        }

        private void btnPharmacistProfile_Click_1(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManagerProfile(UserId));

        }
        private void btnConfirmOrder_Click1(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlConfirmOrder());

        }
    }
}
