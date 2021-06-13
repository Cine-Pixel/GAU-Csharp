
namespace BankManagement {
    partial class DepositPage {
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
            this.tbDepositAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDepositPercent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MyDeposits = new System.Windows.Forms.DataGridView();
            this.btnListDeposits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount";
            // 
            // tbDepositAmount
            // 
            this.tbDepositAmount.Location = new System.Drawing.Point(93, 141);
            this.tbDepositAmount.Name = "tbDepositAmount";
            this.tbDepositAmount.Size = new System.Drawing.Size(197, 20);
            this.tbDepositAmount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Percent";
            // 
            // tbDepositPercent
            // 
            this.tbDepositPercent.Location = new System.Drawing.Point(93, 179);
            this.tbDepositPercent.Name = "tbDepositPercent";
            this.tbDepositPercent.Size = new System.Drawing.Size(197, 20);
            this.tbDepositPercent.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Currency";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "GEL",
            "USD",
            "EUR"});
            this.comboBox1.Location = new System.Drawing.Point(93, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(106, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Request Deposit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Google Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(441, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "My Deposits";
            // 
            // MyDeposits
            // 
            this.MyDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDeposits.Location = new System.Drawing.Point(357, 141);
            this.MyDeposits.Name = "MyDeposits";
            this.MyDeposits.Size = new System.Drawing.Size(301, 129);
            this.MyDeposits.TabIndex = 5;
            // 
            // btnListDeposits
            // 
            this.btnListDeposits.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnListDeposits.FlatAppearance.BorderSize = 0;
            this.btnListDeposits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListDeposits.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListDeposits.ForeColor = System.Drawing.Color.White;
            this.btnListDeposits.Location = new System.Drawing.Point(445, 280);
            this.btnListDeposits.Name = "btnListDeposits";
            this.btnListDeposits.Size = new System.Drawing.Size(133, 33);
            this.btnListDeposits.TabIndex = 4;
            this.btnListDeposits.Text = "List";
            this.btnListDeposits.UseVisualStyleBackColor = false;
            this.btnListDeposits.Click += new System.EventHandler(this.btnListDeposits_Click);
            // 
            // DepositPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.MyDeposits);
            this.Controls.Add(this.btnListDeposits);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDepositPercent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDepositAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DepositPage";
            this.Size = new System.Drawing.Size(683, 453);
            ((System.ComponentModel.ISupportInitialize)(this.MyDeposits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDepositAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepositPercent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView MyDeposits;
        private System.Windows.Forms.Button btnListDeposits;
    }
}
