namespace OOP_Course_Work
{
    partial class FormClientDelete
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
            this.tbFormClientDeleteName = new System.Windows.Forms.TextBox();
            this.btnFormClientDeleteDelete = new System.Windows.Forms.Button();
            this.btnFormClientDeleteExit = new System.Windows.Forms.Button();
            this.tbFormClientDeletePassport = new System.Windows.Forms.TextBox();
            this.tbFormClientDeleteEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormClientDeleteName
            // 
            this.tbFormClientDeleteName.Location = new System.Drawing.Point(12, 12);
            this.tbFormClientDeleteName.Multiline = true;
            this.tbFormClientDeleteName.Name = "tbFormClientDeleteName";
            this.tbFormClientDeleteName.Size = new System.Drawing.Size(345, 42);
            this.tbFormClientDeleteName.TabIndex = 0;
            this.tbFormClientDeleteName.Enter += new System.EventHandler(this.tbFormClientDeleteName_Enter);
            this.tbFormClientDeleteName.Leave += new System.EventHandler(this.tbFormClientDeleteName_Leave);
            // 
            // btnFormClientDeleteDelete
            // 
            this.btnFormClientDeleteDelete.Location = new System.Drawing.Point(12, 257);
            this.btnFormClientDeleteDelete.Name = "btnFormClientDeleteDelete";
            this.btnFormClientDeleteDelete.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientDeleteDelete.TabIndex = 1;
            this.btnFormClientDeleteDelete.Text = "Удалить";
            this.btnFormClientDeleteDelete.UseVisualStyleBackColor = true;
            // 
            // btnFormClientDeleteExit
            // 
            this.btnFormClientDeleteExit.Location = new System.Drawing.Point(247, 257);
            this.btnFormClientDeleteExit.Name = "btnFormClientDeleteExit";
            this.btnFormClientDeleteExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientDeleteExit.TabIndex = 2;
            this.btnFormClientDeleteExit.Text = "Выйти";
            this.btnFormClientDeleteExit.UseVisualStyleBackColor = true;
            this.btnFormClientDeleteExit.Click += new System.EventHandler(this.btnFormClientDeleteExit_Click);
            // 
            // tbFormClientDeletePassport
            // 
            this.tbFormClientDeletePassport.Location = new System.Drawing.Point(12, 78);
            this.tbFormClientDeletePassport.Multiline = true;
            this.tbFormClientDeletePassport.Name = "tbFormClientDeletePassport";
            this.tbFormClientDeletePassport.Size = new System.Drawing.Size(345, 41);
            this.tbFormClientDeletePassport.TabIndex = 3;
            this.tbFormClientDeletePassport.Enter += new System.EventHandler(this.tbFormClientDeletePassport_Enter);
            this.tbFormClientDeletePassport.Leave += new System.EventHandler(this.tbFormClientDeletePassport_Leave);
            // 
            // tbFormClientDeleteEmail
            // 
            this.tbFormClientDeleteEmail.Location = new System.Drawing.Point(12, 146);
            this.tbFormClientDeleteEmail.Multiline = true;
            this.tbFormClientDeleteEmail.Name = "tbFormClientDeleteEmail";
            this.tbFormClientDeleteEmail.Size = new System.Drawing.Size(345, 47);
            this.tbFormClientDeleteEmail.TabIndex = 4;
            this.tbFormClientDeleteEmail.Enter += new System.EventHandler(this.tbFormClientDeleteEmail_Enter);
            this.tbFormClientDeleteEmail.Leave += new System.EventHandler(this.tbFormClientDeleteEmail_Leave);
            // 
            // FormClientDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 324);
            this.Controls.Add(this.tbFormClientDeleteEmail);
            this.Controls.Add(this.tbFormClientDeletePassport);
            this.Controls.Add(this.btnFormClientDeleteExit);
            this.Controls.Add(this.btnFormClientDeleteDelete);
            this.Controls.Add(this.tbFormClientDeleteName);
            this.Name = "FormClientDelete";
            this.Text = "FormClientDelete";
            this.Load += new System.EventHandler(this.FormClientDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormClientDeleteName;
        private System.Windows.Forms.Button btnFormClientDeleteDelete;
        private System.Windows.Forms.Button btnFormClientDeleteExit;
        private System.Windows.Forms.TextBox tbFormClientDeletePassport;
        private System.Windows.Forms.TextBox tbFormClientDeleteEmail;
    }
}