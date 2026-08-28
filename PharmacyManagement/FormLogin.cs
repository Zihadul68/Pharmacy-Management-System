using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement
{
    public partial class FormLogin : Form
    {

        private DataAccess Da { get; set; }
        private string UserId { set; get; }
      
        public FormLogin()
        {

            InitializeComponent();
            this.Da = new DataAccess();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtPassword.Text))
                {
                    MessageBox.Show("Pease fill the empty fields");
                    return;
                }
                
                const string sql = "SELECT u.Name, u.Role FROM UserInfo u INNER JOIN LoginInfo l ON l.UniqueId = u.Id WHERE l.UserId = @userId AND l.Password = @password;";
                var ds = this.Da.ExecuteQuery(sql,
                    new SqlParameter("@userId", this.txtUserId.Text),
                    new SqlParameter("@password", this.txtPassword.Text));



                if (ds.Tables[0].Rows.Count == 1)
                {
                    var name = ds.Tables[0].Rows[0][0].ToString();
                    var role = ds.Tables[0].Rows[0][1].ToString();
                    MessageBox.Show("Valid User: " + name.ToUpper());
                    if (ds.Tables[0].Rows[0][1].ToString().Equals("Manager"))
                    {
                        this.Visible = false;
                        string uName = this.txtUserId.Text;
                        new FormManager(uName, this).Show();


                    }

                    else if (ds.Tables[0].Rows[0][1].ToString().Equals("Pharmacist"))
                    {

                        this.Visible = false;
                        string uName = this.txtUserId.Text;
                        new FormPharmacist(uName, this).Show();

                    }
                  
                    


                }
                else
                {
                    MessageBox.Show("Invalid User", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                
            }
            catch (Exception exc)
            {
                Logger.Error("Unable to authenticate user.", exc);
                MessageBox.Show("Unable to sign in. See the application log for details.");

            }

         

          

        }
      


        

        private void btnCLear_Click_1(object sender, EventArgs e)
        {
            this.txtUserId.Text = "";
            this.txtPassword.Clear();

        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPassword.Text))

                return false;
            else
                return true;
        }

       

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

 
