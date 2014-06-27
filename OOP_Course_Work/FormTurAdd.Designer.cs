namespace OOP_Course_Work
{
    partial class FormTurAdd
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
            this.components = new System.ComponentModel.Container();
            this.tbFormTurAddCountry = new System.Windows.Forms.TextBox();
            this.tbFormTurAddDateO = new System.Windows.Forms.TextBox();
            this.tbFormTurAddDateI = new System.Windows.Forms.TextBox();
            this.tbFormTurAddD_N = new System.Windows.Forms.TextBox();
            this.tbFormTurAddCost = new System.Windows.Forms.TextBox();
            this.btnFormTurAddAdd = new System.Windows.Forms.Button();
            this.btnFormTurAddExit = new System.Windows.Forms.Button();
            this.tbFormTurAddCity = new System.Windows.Forms.TextBox();
            this.cbFormTurAddExcursionID = new System.Windows.Forms.ComboBox();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turAddDataSet = new OOP_Course_Work.TurAddDataSet();
            this.excursionTableAdapter = new OOP_Course_Work.TurAddDataSetTableAdapters.ExcursionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAddDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormTurAddCountry
            // 
            this.tbFormTurAddCountry.Location = new System.Drawing.Point(12, 12);
            this.tbFormTurAddCountry.Multiline = true;
            this.tbFormTurAddCountry.Name = "tbFormTurAddCountry";
            this.tbFormTurAddCountry.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurAddCountry.TabIndex = 1;
            this.tbFormTurAddCountry.Enter += new System.EventHandler(this.tbFormTurAddCountry_Enter);
            this.tbFormTurAddCountry.Leave += new System.EventHandler(this.tbFormTurAddCountry_Leave);
            // 
            // tbFormTurAddDateO
            // 
            this.tbFormTurAddDateO.Location = new System.Drawing.Point(11, 98);
            this.tbFormTurAddDateO.Multiline = true;
            this.tbFormTurAddDateO.Name = "tbFormTurAddDateO";
            this.tbFormTurAddDateO.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurAddDateO.TabIndex = 3;
            this.tbFormTurAddDateO.Enter += new System.EventHandler(this.tbFormTurAddDateO_Enter);
            this.tbFormTurAddDateO.Leave += new System.EventHandler(this.tbFormTurAddDateO_Leave);
            // 
            // tbFormTurAddDateI
            // 
            this.tbFormTurAddDateI.Location = new System.Drawing.Point(11, 141);
            this.tbFormTurAddDateI.Multiline = true;
            this.tbFormTurAddDateI.Name = "tbFormTurAddDateI";
            this.tbFormTurAddDateI.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurAddDateI.TabIndex = 4;
            this.tbFormTurAddDateI.Enter += new System.EventHandler(this.tbFormTurAddDateI_Enter);
            this.tbFormTurAddDateI.Leave += new System.EventHandler(this.tbFormTurAddDateI_Leave);
            // 
            // tbFormTurAddD_N
            // 
            this.tbFormTurAddD_N.Location = new System.Drawing.Point(14, 184);
            this.tbFormTurAddD_N.Multiline = true;
            this.tbFormTurAddD_N.Name = "tbFormTurAddD_N";
            this.tbFormTurAddD_N.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurAddD_N.TabIndex = 5;
            this.tbFormTurAddD_N.Enter += new System.EventHandler(this.tbFormTurAddD_N_Enter);
            this.tbFormTurAddD_N.Leave += new System.EventHandler(this.tbFormTurAddD_N_Leave);
            // 
            // tbFormTurAddCost
            // 
            this.tbFormTurAddCost.Location = new System.Drawing.Point(13, 227);
            this.tbFormTurAddCost.Multiline = true;
            this.tbFormTurAddCost.Name = "tbFormTurAddCost";
            this.tbFormTurAddCost.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurAddCost.TabIndex = 6;
            this.tbFormTurAddCost.Enter += new System.EventHandler(this.tbFormTurAddCost_Enter);
            this.tbFormTurAddCost.Leave += new System.EventHandler(this.tbFormTurAddCost_Leave);
            // 
            // btnFormTurAddAdd
            // 
            this.btnFormTurAddAdd.Location = new System.Drawing.Point(12, 348);
            this.btnFormTurAddAdd.Name = "btnFormTurAddAdd";
            this.btnFormTurAddAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurAddAdd.TabIndex = 8;
            this.btnFormTurAddAdd.Text = "Добавить";
            this.btnFormTurAddAdd.UseVisualStyleBackColor = true;
            this.btnFormTurAddAdd.Click += new System.EventHandler(this.btnFormTurAddAdd_Click);
            // 
            // btnFormTurAddExit
            // 
            this.btnFormTurAddExit.Location = new System.Drawing.Point(253, 348);
            this.btnFormTurAddExit.Name = "btnFormTurAddExit";
            this.btnFormTurAddExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurAddExit.TabIndex = 0;
            this.btnFormTurAddExit.Text = "Выйти";
            this.btnFormTurAddExit.UseVisualStyleBackColor = true;
            this.btnFormTurAddExit.Click += new System.EventHandler(this.btnFormTurAddExit_Click);
            // 
            // tbFormTurAddCity
            // 
            this.tbFormTurAddCity.Location = new System.Drawing.Point(13, 55);
            this.tbFormTurAddCity.Multiline = true;
            this.tbFormTurAddCity.Name = "tbFormTurAddCity";
            this.tbFormTurAddCity.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurAddCity.TabIndex = 2;
            this.tbFormTurAddCity.Enter += new System.EventHandler(this.tbFormTurAddCity_Enter);
            this.tbFormTurAddCity.Leave += new System.EventHandler(this.tbFormTurAddCity_Leave);
            // 
            // cbFormTurAddExcursionID
            // 
            this.cbFormTurAddExcursionID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.excursionBindingSource, "ExcursionID", true));
            this.cbFormTurAddExcursionID.DataSource = this.excursionBindingSource;
            this.cbFormTurAddExcursionID.DisplayMember = "Name";
            this.cbFormTurAddExcursionID.FormattingEnabled = true;
            this.cbFormTurAddExcursionID.Location = new System.Drawing.Point(14, 270);
            this.cbFormTurAddExcursionID.Name = "cbFormTurAddExcursionID";
            this.cbFormTurAddExcursionID.Size = new System.Drawing.Size(339, 24);
            this.cbFormTurAddExcursionID.TabIndex = 7;
            this.cbFormTurAddExcursionID.ValueMember = "ExcursionID";
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.turAddDataSet;
            // 
            // turAddDataSet
            // 
            this.turAddDataSet.DataSetName = "TurAddDataSet";
            this.turAddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // FormTurAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 415);
            this.Controls.Add(this.cbFormTurAddExcursionID);
            this.Controls.Add(this.tbFormTurAddCity);
            this.Controls.Add(this.btnFormTurAddExit);
            this.Controls.Add(this.btnFormTurAddAdd);
            this.Controls.Add(this.tbFormTurAddCost);
            this.Controls.Add(this.tbFormTurAddD_N);
            this.Controls.Add(this.tbFormTurAddDateI);
            this.Controls.Add(this.tbFormTurAddDateO);
            this.Controls.Add(this.tbFormTurAddCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTurAdd";
            this.Text = "Добавление тура";
            this.Load += new System.EventHandler(this.FormTurAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turAddDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormTurAddCountry;
        private System.Windows.Forms.TextBox tbFormTurAddDateO;
        private System.Windows.Forms.TextBox tbFormTurAddDateI;
        private System.Windows.Forms.TextBox tbFormTurAddD_N;
        private System.Windows.Forms.TextBox tbFormTurAddCost;
        private System.Windows.Forms.Button btnFormTurAddAdd;
        private System.Windows.Forms.Button btnFormTurAddExit;
        private System.Windows.Forms.TextBox tbFormTurAddCity;
        private System.Windows.Forms.ComboBox cbFormTurAddExcursionID;
        private TurAddDataSet turAddDataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private TurAddDataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
    }
}