namespace PharmacyManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPharmacist));
            this.pnlPharmacistProfile = new System.Windows.Forms.Panel();
            this.pnlPharmacistControl = new System.Windows.Forms.Panel();
            this.btnBills = new System.Windows.Forms.Button();
            this.btnPResetPassword = new System.Windows.Forms.Button();
            this.btnPInventory = new System.Windows.Forms.Button();
            this.btnPharmacistProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnPLogout = new System.Windows.Forms.Button();
            this.pnlPharmacistControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPharmacistProfile
            // 
            this.pnlPharmacistProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPharmacistProfile.Location = new System.Drawing.Point(0, 212);
            this.pnlPharmacistProfile.Name = "pnlPharmacistProfile";
            this.pnlPharmacistProfile.Size = new System.Drawing.Size(759, 381);
            this.pnlPharmacistProfile.TabIndex = 1;
            // 
            // pnlPharmacistControl
            // 
            this.pnlPharmacistControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPharmacistControl.BackgroundImage")));
            this.pnlPharmacistControl.Controls.Add(this.btnBills);
            this.pnlPharmacistControl.Controls.Add(this.btnPResetPassword);
            this.pnlPharmacistControl.Controls.Add(this.btnPInventory);
            this.pnlPharmacistControl.Controls.Add(this.btnPharmacistProfile);
            this.pnlPharmacistControl.Controls.Add(this.pictureBox1);
            this.pnlPharmacistControl.Controls.Add(this.lblInfo);
            this.pnlPharmacistControl.Controls.Add(this.btnPLogout);
            this.pnlPharmacistControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPharmacistControl.Location = new System.Drawing.Point(0, 0);
            this.pnlPharmacistControl.Name = "pnlPharmacistControl";
            this.pnlPharmacistControl.Size = new System.Drawing.Size(759, 212);
            this.pnlPharmacistControl.TabIndex = 4;
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.Transparent;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBills.Location = new System.Drawing.Point(350, 146);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(61, 26);
            this.btnBills.TabIndex = 10;
            this.btnBills.Text = "Bills";
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnPResetPassword
            // 
            this.btnPResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnPResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPResetPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPResetPassword.Location = new System.Drawing.Point(431, 145);
            this.btnPResetPassword.Name = "btnPResetPassword";
            this.btnPResetPassword.Size = new System.Drawing.Size(120, 26);
            this.btnPResetPassword.TabIndex = 8;
            this.btnPResetPassword.Text = "Reset Password";
            this.btnPResetPassword.UseVisualStyleBackColor = false;
            this.btnPResetPassword.Click += new System.EventHandler(this.btnPResetPassword_Click);
            // 
            // btnPInventory
            // 
            this.btnPInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnPInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPInventory.Location = new System.Drawing.Point(256, 146);
            this.btnPInventory.Name = "btnPInventory";
            this.btnPInventory.Size = new System.Drawing.Size(74, 26);
            this.btnPInventory.TabIndex = 6;
            this.btnPInventory.Text = "Inventory";
            this.btnPInventory.UseVisualStyleBackColor = false;
            this.btnPInventory.Click += new System.EventHandler(this.btnPInventory_Click);
            // 
            // btnPharmacistProfile
            // 
            this.btnPharmacistProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnPharmacistProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharmacistProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacistProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPharmacistProfile.Location = new System.Drawing.Point(173, 146);
            this.btnPharmacistProfile.Name = "btnPharmacistProfile";
            this.btnPharmacistProfile.Size = new System.Drawing.Size(61, 26);
            this.btnPharmacistProfile.TabIndex = 5;
            this.btnPharmacistProfile.Text = "Profile";
            this.btnPharmacistProfile.UseVisualStyleBackColor = false;
            this.btnPharmacistProfile.Click += new System.EventHandler(this.btnPharmacistProfile_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(298, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInfo.Location = new System.Drawing.Point(191, 99);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(401, 25);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome to MediCare, Logged in as Pharmacist\r\n\r\n\r\n";
            // 
            // btnPLogout
            // 
            this.btnPLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnPLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPLogout.Location = new System.Drawing.Point(573, 144);
            this.btnPLogout.Name = "btnPLogout";
            this.btnPLogout.Size = new System.Drawing.Size(62, 27);
            this.btnPLogout.TabIndex = 1;
            this.btnPLogout.Text = "Logout";
            this.btnPLogout.UseVisualStyleBackColor = false;
            this.btnPLogout.Click += new System.EventHandler(this.btnPLogout_Click);
            // 
            // FormPharmacist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 593);
            this.Controls.Add(this.pnlPharmacistControl);
            this.Controls.Add(this.pnlPharmacistProfile);
            this.Name = "FormPharmacist";
            this.Text = "FormPharmacist";
            this.pnlPharmacistControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPharmacistProfile;
        private System.Windows.Forms.Panel pnlPharmacistControl;
        private System.Windows.Forms.Button btnBills;
        private System.Windows.Forms.Button btnPResetPassword;
        private System.Windows.Forms.Button btnPInventory;
        private System.Windows.Forms.Button btnPharmacistProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnPLogout;
    }
}