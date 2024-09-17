namespace Bank_Project
{
    partial class frmUsersInfo
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
            this.ctrlUsersInfo1 = new Bank_Project.ctrlUsersInfo();
            this.SuspendLayout();
            // 
            // ctrlUsersInfo1
            // 
            this.ctrlUsersInfo1.BackColor = System.Drawing.Color.White;
            this.ctrlUsersInfo1.Location = new System.Drawing.Point(2, 3);
            this.ctrlUsersInfo1.Name = "ctrlUsersInfo1";
            this.ctrlUsersInfo1.Size = new System.Drawing.Size(718, 360);
            this.ctrlUsersInfo1.TabIndex = 0;
            // 
            // frmUsersInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 375);
            this.Controls.Add(this.ctrlUsersInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUsersInfo";
            this.Text = "frmUsersInfo";
            this.Load += new System.EventHandler(this.frmUsersInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUsersInfo ctrlUsersInfo1;
    }
}