using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediCare
{

    public partial class FormManager : Form
    {
        private FormLogin Fl { get; set; }

        public FormManager()
        {
            InitializeComponent();
        }

        public FormManager(string info, FormLogin fl) : this()
        {
            this.lblInfo.Text += info.ToUpper();
            this.Fl = fl;
        }

     

       

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.Fl.Show();
            Application.Exit();
        }


        private void FormManager_FormClosed(object sender, EventArgs e)
        {

            MessageBox.Show("GoodBye");
            
        }

        private void FormManager_Load(object sender, EventArgs e)
        {

        }
    }
    
}
