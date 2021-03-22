
namespace form_basics {
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
            this.label1 = new System.Windows.Forms.Label();
            this.Side1 = new System.Windows.Forms.TextBox();
            this.Side2 = new System.Windows.Forms.TextBox();
            this.Side3 = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter 3 sides of Triangle";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Side1
            // 
            this.Side1.Location = new System.Drawing.Point(40, 111);
            this.Side1.Name = "Side1";
            this.Side1.Size = new System.Drawing.Size(100, 20);
            this.Side1.TabIndex = 1;
            // 
            // Side2
            // 
            this.Side2.Location = new System.Drawing.Point(146, 111);
            this.Side2.Name = "Side2";
            this.Side2.Size = new System.Drawing.Size(100, 20);
            this.Side2.TabIndex = 2;
            // 
            // Side3
            // 
            this.Side3.Location = new System.Drawing.Point(252, 111);
            this.Side3.Name = "Side3";
            this.Side3.Size = new System.Drawing.Size(100, 20);
            this.Side3.TabIndex = 3;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(40, 157);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(311, 29);
            this.Calculate.TabIndex = 4;
            this.Calculate.Text = "Calculate Area";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Output
            // 
            this.Output.Font = new System.Drawing.Font("Ubuntu", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Output.Location = new System.Drawing.Point(410, 111);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(338, 74);
            this.Output.TabIndex = 5;
            this.Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ubuntu", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(410, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Output:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(790, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Side3);
            this.Controls.Add(this.Side2);
            this.Controls.Add(this.Side1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Ubuntu", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Bunch of stuff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Side1;
        private System.Windows.Forms.TextBox Side2;
        private System.Windows.Forms.TextBox Side3;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label label2;
    }
}

