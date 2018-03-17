namespace Replace_a_Face
{
    partial class InsertFavorite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertFavorite));
            this.FavoriteListBox = new System.Windows.Forms.ListBox();
            this.InsertButton = new System.Windows.Forms.Button();
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
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(1, 227);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(602, 33);
            this.InsertButton.TabIndex = 1;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // InsertFavorite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 261);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.FavoriteListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InsertFavorite";
            this.Text = "Insert Favorite";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FavoriteListBox;
        private System.Windows.Forms.Button InsertButton;
    }
}