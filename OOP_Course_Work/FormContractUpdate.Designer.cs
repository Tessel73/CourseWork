namespace OOP_Course_Work
{
    partial class FormContractUpdate
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
            this.tbFormContractUpdateNumber = new System.Windows.Forms.TextBox();
            this.tbFormContractUpdateCost = new System.Windows.Forms.TextBox();
            this.btnFormContractUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormContractAddExit = new System.Windows.Forms.Button();
            this.cbFormContractUpdateClientID = new System.Windows.Forms.ComboBox();
            this.cbFormContractUpdateTurID = new System.Windows.Forms.ComboBox();
            this.cbFormContractUpdateHotelID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbFormContractUpdateNumber
            // 
            this.tbFormContractUpdateNumber.Location = new System.Drawing.Point(13, 102);
            this.tbFormContractUpdateNumber.Multiline = true;
            this.tbFormContractUpdateNumber.Name = "tbFormContractUpdateNumber";
            this.tbFormContractUpdateNumber.Size = new System.Drawing.Size(347, 37);
            this.tbFormContractUpdateNumber.TabIndex = 1;
            // 
            // tbFormContractUpdateCost
            // 
            this.tbFormContractUpdateCost.Location = new System.Drawing.Point(13, 145);
            this.tbFormContractUpdateCost.Multiline = true;
            this.tbFormContractUpdateCost.Name = "tbFormContractUpdateCost";
            this.tbFormContractUpdateCost.Size = new System.Drawing.Size(347, 37);
            this.tbFormContractUpdateCost.TabIndex = 2;
            // 
            // btnFormContractUpdateUpdate
            // 
            this.btnFormContractUpdateUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractUpdateUpdate.Location = new System.Drawing.Point(12, 276);
            this.btnFormContractUpdateUpdate.Name = "btnFormContractUpdateUpdate";
            this.btnFormContractUpdateUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractUpdateUpdate.TabIndex = 3;
            this.btnFormContractUpdateUpdate.Text = "Изменить";
            this.btnFormContractUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnFormContractUpdateUpdate.Click += new System.EventHandler(this.btnFormContractUpdateUpdate_Click);
            // 
            // btnFormContractAddExit
            // 
            this.btnFormContractAddExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractAddExit.Location = new System.Drawing.Point(245, 276);
            this.btnFormContractAddExit.Name = "btnFormContractAddExit";
            this.btnFormContractAddExit.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractAddExit.TabIndex = 0;
            this.btnFormContractAddExit.Text = "Выход";
            this.btnFormContractAddExit.UseVisualStyleBackColor = true;
            this.btnFormContractAddExit.Click += new System.EventHandler(this.btnFormContractUpdateExit_Click);
            // 
            // cbFormContractUpdateClientID
            // 
            this.cbFormContractUpdateClientID.FormattingEnabled = true;
            this.cbFormContractUpdateClientID.Location = new System.Drawing.Point(13, 12);
            this.cbFormContractUpdateClientID.Name = "cbFormContractUpdateClientID";
            this.cbFormContractUpdateClientID.Size = new System.Drawing.Size(347, 24);
            this.cbFormContractUpdateClientID.TabIndex = 4;
            // 
            // cbFormContractUpdateTurID
            // 
            this.cbFormContractUpdateTurID.FormattingEnabled = true;
            this.cbFormContractUpdateTurID.Location = new System.Drawing.Point(12, 42);
            this.cbFormContractUpdateTurID.Name = "cbFormContractUpdateTurID";
            this.cbFormContractUpdateTurID.Size = new System.Drawing.Size(348, 24);
            this.cbFormContractUpdateTurID.TabIndex = 5;
            // 
            // cbFormContractUpdateHotelID
            // 
            this.cbFormContractUpdateHotelID.FormattingEnabled = true;
            this.cbFormContractUpdateHotelID.Location = new System.Drawing.Point(13, 72);
            this.cbFormContractUpdateHotelID.Name = "cbFormContractUpdateHotelID";
            this.cbFormContractUpdateHotelID.Size = new System.Drawing.Size(347, 24);
            this.cbFormContractUpdateHotelID.TabIndex = 6;
            // 
            // FormContractUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.cbFormContractUpdateHotelID);
            this.Controls.Add(this.cbFormContractUpdateTurID);
            this.Controls.Add(this.cbFormContractUpdateClientID);
            this.Controls.Add(this.btnFormContractAddExit);
            this.Controls.Add(this.btnFormContractUpdateUpdate);
            this.Controls.Add(this.tbFormContractUpdateCost);
            this.Controls.Add(this.tbFormContractUpdateNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContractUpdate";
            this.Text = "Редактирование договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormContractUpdateNumber;
        private System.Windows.Forms.TextBox tbFormContractUpdateCost;
        private System.Windows.Forms.Button btnFormContractUpdateUpdate;
        private System.Windows.Forms.Button btnFormContractAddExit;
        private System.Windows.Forms.ComboBox cbFormContractUpdateClientID;
        private System.Windows.Forms.ComboBox cbFormContractUpdateTurID;
        private System.Windows.Forms.ComboBox cbFormContractUpdateHotelID;
    }
}