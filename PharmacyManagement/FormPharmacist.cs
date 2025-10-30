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
    public partial class FormPharmacist : Form
    {
        private FormLogin Fl { get; set; }

        

        public FormPharmacist()
        {
            InitializeComponent();
        }

        public FormPharmacist(string info, FormLogin fl) : this()
        {
            this.lblInfo.Text += info.ToUpper();
            this.Fl = fl;
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.Fl.Show();
        }

        private void FormPharmacist_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.Fl.Show();
        }

        private void FormPharmacist_Load(object sender, EventArgs e)
        {

        }
    }
}
