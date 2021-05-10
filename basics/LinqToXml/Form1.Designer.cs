
namespace LinqToXml {
    partial class Form1 {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.AddStudent = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.owner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.shipping = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productsDisplay = new System.Windows.Forms.DataGridView();
            this.maxForItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.applyCustomFilter = new System.Windows.Forms.Button();
            this.maxFilter = new System.Windows.Forms.Button();
            this.minFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productsDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // AddStudent
            // 
            this.AddStudent.Location = new System.Drawing.Point(22, 256);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(176, 23);
            this.AddStudent.TabIndex = 0;
            this.AddStudent.Text = "Add";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(22, 53);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(176, 20);
            this.name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // owner
            // 
            this.owner.Location = new System.Drawing.Point(213, 52);
            this.owner.Name = "owner";
            this.owner.Size = new System.Drawing.Size(168, 20);
            this.owner.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 36);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Owner";
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(22, 212);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(176, 20);
            this.cost.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cost";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(22, 100);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(359, 86);
            this.description.TabIndex = 3;
            this.description.Text = "";
            // 
            // shipping
            // 
            this.shipping.Location = new System.Drawing.Point(213, 212);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(168, 20);
            this.shipping.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(210, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Shipping";
            // 
            // productsDisplay
            // 
            this.productsDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDisplay.Location = new System.Drawing.Point(419, 37);
            this.productsDisplay.Name = "productsDisplay";
            this.productsDisplay.Size = new System.Drawing.Size(369, 242);
            this.productsDisplay.TabIndex = 4;
            // 
            // maxForItem
            // 
            this.maxForItem.Location = new System.Drawing.Point(419, 307);
            this.maxForItem.Name = "maxForItem";
            this.maxForItem.Size = new System.Drawing.Size(147, 20);
            this.maxForItem.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max cost for 1 item";
            // 
            // applyCustomFilter
            // 
            this.applyCustomFilter.Location = new System.Drawing.Point(570, 305);
            this.applyCustomFilter.Name = "applyCustomFilter";
            this.applyCustomFilter.Size = new System.Drawing.Size(69, 23);
            this.applyCustomFilter.TabIndex = 6;
            this.applyCustomFilter.Text = "Apply";
            this.applyCustomFilter.UseVisualStyleBackColor = true;
            this.applyCustomFilter.Click += new System.EventHandler(this.applyCustomFilter_Click);
            // 
            // maxFilter
            // 
            this.maxFilter.Location = new System.Drawing.Point(662, 305);
            this.maxFilter.Name = "maxFilter";
            this.maxFilter.Size = new System.Drawing.Size(61, 23);
            this.maxFilter.TabIndex = 6;
            this.maxFilter.Text = "Max";
            this.maxFilter.UseVisualStyleBackColor = true;
            // 
            // minFilter
            // 
            this.minFilter.Location = new System.Drawing.Point(724, 305);
            this.minFilter.Name = "minFilter";
            this.minFilter.Size = new System.Drawing.Size(64, 23);
            this.minFilter.TabIndex = 6;
            this.minFilter.Text = "Min";
            this.minFilter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.minFilter);
            this.Controls.Add(this.maxFilter);
            this.Controls.Add(this.applyCustomFilter);
            this.Controls.Add(this.maxForItem);
            this.Controls.Add(this.productsDisplay);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.owner);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox owner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.TextBox shipping;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView productsDisplay;
        private System.Windows.Forms.TextBox maxForItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button applyCustomFilter;
        private System.Windows.Forms.Button maxFilter;
        private System.Windows.Forms.Button minFilter;
    }
}

