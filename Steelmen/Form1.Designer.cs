namespace Steelmen
{
    partial class Form1
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
            this.JoesCashLabel = new System.Windows.Forms.Label();
            this.BobCashLabel = new System.Windows.Forms.Label();
            this.BankCashLabel = new System.Windows.Forms.Label();
            this.JoeGetMoney = new System.Windows.Forms.Button();
            this.BobGivesMoney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // JoesCashLabel
            // 
            this.JoesCashLabel.AutoSize = true;
            this.JoesCashLabel.Location = new System.Drawing.Point(144, 29);
            this.JoesCashLabel.Name = "JoesCashLabel";
            this.JoesCashLabel.Size = new System.Drawing.Size(35, 20);
            this.JoesCashLabel.TabIndex = 0;
            this.JoesCashLabel.Text = "Joe";
            // 
            // BobCashLabel
            // 
            this.BobCashLabel.AutoSize = true;
            this.BobCashLabel.Location = new System.Drawing.Point(144, 63);
            this.BobCashLabel.Name = "BobCashLabel";
            this.BobCashLabel.Size = new System.Drawing.Size(38, 20);
            this.BobCashLabel.TabIndex = 1;
            this.BobCashLabel.Text = "Bob";
            // 
            // BankCashLabel
            // 
            this.BankCashLabel.AutoSize = true;
            this.BankCashLabel.Location = new System.Drawing.Point(144, 99);
            this.BankCashLabel.Name = "BankCashLabel";
            this.BankCashLabel.Size = new System.Drawing.Size(46, 20);
            this.BankCashLabel.TabIndex = 2;
            this.BankCashLabel.Text = "Bank";
            // 
            // JoeGetMoney
            // 
            this.JoeGetMoney.AutoSize = true;
            this.JoeGetMoney.Location = new System.Drawing.Point(148, 352);
            this.JoeGetMoney.Name = "JoeGetMoney";
            this.JoeGetMoney.Size = new System.Drawing.Size(145, 30);
            this.JoeGetMoney.TabIndex = 3;
            this.JoeGetMoney.Text = "Get money to Joe";
            this.JoeGetMoney.UseVisualStyleBackColor = true;
            this.JoeGetMoney.Click += new System.EventHandler(this.JoeGetMoney_Click);
            // 
            // BobGivesMoney
            // 
            this.BobGivesMoney.AutoSize = true;
            this.BobGivesMoney.Location = new System.Drawing.Point(546, 351);
            this.BobGivesMoney.Name = "BobGivesMoney";
            this.BobGivesMoney.Size = new System.Drawing.Size(139, 30);
            this.BobGivesMoney.TabIndex = 4;
            this.BobGivesMoney.Text = "Bob gives money";
            this.BobGivesMoney.UseVisualStyleBackColor = true;
            this.BobGivesMoney.Click += new System.EventHandler(this.BobGivesMoney_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BobGivesMoney);
            this.Controls.Add(this.JoeGetMoney);
            this.Controls.Add(this.BankCashLabel);
            this.Controls.Add(this.BobCashLabel);
            this.Controls.Add(this.JoesCashLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label JoesCashLabel;
        private System.Windows.Forms.Label BobCashLabel;
        private System.Windows.Forms.Label BankCashLabel;
        private System.Windows.Forms.Button JoeGetMoney;
        private System.Windows.Forms.Button BobGivesMoney;
    }
}

