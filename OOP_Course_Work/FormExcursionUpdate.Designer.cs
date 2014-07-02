namespace OOP_Course_Work
{
    partial class FormExcursionUpdate
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
            this.tbFormExcursionUpdateName = new System.Windows.Forms.TextBox();
            this.btnFormExcursionUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormExcursionUpdateExit = new System.Windows.Forms.Button();
            this.tbFormExcursionUpdateRating = new System.Windows.Forms.TextBox();
            this.tbFormExcursionUpdateLength = new System.Windows.Forms.TextBox();
            this.tbFormExcursionUpdateTime = new System.Windows.Forms.TextBox();
            this.tbFormExcursionUpdateNote = new System.Windows.Forms.TextBox();
            this.tbFormExcursionUpdateCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormExcursionUpdateName
            // 
            this.tbFormExcursionUpdateName.Location = new System.Drawing.Point(12, 12);
            this.tbFormExcursionUpdateName.Multiline = true;
            this.tbFormExcursionUpdateName.Name = "tbFormExcursionUpdateName";
            this.tbFormExcursionUpdateName.Size = new System.Drawing.Size(374, 43);
            this.tbFormExcursionUpdateName.TabIndex = 1;
            this.tbFormExcursionUpdateName.Enter += new System.EventHandler(this.tbFormExcursionUpdateName_Enter);
            this.tbFormExcursionUpdateName.Leave += new System.EventHandler(this.tbFormExcursionUpdateName_Leave);
            // 
            // btnFormExcursionUpdateUpdate
            // 
            this.btnFormExcursionUpdateUpdate.Location = new System.Drawing.Point(12, 359);
            this.btnFormExcursionUpdateUpdate.Name = "btnFormExcursionUpdateUpdate";
            this.btnFormExcursionUpdateUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormExcursionUpdateUpdate.TabIndex = 7;
            this.btnFormExcursionUpdateUpdate.Text = "Изменить";
            this.btnFormExcursionUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnFormExcursionUpdateUpdate.Click += new System.EventHandler(this.btnFormExcursionUpdateUpdate_Click);
            // 
            // btnFormExcursionUpdateExit
            // 
            this.btnFormExcursionUpdateExit.Location = new System.Drawing.Point(276, 359);
            this.btnFormExcursionUpdateExit.Name = "btnFormExcursionUpdateExit";
            this.btnFormExcursionUpdateExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormExcursionUpdateExit.TabIndex = 0;
            this.btnFormExcursionUpdateExit.Text = "Выйти";
            this.btnFormExcursionUpdateExit.UseVisualStyleBackColor = true;
            this.btnFormExcursionUpdateExit.Click += new System.EventHandler(this.btnFormExcursionUpdateExit_Click);
            // 
            // tbFormExcursionUpdateRating
            // 
            this.tbFormExcursionUpdateRating.Location = new System.Drawing.Point(12, 61);
            this.tbFormExcursionUpdateRating.Multiline = true;
            this.tbFormExcursionUpdateRating.Name = "tbFormExcursionUpdateRating";
            this.tbFormExcursionUpdateRating.Size = new System.Drawing.Size(374, 43);
            this.tbFormExcursionUpdateRating.TabIndex = 2;
            this.tbFormExcursionUpdateRating.Enter += new System.EventHandler(this.tbFormExcursionUpdateRating_Enter);
            this.tbFormExcursionUpdateRating.Leave += new System.EventHandler(this.tbFormExcursionUpdateRating_Leave);
            // 
            // tbFormExcursionUpdateLength
            // 
            this.tbFormExcursionUpdateLength.Location = new System.Drawing.Point(12, 159);
            this.tbFormExcursionUpdateLength.Multiline = true;
            this.tbFormExcursionUpdateLength.Name = "tbFormExcursionUpdateLength";
            this.tbFormExcursionUpdateLength.Size = new System.Drawing.Size(374, 43);
            this.tbFormExcursionUpdateLength.TabIndex = 4;
            this.tbFormExcursionUpdateLength.Enter += new System.EventHandler(this.tbFormExcursionUpdateCost_Enter);
            this.tbFormExcursionUpdateLength.Leave += new System.EventHandler(this.tbFormExcursionUpdateCost_Leave);
            // 
            // tbFormExcursionUpdateTime
            // 
            this.tbFormExcursionUpdateTime.Location = new System.Drawing.Point(13, 110);
            this.tbFormExcursionUpdateTime.Multiline = true;
            this.tbFormExcursionUpdateTime.Name = "tbFormExcursionUpdateTime";
            this.tbFormExcursionUpdateTime.Size = new System.Drawing.Size(373, 43);
            this.tbFormExcursionUpdateTime.TabIndex = 3;
            // 
            // tbFormExcursionUpdateNote
            // 
            this.tbFormExcursionUpdateNote.Location = new System.Drawing.Point(12, 257);
            this.tbFormExcursionUpdateNote.Multiline = true;
            this.tbFormExcursionUpdateNote.Name = "tbFormExcursionUpdateNote";
            this.tbFormExcursionUpdateNote.Size = new System.Drawing.Size(374, 43);
            this.tbFormExcursionUpdateNote.TabIndex = 6;
            // 
            // tbFormExcursionUpdateCost
            // 
            this.tbFormExcursionUpdateCost.Location = new System.Drawing.Point(13, 208);
            this.tbFormExcursionUpdateCost.Multiline = true;
            this.tbFormExcursionUpdateCost.Name = "tbFormExcursionUpdateCost";
            this.tbFormExcursionUpdateCost.Size = new System.Drawing.Size(373, 43);
            this.tbFormExcursionUpdateCost.TabIndex = 5;
            // 
            // FormExcursionUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(398, 422);
            this.Controls.Add(this.tbFormExcursionUpdateCost);
            this.Controls.Add(this.tbFormExcursionUpdateNote);
            this.Controls.Add(this.tbFormExcursionUpdateTime);
            this.Controls.Add(this.tbFormExcursionUpdateLength);
            this.Controls.Add(this.tbFormExcursionUpdateRating);
            this.Controls.Add(this.btnFormExcursionUpdateExit);
            this.Controls.Add(this.btnFormExcursionUpdateUpdate);
            this.Controls.Add(this.tbFormExcursionUpdateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormExcursionUpdate";
            this.Text = "Редактирование экскурсии";
            this.Load += new System.EventHandler(this.FormExcursionUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormExcursionUpdateName;
        private System.Windows.Forms.Button btnFormExcursionUpdateUpdate;
        private System.Windows.Forms.Button btnFormExcursionUpdateExit;
        private System.Windows.Forms.TextBox tbFormExcursionUpdateRating;
        private System.Windows.Forms.TextBox tbFormExcursionUpdateLength;
        private System.Windows.Forms.TextBox tbFormExcursionUpdateTime;
        private System.Windows.Forms.TextBox tbFormExcursionUpdateNote;
        private System.Windows.Forms.TextBox tbFormExcursionUpdateCost;
    }
}