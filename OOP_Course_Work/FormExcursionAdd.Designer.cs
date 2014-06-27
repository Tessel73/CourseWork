namespace OOP_Course_Work
{
    partial class FormExcursionAdd
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
            this.tbFormExcursionAddName = new System.Windows.Forms.TextBox();
            this.tbFormExcursionAddRating = new System.Windows.Forms.TextBox();
            this.tbFormExcursionAddLength = new System.Windows.Forms.TextBox();
            this.btnFormExcursionAddAdd = new System.Windows.Forms.Button();
            this.btnFromExcursionAddExit = new System.Windows.Forms.Button();
            this.tbFormExcursionAddTime = new System.Windows.Forms.TextBox();
            this.tbFormExcursionAddNote = new System.Windows.Forms.TextBox();
            this.tbFormExcursionAddCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormExcursionAddName
            // 
            this.tbFormExcursionAddName.Location = new System.Drawing.Point(12, 12);
            this.tbFormExcursionAddName.Multiline = true;
            this.tbFormExcursionAddName.Name = "tbFormExcursionAddName";
            this.tbFormExcursionAddName.Size = new System.Drawing.Size(345, 43);
            this.tbFormExcursionAddName.TabIndex = 1;
            this.tbFormExcursionAddName.Enter += new System.EventHandler(this.tbFormExcursionAddName_Enter);
            this.tbFormExcursionAddName.Leave += new System.EventHandler(this.tbFormExcursionAddName_Leave);
            // 
            // tbFormExcursionAddRating
            // 
            this.tbFormExcursionAddRating.Location = new System.Drawing.Point(12, 61);
            this.tbFormExcursionAddRating.Multiline = true;
            this.tbFormExcursionAddRating.Name = "tbFormExcursionAddRating";
            this.tbFormExcursionAddRating.Size = new System.Drawing.Size(345, 43);
            this.tbFormExcursionAddRating.TabIndex = 2;
            this.tbFormExcursionAddRating.Enter += new System.EventHandler(this.tbFormExcursionAddRating_Enter);
            this.tbFormExcursionAddRating.Leave += new System.EventHandler(this.tbFormExcursionAddRating_Leave);
            // 
            // tbFormExcursionAddLength
            // 
            this.tbFormExcursionAddLength.Location = new System.Drawing.Point(14, 159);
            this.tbFormExcursionAddLength.Multiline = true;
            this.tbFormExcursionAddLength.Name = "tbFormExcursionAddLength";
            this.tbFormExcursionAddLength.Size = new System.Drawing.Size(345, 43);
            this.tbFormExcursionAddLength.TabIndex = 4;
            this.tbFormExcursionAddLength.Enter += new System.EventHandler(this.tbFormExcursionAddLength_Enter);
            this.tbFormExcursionAddLength.Leave += new System.EventHandler(this.tbFormExcursionAddLength_Leave);
            // 
            // btnFormExcursionAddAdd
            // 
            this.btnFormExcursionAddAdd.Location = new System.Drawing.Point(14, 381);
            this.btnFormExcursionAddAdd.Name = "btnFormExcursionAddAdd";
            this.btnFormExcursionAddAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionAddAdd.TabIndex = 7;
            this.btnFormExcursionAddAdd.Text = "Добавить";
            this.btnFormExcursionAddAdd.UseVisualStyleBackColor = true;
            this.btnFormExcursionAddAdd.Click += new System.EventHandler(this.btnFormExcursionAddAdd_Click);
            // 
            // btnFromExcursionAddExit
            // 
            this.btnFromExcursionAddExit.Location = new System.Drawing.Point(243, 381);
            this.btnFromExcursionAddExit.Name = "btnFromExcursionAddExit";
            this.btnFromExcursionAddExit.Size = new System.Drawing.Size(115, 55);
            this.btnFromExcursionAddExit.TabIndex = 0;
            this.btnFromExcursionAddExit.Text = "Выйти";
            this.btnFromExcursionAddExit.UseVisualStyleBackColor = true;
            this.btnFromExcursionAddExit.Click += new System.EventHandler(this.btnFormExcursionAddExit_Click);
            // 
            // tbFormExcursionAddTime
            // 
            this.tbFormExcursionAddTime.Location = new System.Drawing.Point(13, 110);
            this.tbFormExcursionAddTime.Multiline = true;
            this.tbFormExcursionAddTime.Name = "tbFormExcursionAddTime";
            this.tbFormExcursionAddTime.Size = new System.Drawing.Size(345, 43);
            this.tbFormExcursionAddTime.TabIndex = 3;
            this.tbFormExcursionAddTime.Enter += new System.EventHandler(this.tbFormExcursionAddTime_Enter);
            this.tbFormExcursionAddTime.Leave += new System.EventHandler(this.tbFormExcursionAddTime_Leave);
            // 
            // tbFormExcursionAddNote
            // 
            this.tbFormExcursionAddNote.Location = new System.Drawing.Point(12, 257);
            this.tbFormExcursionAddNote.Multiline = true;
            this.tbFormExcursionAddNote.Name = "tbFormExcursionAddNote";
            this.tbFormExcursionAddNote.Size = new System.Drawing.Size(345, 43);
            this.tbFormExcursionAddNote.TabIndex = 6;
            this.tbFormExcursionAddNote.Enter += new System.EventHandler(this.tbFormExcursionAddNote_Enter);
            this.tbFormExcursionAddNote.Leave += new System.EventHandler(this.tbFormExcursionAddNote_Leave);
            // 
            // tbFormExcursionAddCost
            // 
            this.tbFormExcursionAddCost.Location = new System.Drawing.Point(13, 208);
            this.tbFormExcursionAddCost.Multiline = true;
            this.tbFormExcursionAddCost.Name = "tbFormExcursionAddCost";
            this.tbFormExcursionAddCost.Size = new System.Drawing.Size(344, 43);
            this.tbFormExcursionAddCost.TabIndex = 5;
            this.tbFormExcursionAddCost.Enter += new System.EventHandler(this.tbFormExcursionAddCost_Enter);
            this.tbFormExcursionAddCost.Leave += new System.EventHandler(this.tbFormExcursionAddCost_Leave);
            // 
            // FormExcursionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(370, 442);
            this.Controls.Add(this.tbFormExcursionAddCost);
            this.Controls.Add(this.tbFormExcursionAddNote);
            this.Controls.Add(this.tbFormExcursionAddTime);
            this.Controls.Add(this.btnFromExcursionAddExit);
            this.Controls.Add(this.btnFormExcursionAddAdd);
            this.Controls.Add(this.tbFormExcursionAddLength);
            this.Controls.Add(this.tbFormExcursionAddRating);
            this.Controls.Add(this.tbFormExcursionAddName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormExcursionAdd";
            this.Text = "Добавление экскурсии";
            this.Load += new System.EventHandler(this.FormExcursionAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormExcursionAddName;
        private System.Windows.Forms.TextBox tbFormExcursionAddRating;
        private System.Windows.Forms.TextBox tbFormExcursionAddLength;
        private System.Windows.Forms.Button btnFormExcursionAddAdd;
        private System.Windows.Forms.Button btnFromExcursionAddExit;
        private System.Windows.Forms.TextBox tbFormExcursionAddTime;
        private System.Windows.Forms.TextBox tbFormExcursionAddNote;
        private System.Windows.Forms.TextBox tbFormExcursionAddCost;
    }
}