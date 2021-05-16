
namespace Work6_Inheritance {
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
            this.magicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // magicButton
            // 
            this.magicButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.magicButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.magicButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.magicButton.FlatAppearance.BorderSize = 0;
            this.magicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.magicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.magicButton.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.magicButton.Location = new System.Drawing.Point(86, 126);
            this.magicButton.Name = "magicButton";
            this.magicButton.Size = new System.Drawing.Size(249, 72);
            this.magicButton.TabIndex = 0;
            this.magicButton.Text = "Make Magic";
            this.magicButton.UseVisualStyleBackColor = false;
            this.magicButton.Click += new System.EventHandler(this.magicButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 327);
            this.Controls.Add(this.magicButton);
            this.Name = "Form1";
            this.Text = "Magic Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button magicButton;
    }
}

