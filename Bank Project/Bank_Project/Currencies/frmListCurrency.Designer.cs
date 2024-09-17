namespace Bank_Project
{
    partial class frmListCurrency
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
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCurrencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToDeleteRows = false;
            this.dgvCurrencies.AllowUserToOrderColumns = true;
            this.dgvCurrencies.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencies.Location = new System.Drawing.Point(0, 220);
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.ReadOnly = true;
            this.dgvCurrencies.RowHeadersWidth = 51;
            this.dgvCurrencies.RowTemplate.Height = 24;
            this.dgvCurrencies.Size = new System.Drawing.Size(895, 369);
            this.dgvCurrencies.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCurrencyToolStripMenuItem,
            this.updateCurrencyToolStripMenuItem,
            this.deleteCurrencyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(898, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addCurrencyToolStripMenuItem
            // 
            this.addCurrencyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.addCurrencyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCurrencyToolStripMenuItem.Name = "addCurrencyToolStripMenuItem";
            this.addCurrencyToolStripMenuItem.Size = new System.Drawing.Size(145, 32);
            this.addCurrencyToolStripMenuItem.Text = "Add Currency";
            this.addCurrencyToolStripMenuItem.Click += new System.EventHandler(this.addCurrencyToolStripMenuItem_Click);
            // 
            // updateCurrencyToolStripMenuItem
            // 
            this.updateCurrencyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.updateCurrencyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCurrencyToolStripMenuItem.Name = "updateCurrencyToolStripMenuItem";
            this.updateCurrencyToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.updateCurrencyToolStripMenuItem.Text = "Update Currency";
            this.updateCurrencyToolStripMenuItem.Click += new System.EventHandler(this.updateCurrencyToolStripMenuItem_Click);
            // 
            // deleteCurrencyToolStripMenuItem
            // 
            this.deleteCurrencyToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.deleteCurrencyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCurrencyToolStripMenuItem.Name = "deleteCurrencyToolStripMenuItem";
            this.deleteCurrencyToolStripMenuItem.Size = new System.Drawing.Size(164, 32);
            this.deleteCurrencyToolStripMenuItem.Text = "Delete Currency";
            this.deleteCurrencyToolStripMenuItem.Click += new System.EventHandler(this.deleteCurrencyToolStripMenuItem_Click);
            // 
            // frmListCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(898, 591);
            this.Controls.Add(this.dgvCurrencies);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmListCurrency";
            this.Text = "List Currency";
            this.Load += new System.EventHandler(this.frmListCurrency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCurrencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCurrencyToolStripMenuItem;
    }
}