namespace OOP_Course_Work
{
    partial class FormContractAdd
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
            this.tbFormContractAddNumber = new System.Windows.Forms.TextBox();
            this.tbFormContractAddCost = new System.Windows.Forms.TextBox();
            this.btnFormContractAddAdd = new System.Windows.Forms.Button();
            this.btnFormContractAddExit = new System.Windows.Forms.Button();
            this.cbFormContractAddClientID = new System.Windows.Forms.ComboBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractAddDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractAddDataSet = new OOP_Course_Work.ContractAddDataSet();
            this.cbFormContractAddTurID = new System.Windows.Forms.ComboBox();
            this.turBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbFormContractAddHotelID = new System.Windows.Forms.ComboBox();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new OOP_Course_Work.ContractAddDataSetTableAdapters.ClientTableAdapter();
            this.hotelTableAdapter = new OOP_Course_Work.ContractAddDataSetTableAdapters.HotelTableAdapter();
            this.turTableAdapter = new OOP_Course_Work.ContractAddDataSetTableAdapters.TurTableAdapter();
            this.tbFormContractAddDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractAddDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractAddDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFormContractAddNumber
            // 
            this.tbFormContractAddNumber.Location = new System.Drawing.Point(12, 102);
            this.tbFormContractAddNumber.Multiline = true;
            this.tbFormContractAddNumber.Name = "tbFormContractAddNumber";
            this.tbFormContractAddNumber.Size = new System.Drawing.Size(324, 37);
            this.tbFormContractAddNumber.TabIndex = 4;
            this.tbFormContractAddNumber.Enter += new System.EventHandler(this.tbFormContractAddNumber_Enter);
            this.tbFormContractAddNumber.Leave += new System.EventHandler(this.tbFormContractAddNumber_Leave);
            // 
            // tbFormContractAddCost
            // 
            this.tbFormContractAddCost.Location = new System.Drawing.Point(12, 145);
            this.tbFormContractAddCost.Multiline = true;
            this.tbFormContractAddCost.Name = "tbFormContractAddCost";
            this.tbFormContractAddCost.Size = new System.Drawing.Size(324, 37);
            this.tbFormContractAddCost.TabIndex = 5;
            this.tbFormContractAddCost.Enter += new System.EventHandler(this.tbFormContractAddCost_Enter);
            this.tbFormContractAddCost.Leave += new System.EventHandler(this.tbFormContractAddCost_Leave);
            // 
            // btnFormContractAddAdd
            // 
            this.btnFormContractAddAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractAddAdd.Location = new System.Drawing.Point(12, 264);
            this.btnFormContractAddAdd.Name = "btnFormContractAddAdd";
            this.btnFormContractAddAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractAddAdd.TabIndex = 7;
            this.btnFormContractAddAdd.Text = "Добавить";
            this.btnFormContractAddAdd.UseVisualStyleBackColor = true;
            this.btnFormContractAddAdd.Click += new System.EventHandler(this.btnFormContractAddAdd_Click);
            // 
            // btnFormContractAddExit
            // 
            this.btnFormContractAddExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractAddExit.Location = new System.Drawing.Point(221, 264);
            this.btnFormContractAddExit.Name = "btnFormContractAddExit";
            this.btnFormContractAddExit.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractAddExit.TabIndex = 0;
            this.btnFormContractAddExit.Text = "Выход";
            this.btnFormContractAddExit.UseVisualStyleBackColor = true;
            this.btnFormContractAddExit.Click += new System.EventHandler(this.btnFormContractAddExit_Click);
            // 
            // cbFormContractAddClientID
            // 
            this.cbFormContractAddClientID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientBindingSource, "ClientID", true));
            this.cbFormContractAddClientID.DataSource = this.clientBindingSource;
            this.cbFormContractAddClientID.DisplayMember = "Name";
            this.cbFormContractAddClientID.FormattingEnabled = true;
            this.cbFormContractAddClientID.Location = new System.Drawing.Point(12, 12);
            this.cbFormContractAddClientID.Name = "cbFormContractAddClientID";
            this.cbFormContractAddClientID.Size = new System.Drawing.Size(324, 24);
            this.cbFormContractAddClientID.TabIndex = 1;
            this.cbFormContractAddClientID.ValueMember = "ClientID";
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.contractAddDataSetBindingSource;
            // 
            // contractAddDataSetBindingSource
            // 
            this.contractAddDataSetBindingSource.DataSource = this.contractAddDataSet;
            this.contractAddDataSetBindingSource.Position = 0;
            // 
            // contractAddDataSet
            // 
            this.contractAddDataSet.DataSetName = "ContractAddDataSet";
            this.contractAddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbFormContractAddTurID
            // 
            this.cbFormContractAddTurID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.turBindingSource, "TurID", true));
            this.cbFormContractAddTurID.DataSource = this.turBindingSource;
            this.cbFormContractAddTurID.DisplayMember = "City";
            this.cbFormContractAddTurID.FormattingEnabled = true;
            this.cbFormContractAddTurID.Location = new System.Drawing.Point(12, 42);
            this.cbFormContractAddTurID.Name = "cbFormContractAddTurID";
            this.cbFormContractAddTurID.Size = new System.Drawing.Size(324, 24);
            this.cbFormContractAddTurID.TabIndex = 2;
            this.cbFormContractAddTurID.ValueMember = "TurID";
            // 
            // turBindingSource
            // 
            this.turBindingSource.DataMember = "Tur";
            this.turBindingSource.DataSource = this.contractAddDataSetBindingSource;
            // 
            // cbFormContractAddHotelID
            // 
            this.cbFormContractAddHotelID.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.hotelBindingSource, "HotelID", true));
            this.cbFormContractAddHotelID.DataSource = this.hotelBindingSource;
            this.cbFormContractAddHotelID.DisplayMember = "Name";
            this.cbFormContractAddHotelID.FormattingEnabled = true;
            this.cbFormContractAddHotelID.Location = new System.Drawing.Point(12, 72);
            this.cbFormContractAddHotelID.Name = "cbFormContractAddHotelID";
            this.cbFormContractAddHotelID.Size = new System.Drawing.Size(324, 24);
            this.cbFormContractAddHotelID.TabIndex = 3;
            this.cbFormContractAddHotelID.ValueMember = "HotelID";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.contractAddDataSetBindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // hotelTableAdapter
            // 
            this.hotelTableAdapter.ClearBeforeFill = true;
            // 
            // turTableAdapter
            // 
            this.turTableAdapter.ClearBeforeFill = true;
            // 
            // tbFormContractAddDate
            // 
            this.tbFormContractAddDate.Location = new System.Drawing.Point(13, 189);
            this.tbFormContractAddDate.Multiline = true;
            this.tbFormContractAddDate.Name = "tbFormContractAddDate";
            this.tbFormContractAddDate.Size = new System.Drawing.Size(323, 37);
            this.tbFormContractAddDate.TabIndex = 6;
            this.tbFormContractAddDate.Enter += new System.EventHandler(this.tbFormContractAddDate_Enter);
            this.tbFormContractAddDate.Leave += new System.EventHandler(this.tbFormContractAddDate_Leave);
            // 
            // FormContractAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 331);
            this.Controls.Add(this.tbFormContractAddDate);
            this.Controls.Add(this.cbFormContractAddHotelID);
            this.Controls.Add(this.cbFormContractAddTurID);
            this.Controls.Add(this.cbFormContractAddClientID);
            this.Controls.Add(this.btnFormContractAddExit);
            this.Controls.Add(this.btnFormContractAddAdd);
            this.Controls.Add(this.tbFormContractAddCost);
            this.Controls.Add(this.tbFormContractAddNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormContractAdd";
            this.Text = "Добавление договора";
            this.Load += new System.EventHandler(this.FormContractAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractAddDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractAddDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFormContractAddNumber;
        private System.Windows.Forms.TextBox tbFormContractAddCost;
        private System.Windows.Forms.Button btnFormContractAddAdd;
        private System.Windows.Forms.Button btnFormContractAddExit;
        private System.Windows.Forms.ComboBox cbFormContractAddClientID;
        private System.Windows.Forms.ComboBox cbFormContractAddTurID;
        private System.Windows.Forms.ComboBox cbFormContractAddHotelID;
        private System.Windows.Forms.BindingSource contractAddDataSetBindingSource;
        private ContractAddDataSet contractAddDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ContractAddDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private ContractAddDataSetTableAdapters.HotelTableAdapter hotelTableAdapter;
        private System.Windows.Forms.BindingSource turBindingSource;
        private ContractAddDataSetTableAdapters.TurTableAdapter turTableAdapter;
        private System.Windows.Forms.TextBox tbFormContractAddDate;
    }
}