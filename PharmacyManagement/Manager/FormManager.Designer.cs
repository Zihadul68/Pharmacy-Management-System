namespace PharmacyManagement
{
    partial class FormManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManager));
            this.pnlManagerControl = new System.Windows.Forms.Panel();
            this.btnMResetPassword = new System.Windows.Forms.Button();
            this.btnSalesSummary = new System.Windows.Forms.Button();
            this.btnMInventory = new System.Windows.Forms.Button();
            this.btnManagerProfile = new System.Windows.Forms.Button();
            this.btnManagementPanel = new System.Windows.Forms.Button();
            this.picMediCareLogo2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlManagerProfile = new System.Windows.Forms.Panel();
            this.pnlManagerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMediCareLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlManagerControl
            // 
            this.pnlManagerControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlManagerControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlManagerControl.BackgroundImage")));
            this.pnlManagerControl.Controls.Add(this.btnMResetPassword);
            this.pnlManagerControl.Controls.Add(this.btnSalesSummary);
            this.pnlManagerControl.Controls.Add(this.btnMInventory);
            this.pnlManagerControl.Controls.Add(this.btnManagerProfile);
            this.pnlManagerControl.Controls.Add(this.btnManagementPanel);
            this.pnlManagerControl.Controls.Add(this.picMediCareLogo2);
            this.pnlManagerControl.Controls.Add(this.btnLogout);
            this.pnlManagerControl.Controls.Add(this.lblInfo);
            this.pnlManagerControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlManagerControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlManagerControl.Location = new System.Drawing.Point(0, 0);
            this.pnlManagerControl.Name = "pnlManagerControl";
            this.pnlManagerControl.Size = new System.Drawing.Size(759, 212);
            this.pnlManagerControl.TabIndex = 0;
           
            // 
            // btnMResetPassword
            // 
            this.btnMResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnMResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMResetPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMResetPassword.Location = new System.Drawing.Point(389, 151);
            this.btnMResetPassword.Name = "btnMResetPassword";
            this.btnMResetPassword.Size = new System.Drawing.Size(120, 26);
            this.btnMResetPassword.TabIndex = 7;
            this.btnMResetPassword.Text = "Reset Password";
            this.btnMResetPassword.UseVisualStyleBackColor = false;
            this.btnMResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnSalesSummary
            // 
            this.btnSalesSummary.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesSummary.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalesSummary.Location = new System.Drawing.Point(522, 151);
            this.btnSalesSummary.Name = "btnSalesSummary";
            this.btnSalesSummary.Size = new System.Drawing.Size(120, 26);
            this.btnSalesSummary.TabIndex = 6;
            this.btnSalesSummary.Text = "Sales Summary";
            this.btnSalesSummary.UseVisualStyleBackColor = false;
            this.btnSalesSummary.Click += new System.EventHandler(this.btnSalesSummary_Click);
            // 
            // btnMInventory
            // 
            this.btnMInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnMInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMInventory.Location = new System.Drawing.Point(300, 151);
            this.btnMInventory.Name = "btnMInventory";
            this.btnMInventory.Size = new System.Drawing.Size(74, 26);
            this.btnMInventory.TabIndex = 5;
            this.btnMInventory.Text = "Inventory";
            this.btnMInventory.UseVisualStyleBackColor = false;
            this.btnMInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnManagerProfile
            // 
            this.btnManagerProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnManagerProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagerProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerProfile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManagerProfile.Location = new System.Drawing.Point(64, 151);
            this.btnManagerProfile.Name = "btnManagerProfile";
            this.btnManagerProfile.Size = new System.Drawing.Size(61, 26);
            this.btnManagerProfile.TabIndex = 4;
            this.btnManagerProfile.Text = "Profile";
            this.btnManagerProfile.UseVisualStyleBackColor = false;
            this.btnManagerProfile.Click += new System.EventHandler(this.btnManagerProfile_Click);
            // 
            // btnManagementPanel
            // 
            this.btnManagementPanel.BackColor = System.Drawing.Color.Transparent;
            this.btnManagementPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementPanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManagementPanel.Location = new System.Drawing.Point(141, 151);
            this.btnManagementPanel.Name = "btnManagementPanel";
            this.btnManagementPanel.Size = new System.Drawing.Size(142, 26);
            this.btnManagementPanel.TabIndex = 3;
            this.btnManagementPanel.Text = "Management Panel";
            this.btnManagementPanel.UseVisualStyleBackColor = false;
            this.btnManagementPanel.Click += new System.EventHandler(this.btnManagementPanel_Click);
            // 
            // picMediCareLogo2
            // 
            this.picMediCareLogo2.Image = ((System.Drawing.Image)(resources.GetObject("picMediCareLogo2.Image")));
            this.picMediCareLogo2.Location = new System.Drawing.Point(313, 3);
            this.picMediCareLogo2.Name = "picMediCareLogo2";
            this.picMediCareLogo2.Size = new System.Drawing.Size(159, 84);
            this.picMediCareLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediCareLogo2.TabIndex = 2;
            this.picMediCareLogo2.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(656, 151);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(61, 26);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInfo.Location = new System.Drawing.Point(202, 90);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(357, 22);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome to MediCare, Logged in as Manager\r\n\r\n";
            // 
            // pnlManagerProfile
            // 
            this.pnlManagerProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManagerProfile.Location = new System.Drawing.Point(0, 212);
            this.pnlManagerProfile.Name = "pnlManagerProfile";
            this.pnlManagerProfile.Size = new System.Drawing.Size(759, 381);
            this.pnlManagerProfile.TabIndex = 1;
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 593);
            this.Controls.Add(this.pnlManagerProfile);
            this.Controls.Add(this.pnlManagerControl);
            this.MaximizeBox = false;
            this.Name = "FormManager";
            this.Text = "Manager Panel";
            this.Load += new System.EventHandler(this.FormManager_Load_1);
            this.pnlManagerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMediCareLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Panel pnlManagerControl;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox picMediCareLogo2;
        private System.Windows.Forms.Panel pnlManagerProfile;
        private System.Windows.Forms.Button btnManagerProfile;
        private System.Windows.Forms.Button btnManagementPanel;
        private System.Windows.Forms.Button btnMInventory;
        private System.Windows.Forms.Button btnSalesSummary;
        private System.Windows.Forms.Button btnMResetPassword;
    }
}