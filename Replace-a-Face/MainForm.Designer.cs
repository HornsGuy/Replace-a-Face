namespace Replace_a_Face
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupProfilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameFaceDataGrid = new System.Windows.Forms.DataGridView();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaceKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Favorite = new System.Windows.Forms.DataGridViewButtonColumn();
            this.InsertFav = new System.Windows.Forms.DataGridViewButtonColumn();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameFaceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(818, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "Menu";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageFavoritesToolStripMenuItem,
            this.backupProfilesToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // manageFavoritesToolStripMenuItem
            // 
            this.manageFavoritesToolStripMenuItem.Name = "manageFavoritesToolStripMenuItem";
            this.manageFavoritesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.manageFavoritesToolStripMenuItem.Text = "Manage Favorites";
            this.manageFavoritesToolStripMenuItem.Click += new System.EventHandler(this.ManageFavorites_Click);
            // 
            // backupProfilesToolStripMenuItem
            // 
            this.backupProfilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.backupProfilesToolStripMenuItem.Name = "backupProfilesToolStripMenuItem";
            this.backupProfilesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.backupProfilesToolStripMenuItem.Text = "Backup Profiles";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveProfile_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadProfile_Click);
            // 
            // NameFaceDataGrid
            // 
            this.NameFaceDataGrid.AllowUserToAddRows = false;
            this.NameFaceDataGrid.AllowUserToDeleteRows = false;
            this.NameFaceDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.NameFaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NameFaceDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
            this.FaceKey,
            this.Save,
            this.Favorite,
            this.InsertFav});
            this.NameFaceDataGrid.Location = new System.Drawing.Point(0, 24);
            this.NameFaceDataGrid.MultiSelect = false;
            this.NameFaceDataGrid.Name = "NameFaceDataGrid";
            this.NameFaceDataGrid.RowHeadersVisible = false;
            this.NameFaceDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameFaceDataGrid.Size = new System.Drawing.Size(818, 318);
            this.NameFaceDataGrid.TabIndex = 8;
            this.NameFaceDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FavoritesDataGrid_CellContentClick);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProfileName.FillWeight = 20F;
            this.ProfileName.HeaderText = "Profile Name";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            this.ProfileName.Width = 85;
            // 
            // FaceKey
            // 
            this.FaceKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FaceKey.HeaderText = "Face Key (Click to Edit)";
            this.FaceKey.Name = "FaceKey";
            // 
            // Save
            // 
            this.Save.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Save.HeaderText = "";
            this.Save.Name = "Save";
            this.Save.Width = 5;
            // 
            // Favorite
            // 
            this.Favorite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Favorite.HeaderText = "";
            this.Favorite.Name = "Favorite";
            this.Favorite.Width = 5;
            // 
            // InsertFav
            // 
            this.InsertFav.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InsertFav.HeaderText = "";
            this.InsertFav.Name = "InsertFav";
            this.InsertFav.Width = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(818, 342);
            this.Controls.Add(this.NameFaceDataGrid);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Replace a Face";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NameFaceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backupProfilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.DataGridView NameFaceDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaceKey;
        private System.Windows.Forms.DataGridViewButtonColumn Save;
        private System.Windows.Forms.DataGridViewButtonColumn Favorite;
        private System.Windows.Forms.DataGridViewButtonColumn InsertFav;
        private System.Windows.Forms.ToolStripMenuItem manageFavoritesToolStripMenuItem;
    }
}

