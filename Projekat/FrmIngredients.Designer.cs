namespace Projekat
{
    partial class FrmIngredients
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
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.dgIngredients = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pregledajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIngredientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIngredientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecipeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.allIngrReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRcpReportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIngredient.Location = new System.Drawing.Point(235, 98);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(194, 42);
            this.btnDeleteIngredient.TabIndex = 9;
            this.btnDeleteIngredient.Text = "OBRIŠI SASTOJAK";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIngredient.Location = new System.Drawing.Point(20, 98);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(209, 42);
            this.btnEditIngredient.TabIndex = 8;
            this.btnEditIngredient.Text = "IZMIJENI SASTOJAK";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(13, 47);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(263, 37);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Pregled sastojaka";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgIngredients
            // 
            this.dgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngredients.Location = new System.Drawing.Point(156, 216);
            this.dgIngredients.Name = "dgIngredients";
            this.dgIngredients.RowHeadersWidth = 51;
            this.dgIngredients.RowTemplate.Height = 24;
            this.dgIngredients.Size = new System.Drawing.Size(337, 255);
            this.dgIngredients.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajToolStripMenuItem,
            this.opcijeToolStripMenuItem,
            this.reportsMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pregledajToolStripMenuItem
            // 
            this.pregledajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewIngredientsMenuItem,
            this.viewRecipesMenuItem});
            this.pregledajToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledajToolStripMenuItem.Name = "pregledajToolStripMenuItem";
            this.pregledajToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.pregledajToolStripMenuItem.Text = "Pregledaj";
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
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIngredientMenuItem,
            this.addRecipeMenuItem});
            this.opcijeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.opcijeToolStripMenuItem.Text = "Dodaj";
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
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToRecipe.Location = new System.Drawing.Point(435, 98);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(194, 42);
            this.btnAddToRecipe.TabIndex = 11;
            this.btnAddToRecipe.Text = "DODAJ U RECEPT";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Naziv sastojka:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 168);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 22);
            this.textBox1.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(356, 158);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 42);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "PRETRAŽI";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // FrmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnEditIngredient);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.dgIngredients);
            this.Name = "FrmIngredients";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.DataGridView dgIngredients;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pregledajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIngredientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecipesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIngredientMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecipeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Button btnAddToRecipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem allIngrReportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRcpReportMenuItem;
    }
}