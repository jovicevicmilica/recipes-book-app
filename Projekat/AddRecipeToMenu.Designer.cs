namespace Projekat
{
    partial class AddRecipeToMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRecipeToMenu));
            this.cbTypeMeal = new System.Windows.Forms.ComboBox();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.lblTypeMeal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTypeMeal
            // 
            this.cbTypeMeal.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeMeal.FormattingEnabled = true;
            this.cbTypeMeal.Location = new System.Drawing.Point(318, 256);
            this.cbTypeMeal.Name = "cbTypeMeal";
            this.cbTypeMeal.Size = new System.Drawing.Size(168, 34);
            this.cbTypeMeal.TabIndex = 19;
            // 
            // cbMenu
            // 
            this.cbMenu.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(318, 196);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(168, 34);
            this.cbMenu.TabIndex = 16;
            // 
            // lblTypeMeal
            // 
            this.lblTypeMeal.AutoSize = true;
            this.lblTypeMeal.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeMeal.ForeColor = System.Drawing.Color.White;
            this.lblTypeMeal.Location = new System.Drawing.Point(162, 250);
            this.lblTypeMeal.Name = "lblTypeMeal";
            this.lblTypeMeal.Size = new System.Drawing.Size(145, 40);
            this.lblTypeMeal.TabIndex = 14;
            this.lblTypeMeal.Text = "Tip obroka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(230, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 13;
            this.label2.Text = "Meni:";
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.ForeColor = System.Drawing.Color.White;
            this.lblIngredient.Location = new System.Drawing.Point(205, 127);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(102, 40);
            this.lblIngredient.TabIndex = 12;
            this.lblIngredient.Text = "Recept:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(197, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(390, 60);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Dodaj recept u meni";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.ForeColor = System.Drawing.Color.White;
            this.lblRecipeName.Location = new System.Drawing.Point(313, 136);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(0, 26);
            this.lblRecipeName.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(318, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 43);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "DODAJ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddRecipeToMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.cbTypeMeal);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.lblTypeMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddRecipeToMenu";
            this.Text = "Dodaj recept u meni";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTypeMeal;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label lblTypeMeal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Button btnSave;
    }
}