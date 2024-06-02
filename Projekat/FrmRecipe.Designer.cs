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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTimeCooking = new System.Windows.Forms.Label();
            this.lblTimeMaking = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblNumPortions = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTimeMaking = new System.Windows.Forms.TextBox();
            this.txtTimeCooking = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtNumPortions = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(295, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(166, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dodaj recept";
            // 
            // lblTimeCooking
            // 
            this.lblTimeCooking.AutoSize = true;
            this.lblTimeCooking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeCooking.Location = new System.Drawing.Point(153, 248);
            this.lblTimeCooking.Name = "lblTimeCooking";
            this.lblTimeCooking.Size = new System.Drawing.Size(139, 22);
            this.lblTimeCooking.TabIndex = 1;
            this.lblTimeCooking.Text = "Vrijeme kuvanja";
            // 
            // lblTimeMaking
            // 
            this.lblTimeMaking.AutoSize = true;
            this.lblTimeMaking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeMaking.Location = new System.Drawing.Point(153, 201);
            this.lblTimeMaking.Name = "lblTimeMaking";
            this.lblTimeMaking.Size = new System.Drawing.Size(150, 22);
            this.lblTimeMaking.TabIndex = 2;
            this.lblTimeMaking.Text = "Vrijeme pripreme";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(153, 151);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(48, 22);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Opis";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(153, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 22);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Naziv";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(153, 297);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(136, 22);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Ukupno vrijeme";
            // 
            // lblNumPortions
            // 
            this.lblNumPortions.AutoSize = true;
            this.lblNumPortions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPortions.Location = new System.Drawing.Point(153, 344);
            this.lblNumPortions.Name = "lblNumPortions";
            this.lblNumPortions.Size = new System.Drawing.Size(108, 22);
            this.lblNumPortions.TabIndex = 6;
            this.lblNumPortions.Text = "Broj porcija";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(252, 22);
            this.txtName.TabIndex = 7;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(250, 151);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(466, 22);
            this.txtDesc.TabIndex = 8;
            // 
            // txtTimeMaking
            // 
            this.txtTimeMaking.Location = new System.Drawing.Point(380, 202);
            this.txtTimeMaking.Name = "txtTimeMaking";
            this.txtTimeMaking.Size = new System.Drawing.Size(115, 22);
            this.txtTimeMaking.TabIndex = 9;
            // 
            // txtTimeCooking
            // 
            this.txtTimeCooking.Location = new System.Drawing.Point(380, 248);
            this.txtTimeCooking.Name = "txtTimeCooking";
            this.txtTimeCooking.Size = new System.Drawing.Size(115, 22);
            this.txtTimeCooking.TabIndex = 10;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(380, 297);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(115, 22);
            this.txtTime.TabIndex = 11;
            // 
            // txtNumPortions
            // 
            this.txtNumPortions.Location = new System.Drawing.Point(380, 344);
            this.txtNumPortions.Name = "txtNumPortions";
            this.txtNumPortions.Size = new System.Drawing.Size(115, 22);
            this.txtNumPortions.TabIndex = 12;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(301, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 43);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Sačuvaj";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumPortions);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtTimeCooking);
            this.Controls.Add(this.txtTimeMaking);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumPortions);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTimeMaking);
            this.Controls.Add(this.lblTimeCooking);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmRecipe";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTimeCooking;
        private System.Windows.Forms.Label lblTimeMaking;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblNumPortions;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTimeMaking;
        private System.Windows.Forms.TextBox txtTimeCooking;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtNumPortions;
        private System.Windows.Forms.Button btnSave;
    }
}