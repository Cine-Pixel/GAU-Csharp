
namespace BankManagement {
    partial class BankirDashboard {
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
            this.pendingLoans = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnListPending = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pendingLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // pendingLoans
            // 
            this.pendingLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendingLoans.Location = new System.Drawing.Point(3, 130);
            this.pendingLoans.Name = "pendingLoans";
            this.pendingLoans.Size = new System.Drawing.Size(677, 320);
            this.pendingLoans.TabIndex = 1;
            this.pendingLoans.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.pendingLoans_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percent";
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(30, 69);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(159, 20);
            this.tbPercent.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration in moths";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(205, 69);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(159, 20);
            this.tbDuration.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Approve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListPending
            // 
            this.btnListPending.Location = new System.Drawing.Point(591, 92);
            this.btnListPending.Name = "btnListPending";
            this.btnListPending.Size = new System.Drawing.Size(89, 32);
            this.btnListPending.TabIndex = 5;
            this.btnListPending.Text = "List";
            this.btnListPending.UseVisualStyleBackColor = true;
            this.btnListPending.Click += new System.EventHandler(this.btnListPending_Click);
            // 
            // BankirDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnListPending);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pendingLoans);
            this.Controls.Add(this.label1);
            this.Name = "BankirDashboard";
            this.Size = new System.Drawing.Size(683, 453);
            ((System.ComponentModel.ISupportInitialize)(this.pendingLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView pendingLoans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnListPending;
    }
}
