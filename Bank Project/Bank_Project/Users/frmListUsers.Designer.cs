namespace Bank_Project
{
    partial class frmListUsers
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
            this.components = new System.ComponentModel.Container();
            this.dgvGetAllUsers = new System.Windows.Forms.DataGridView();
            this.cmsUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showClientsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCleintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblUsers2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).BeginInit();
            this.cmsUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGetAllUsers
            // 
            this.dgvGetAllUsers.AllowUserToAddRows = false;
            this.dgvGetAllUsers.AllowUserToDeleteRows = false;
            this.dgvGetAllUsers.AllowUserToOrderColumns = true;
            this.dgvGetAllUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgvGetAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGetAllUsers.ContextMenuStrip = this.cmsUsers;
            this.dgvGetAllUsers.Location = new System.Drawing.Point(12, 305);
            this.dgvGetAllUsers.Name = "dgvGetAllUsers";
            this.dgvGetAllUsers.ReadOnly = true;
            this.dgvGetAllUsers.RowHeadersWidth = 51;
            this.dgvGetAllUsers.RowTemplate.Height = 24;
            this.dgvGetAllUsers.Size = new System.Drawing.Size(1277, 350);
            this.dgvGetAllUsers.TabIndex = 0;
            // 
            // cmsUsers
            // 
            this.cmsUsers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsInfoToolStripMenuItem,
            this.addClientsToolStripMenuItem,
            this.updateCleintsToolStripMenuItem,
            this.deleteClientsToolStripMenuItem});
            this.cmsUsers.Name = "contextMenuStrip1";
            this.cmsUsers.Size = new System.Drawing.Size(188, 100);
            // 
            // showClientsInfoToolStripMenuItem
            // 
            this.showClientsInfoToolStripMenuItem.Name = "showClientsInfoToolStripMenuItem";
            this.showClientsInfoToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.showClientsInfoToolStripMenuItem.Text = "Show Users  Info";
            this.showClientsInfoToolStripMenuItem.Click += new System.EventHandler(this.showClientsInfoToolStripMenuItem_Click);
            // 
            // addClientsToolStripMenuItem
            // 
            this.addClientsToolStripMenuItem.Name = "addClientsToolStripMenuItem";
            this.addClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.addClientsToolStripMenuItem.Text = "Add Users";
            this.addClientsToolStripMenuItem.Click += new System.EventHandler(this.addClientsToolStripMenuItem_Click);
            // 
            // updateCleintsToolStripMenuItem
            // 
            this.updateCleintsToolStripMenuItem.Name = "updateCleintsToolStripMenuItem";
            this.updateCleintsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.updateCleintsToolStripMenuItem.Text = "Update Users";
            this.updateCleintsToolStripMenuItem.Click += new System.EventHandler(this.updateCleintsToolStripMenuItem_Click);
            // 
            // deleteClientsToolStripMenuItem
            // 
            this.deleteClientsToolStripMenuItem.Name = "deleteClientsToolStripMenuItem";
            this.deleteClientsToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.deleteClientsToolStripMenuItem.Text = "Delete Users";
            this.deleteClientsToolStripMenuItem.Click += new System.EventHandler(this.deleteClientsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 670);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Users :";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.Location = new System.Drawing.Point(127, 670);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(48, 25);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "???";
            // 
            // lblUsers2
            // 
            this.lblUsers2.AutoSize = true;
            this.lblUsers2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers2.Location = new System.Drawing.Point(670, 670);
            this.lblUsers2.Name = "lblUsers2";
            this.lblUsers2.Size = new System.Drawing.Size(48, 25);
            this.lblUsers2.TabIndex = 6;
            this.lblUsers2.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 670);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Users :";
            // 
            // frmListUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 716);
            this.Controls.Add(this.lblUsers2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGetAllUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListUsers";
            this.Text = "frmListUsers";
            this.Load += new System.EventHandler(this.frmListUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGetAllUsers)).EndInit();
            this.cmsUsers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGetAllUsers;
        private System.Windows.Forms.ContextMenuStrip cmsUsers;
        private System.Windows.Forms.ToolStripMenuItem showClientsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCleintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.Label lblUsers2;
        private System.Windows.Forms.Label label2;
    }
}