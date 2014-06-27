namespace OOP_Course_Work
{
    partial class FormHotelUpdate
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
            this.tbFormHotelUpdateName = new System.Windows.Forms.TextBox();
            this.btnFormHotelUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormHotelUpdateExit = new System.Windows.Forms.Button();
            this.tbFormHotelUpdateRating = new System.Windows.Forms.TextBox();
            this.tbFormHotelUpdateCost = new System.Windows.Forms.TextBox();
            this.tbFormHotelUpdateFood = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormHotelUpdateName
            // 
            this.tbFormHotelUpdateName.Location = new System.Drawing.Point(12, 12);
            this.tbFormHotelUpdateName.Multiline = true;
            this.tbFormHotelUpdateName.Name = "tbFormHotelUpdateName";
            this.tbFormHotelUpdateName.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelUpdateName.TabIndex = 1;
            this.tbFormHotelUpdateName.Enter += new System.EventHandler(this.tbFormHotelUpdateName_Enter);
            this.tbFormHotelUpdateName.Leave += new System.EventHandler(this.tbFormHotelUpdateName_Leave);
            // 
            // btnFormHotelUpdateUpdate
            // 
            this.btnFormHotelUpdateUpdate.Location = new System.Drawing.Point(12, 257);
            this.btnFormHotelUpdateUpdate.Name = "btnFormHotelUpdateUpdate";
            this.btnFormHotelUpdateUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelUpdateUpdate.TabIndex = 5;
            this.btnFormHotelUpdateUpdate.Text = "Изменить";
            this.btnFormHotelUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnFormHotelUpdateUpdate.Click += new System.EventHandler(this.btnFormHotelUpdateUpdate_Click);
            // 
            // btnFormHotelUpdateExit
            // 
            this.btnFormHotelUpdateExit.Location = new System.Drawing.Point(247, 257);
            this.btnFormHotelUpdateExit.Name = "btnFormHotelUpdateExit";
            this.btnFormHotelUpdateExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelUpdateExit.TabIndex = 0;
            this.btnFormHotelUpdateExit.Text = "Выйти";
            this.btnFormHotelUpdateExit.UseVisualStyleBackColor = true;
            this.btnFormHotelUpdateExit.Click += new System.EventHandler(this.btnFormHotelUpdateExit_Click);
            // 
            // tbFormHotelUpdateRating
            // 
            this.tbFormHotelUpdateRating.Location = new System.Drawing.Point(12, 60);
            this.tbFormHotelUpdateRating.Multiline = true;
            this.tbFormHotelUpdateRating.Name = "tbFormHotelUpdateRating";
            this.tbFormHotelUpdateRating.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelUpdateRating.TabIndex = 2;
            this.tbFormHotelUpdateRating.Enter += new System.EventHandler(this.tbFormHotelUpdateRating_Enter);
            this.tbFormHotelUpdateRating.Leave += new System.EventHandler(this.tbFormHotelUpdateRating_Leave);
            // 
            // tbFormHotelUpdateCost
            // 
            this.tbFormHotelUpdateCost.Location = new System.Drawing.Point(12, 158);
            this.tbFormHotelUpdateCost.Multiline = true;
            this.tbFormHotelUpdateCost.Name = "tbFormHotelUpdateCost";
            this.tbFormHotelUpdateCost.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelUpdateCost.TabIndex = 4;
            this.tbFormHotelUpdateCost.Enter += new System.EventHandler(this.tbFormHotelUpdateCost_Enter);
            this.tbFormHotelUpdateCost.Leave += new System.EventHandler(this.tbFormHotelUpdateCost_Leave);
            // 
            // tbFormHotelUpdateFood
            // 
            this.tbFormHotelUpdateFood.Location = new System.Drawing.Point(12, 109);
            this.tbFormHotelUpdateFood.Multiline = true;
            this.tbFormHotelUpdateFood.Name = "tbFormHotelUpdateFood";
            this.tbFormHotelUpdateFood.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelUpdateFood.TabIndex = 3;
            this.tbFormHotelUpdateFood.Enter += new System.EventHandler(this.tbFormHotelUpdateFood_Enter);
            this.tbFormHotelUpdateFood.Leave += new System.EventHandler(this.tbFormHotelUpdateFood_Leave);
            // 
            // FormHotelUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 324);
            this.Controls.Add(this.tbFormHotelUpdateFood);
            this.Controls.Add(this.tbFormHotelUpdateCost);
            this.Controls.Add(this.tbFormHotelUpdateRating);
            this.Controls.Add(this.btnFormHotelUpdateExit);
            this.Controls.Add(this.btnFormHotelUpdateUpdate);
            this.Controls.Add(this.tbFormHotelUpdateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHotelUpdate";
            this.Text = "Редактирование отеля";
            this.Load += new System.EventHandler(this.FormHotelUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormHotelUpdateName;
        private System.Windows.Forms.Button btnFormHotelUpdateUpdate;
        private System.Windows.Forms.Button btnFormHotelUpdateExit;
        private System.Windows.Forms.TextBox tbFormHotelUpdateRating;
        private System.Windows.Forms.TextBox tbFormHotelUpdateCost;
        private System.Windows.Forms.TextBox tbFormHotelUpdateFood;
    }
}