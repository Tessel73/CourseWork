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
            this.components = new System.ComponentModel.Container();
            this.tbFormContractUpdateNumber = new System.Windows.Forms.TextBox();
            this.tbFormContractUpdateCost = new System.Windows.Forms.TextBox();
            this.btnFormContractUpdateUpdate = new System.Windows.Forms.Button();
            this.btnFormContractAddExit = new System.Windows.Forms.Button();
            this.cbFormContractUpdateClientID = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new OOP_Course_Work.DBDataSet();
            this.cbFormContractUpdateTurID = new System.Windows.Forms.ComboBox();
            this.turBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFormContractUpdateHotelID = new System.Windows.Forms.ComboBox();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new OOP_Course_Work.DBDataSetTableAdapters.ClientTableAdapter();
            this.turTableAdapter = new OOP_Course_Work.DBDataSetTableAdapters.TurTableAdapter();
            this.hotelTableAdapter = new OOP_Course_Work.DBDataSetTableAdapters.HotelTableAdapter();
            this.tbFormContractUpdateDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormContractUpdateNumber
            // 
            this.tbFormContractUpdateNumber.Location = new System.Drawing.Point(13, 102);
            this.tbFormContractUpdateNumber.Multiline = true;
            this.tbFormContractUpdateNumber.Name = "tbFormContractUpdateNumber";
            this.tbFormContractUpdateNumber.Size = new System.Drawing.Size(347, 37);
            this.tbFormContractUpdateNumber.TabIndex = 4;
            this.tbFormContractUpdateNumber.Enter += new System.EventHandler(this.tbFormContractUpdateNumber_Enter);
            this.tbFormContractUpdateNumber.Leave += new System.EventHandler(this.tbFormContractUpdateNumber_Leave);
            // 
            // tbFormContractUpdateCost
            // 
            this.tbFormContractUpdateCost.Location = new System.Drawing.Point(13, 145);
            this.tbFormContractUpdateCost.Multiline = true;
            this.tbFormContractUpdateCost.Name = "tbFormContractUpdateCost";
            this.tbFormContractUpdateCost.Size = new System.Drawing.Size(347, 37);
            this.tbFormContractUpdateCost.TabIndex = 5;
            this.tbFormContractUpdateCost.Enter += new System.EventHandler(this.tbFormContractUpdateCost_Enter);
            this.tbFormContractUpdateCost.Leave += new System.EventHandler(this.tbFormContractUpdateCost_Leave);
            // 
            // btnFormContractUpdateUpdate
            // 
            this.btnFormContractUpdateUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractUpdateUpdate.Location = new System.Drawing.Point(12, 276);
            this.btnFormContractUpdateUpdate.Name = "btnFormContractUpdateUpdate";
            this.btnFormContractUpdateUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractUpdateUpdate.TabIndex = 7;
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
            this.cbFormContractUpdateClientID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ClientID", true));
            this.cbFormContractUpdateClientID.DataSource = this.clientBindingSource;
            this.cbFormContractUpdateClientID.DisplayMember = "Name";
            this.cbFormContractUpdateClientID.FormattingEnabled = true;
            this.cbFormContractUpdateClientID.Location = new System.Drawing.Point(13, 12);
            this.cbFormContractUpdateClientID.Name = "cbFormContractUpdateClientID";
            this.cbFormContractUpdateClientID.Size = new System.Drawing.Size(347, 24);
            this.cbFormContractUpdateClientID.TabIndex = 1;
            this.cbFormContractUpdateClientID.ValueMember = "ClientID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dBDataSetBindingSource;
            // 
            // dBDataSetBindingSource
            // 
            this.dBDataSetBindingSource.DataSource = this.dBDataSet;
            this.dBDataSetBindingSource.Position = 0;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFormContractUpdateTurID
            // 
            this.cbFormContractUpdateTurID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.turBindingSource, "TurID", true));
            this.cbFormContractUpdateTurID.DataSource = this.turBindingSource;
            this.cbFormContractUpdateTurID.DisplayMember = "City";
            this.cbFormContractUpdateTurID.FormattingEnabled = true;
            this.cbFormContractUpdateTurID.Location = new System.Drawing.Point(12, 42);
            this.cbFormContractUpdateTurID.Name = "cbFormContractUpdateTurID";
            this.cbFormContractUpdateTurID.Size = new System.Drawing.Size(348, 24);
            this.cbFormContractUpdateTurID.TabIndex = 2;
            this.cbFormContractUpdateTurID.ValueMember = "TurID";
            // 
            // turBindingSource
            // 
            this.turBindingSource.DataMember = "Tur";
            this.turBindingSource.DataSource = this.dBDataSetBindingSource;
            // 
            // cbFormContractUpdateHotelID
            // 
            this.cbFormContractUpdateHotelID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hotelBindingSource, "HotelID", true));
            this.cbFormContractUpdateHotelID.DataSource = this.hotelBindingSource;
            this.cbFormContractUpdateHotelID.DisplayMember = "Name";
            this.cbFormContractUpdateHotelID.FormattingEnabled = true;
            this.cbFormContractUpdateHotelID.Location = new System.Drawing.Point(13, 72);
            this.cbFormContractUpdateHotelID.Name = "cbFormContractUpdateHotelID";
            this.cbFormContractUpdateHotelID.Size = new System.Drawing.Size(347, 24);
            this.cbFormContractUpdateHotelID.TabIndex = 3;
            this.cbFormContractUpdateHotelID.ValueMember = "HotelID";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.dBDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // turTableAdapter
            // 
            this.turTableAdapter.ClearBeforeFill = true;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // tbFormContractUpdateDate
            // 
            this.tbFormContractUpdateDate.Location = new System.Drawing.Point(13, 189);
            this.tbFormContractUpdateDate.Multiline = true;
            this.tbFormContractUpdateDate.Name = "tbFormContractUpdateDate";
            this.tbFormContractUpdateDate.Size = new System.Drawing.Size(347, 37);
            this.tbFormContractUpdateDate.TabIndex = 6;
            this.tbFormContractUpdateDate.Enter += new System.EventHandler(this.tbFormContractUpdateDate_Enter);
            this.tbFormContractUpdateDate.Leave += new System.EventHandler(this.tbFormContractUpdateDate_Leave);
            // 
            // FormContractUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(372, 343);
            this.Controls.Add(this.tbFormContractUpdateDate);
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
            this.Load += new System.EventHandler(this.FormContractUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource dBDataSetBindingSource;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DBDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource turBindingSource;
        private DBDataSetTableAdapters.TurTableAdapter turTableAdapter;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private DBDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.TextBox tbFormContractUpdateDate;
    }
}