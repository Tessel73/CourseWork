namespace OOP_Course_Work
{
    partial class FormClientAdd
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
            this.tbFormClientAddName = new System.Windows.Forms.TextBox();
            this.tbFormClientAddPassport = new System.Windows.Forms.TextBox();
            this.tbFormClientAddEmail = new System.Windows.Forms.TextBox();
            this.btnFormClientAddAdd = new System.Windows.Forms.Button();
            this.btnFromClientAddExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFormClientAddName
            // 
            this.tbFormClientAddName.Location = new System.Drawing.Point(12, 12);
            this.tbFormClientAddName.Multiline = true;
            this.tbFormClientAddName.Name = "tbFormClientAddName";
            this.tbFormClientAddName.Size = new System.Drawing.Size(345, 40);
            this.tbFormClientAddName.TabIndex = 1;
            this.tbFormClientAddName.Enter += new System.EventHandler(this.tbFormClientAddName_Enter);
            this.tbFormClientAddName.Leave += new System.EventHandler(this.tbFormClientAddName_Leave);
            // 
            // tbFormClientAddPassport
            // 
            this.tbFormClientAddPassport.Location = new System.Drawing.Point(12, 70);
            this.tbFormClientAddPassport.Multiline = true;
            this.tbFormClientAddPassport.Name = "tbFormClientAddPassport";
            this.tbFormClientAddPassport.Size = new System.Drawing.Size(345, 45);
            this.tbFormClientAddPassport.TabIndex = 2;
            this.tbFormClientAddPassport.Enter += new System.EventHandler(this.tbFormClientAddPassport_Enter);
            this.tbFormClientAddPassport.Leave += new System.EventHandler(this.tbFormClientAddPassport_Leave);
            // 
            // tbFormClientAddEmail
            // 
            this.tbFormClientAddEmail.Location = new System.Drawing.Point(12, 138);
            this.tbFormClientAddEmail.Multiline = true;
            this.tbFormClientAddEmail.Name = "tbFormClientAddEmail";
            this.tbFormClientAddEmail.Size = new System.Drawing.Size(345, 43);
            this.tbFormClientAddEmail.TabIndex = 3;
            this.tbFormClientAddEmail.Enter += new System.EventHandler(this.tbFormClientAddEmail_Enter);
            this.tbFormClientAddEmail.Leave += new System.EventHandler(this.tbFormClientAddEmail_Leave);
            // 
            // btnFormClientAddAdd
            // 
            this.btnFormClientAddAdd.Location = new System.Drawing.Point(12, 257);
            this.btnFormClientAddAdd.Name = "btnFormClientAddAdd";
            this.btnFormClientAddAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientAddAdd.TabIndex = 4;
            this.btnFormClientAddAdd.Text = "Добавить";
            this.btnFormClientAddAdd.UseVisualStyleBackColor = true;
            this.btnFormClientAddAdd.Click += new System.EventHandler(this.btnFormClientAddAdd_Click);
            // 
            // btnFromClientAddExit
            // 
            this.btnFromClientAddExit.Location = new System.Drawing.Point(247, 257);
            this.btnFromClientAddExit.Name = "btnFromClientAddExit";
            this.btnFromClientAddExit.Size = new System.Drawing.Size(110, 55);
            this.btnFromClientAddExit.TabIndex = 0;
            this.btnFromClientAddExit.Text = "Выйти";
            this.btnFromClientAddExit.UseVisualStyleBackColor = true;
            this.btnFromClientAddExit.Click += new System.EventHandler(this.btnFormClientAddExit_Click);
            // 
            // FormClientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(369, 324);
            this.Controls.Add(this.btnFromClientAddExit);
            this.Controls.Add(this.btnFormClientAddAdd);
            this.Controls.Add(this.tbFormClientAddEmail);
            this.Controls.Add(this.tbFormClientAddPassport);
            this.Controls.Add(this.tbFormClientAddName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClientAdd";
            this.Text = "Добавление клиента";
            this.Load += new System.EventHandler(this.FormClientAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormClientAddName;
        private System.Windows.Forms.TextBox tbFormClientAddPassport;
        private System.Windows.Forms.TextBox tbFormClientAddEmail;
        private System.Windows.Forms.Button btnFormClientAddAdd;
        private System.Windows.Forms.Button btnFromClientAddExit;
    }
}