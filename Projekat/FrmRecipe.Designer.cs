namespace Projekat
{
    partial class FrmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecipe));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeCooking = new System.Windows.Forms.Label();
            this.lblTimeMaking = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumPortions = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTimeMaking = new System.Windows.Forms.TextBox();
            this.txtTimeCooking = new System.Windows.Forms.TextBox();
            this.txtNumPortions = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Becky Tahlia", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(214, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 34);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj recept";
            // 
            // lblTimeCooking
            // 
            this.lblTimeCooking.AutoSize = true;
            this.lblTimeCooking.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCooking.ForeColor = System.Drawing.Color.White;
            this.lblTimeCooking.Location = new System.Drawing.Point(103, 187);
            this.lblTimeCooking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeCooking.Name = "lblTimeCooking";
            this.lblTimeCooking.Size = new System.Drawing.Size(146, 23);
            this.lblTimeCooking.TabIndex = 1;
            this.lblTimeCooking.Text = "Vrijeme kuvanja:";
            // 
            // lblTimeMaking
            // 
            this.lblTimeMaking.AutoSize = true;
            this.lblTimeMaking.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMaking.ForeColor = System.Drawing.Color.White;
            this.lblTimeMaking.Location = new System.Drawing.Point(94, 153);
            this.lblTimeMaking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeMaking.Name = "lblTimeMaking";
            this.lblTimeMaking.Size = new System.Drawing.Size(156, 23);
            this.lblTimeMaking.TabIndex = 2;
            this.lblTimeMaking.Text = "Vrijeme pripreme:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.White;
            this.lblDesc.Location = new System.Drawing.Point(188, 119);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(50, 23);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Opis:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(180, 86);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naziv:";
            // 
            // lblNumPortions
            // 
            this.lblNumPortions.AutoSize = true;
            this.lblNumPortions.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPortions.ForeColor = System.Drawing.Color.White;
            this.lblNumPortions.Location = new System.Drawing.Point(136, 223);
            this.lblNumPortions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumPortions.Name = "lblNumPortions";
            this.lblNumPortions.Size = new System.Drawing.Size(109, 23);
            this.lblNumPortions.TabIndex = 6;
            this.lblNumPortions.Text = "Broj porcija:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(251, 88);
            this.txtName.Margin = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(251, 120);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(228, 22);
            this.txtDesc.TabIndex = 8;
            // 
            // txtTimeMaking
            // 
            this.txtTimeMaking.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeMaking.Location = new System.Drawing.Point(251, 157);
            this.txtTimeMaking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeMaking.Name = "txtTimeMaking";
            this.txtTimeMaking.Size = new System.Drawing.Size(87, 22);
            this.txtTimeMaking.TabIndex = 9;
            // 
            // txtTimeCooking
            // 
            this.txtTimeCooking.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeCooking.Location = new System.Drawing.Point(251, 192);
            this.txtTimeCooking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimeCooking.Name = "txtTimeCooking";
            this.txtTimeCooking.Size = new System.Drawing.Size(87, 22);
            this.txtTimeCooking.TabIndex = 10;
            // 
            // txtNumPortions
            // 
            this.txtNumPortions.Font = new System.Drawing.Font("Abel Pro", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPortions.Location = new System.Drawing.Point(251, 228);
            this.txtNumPortions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumPortions.Name = "txtNumPortions";
            this.txtNumPortions.Size = new System.Drawing.Size(87, 22);
            this.txtNumPortions.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Abel Pro", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(231, 293);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 35);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "DODAJ";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(342, 158);
            this.lblMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(54, 18);
            this.lblMin.TabIndex = 14;
            this.lblMin.Text = "minuta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Abel Pro", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 192);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "minuta";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Projekat.Properties.Resources.baking__1_;
            this.pictureBox2.InitialImage = global::Projekat.Properties.Resources.cheffilled;
            this.pictureBox2.Location = new System.Drawing.Point(483, -4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 411);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Projekat.Properties.Resources.cheffilled;
            this.pictureBox1.InitialImage = global::Projekat.Properties.Resources.cheffilled;
            this.pictureBox1.Location = new System.Drawing.Point(-280, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 240);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumPortions);
            this.Controls.Add(this.txtTimeCooking);
            this.Controls.Add(this.txtTimeMaking);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumPortions);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTimeMaking);
            this.Controls.Add(this.lblTimeCooking);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRecipe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj recept";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeCooking;
        private System.Windows.Forms.Label lblTimeMaking;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumPortions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTimeMaking;
        private System.Windows.Forms.TextBox txtTimeCooking;
        private System.Windows.Forms.TextBox txtNumPortions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}