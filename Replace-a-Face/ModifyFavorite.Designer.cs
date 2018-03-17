namespace Replace_a_Face
{
    partial class ModifyFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyFavorite));
            this.NameLabel = new System.Windows.Forms.Label();
            this.FaceKeyLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FaceKeyTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // FaceKeyLabel
            // 
            this.FaceKeyLabel.AutoSize = true;
            this.FaceKeyLabel.Location = new System.Drawing.Point(12, 52);
            this.FaceKeyLabel.Name = "FaceKeyLabel";
            this.FaceKeyLabel.Size = new System.Drawing.Size(52, 13);
            this.FaceKeyLabel.TabIndex = 1;
            this.FaceKeyLabel.Text = "Face Key";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 25);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(476, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // FaceKeyTextBox
            // 
            this.FaceKeyTextBox.Location = new System.Drawing.Point(15, 68);
            this.FaceKeyTextBox.Name = "FaceKeyTextBox";
            this.FaceKeyTextBox.Size = new System.Drawing.Size(476, 20);
            this.FaceKeyTextBox.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(416, 94);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ModifyFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 120);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FaceKeyTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.FaceKeyLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyFavorite";
            this.Text = "Modify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label FaceKeyLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox FaceKeyTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}