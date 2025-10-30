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

namespace MediCare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-2KF12JE\SQLEXPRESS;Initial Catalog=MediCare;User ID=sa;Password=P@$$w0rd");
            sqlcon.Open();
            SqlCommand sqlcom = new SqlCommand("select * from UserInfo;", sqlcon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            this.label1.Text = ds.Tables[0].Rows[0][0].ToString();
            this.label2.Text = ds.Tables[0].Rows[0][1].ToString();
            this.label3.Text = ds.Tables[0].Rows[0][2].ToString();
            this.label4.Text = ds.Tables[0].Rows[2][3].ToString();

            sqlcon.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
