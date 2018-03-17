namespace Replace_a_Face
{
    partial class ManageFavorites
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFavorites));
            this.FavoriteListBox = new System.Windows.Forms.ListBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FavoriteListBox
            // 
            this.FavoriteListBox.FormattingEnabled = true;
            this.FavoriteListBox.Location = new System.Drawing.Point(1, 1);
            this.FavoriteListBox.Name = "FavoriteListBox";
            this.FavoriteListBox.ScrollAlwaysVisible = true;
            this.FavoriteListBox.Size = new System.Drawing.Size(602, 225);
            this.FavoriteListBox.TabIndex = 0;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(303, 227);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(300, 33);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(1, 227);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(300, 33);
            this.ModifyButton.TabIndex = 2;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ManageFavorites
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FavoriteListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageFavorites";
            this.Text = "Manage Favorites";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FavoriteListBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ModifyButton;
    }
}