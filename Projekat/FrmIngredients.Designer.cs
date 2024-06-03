﻿namespace Projekat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngredients));
            this.btnDeleteIngredient = new System.Windows.Forms.Button();
            this.btnEditIngredient = new System.Windows.Forms.Button();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.dgIngredients = new System.Windows.Forms.DataGridView();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteIngredient
            // 
            this.btnDeleteIngredient.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteIngredient.Location = new System.Drawing.Point(238, 110);
            this.btnDeleteIngredient.Name = "btnDeleteIngredient";
            this.btnDeleteIngredient.Size = new System.Drawing.Size(194, 42);
            this.btnDeleteIngredient.TabIndex = 9;
            this.btnDeleteIngredient.Text = "OBRIŠI SASTOJAK";
            this.btnDeleteIngredient.UseVisualStyleBackColor = true;
            // 
            // btnEditIngredient
            // 
            this.btnEditIngredient.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditIngredient.Location = new System.Drawing.Point(12, 110);
            this.btnEditIngredient.Name = "btnEditIngredient";
            this.btnEditIngredient.Size = new System.Drawing.Size(209, 42);
            this.btnEditIngredient.TabIndex = 8;
            this.btnEditIngredient.Text = "IZMIJENI SASTOJAK";
            this.btnEditIngredient.UseVisualStyleBackColor = true;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.Color.White;
            this.lblIngredients.Location = new System.Drawing.Point(2, 47);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(160, 58);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Sastojci";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgIngredients
            // 
            this.dgIngredients.BackgroundColor = System.Drawing.Color.White;
            this.dgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgIngredients.Location = new System.Drawing.Point(167, 228);
            this.dgIngredients.Name = "dgIngredients";
            this.dgIngredients.RowHeadersWidth = 51;
            this.dgIngredients.RowTemplate.Height = 24;
            this.dgIngredients.Size = new System.Drawing.Size(337, 255);
            this.dgIngredients.TabIndex = 6;
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToRecipe.Location = new System.Drawing.Point(500, 110);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(208, 42);
            this.btnAddToRecipe.TabIndex = 11;
            this.btnAddToRecipe.Text = "DODAJ U RECEPT";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(7, 178);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 26);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Naziv:";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(68, 174);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(168, 30);
            this.txtNameSearch.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(270, 169);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 42);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "PRETRAŽI";
            this.btnSearch.UseVisualStyleBackColor = true;
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
            this.menuStrip.Size = new System.Drawing.Size(720, 38);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "mainMenu";
            // 
            // addMenuItem
            // 
            this.addMenuItem.BackColor = System.Drawing.Color.White;
            this.addMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addIngredientMenuItem,
            this.addRecipeMenuItem,
            this.addMenuMenuItem});
            this.addMenuItem.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(76, 34);
            this.addMenuItem.Text = "Dodaj";
            // 
            // addIngredientMenuItem
            // 
            this.addIngredientMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addIngredientMenuItem.Name = "addIngredientMenuItem";
            this.addIngredientMenuItem.Size = new System.Drawing.Size(171, 34);
            this.addIngredientMenuItem.Text = "Sastojak";
            // 
            // addRecipeMenuItem
            // 
            this.addRecipeMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addRecipeMenuItem.Name = "addRecipeMenuItem";
            this.addRecipeMenuItem.Size = new System.Drawing.Size(171, 34);
            this.addRecipeMenuItem.Text = "Recept";
            // 
            // addMenuMenuItem
            // 
            this.addMenuMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.addMenuMenuItem.Name = "addMenuMenuItem";
            this.addMenuMenuItem.Size = new System.Drawing.Size(171, 34);
            this.addMenuMenuItem.Text = "Meni";
            // 
            // reportsMenuItem
            // 
            this.reportsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allIngrReportMenuItem,
            this.allRcpReportMenuItem,
            this.allMenusReportMenuItem});
            this.reportsMenuItem.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsMenuItem.Name = "reportsMenuItem";
            this.reportsMenuItem.Size = new System.Drawing.Size(98, 34);
            this.reportsMenuItem.Text = "Izvještaji";
            // 
            // allIngrReportMenuItem
            // 
            this.allIngrReportMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.allIngrReportMenuItem.Name = "allIngrReportMenuItem";
            this.allIngrReportMenuItem.Size = new System.Drawing.Size(193, 34);
            this.allIngrReportMenuItem.Text = "Svi sastojci";
            // 
            // allRcpReportMenuItem
            // 
            this.allRcpReportMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.allRcpReportMenuItem.Name = "allRcpReportMenuItem";
            this.allRcpReportMenuItem.Size = new System.Drawing.Size(193, 34);
            this.allRcpReportMenuItem.Text = "Svi recepti";
            // 
            // allMenusReportMenuItem
            // 
            this.allMenusReportMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.allMenusReportMenuItem.Name = "allMenusReportMenuItem";
            this.allMenusReportMenuItem.Size = new System.Drawing.Size(193, 34);
            this.allMenusReportMenuItem.Text = "Svi meniji";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(65, 34);
            this.exitMenuItem.Text = "Izađi";
            // 
            // FrmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.btnDeleteIngredient);
            this.Controls.Add(this.btnEditIngredient);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.dgIngredients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sastojci";
            ((System.ComponentModel.ISupportInitialize)(this.dgIngredients)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteIngredient;
        private System.Windows.Forms.Button btnEditIngredient;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.DataGridView dgIngredients;
        private System.Windows.Forms.Button btnAddToRecipe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Button btnSearch;
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
    }
}