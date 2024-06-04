namespace Projekat
{
    partial class FrmMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenus));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnDeleteMenu = new System.Windows.Forms.Button();
            this.btnEditMenu = new System.Windows.Forms.Button();
            this.lblMenus = new System.Windows.Forms.Label();
            this.dgMenus = new System.Windows.Forms.DataGridView();
            this.dgRecipes = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allIngrReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRcpReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allMenusReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(607, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 42);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "PRETRAŽI";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(414, 184);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(168, 28);
            this.txtNameSearch.TabIndex = 27;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(350, 186);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 22);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Naziv:";
            // 
            // btnDeleteMenu
            // 
            this.btnDeleteMenu.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMenu.Location = new System.Drawing.Point(584, 119);
            this.btnDeleteMenu.Name = "btnDeleteMenu";
            this.btnDeleteMenu.Size = new System.Drawing.Size(194, 42);
            this.btnDeleteMenu.TabIndex = 25;
            this.btnDeleteMenu.Text = "OBRIŠI MENI";
            this.btnDeleteMenu.UseVisualStyleBackColor = true;
            // 
            // btnEditMenu
            // 
            this.btnEditMenu.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMenu.Location = new System.Drawing.Point(356, 119);
            this.btnEditMenu.Name = "btnEditMenu";
            this.btnEditMenu.Size = new System.Drawing.Size(209, 42);
            this.btnEditMenu.TabIndex = 24;
            this.btnEditMenu.Text = "IZMIJENI MENI";
            this.btnEditMenu.UseVisualStyleBackColor = true;
            // 
            // lblMenus
            // 
            this.lblMenus.AutoSize = true;
            this.lblMenus.Font = new System.Drawing.Font("Becky Tahlia", 24F, System.Drawing.FontStyle.Bold);
            this.lblMenus.ForeColor = System.Drawing.Color.White;
            this.lblMenus.Location = new System.Drawing.Point(471, 71);
            this.lblMenus.Name = "lblMenus";
            this.lblMenus.Size = new System.Drawing.Size(118, 45);
            this.lblMenus.TabIndex = 23;
            this.lblMenus.Text = "Meniji";
            this.lblMenus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgMenus
            // 
            this.dgMenus.BackgroundColor = System.Drawing.Color.White;
            this.dgMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMenus.Location = new System.Drawing.Point(31, 236);
            this.dgMenus.Name = "dgMenus";
            this.dgMenus.RowHeadersWidth = 51;
            this.dgMenus.RowTemplate.Height = 24;
            this.dgMenus.Size = new System.Drawing.Size(504, 298);
            this.dgMenus.TabIndex = 22;
            // 
            // dgRecipes
            // 
            this.dgRecipes.BackgroundColor = System.Drawing.Color.White;
            this.dgRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecipes.Location = new System.Drawing.Point(564, 236);
            this.dgRecipes.Name = "dgRecipes";
            this.dgRecipes.RowHeadersWidth = 51;
            this.dgRecipes.RowTemplate.Height = 24;
            this.dgRecipes.Size = new System.Drawing.Size(468, 298);
            this.dgRecipes.TabIndex = 29;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.reportsMenuItem,
            this.exitMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1065, 32);
            this.menuStrip.TabIndex = 30;
            this.menuStrip.Text = "mainMenu";
            // 
            // addMenuItem
            // 
            this.addMenuItem.BackColor = System.Drawing.Color.White;
            this.addMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIngredientMenuItem,
            this.addRecipeMenuItem,
            this.addMenuMenuItem});
            this.addMenuItem.Font = new System.Drawing.Font("Abel Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(71, 28);
            this.addMenuItem.Text = "Dodaj";
            // 
            // addIngredientMenuItem
            // 
            this.addIngredientMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.addIngredientMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIngredientMenuItem.ForeColor = System.Drawing.Color.White;
            this.addIngredientMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addIngredientMenuItem.Name = "addIngredientMenuItem";
            this.addIngredientMenuItem.Size = new System.Drawing.Size(158, 26);
            this.addIngredientMenuItem.Text = "Sastojak";
            this.addIngredientMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addRecipeMenuItem
            // 
            this.addRecipeMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.addRecipeMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipeMenuItem.ForeColor = System.Drawing.Color.White;
            this.addRecipeMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addRecipeMenuItem.Name = "addRecipeMenuItem";
            this.addRecipeMenuItem.Size = new System.Drawing.Size(158, 26);
            this.addRecipeMenuItem.Text = "Recept";
            this.addRecipeMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addMenuMenuItem
            // 
            this.addMenuMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.addMenuMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuMenuItem.ForeColor = System.Drawing.Color.White;
            this.addMenuMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addMenuMenuItem.Name = "addMenuMenuItem";
            this.addMenuMenuItem.Size = new System.Drawing.Size(158, 26);
            this.addMenuMenuItem.Text = "Meni";
            this.addMenuMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIngrReportMenuItem,
            this.allRcpReportMenuItem,
            this.allMenusReportMenuItem});
            this.reportsMenuItem.Font = new System.Drawing.Font("Abel Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(102, 28);
            this.reportsMenuItem.Text = "Izvještaji";
            // 
            // allIngrReportMenuItem
            // 
            this.allIngrReportMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.allIngrReportMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allIngrReportMenuItem.ForeColor = System.Drawing.Color.White;
            this.allIngrReportMenuItem.Name = "allIngrReportMenuItem";
            this.allIngrReportMenuItem.Size = new System.Drawing.Size(177, 26);
            this.allIngrReportMenuItem.Text = "Svi sastojci";
            // 
            // allRcpReportMenuItem
            // 
            this.allRcpReportMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.allRcpReportMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRcpReportMenuItem.ForeColor = System.Drawing.Color.White;
            this.allRcpReportMenuItem.Name = "allRcpReportMenuItem";
            this.allRcpReportMenuItem.Size = new System.Drawing.Size(177, 26);
            this.allRcpReportMenuItem.Text = "Svi recepti";
            // 
            // allMenusReportMenuItem
            // 
            this.allMenusReportMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.allMenusReportMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allMenusReportMenuItem.ForeColor = System.Drawing.Color.White;
            this.allMenusReportMenuItem.Name = "allMenusReportMenuItem";
            this.allMenusReportMenuItem.Size = new System.Drawing.Size(177, 26);
            this.allMenusReportMenuItem.Text = "Svi meniji";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Abel Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(64, 28);
            this.exitMenuItem.Text = "Izađi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projekat.Properties.Resources.open_book__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(595, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 50);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1065, 564);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.dgRecipes);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDeleteMenu);
            this.Controls.Add(this.btnEditMenu);
            this.Controls.Add(this.lblMenus);
            this.Controls.Add(this.dgMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniji";
            ((System.ComponentModel.ISupportInitialize)(this.dgMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDeleteMenu;
        private System.Windows.Forms.Button btnEditMenu;
        private System.Windows.Forms.Label lblMenus;
        private System.Windows.Forms.DataGridView dgMenus;
        private System.Windows.Forms.DataGridView dgRecipes;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIngrReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRcpReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMenusReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}