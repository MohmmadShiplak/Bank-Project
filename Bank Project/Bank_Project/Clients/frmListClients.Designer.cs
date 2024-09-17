namespace Bank_Project
{
    partial class frmListClients
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.cmsClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblClients = new System.Windows.Forms.Label();
            this.clientsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.cmsClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.AllowUserToAddRows = false;
            this.dgvClients.AllowUserToOrderColumns = true;
            this.dgvClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.ContextMenuStrip = this.cmsClients;
            this.dgvClients.Location = new System.Drawing.Point(2, 248);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowHeadersWidth = 51;
            this.dgvClients.RowTemplate.Height = 24;
            this.dgvClients.Size = new System.Drawing.Size(1138, 296);
            this.dgvClients.TabIndex = 0;
            // 
            // cmsClients
            // 
            this.cmsClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.clientsInfoToolStripMenuItem});
            this.cmsClients.Name = "cmsClients";
            this.cmsClients.Size = new System.Drawing.Size(211, 128);
            // 
            // addNToolStripMenuItem
            // 
            this.addNToolStripMenuItem.Name = "addNToolStripMenuItem";
            this.addNToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addNToolStripMenuItem.Text = "Add New Client";
            this.addNToolStripMenuItem.Click += new System.EventHandler(this.addNToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 586);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clients :";
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(130, 586);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(45, 25);
            this.lblClients.TabIndex = 2;
            this.lblClients.Text = "???";
            // 
            // clientsInfoToolStripMenuItem
            // 
            this.clientsInfoToolStripMenuItem.Name = "clientsInfoToolStripMenuItem";
            this.clientsInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.clientsInfoToolStripMenuItem.Text = "Clients Info";
            this.clientsInfoToolStripMenuItem.Click += new System.EventHandler(this.clientsInfoToolStripMenuItem_Click);
            // 
            // frmListClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1145, 632);
            this.Controls.Add(this.lblClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListClients";
            this.Text = "List Clients";
            this.Load += new System.EventHandler(this.frmListClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.cmsClients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.ContextMenuStrip cmsClients;
        private System.Windows.Forms.ToolStripMenuItem addNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsInfoToolStripMenuItem;
    }
}