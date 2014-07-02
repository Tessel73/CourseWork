namespace OOP_Course_Work
{
    partial class FormTurUpdate
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
            this.tbFormTurUpdateCountry = new System.Windows.Forms.TextBox();
            this.tbFormTurUpdateDateO = new System.Windows.Forms.TextBox();
            this.tbFormTurUpdateDateI = new System.Windows.Forms.TextBox();
            this.tbFormTurUpdateD_N = new System.Windows.Forms.TextBox();
            this.tbFormTurUpdateCost = new System.Windows.Forms.TextBox();
            this.btnFormTurUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormTurUpdateExit = new System.Windows.Forms.Button();
            this.tbFormTurUpdateCity = new System.Windows.Forms.TextBox();
            this.cbFormTurUpdateExcursionID = new System.Windows.Forms.ComboBox();
            this.turUpdateDataSet = new OOP_Course_Work.TurUpdateDataSet();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionTableAdapter = new OOP_Course_Work.TurUpdateDataSetTableAdapters.ExcursionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.turUpdateDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormTurUpdateCountry
            // 
            this.tbFormTurUpdateCountry.Location = new System.Drawing.Point(12, 12);
            this.tbFormTurUpdateCountry.Multiline = true;
            this.tbFormTurUpdateCountry.Name = "tbFormTurUpdateCountry";
            this.tbFormTurUpdateCountry.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurUpdateCountry.TabIndex = 1;
            this.tbFormTurUpdateCountry.Enter += new System.EventHandler(this.tbFormTurUpdateCountry_Enter);
            this.tbFormTurUpdateCountry.Leave += new System.EventHandler(this.tbFormTurUpdateCountry_Leave);
            // 
            // tbFormTurUpdateDateO
            // 
            this.tbFormTurUpdateDateO.Location = new System.Drawing.Point(12, 98);
            this.tbFormTurUpdateDateO.Multiline = true;
            this.tbFormTurUpdateDateO.Name = "tbFormTurUpdateDateO";
            this.tbFormTurUpdateDateO.Size = new System.Drawing.Size(343, 37);
            this.tbFormTurUpdateDateO.TabIndex = 3;
            this.tbFormTurUpdateDateO.Enter += new System.EventHandler(this.tbFormTurUpdateDateO_Enter);
            this.tbFormTurUpdateDateO.Leave += new System.EventHandler(this.tbFormTurUpdateDateO_Leave);
            // 
            // tbFormTurUpdateDateI
            // 
            this.tbFormTurUpdateDateI.Location = new System.Drawing.Point(12, 141);
            this.tbFormTurUpdateDateI.Multiline = true;
            this.tbFormTurUpdateDateI.Name = "tbFormTurUpdateDateI";
            this.tbFormTurUpdateDateI.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurUpdateDateI.TabIndex = 4;
            this.tbFormTurUpdateDateI.Enter += new System.EventHandler(this.tbFormTurUpdateDateI_Enter);
            this.tbFormTurUpdateDateI.Leave += new System.EventHandler(this.tbFormTurUpdateDateI_Leave);
            // 
            // tbFormTurUpdateD_N
            // 
            this.tbFormTurUpdateD_N.Location = new System.Drawing.Point(12, 184);
            this.tbFormTurUpdateD_N.Multiline = true;
            this.tbFormTurUpdateD_N.Name = "tbFormTurUpdateD_N";
            this.tbFormTurUpdateD_N.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurUpdateD_N.TabIndex = 5;
            this.tbFormTurUpdateD_N.Enter += new System.EventHandler(this.tbFormTurUpdateD_N_Enter);
            this.tbFormTurUpdateD_N.Leave += new System.EventHandler(this.tbFormTurUpdateD_N_Leave);
            // 
            // tbFormTurUpdateCost
            // 
            this.tbFormTurUpdateCost.Location = new System.Drawing.Point(12, 227);
            this.tbFormTurUpdateCost.Multiline = true;
            this.tbFormTurUpdateCost.Name = "tbFormTurUpdateCost";
            this.tbFormTurUpdateCost.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurUpdateCost.TabIndex = 6;
            this.tbFormTurUpdateCost.Enter += new System.EventHandler(this.tbFormTurUpdateCost_Enter);
            this.tbFormTurUpdateCost.Leave += new System.EventHandler(this.tbFormTurUpdateCost_Leave);
            // 
            // btnFormTurUpdateUpdate
            // 
            this.btnFormTurUpdateUpdate.Location = new System.Drawing.Point(12, 348);
            this.btnFormTurUpdateUpdate.Name = "btnFormTurUpdateUpdate";
            this.btnFormTurUpdateUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurUpdateUpdate.TabIndex = 8;
            this.btnFormTurUpdateUpdate.Text = "Обновить";
            this.btnFormTurUpdateUpdate.UseVisualStyleBackColor = true;
            this.btnFormTurUpdateUpdate.Click += new System.EventHandler(this.btnFormTurUpdateUpdate_Click);
            // 
            // btnFormTurUpdateExit
            // 
            this.btnFormTurUpdateExit.Location = new System.Drawing.Point(253, 348);
            this.btnFormTurUpdateExit.Name = "btnFormTurUpdateExit";
            this.btnFormTurUpdateExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurUpdateExit.TabIndex = 0;
            this.btnFormTurUpdateExit.Text = "Выйти";
            this.btnFormTurUpdateExit.UseVisualStyleBackColor = true;
            this.btnFormTurUpdateExit.Click += new System.EventHandler(this.btnFormTurUpdateExit_Click);
            // 
            // tbFormTurUpdateCity
            // 
            this.tbFormTurUpdateCity.Location = new System.Drawing.Point(12, 55);
            this.tbFormTurUpdateCity.Multiline = true;
            this.tbFormTurUpdateCity.Name = "tbFormTurUpdateCity";
            this.tbFormTurUpdateCity.Size = new System.Drawing.Size(342, 37);
            this.tbFormTurUpdateCity.TabIndex = 2;
            this.tbFormTurUpdateCity.Enter += new System.EventHandler(this.tbFormTurUpdateCity_Enter);
            this.tbFormTurUpdateCity.Leave += new System.EventHandler(this.tbFormTurUpdateCity_Leave);
            // 
            // cbFormTurUpdateExcursionID
            // 
            this.cbFormTurUpdateExcursionID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.excursionBindingSource, "ExcursionID", true));
            this.cbFormTurUpdateExcursionID.DataSource = this.excursionBindingSource;
            this.cbFormTurUpdateExcursionID.DisplayMember = "Name";
            this.cbFormTurUpdateExcursionID.FormattingEnabled = true;
            this.cbFormTurUpdateExcursionID.Location = new System.Drawing.Point(12, 271);
            this.cbFormTurUpdateExcursionID.Name = "cbFormTurUpdateExcursionID";
            this.cbFormTurUpdateExcursionID.Size = new System.Drawing.Size(342, 24);
            this.cbFormTurUpdateExcursionID.TabIndex = 7;
            this.cbFormTurUpdateExcursionID.ValueMember = "ExcursionID";
            // 
            // turUpdateDataSet
            // 
            this.turUpdateDataSet.DataSetName = "TurUpdateDataSet";
            this.turUpdateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.turUpdateDataSet;
            // 
            // excursionTableAdapter
            // 
            this.excursionTableAdapter.ClearBeforeFill = true;
            // 
            // FormTurUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(375, 415);
            this.Controls.Add(this.cbFormTurUpdateExcursionID);
            this.Controls.Add(this.tbFormTurUpdateCity);
            this.Controls.Add(this.btnFormTurUpdateExit);
            this.Controls.Add(this.btnFormTurUpdateUpdate);
            this.Controls.Add(this.tbFormTurUpdateCost);
            this.Controls.Add(this.tbFormTurUpdateD_N);
            this.Controls.Add(this.tbFormTurUpdateDateI);
            this.Controls.Add(this.tbFormTurUpdateDateO);
            this.Controls.Add(this.tbFormTurUpdateCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTurUpdate";
            this.Text = "Редактирование тура";
            this.Load += new System.EventHandler(this.FormTurUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.turUpdateDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormTurUpdateCountry;
        private System.Windows.Forms.TextBox tbFormTurUpdateDateO;
        private System.Windows.Forms.TextBox tbFormTurUpdateDateI;
        private System.Windows.Forms.TextBox tbFormTurUpdateD_N;
        private System.Windows.Forms.TextBox tbFormTurUpdateCost;
        private System.Windows.Forms.Button btnFormTurUpdateUpdate;
        private System.Windows.Forms.Button btnFormTurUpdateExit;
        private System.Windows.Forms.TextBox tbFormTurUpdateCity;
        private System.Windows.Forms.ComboBox cbFormTurUpdateExcursionID;
        private TurUpdateDataSet turUpdateDataSet;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private TurUpdateDataSetTableAdapters.ExcursionTableAdapter excursionTableAdapter;
    }
}