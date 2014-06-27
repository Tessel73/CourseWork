namespace OOP_Course_Work
{
    partial class FormTurDelete
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
            this.tbFormTurDeletePlace = new System.Windows.Forms.TextBox();
            this.tbFormTurDeleteDateO = new System.Windows.Forms.TextBox();
            this.tbFormTurDeleteDateI = new System.Windows.Forms.TextBox();
            this.tbFormTurDeleteD_N = new System.Windows.Forms.TextBox();
            this.tbFormTurDeleteCost = new System.Windows.Forms.TextBox();
            this.btnFormTurDeleteDelete = new System.Windows.Forms.Button();
            this.btnFormTurDeleteExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFormTurDeletePlace
            // 
            this.tbFormTurDeletePlace.Location = new System.Drawing.Point(12, 12);
            this.tbFormTurDeletePlace.Multiline = true;
            this.tbFormTurDeletePlace.Name = "tbFormTurDeletePlace";
            this.tbFormTurDeletePlace.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurDeletePlace.TabIndex = 0;
            this.tbFormTurDeletePlace.Enter += new System.EventHandler(this.tbFormTurDeletePlace_Enter);
            this.tbFormTurDeletePlace.Leave += new System.EventHandler(this.tbFormTurDeletePlace_Leave);
            // 
            // tbFormTurDeleteDateO
            // 
            this.tbFormTurDeleteDateO.Location = new System.Drawing.Point(12, 55);
            this.tbFormTurDeleteDateO.Multiline = true;
            this.tbFormTurDeleteDateO.Name = "tbFormTurDeleteDateO";
            this.tbFormTurDeleteDateO.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurDeleteDateO.TabIndex = 1;
            this.tbFormTurDeleteDateO.Enter += new System.EventHandler(this.tbFormTurDeleteDateO_Enter);
            this.tbFormTurDeleteDateO.Leave += new System.EventHandler(this.tbFormTurDeleteDateO_Leave);
            // 
            // tbFormTurDeleteDateI
            // 
            this.tbFormTurDeleteDateI.Location = new System.Drawing.Point(13, 102);
            this.tbFormTurDeleteDateI.Multiline = true;
            this.tbFormTurDeleteDateI.Name = "tbFormTurDeleteDateI";
            this.tbFormTurDeleteDateI.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurDeleteDateI.TabIndex = 2;
            this.tbFormTurDeleteDateI.Enter += new System.EventHandler(this.tbFormTurDeleteDateI_Enter);
            this.tbFormTurDeleteDateI.Leave += new System.EventHandler(this.tbFormTurDeleteDateI_Leave);
            // 
            // tbFormTurDeleteD_N
            // 
            this.tbFormTurDeleteD_N.Location = new System.Drawing.Point(13, 151);
            this.tbFormTurDeleteD_N.Multiline = true;
            this.tbFormTurDeleteD_N.Name = "tbFormTurDeleteD_N";
            this.tbFormTurDeleteD_N.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurDeleteD_N.TabIndex = 3;
            this.tbFormTurDeleteD_N.Enter += new System.EventHandler(this.tbFormTurDeleteD_N_Enter);
            this.tbFormTurDeleteD_N.Leave += new System.EventHandler(this.tbFormTurDeleteD_N_Leave);
            // 
            // tbFormTurDeleteCost
            // 
            this.tbFormTurDeleteCost.Location = new System.Drawing.Point(12, 194);
            this.tbFormTurDeleteCost.Multiline = true;
            this.tbFormTurDeleteCost.Name = "tbFormTurDeleteCost";
            this.tbFormTurDeleteCost.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurDeleteCost.TabIndex = 4;
            this.tbFormTurDeleteCost.Enter += new System.EventHandler(this.tbFormTurDeleteCost_Enter);
            this.tbFormTurDeleteCost.Leave += new System.EventHandler(this.tbFormTurDeleteCost_Leave);
            // 
            // btnFormTurDeleteDelete
            // 
            this.btnFormTurDeleteDelete.Location = new System.Drawing.Point(12, 288);
            this.btnFormTurDeleteDelete.Name = "btnFormTurDeleteDelete";
            this.btnFormTurDeleteDelete.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurDeleteDelete.TabIndex = 5;
            this.btnFormTurDeleteDelete.Text = "Удалить";
            this.btnFormTurDeleteDelete.UseVisualStyleBackColor = true;
            this.btnFormTurDeleteDelete.Click += new System.EventHandler(this.btnFormTurDeleteDelete_Click);
            // 
            // btnFormTurDeleteExit
            // 
            this.btnFormTurDeleteExit.Location = new System.Drawing.Point(245, 288);
            this.btnFormTurDeleteExit.Name = "btnFormTurDeleteExit";
            this.btnFormTurDeleteExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurDeleteExit.TabIndex = 6;
            this.btnFormTurDeleteExit.Text = "Выйти";
            this.btnFormTurDeleteExit.UseVisualStyleBackColor = true;
            this.btnFormTurDeleteExit.Click += new System.EventHandler(this.btnFormTurDeleteExit_Click);
            // 
            // FormTurDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 355);
            this.Controls.Add(this.btnFormTurDeleteExit);
            this.Controls.Add(this.btnFormTurDeleteDelete);
            this.Controls.Add(this.tbFormTurDeleteCost);
            this.Controls.Add(this.tbFormTurDeleteD_N);
            this.Controls.Add(this.tbFormTurDeleteDateI);
            this.Controls.Add(this.tbFormTurDeleteDateO);
            this.Controls.Add(this.tbFormTurDeletePlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTurDelete";
            this.Text = "FormTurDelete";
            this.Load += new System.EventHandler(this.FormTurDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormTurDeletePlace;
        private System.Windows.Forms.TextBox tbFormTurDeleteDateO;
        private System.Windows.Forms.TextBox tbFormTurDeleteDateI;
        private System.Windows.Forms.TextBox tbFormTurDeleteD_N;
        private System.Windows.Forms.TextBox tbFormTurDeleteCost;
        private System.Windows.Forms.Button btnFormTurDeleteDelete;
        private System.Windows.Forms.Button btnFormTurDeleteExit;
    }
}