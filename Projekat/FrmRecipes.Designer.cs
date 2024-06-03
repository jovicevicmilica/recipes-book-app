namespace Projekat
{
    partial class FrmRecipes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecipes));
            this.dgRecipes = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEditRecipe = new System.Windows.Forms.Button();
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
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.dgIngredients = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTimeTo = new System.Windows.Forms.TextBox();
            this.lblSalaryTo = new System.Windows.Forms.Label();
            this.txtTimeFrom = new System.Windows.Forms.TextBox();
            this.lblSalaryFrom = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.btnAddToMenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRecipes
            // 
            this.dgRecipes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRecipes.GridColor = System.Drawing.Color.MediumOrchid;
            this.dgRecipes.Location = new System.Drawing.Point(12, 226);
            this.dgRecipes.Name = "dgRecipes";
            this.dgRecipes.RowHeadersWidth = 51;
            this.dgRecipes.RowTemplate.Height = 24;
            this.dgRecipes.Size = new System.Drawing.Size(712, 317);
            this.dgRecipes.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Abel Pro", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(497, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 46);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Recepti";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecipe.Location = new System.Drawing.Point(482, 113);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(209, 40);
            this.btnEditRecipe.TabIndex = 2;
            this.btnEditRecipe.Text = "IZMIJENI RECEPT";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
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
            this.menuStrip.Size = new System.Drawing.Size(1152, 32);
            this.menuStrip.TabIndex = 4;
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
            this.addIngredientMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addIngredientMenuItem.Name = "addIngredientMenuItem";
            this.addIngredientMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addIngredientMenuItem.Text = "Sastojak";
            this.addIngredientMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addRecipeMenuItem
            // 
            this.addRecipeMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.addRecipeMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecipeMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addRecipeMenuItem.Name = "addRecipeMenuItem";
            this.addRecipeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRecipeMenuItem.Text = "Recept";
            this.addRecipeMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addMenuMenuItem
            // 
            this.addMenuMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.addMenuMenuItem.Font = new System.Drawing.Font("Abel Pro", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addMenuMenuItem.Name = "addMenuMenuItem";
            this.addMenuMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.allIngrReportMenuItem.Name = "allIngrReportMenuItem";
            this.allIngrReportMenuItem.Size = new System.Drawing.Size(224, 28);
            this.allIngrReportMenuItem.Text = "Svi sastojci";
            // 
            // allRcpReportMenuItem
            // 
            this.allRcpReportMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.allRcpReportMenuItem.Name = "allRcpReportMenuItem";
            this.allRcpReportMenuItem.Size = new System.Drawing.Size(224, 28);
            this.allRcpReportMenuItem.Text = "Svi recepti";
            // 
            // allMenusReportMenuItem
            // 
            this.allMenusReportMenuItem.BackColor = System.Drawing.Color.DarkOrchid;
            this.allMenusReportMenuItem.Name = "allMenusReportMenuItem";
            this.allMenusReportMenuItem.Size = new System.Drawing.Size(224, 28);
            this.allMenusReportMenuItem.Text = "Svi meniji";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Abel Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(64, 28);
            this.exitMenuItem.Text = "Izađi";
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecipe.Location = new System.Drawing.Point(247, 113);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(209, 40);
            this.btnDeleteRecipe.TabIndex = 5;
            this.btnDeleteRecipe.Text = "OBRIŠI RECEPT";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // dgIngredients
            // 
            this.dgIngredients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngredients.Location = new System.Drawing.Point(739, 226);
            this.dgIngredients.Name = "dgIngredients";
            this.dgIngredients.RowHeadersWidth = 51;
            this.dgIngredients.RowTemplate.Height = 24;
            this.dgIngredients.Size = new System.Drawing.Size(401, 317);
            this.dgIngredients.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(694, 172);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(209, 40);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "PRETRAŽI";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtTimeTo
            // 
            this.txtTimeTo.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeTo.Location = new System.Drawing.Point(583, 180);
            this.txtTimeTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimeTo.Name = "txtTimeTo";
            this.txtTimeTo.Size = new System.Drawing.Size(81, 26);
            this.txtTimeTo.TabIndex = 19;
            // 
            // lblSalaryTo
            // 
            this.lblSalaryTo.AutoSize = true;
            this.lblSalaryTo.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryTo.ForeColor = System.Drawing.Color.White;
            this.lblSalaryTo.Location = new System.Drawing.Point(544, 182);
            this.lblSalaryTo.Name = "lblSalaryTo";
            this.lblSalaryTo.Size = new System.Drawing.Size(33, 22);
            this.lblSalaryTo.TabIndex = 18;
            this.lblSalaryTo.Text = "do:";
            // 
            // txtTimeFrom
            // 
            this.txtTimeFrom.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeFrom.Location = new System.Drawing.Point(457, 180);
            this.txtTimeFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimeFrom.Name = "txtTimeFrom";
            this.txtTimeFrom.Size = new System.Drawing.Size(81, 26);
            this.txtTimeFrom.TabIndex = 17;
            // 
            // lblSalaryFrom
            // 
            this.lblSalaryFrom.AutoSize = true;
            this.lblSalaryFrom.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaryFrom.ForeColor = System.Drawing.Color.White;
            this.lblSalaryFrom.Location = new System.Drawing.Point(302, 182);
            this.lblSalaryFrom.Name = "lblSalaryFrom";
            this.lblSalaryFrom.Size = new System.Drawing.Size(154, 22);
            this.lblSalaryFrom.TabIndex = 16;
            this.lblSalaryFrom.Text = "Ukupno vrijeme od:";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(135, 180);
            this.txtNameSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(159, 26);
            this.txtNameSearch.TabIndex = 15;
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.White;
            this.lblNameSearch.Location = new System.Drawing.Point(12, 182);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(120, 22);
            this.lblNameSearch.TabIndex = 14;
            this.lblNameSearch.Text = "Naziv recepta:";
            // 
            // btnAddToMenu
            // 
            this.btnAddToMenu.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToMenu.Location = new System.Drawing.Point(717, 113);
            this.btnAddToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToMenu.Name = "btnAddToMenu";
            this.btnAddToMenu.Size = new System.Drawing.Size(209, 40);
            this.btnAddToMenu.TabIndex = 13;
            this.btnAddToMenu.Text = "DODAJ U MENI";
            this.btnAddToMenu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Projekat.Properties.Resources.cooking2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(643, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 74);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(1152, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTimeTo);
            this.Controls.Add(this.lblSalaryTo);
            this.Controls.Add(this.txtTimeFrom);
            this.Controls.Add(this.lblSalaryFrom);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.lblNameSearch);
            this.Controls.Add(this.btnAddToMenu);
            this.Controls.Add(this.dgIngredients);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgRecipes);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmRecipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepti";
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRecipes;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEditRecipe;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnDeleteRecipe;
        private System.Windows.Forms.DataGridView dgIngredients;
        private System.Windows.Forms.ToolStripMenuItem allIngrReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRcpReportMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTimeTo;
        private System.Windows.Forms.Label lblSalaryTo;
        private System.Windows.Forms.TextBox txtTimeFrom;
        private System.Windows.Forms.Label lblSalaryFrom;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.Button btnAddToMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allMenusReportMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

