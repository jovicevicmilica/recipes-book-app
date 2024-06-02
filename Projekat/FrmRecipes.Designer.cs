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
            this.dgRecipes = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEditRecipe = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIngredientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteRecipe = new System.Windows.Forms.Button();
            this.dgIngredients = new System.Windows.Forms.DataGridView();
            this.allIngrReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRcpReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRecipes
            // 
            this.dgRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgRecipes.Location = new System.Drawing.Point(12, 135);
            this.dgRecipes.Name = "dgRecipes";
            this.dgRecipes.RowHeadersWidth = 51;
            this.dgRecipes.RowTemplate.Height = 24;
            this.dgRecipes.Size = new System.Drawing.Size(712, 317);
            this.dgRecipes.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(242, 37);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Knjiga recepata";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditRecipe
            // 
            this.btnEditRecipe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRecipe.Location = new System.Drawing.Point(12, 91);
            this.btnEditRecipe.Name = "btnEditRecipe";
            this.btnEditRecipe.Size = new System.Drawing.Size(151, 38);
            this.btnEditRecipe.TabIndex = 2;
            this.btnEditRecipe.Text = "Izmijeni recept";
            this.btnEditRecipe.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewMenuItem,
            this.addMenuItem,
            this.reportsMenuItem,
            this.exitMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1161, 30);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "mainMenu";
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewIngredientsMenuItem,
            this.viewRecipesMenuItem});
            this.viewMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(100, 26);
            this.viewMenuItem.Text = "Pregledaj";
            // 
            // viewIngredientsMenuItem
            // 
            this.viewIngredientsMenuItem.Name = "viewIngredientsMenuItem";
            this.viewIngredientsMenuItem.Size = new System.Drawing.Size(161, 26);
            this.viewIngredientsMenuItem.Text = "Sastojke";
            // 
            // viewRecipesMenuItem
            // 
            this.viewRecipesMenuItem.Name = "viewRecipesMenuItem";
            this.viewRecipesMenuItem.Size = new System.Drawing.Size(161, 26);
            this.viewRecipesMenuItem.Text = "Recepte";
            // 
            // addMenuItem
            // 
            this.addMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIngredientMenuItem,
            this.addRecipeMenuItem});
            this.addMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(73, 26);
            this.addMenuItem.Text = "Dodaj";
            // 
            // addIngredientMenuItem
            // 
            this.addIngredientMenuItem.Name = "addIngredientMenuItem";
            this.addIngredientMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addIngredientMenuItem.Text = "Sastojak";
            // 
            // addRecipeMenuItem
            // 
            this.addRecipeMenuItem.Name = "addRecipeMenuItem";
            this.addRecipeMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addRecipeMenuItem.Text = "Recept";
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIngrReportMenuItem,
            this.allRcpReportMenuItem});
            this.reportsMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(97, 26);
            this.reportsMenuItem.Text = "Izvještaji";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(63, 26);
            this.exitMenuItem.Text = "Izađi";
            // 
            // btnDeleteRecipe
            // 
            this.btnDeleteRecipe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecipe.Location = new System.Drawing.Point(169, 91);
            this.btnDeleteRecipe.Name = "btnDeleteRecipe";
            this.btnDeleteRecipe.Size = new System.Drawing.Size(151, 38);
            this.btnDeleteRecipe.TabIndex = 5;
            this.btnDeleteRecipe.Text = "Obriši recept";
            this.btnDeleteRecipe.UseVisualStyleBackColor = true;
            // 
            // dgIngredients
            // 
            this.dgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngredients.Location = new System.Drawing.Point(748, 135);
            this.dgIngredients.Name = "dgIngredients";
            this.dgIngredients.RowHeadersWidth = 51;
            this.dgIngredients.RowTemplate.Height = 24;
            this.dgIngredients.Size = new System.Drawing.Size(401, 317);
            this.dgIngredients.TabIndex = 6;
            // 
            // allIngrReportMenuItem
            // 
            this.allIngrReportMenuItem.Name = "allIngrReportMenuItem";
            this.allIngrReportMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allIngrReportMenuItem.Text = "Svi sastojci";
            // 
            // allRcpReportMenuItem
            // 
            this.allRcpReportMenuItem.Name = "allRcpReportMenuItem";
            this.allRcpReportMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allRcpReportMenuItem.Text = "Svi recepti";
            // 
            // FrmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 467);
            this.Controls.Add(this.dgIngredients);
            this.Controls.Add(this.btnDeleteRecipe);
            this.Controls.Add(this.btnEditRecipe);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgRecipes);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmRecipes";
            this.Text = "Recepti";
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIngredientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecipesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allIngrReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRcpReportMenuItem;
    }
}

