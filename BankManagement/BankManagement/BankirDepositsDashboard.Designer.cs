
namespace BankManagement {
    partial class BankirDepositsDashboard {
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
            this.pendingDeposits = new System.Windows.Forms.DataGridView();
            this.btnListDeposit = new System.Windows.Forms.Button();
            this.btnApproveDeposit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pendingDeposits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deposit Requests";
            // 
            // pendingDeposits
            // 
            this.pendingDeposits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingDeposits.Location = new System.Drawing.Point(3, 189);
            this.pendingDeposits.Name = "pendingDeposits";
            this.pendingDeposits.Size = new System.Drawing.Size(677, 261);
            this.pendingDeposits.TabIndex = 1;
            this.pendingDeposits.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pendingDeposits_RowHeaderMouseDoubleClick);
            // 
            // btnListDeposit
            // 
            this.btnListDeposit.Location = new System.Drawing.Point(360, 90);
            this.btnListDeposit.Name = "btnListDeposit";
            this.btnListDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnListDeposit.TabIndex = 2;
            this.btnListDeposit.Text = "List";
            this.btnListDeposit.UseVisualStyleBackColor = true;
            // 
            // btnApproveDeposit
            // 
            this.btnApproveDeposit.Location = new System.Drawing.Point(250, 90);
            this.btnApproveDeposit.Name = "btnApproveDeposit";
            this.btnApproveDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnApproveDeposit.TabIndex = 3;
            this.btnApproveDeposit.Text = "Approve";
            this.btnApproveDeposit.UseVisualStyleBackColor = true;
            this.btnApproveDeposit.Click += new System.EventHandler(this.btnApproveDeposit_Click);
            // 
            // BankirDepositsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnApproveDeposit);
            this.Controls.Add(this.btnListDeposit);
            this.Controls.Add(this.pendingDeposits);
            this.Controls.Add(this.label1);
            this.Name = "BankirDepositsDashboard";
            this.Size = new System.Drawing.Size(683, 453);
            ((System.ComponentModel.ISupportInitialize)(this.pendingDeposits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pendingDeposits;
        private System.Windows.Forms.Button btnListDeposit;
        private System.Windows.Forms.Button btnApproveDeposit;
    }
}
