
namespace BankManagement {
    partial class Loan {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cbGetLoanCurrency = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBackPerNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGetLoanAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myLoans = new System.Windows.Forms.DataGridView();
            this.btnListLoans = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Loan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(427, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your Loans";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbGetLoanCurrency);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbBackPerNum);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbGetLoanAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 279);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Request Loan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbGetLoanCurrency
            // 
            this.cbGetLoanCurrency.FormattingEnabled = true;
            this.cbGetLoanCurrency.Items.AddRange(new object[] {
            "GEL",
            "USD",
            "EUR"});
            this.cbGetLoanCurrency.Location = new System.Drawing.Point(20, 94);
            this.cbGetLoanCurrency.Name = "cbGetLoanCurrency";
            this.cbGetLoanCurrency.Size = new System.Drawing.Size(271, 21);
            this.cbGetLoanCurrency.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Currency";
            // 
            // tbBackPerNum
            // 
            this.tbBackPerNum.Location = new System.Drawing.Point(20, 147);
            this.tbBackPerNum.Name = "tbBackPerNum";
            this.tbBackPerNum.Size = new System.Drawing.Size(271, 20);
            this.tbBackPerNum.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Backer Personal Number";
            // 
            // tbGetLoanAmount
            // 
            this.tbGetLoanAmount.Location = new System.Drawing.Point(20, 43);
            this.tbGetLoanAmount.Name = "tbGetLoanAmount";
            this.tbGetLoanAmount.Size = new System.Drawing.Size(271, 20);
            this.tbGetLoanAmount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Amount";
            // 
            // myLoans
            // 
            this.myLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myLoans.Location = new System.Drawing.Point(364, 120);
            this.myLoans.Name = "myLoans";
            this.myLoans.Size = new System.Drawing.Size(297, 159);
            this.myLoans.TabIndex = 3;
            // 
            // btnListLoans
            // 
            this.btnListLoans.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListLoans.FlatAppearance.BorderSize = 0;
            this.btnListLoans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListLoans.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListLoans.ForeColor = System.Drawing.Color.White;
            this.btnListLoans.Location = new System.Drawing.Point(380, 302);
            this.btnListLoans.Name = "btnListLoans";
            this.btnListLoans.Size = new System.Drawing.Size(268, 35);
            this.btnListLoans.TabIndex = 3;
            this.btnListLoans.Text = "List";
            this.btnListLoans.UseVisualStyleBackColor = false;
            this.btnListLoans.Click += new System.EventHandler(this.btnListLoans_Click);
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnListLoans);
            this.Controls.Add(this.myLoans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Loan";
            this.Size = new System.Drawing.Size(683, 453);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbGetLoanAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbGetLoanCurrency;
        private System.Windows.Forms.TextBox tbBackPerNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView myLoans;
        private System.Windows.Forms.Button btnListLoans;
    }
}
