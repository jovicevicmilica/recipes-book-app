namespace Projekat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnViewIngredients = new System.Windows.Forms.Button();
            this.btnViewRecipes = new System.Windows.Forms.Button();
            this.btnViewMenus = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewIngredients
            // 
            this.btnViewIngredients.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIngredients.Location = new System.Drawing.Point(47, 233);
            this.btnViewIngredients.Name = "btnViewIngredients";
            this.btnViewIngredients.Size = new System.Drawing.Size(144, 61);
            this.btnViewIngredients.TabIndex = 0;
            this.btnViewIngredients.Text = "PREGLEDAJ SASTOJKE";
            this.btnViewIngredients.UseVisualStyleBackColor = true;
            // 
            // btnViewRecipes
            // 
            this.btnViewRecipes.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRecipes.Location = new System.Drawing.Point(273, 233);
            this.btnViewRecipes.Name = "btnViewRecipes";
            this.btnViewRecipes.Size = new System.Drawing.Size(144, 61);
            this.btnViewRecipes.TabIndex = 1;
            this.btnViewRecipes.Text = "PREGLEDAJ RECEPTE";
            this.btnViewRecipes.UseVisualStyleBackColor = true;
            // 
            // btnViewMenus
            // 
            this.btnViewMenus.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMenus.Location = new System.Drawing.Point(498, 233);
            this.btnViewMenus.Name = "btnViewMenus";
            this.btnViewMenus.Size = new System.Drawing.Size(144, 61);
            this.btnViewMenus.TabIndex = 2;
            this.btnViewMenus.Text = "PREGLEDAJ  MENIJE";
            this.btnViewMenus.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Projekat.Properties.Resources.bread;
            this.pictureBox3.Location = new System.Drawing.Point(498, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 94);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projekat.Properties.Resources.cake;
            this.pictureBox2.Location = new System.Drawing.Point(273, 124);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projekat.Properties.Resources.baking;
            this.pictureBox1.Location = new System.Drawing.Point(47, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewMenus);
            this.Controls.Add(this.btnViewRecipes);
            this.Controls.Add(this.btnViewIngredients);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Knjiga recepata";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnViewIngredients;
        private System.Windows.Forms.Button btnViewRecipes;
        private System.Windows.Forms.Button btnViewMenus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}