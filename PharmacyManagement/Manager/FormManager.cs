using PharmacyManagement.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PharmacyManagement
{

    public partial class FormManager : Form
    {
        private UserControl uControl;

        
        private FormLogin FM { get; set; }

    
        private string UserId { set; get; }
        public FormManager()
        {
            InitializeComponent();
            
        }
        private void ViewUserControl(UserControl control)
        {
            if (uControl != null)
            {
                pnlManagerProfile.Controls.Remove(uControl);
                uControl.Dispose();
            }
            uControl = control;
            control.Dock = DockStyle.Fill;
            pnlManagerProfile.Controls.Add(control);
            control.Visible = true;
        }

        public FormManager(string text, FormLogin fm) : this()
        {
            this.UserId = text;
            this.FM = fm;
        }
       

        private void btnManagerProfile_Click(object sender, EventArgs e)
        {

            ViewUserControl(new UserControlManagerProfile(UserId));

        }


        private void btnManagementPanel_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManagementPanel());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlManageInventory());
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlResetPassword());
        }
        private void btnSalesSummary_Click(object sender, EventArgs e)
        {
            ViewUserControl(new UserControlSalesSummary());
        }
      

        
        


     

        
        

        private void FormManager_Load_1(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            MessageBox.Show("Logged out from the system");
            this.Hide();
        }
        private void FormManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.FM.Show();
            Application.Exit();
            

        }

    }
}
    

