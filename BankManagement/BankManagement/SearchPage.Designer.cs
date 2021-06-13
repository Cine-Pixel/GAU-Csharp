
namespace BankManagement {
    partial class SearchPage {
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
            this.filteredByDate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnClientsFromDate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClientsTopM = new System.Windows.Forms.Button();
            this.topUsers = new System.Windows.Forms.DataGridView();
            this.tbTopM = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.filteredByDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // filteredByDate
            // 
            this.filteredByDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filteredByDate.Location = new System.Drawing.Point(18, 184);
            this.filteredByDate.Name = "filteredByDate";
            this.filteredByDate.Size = new System.Drawing.Size(320, 247);
            this.filteredByDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(62, 95);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(188, 20);
            this.dtFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(62, 121);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(188, 20);
            this.dtTo.TabIndex = 3;
            // 
            // btnClientsFromDate
            // 
            this.btnClientsFromDate.Location = new System.Drawing.Point(62, 147);
            this.btnClientsFromDate.Name = "btnClientsFromDate";
            this.btnClientsFromDate.Size = new System.Drawing.Size(75, 23);
            this.btnClientsFromDate.TabIndex = 4;
            this.btnClientsFromDate.Text = "Get Clients";
            this.btnClientsFromDate.UseVisualStyleBackColor = true;
            this.btnClientsFromDate.Click += new System.EventHandler(this.btnClientsFromDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Google Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(343, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Top";
            // 
            // btnClientsTopM
            // 
            this.btnClientsTopM.Location = new System.Drawing.Point(380, 147);
            this.btnClientsTopM.Name = "btnClientsTopM";
            this.btnClientsTopM.Size = new System.Drawing.Size(75, 23);
            this.btnClientsTopM.TabIndex = 4;
            this.btnClientsTopM.Text = "Get Clients";
            this.btnClientsTopM.UseVisualStyleBackColor = true;
            this.btnClientsTopM.Click += new System.EventHandler(this.btnClientsTopM_Click);
            // 
            // topUsers
            // 
            this.topUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.topUsers.Location = new System.Drawing.Point(344, 184);
            this.topUsers.Name = "topUsers";
            this.topUsers.Size = new System.Drawing.Size(320, 247);
            this.topUsers.TabIndex = 1;
            // 
            // tbTopM
            // 
            this.tbTopM.Location = new System.Drawing.Point(380, 95);
            this.tbTopM.Name = "tbTopM";
            this.tbTopM.Size = new System.Drawing.Size(187, 20);
            this.tbTopM.TabIndex = 5;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.tbTopM);
            this.Controls.Add(this.btnClientsTopM);
            this.Controls.Add(this.btnClientsFromDate);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topUsers);
            this.Controls.Add(this.filteredByDate);
            this.Name = "SearchPage";
            this.Size = new System.Drawing.Size(683, 453);
            ((System.ComponentModel.ISupportInitialize)(this.filteredByDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView filteredByDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnClientsFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClientsTopM;
        private System.Windows.Forms.DataGridView topUsers;
        private System.Windows.Forms.TextBox tbTopM;
    }
}
