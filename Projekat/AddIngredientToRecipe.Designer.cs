namespace Projekat
{
    partial class AddIngredientToRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIngredientToRecipe));
            this.label1 = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRecipe = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cbMeasurement = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(175, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj sastojak u recept";
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredient.ForeColor = System.Drawing.Color.White;
            this.lblIngredient.Location = new System.Drawing.Point(182, 113);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(120, 40);
            this.lblIngredient.TabIndex = 1;
            this.lblIngredient.Text = "Sastojak:";
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.ForeColor = System.Drawing.Color.White;
            this.lblIngredientName.Location = new System.Drawing.Point(317, 122);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(0, 26);
            this.lblIngredientName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(200, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Recept:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(188, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mjera:";
            // 
            // cbRecipe
            // 
            this.cbRecipe.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRecipe.FormattingEnabled = true;
            this.cbRecipe.Location = new System.Drawing.Point(315, 176);
            this.cbRecipe.Name = "cbRecipe";
            this.cbRecipe.Size = new System.Drawing.Size(168, 34);
            this.cbRecipe.TabIndex = 6;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(315, 241);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(168, 30);
            this.txtAmount.TabIndex = 7;
            // 
            // cbMeasurement
            // 
            this.cbMeasurement.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMeasurement.FormattingEnabled = true;
            this.cbMeasurement.Location = new System.Drawing.Point(315, 296);
            this.cbMeasurement.Name = "cbMeasurement";
            this.cbMeasurement.Size = new System.Drawing.Size(168, 34);
            this.cbMeasurement.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(315, 367);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 43);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "DODAJ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddIngredientToRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbMeasurement);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cbRecipe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.lblIngredient);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddIngredientToRecipe";
            this.Text = "Dodaj sastojak u recept";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRecipe;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cbMeasurement;
        private System.Windows.Forms.Button btnSave;
    }
}