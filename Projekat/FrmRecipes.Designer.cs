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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.opcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajSastojakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajReceptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajMeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.dgIngredients = new System.Windows.Forms.DataGridView();
            this.pregledajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIngredientsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecipesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenusMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecipes)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRecipes
            // 
            this.dgRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecipes.Location = new System.Drawing.Point(12, 135);
            this.dgRecipes.Name = "dgRecipes";
            this.dgRecipes.RowHeadersWidth = 51;
            this.dgRecipes.RowTemplate.Height = 24;
            this.dgRecipes.Size = new System.Drawing.Size(712, 317);
            this.dgRecipes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Knjiga recepata";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izmijeni recept";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledajToolStripMenuItem,
            this.opcijeToolStripMenuItem,
            this.izvještajToolStripMenuItem,
            this.izađiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1161, 30);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // opcijeToolStripMenuItem
            // 
            this.opcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajSastojakToolStripMenuItem,
            this.dodajReceptToolStripMenuItem,
            this.dodajMeniToolStripMenuItem});
            this.opcijeToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcijeToolStripMenuItem.Name = "opcijeToolStripMenuItem";
            this.opcijeToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.opcijeToolStripMenuItem.Text = "Dodaj";
            // 
            // dodajSastojakToolStripMenuItem
            // 
            this.dodajSastojakToolStripMenuItem.Name = "dodajSastojakToolStripMenuItem";
            this.dodajSastojakToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajSastojakToolStripMenuItem.Text = "Sastojak";
            // 
            // dodajReceptToolStripMenuItem
            // 
            this.dodajReceptToolStripMenuItem.Name = "dodajReceptToolStripMenuItem";
            this.dodajReceptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajReceptToolStripMenuItem.Text = "Recept";
            // 
            // dodajMeniToolStripMenuItem
            // 
            this.dodajMeniToolStripMenuItem.Name = "dodajMeniToolStripMenuItem";
            this.dodajMeniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajMeniToolStripMenuItem.Text = "Meni";
            // 
            // izvještajToolStripMenuItem
            // 
            this.izvještajToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izvještajToolStripMenuItem.Name = "izvještajToolStripMenuItem";
            this.izvještajToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.izvještajToolStripMenuItem.Text = "Izvještaj";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.izađiToolStripMenuItem.Text = "Izađi";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(169, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 38);
            this.button2.TabIndex = 5;
            this.button2.Text = "Obriši recept";
            this.button2.UseVisualStyleBackColor = true;
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
            // pregledajToolStripMenuItem
            // 
            this.pregledajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewIngredientsMenuItem,
            this.viewRecipesMenuItem,
            this.viewMenusMenuItem});
            this.pregledajToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregledajToolStripMenuItem.Name = "pregledajToolStripMenuItem";
            this.pregledajToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.pregledajToolStripMenuItem.Text = "Pregledaj";
            // 
            // viewIngredientsMenuItem
            // 
            this.viewIngredientsMenuItem.Name = "viewIngredientsMenuItem";
            this.viewIngredientsMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewIngredientsMenuItem.Text = "Sastojke";
            // 
            // viewRecipesMenuItem
            // 
            this.viewRecipesMenuItem.Name = "viewRecipesMenuItem";
            this.viewRecipesMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewRecipesMenuItem.Text = "Recepte";
            // 
            // viewMenusMenuItem
            // 
            this.viewMenusMenuItem.Name = "viewMenusMenuItem";
            this.viewMenusMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewMenusMenuItem.Text = "Menije";
            // 
            // FrmRecipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 467);
            this.Controls.Add(this.dgIngredients);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem opcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajSastojakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajReceptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajMeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgIngredients;
        private System.Windows.Forms.ToolStripMenuItem pregledajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIngredientsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecipesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenusMenuItem;
    }
}

