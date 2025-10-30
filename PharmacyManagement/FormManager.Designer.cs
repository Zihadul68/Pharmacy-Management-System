namespace MediCare
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
            this.pnlManager = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManager
            // 
            this.pnlManager.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlManager.Controls.Add(this.btnLogout);
            this.pnlManager.Controls.Add(this.lblInfo);
            this.pnlManager.Location = new System.Drawing.Point(1, 1);
            this.pnlManager.Name = "pnlManager";
            this.pnlManager.Size = new System.Drawing.Size(762, 527);
            this.pnlManager.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(347, 303);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 34);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(223, 86);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(340, 30);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Welcome to MediCare, Logged in as Manager: \r\n";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 527);
            this.Controls.Add(this.pnlManager);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.pnlManager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Panel pnlManager;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnLogout;
    }
}