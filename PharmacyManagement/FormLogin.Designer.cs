namespace PharmacyManagement
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlMediCare = new System.Windows.Forms.Panel();
            this.lblMediCare = new System.Windows.Forms.Label();
            this.pnlLogInInfo = new System.Windows.Forms.Panel();
            this.pnlMediCareLogo = new System.Windows.Forms.Panel();
            this.picMediCareLogo = new System.Windows.Forms.PictureBox();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMediCare.SuspendLayout();
            this.pnlLogInInfo.SuspendLayout();
            this.pnlMediCareLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMediCareLogo)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMediCare
            // 
            this.pnlMediCare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(18)))), ((int)(((byte)(81)))));
            this.pnlMediCare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlMediCare.Controls.Add(this.lblMediCare);
            this.pnlMediCare.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMediCare.Location = new System.Drawing.Point(0, 0);
            this.pnlMediCare.Name = "pnlMediCare";
            this.pnlMediCare.Size = new System.Drawing.Size(743, 43);
            this.pnlMediCare.TabIndex = 3;
            // 
            // lblMediCare
            // 
            this.lblMediCare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMediCare.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMediCare.ForeColor = System.Drawing.Color.White;
            this.lblMediCare.Location = new System.Drawing.Point(-1, 12);
            this.lblMediCare.Name = "lblMediCare";
            this.lblMediCare.Size = new System.Drawing.Size(76, 23);
            this.lblMediCare.TabIndex = 4;
            this.lblMediCare.Text = "MediCare";
            this.lblMediCare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLogInInfo
            // 
            this.pnlLogInInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlLogInInfo.Controls.Add(this.pnlMediCareLogo);
            this.pnlLogInInfo.Controls.Add(this.pnlMediCare);
            this.pnlLogInInfo.Controls.Add(this.pnlUserInfo);
            this.pnlLogInInfo.Controls.Add(this.pictureBox1);
            this.pnlLogInInfo.Location = new System.Drawing.Point(-1, -3);
            this.pnlLogInInfo.Name = "pnlLogInInfo";
            this.pnlLogInInfo.Size = new System.Drawing.Size(743, 595);
            this.pnlLogInInfo.TabIndex = 0;
            // 
            // pnlMediCareLogo
            // 
            this.pnlMediCareLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlMediCareLogo.Controls.Add(this.picMediCareLogo);
            this.pnlMediCareLogo.Location = new System.Drawing.Point(278, 55);
            this.pnlMediCareLogo.Name = "pnlMediCareLogo";
            this.pnlMediCareLogo.Size = new System.Drawing.Size(240, 115);
            this.pnlMediCareLogo.TabIndex = 5;
            this.pnlMediCareLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picMediCareLogo
            // 
            this.picMediCareLogo.Image = ((System.Drawing.Image)(resources.GetObject("picMediCareLogo.Image")));
            this.picMediCareLogo.Location = new System.Drawing.Point(0, 0);
            this.picMediCareLogo.Name = "picMediCareLogo";
            this.picMediCareLogo.Size = new System.Drawing.Size(240, 115);
            this.picMediCareLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMediCareLogo.TabIndex = 0;
            this.picMediCareLogo.TabStop = false;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlUserInfo.BackgroundImage")));
            this.pnlUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlUserInfo.Controls.Add(this.label2);
            this.pnlUserInfo.Controls.Add(this.label1);
            this.pnlUserInfo.Controls.Add(this.picPassword);
            this.pnlUserInfo.Controls.Add(this.picUserIcon);
            this.pnlUserInfo.Controls.Add(this.txtUserId);
            this.pnlUserInfo.Controls.Add(this.btnLogin);
            this.pnlUserInfo.Controls.Add(this.btnCLear);
            this.pnlUserInfo.Controls.Add(this.txtPassword);
            this.pnlUserInfo.Controls.Add(this.lblPassword);
            this.pnlUserInfo.Controls.Add(this.lblUserId);
            this.pnlUserInfo.Location = new System.Drawing.Point(195, 179);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(375, 344);
            this.pnlUserInfo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(171, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(258, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(4, 0);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login";
            // 
            // picPassword
            // 
            this.picPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPassword.Image = ((System.Drawing.Image)(resources.GetObject("picPassword.Image")));
            this.picPassword.Location = new System.Drawing.Point(64, 243);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(23, 24);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 8;
            this.picPassword.TabStop = false;
            // 
            // picUserIcon
            // 
            this.picUserIcon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picUserIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserIcon.Image")));
            this.picUserIcon.Location = new System.Drawing.Point(64, 164);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(22, 23);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUserIcon.TabIndex = 7;
            this.picUserIcon.TabStop = false;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(93, 165);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(221, 20);
            this.txtUserId.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(210, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(52, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLear.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLear.ForeColor = System.Drawing.Color.Transparent;
            this.btnCLear.Location = new System.Drawing.Point(152, 292);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(52, 23);
            this.btnCLear.TabIndex = 4;
            this.btnCLear.Text = "Clear";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(93, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(221, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Location = new System.Drawing.Point(90, 224);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 20);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserId.Location = new System.Drawing.Point(89, 145);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(57, 19);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(743, 595);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 590);
            this.Controls.Add(this.pnlLogInInfo);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnlMediCare.ResumeLayout(false);
            this.pnlLogInInfo.ResumeLayout(false);
            this.pnlMediCareLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMediCareLogo)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMediCare;
        private System.Windows.Forms.Label lblMediCare;
        private System.Windows.Forms.Panel pnlLogInInfo;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMediCareLogo;
        private System.Windows.Forms.PictureBox picMediCareLogo;
    }
}

