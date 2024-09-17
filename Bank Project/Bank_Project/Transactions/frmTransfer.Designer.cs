namespace Bank_Project
{
    partial class frmTransfer
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
            this.txtAccountNumber1 = new System.Windows.Forms.TextBox();
            this.txtAccountNumber2 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.btnTransform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAccountNumber1
            // 
            this.txtAccountNumber1.Location = new System.Drawing.Point(293, 105);
            this.txtAccountNumber1.Multiline = true;
            this.txtAccountNumber1.Name = "txtAccountNumber1";
            this.txtAccountNumber1.Size = new System.Drawing.Size(128, 24);
            this.txtAccountNumber1.TabIndex = 0;
            // 
            // txtAccountNumber2
            // 
            this.txtAccountNumber2.Enabled = false;
            this.txtAccountNumber2.Location = new System.Drawing.Point(293, 181);
            this.txtAccountNumber2.Multiline = true;
            this.txtAccountNumber2.Name = "txtAccountNumber2";
            this.txtAccountNumber2.Size = new System.Drawing.Size(128, 24);
            this.txtAccountNumber2.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(293, 251);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(128, 26);
            this.txtAmount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "AccountNumber 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "AccountNumber 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch1.Location = new System.Drawing.Point(472, 102);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(90, 27);
            this.btnSearch1.TabIndex = 6;
            this.btnSearch1.Text = "Search 1";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.Color.LightGray;
            this.btnSearch2.Enabled = false;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.Location = new System.Drawing.Point(472, 174);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(90, 27);
            this.btnSearch2.TabIndex = 7;
            this.btnSearch2.Text = "Search 2";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.BackColor = System.Drawing.Color.LightGray;
            this.btnTransform.Enabled = false;
            this.btnTransform.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransform.Location = new System.Drawing.Point(472, 248);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(109, 27);
            this.btnTransform.TabIndex = 8;
            this.btnTransform.Text = "Transform";
            this.btnTransform.UseVisualStyleBackColor = false;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnSearch1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtAccountNumber2);
            this.Controls.Add(this.txtAccountNumber1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransfer";
            this.Text = "frmTransfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountNumber1;
        private System.Windows.Forms.TextBox txtAccountNumber2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Button btnTransform;
    }
}