namespace OOP_Course_Work
{
    partial class FormClientUpdate
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
            this.tbFormClientUpdateName = new System.Windows.Forms.TextBox();
            this.btnFormClientUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormClientUpdateExit = new System.Windows.Forms.Button();
            this.tbFormClientUpdatePassport = new System.Windows.Forms.TextBox();
            this.tbFormClientUpdateEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbFormClientUpdateName
            // 
            this.tbFormClientUpdateName.Location = new System.Drawing.Point(12, 12);
            this.tbFormClientUpdateName.Multiline = true;
            this.tbFormClientUpdateName.Name = "tbFormClientUpdateName";
            this.tbFormClientUpdateName.Size = new System.Drawing.Size(345, 42);
            this.tbFormClientUpdateName.TabIndex = 1;
            this.tbFormClientUpdateName.Enter += new System.EventHandler(this.tbFormClientUpdateName_Enter);
            this.tbFormClientUpdateName.Leave += new System.EventHandler(this.tbFormClientUpdateName_Leave);
            // 
            // btnFormClientUpdateUpdate
            // 
            this.btnFormClientUpdateUpdate.Location = new System.Drawing.Point(12, 257);
            this.btnFormClientUpdateUpdate.Name = "btnFormClientUpdateUpdate";
            this.btnFormClientUpdateUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientUpdateUpdate.TabIndex = 4;
            this.btnFormClientUpdateUpdate.Text = "Изменить";
            this.btnFormClientUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnFormClientUpdateUpdate.Click += new System.EventHandler(this.btnFormClientUpdateUpdate_Click);
            // 
            // btnFormClientUpdateExit
            // 
            this.btnFormClientUpdateExit.Location = new System.Drawing.Point(247, 257);
            this.btnFormClientUpdateExit.Name = "btnFormClientUpdateExit";
            this.btnFormClientUpdateExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientUpdateExit.TabIndex = 0;
            this.btnFormClientUpdateExit.Text = "Выйти";
            this.btnFormClientUpdateExit.UseVisualStyleBackColor = true;
            this.btnFormClientUpdateExit.Click += new System.EventHandler(this.btnFormClientUpdateExit_Click);
            // 
            // tbFormClientUpdatePassport
            // 
            this.tbFormClientUpdatePassport.Location = new System.Drawing.Point(12, 77);
            this.tbFormClientUpdatePassport.Multiline = true;
            this.tbFormClientUpdatePassport.Name = "tbFormClientUpdatePassport";
            this.tbFormClientUpdatePassport.Size = new System.Drawing.Size(345, 41);
            this.tbFormClientUpdatePassport.TabIndex = 2;
            this.tbFormClientUpdatePassport.Enter += new System.EventHandler(this.tbFormClientUpdatePassport_Enter);
            this.tbFormClientUpdatePassport.Leave += new System.EventHandler(this.tbFormClientUpdatePassport_Leave);
            // 
            // tbFormClientUpdateEmail
            // 
            this.tbFormClientUpdateEmail.Location = new System.Drawing.Point(12, 146);
            this.tbFormClientUpdateEmail.Multiline = true;
            this.tbFormClientUpdateEmail.Name = "tbFormClientUpdateEmail";
            this.tbFormClientUpdateEmail.Size = new System.Drawing.Size(345, 47);
            this.tbFormClientUpdateEmail.TabIndex = 3;
            this.tbFormClientUpdateEmail.Enter += new System.EventHandler(this.tbFormClientUpdateEmail_Enter);
            this.tbFormClientUpdateEmail.Leave += new System.EventHandler(this.tbFormClientUpdateEmail_Leave);
            // 
            // FormClientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 324);
            this.Controls.Add(this.tbFormClientUpdateEmail);
            this.Controls.Add(this.tbFormClientUpdatePassport);
            this.Controls.Add(this.btnFormClientUpdateExit);
            this.Controls.Add(this.btnFormClientUpdateUpdate);
            this.Controls.Add(this.tbFormClientUpdateName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClientUpdate";
            this.Text = "Редактирование клиента";
            this.Load += new System.EventHandler(this.FormClientUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormClientUpdateName;
        private System.Windows.Forms.Button btnFormClientUpdateUpdate;
        private System.Windows.Forms.Button btnFormClientUpdateExit;
        private System.Windows.Forms.TextBox tbFormClientUpdatePassport;
        private System.Windows.Forms.TextBox tbFormClientUpdateEmail;
    }
}