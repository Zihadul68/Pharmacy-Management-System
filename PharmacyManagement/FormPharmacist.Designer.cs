namespace MediCare
{
    partial class FormPharmacist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPharmacist = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlPharmacist.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPharmacist
            // 
            this.pnlPharmacist.Controls.Add(this.btnLogout);
            this.pnlPharmacist.Controls.Add(this.lblInfo);
            this.pnlPharmacist.Location = new System.Drawing.Point(-2, -1);
            this.pnlPharmacist.Name = "pnlPharmacist";
            this.pnlPharmacist.Size = new System.Drawing.Size(802, 453);
            this.pnlPharmacist.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(416, 257);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(62, 27);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(144, 62);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(596, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome to MediCare, Logged in as Pharmacist: \r\n\r\n";
            // 
            // FormPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.pnlPharmacist);
            this.Name = "FormPharmacist";
            this.Text = "FormPharmacist";
            this.Load += new System.EventHandler(this.FormPharmacist_Load);
            this.pnlPharmacist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPharmacist;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblInfo;
    }
}