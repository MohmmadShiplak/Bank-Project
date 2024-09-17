namespace Bank_Project.Transactions
{
    partial class frmTransactions
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdrew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.White;
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Location = new System.Drawing.Point(3, 3);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(164, 35);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "Transactions ";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.BackColor = System.Drawing.Color.White;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(173, 3);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(164, 35);
            this.btnDeposit.TabIndex = 1;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdrew
            // 
            this.btnWithdrew.BackColor = System.Drawing.Color.White;
            this.btnWithdrew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrew.Location = new System.Drawing.Point(343, 3);
            this.btnWithdrew.Name = "btnWithdrew";
            this.btnWithdrew.Size = new System.Drawing.Size(164, 35);
            this.btnWithdrew.TabIndex = 2;
            this.btnWithdrew.Text = "Withdrew ";
            this.btnWithdrew.UseVisualStyleBackColor = false;
            this.btnWithdrew.Click += new System.EventHandler(this.btnWithdrew_Click);
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(568, 182);
            this.Controls.Add(this.btnWithdrew);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdrew;
    }
}