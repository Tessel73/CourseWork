namespace OOP_Course_Work
{
    partial class FormHotelAdd
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
            this.tbFormHotelAddName = new System.Windows.Forms.TextBox();
            this.tbFormHotelAddRating = new System.Windows.Forms.TextBox();
            this.tbFormHotelAddCost = new System.Windows.Forms.TextBox();
            this.btnFormHotelAddAdd = new System.Windows.Forms.Button();
            this.btnFromHotelAddExit = new System.Windows.Forms.Button();
            this.tbFormHotelAddFood = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormHotelAddName
            // 
            this.tbFormHotelAddName.Location = new System.Drawing.Point(12, 12);
            this.tbFormHotelAddName.Multiline = true;
            this.tbFormHotelAddName.Name = "tbFormHotelAddName";
            this.tbFormHotelAddName.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelAddName.TabIndex = 1;
            this.tbFormHotelAddName.Enter += new System.EventHandler(this.tbFormHotelAddName_Enter);
            this.tbFormHotelAddName.Leave += new System.EventHandler(this.tbFormHotelAddName_Leave);
            // 
            // tbFormHotelAddRating
            // 
            this.tbFormHotelAddRating.Location = new System.Drawing.Point(12, 61);
            this.tbFormHotelAddRating.Multiline = true;
            this.tbFormHotelAddRating.Name = "tbFormHotelAddRating";
            this.tbFormHotelAddRating.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelAddRating.TabIndex = 2;
            this.tbFormHotelAddRating.Enter += new System.EventHandler(this.tbFormHotelAddRating_Enter);
            this.tbFormHotelAddRating.Leave += new System.EventHandler(this.tbFormHotelAddRating_Leave);
            // 
            // tbFormHotelAddCost
            // 
            this.tbFormHotelAddCost.Location = new System.Drawing.Point(12, 159);
            this.tbFormHotelAddCost.Multiline = true;
            this.tbFormHotelAddCost.Name = "tbFormHotelAddCost";
            this.tbFormHotelAddCost.Size = new System.Drawing.Size(345, 43);
            this.tbFormHotelAddCost.TabIndex = 4;
            this.tbFormHotelAddCost.Enter += new System.EventHandler(this.tbFormHotelAddCost_Enter);
            this.tbFormHotelAddCost.Leave += new System.EventHandler(this.tbFormHotelAddCost_Leave);
            // 
            // btnFormHotelAddAdd
            // 
            this.btnFormHotelAddAdd.Location = new System.Drawing.Point(12, 275);
            this.btnFormHotelAddAdd.Name = "btnFormHotelAddAdd";
            this.btnFormHotelAddAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelAddAdd.TabIndex = 5;
            this.btnFormHotelAddAdd.Text = "Добавить";
            this.btnFormHotelAddAdd.UseVisualStyleBackColor = true;
            this.btnFormHotelAddAdd.Click += new System.EventHandler(this.btnFormHotelAddAdd_Click);
            // 
            // btnFromHotelAddExit
            // 
            this.btnFromHotelAddExit.Location = new System.Drawing.Point(247, 275);
            this.btnFromHotelAddExit.Name = "btnFromHotelAddExit";
            this.btnFromHotelAddExit.Size = new System.Drawing.Size(110, 55);
            this.btnFromHotelAddExit.TabIndex = 0;
            this.btnFromHotelAddExit.Text = "Выйти";
            this.btnFromHotelAddExit.UseVisualStyleBackColor = true;
            this.btnFromHotelAddExit.Click += new System.EventHandler(this.btnFormHotelAddExit_Click);
            // 
            // tbFormHotelAddFood
            // 
            this.tbFormHotelAddFood.Location = new System.Drawing.Point(13, 110);
            this.tbFormHotelAddFood.Multiline = true;
            this.tbFormHotelAddFood.Name = "tbFormHotelAddFood";
            this.tbFormHotelAddFood.Size = new System.Drawing.Size(344, 43);
            this.tbFormHotelAddFood.TabIndex = 3;
            this.tbFormHotelAddFood.Enter += new System.EventHandler(this.tbFormHotelAddFood_Enter);
            this.tbFormHotelAddFood.Leave += new System.EventHandler(this.tbFormHotelAddFood_Leave);
            // 
            // FormHotelAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 342);
            this.Controls.Add(this.tbFormHotelAddFood);
            this.Controls.Add(this.btnFromHotelAddExit);
            this.Controls.Add(this.btnFormHotelAddAdd);
            this.Controls.Add(this.tbFormHotelAddCost);
            this.Controls.Add(this.tbFormHotelAddRating);
            this.Controls.Add(this.tbFormHotelAddName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHotelAdd";
            this.Text = "Добавление отеля";
            this.Load += new System.EventHandler(this.FormHotelAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormHotelAddName;
        private System.Windows.Forms.TextBox tbFormHotelAddRating;
        private System.Windows.Forms.TextBox tbFormHotelAddCost;
        private System.Windows.Forms.Button btnFormHotelAddAdd;
        private System.Windows.Forms.Button btnFromHotelAddExit;
        private System.Windows.Forms.TextBox tbFormHotelAddFood;
    }
}