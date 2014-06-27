namespace OOP_Course_Work
{
    partial class MainMenu
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.Туры = new System.Windows.Forms.TabPage();
            this.btnFormTurDelete = new System.Windows.Forms.Button();
            this.btnFormTurUpdate = new System.Windows.Forms.Button();
            this.btnFormTurAdd = new System.Windows.Forms.Button();
            this.dataGridViewTur = new System.Windows.Forms.DataGridView();
            this.turBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceDB = new System.Windows.Forms.BindingSource(this.components);
            this.DBDataSet = new OOP_Course_Work.DBDataSet();
            this.Клиенты = new System.Windows.Forms.TabPage();
            this.btnFormClientUpdate = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnFormClientDelete = new System.Windows.Forms.Button();
            this.btnFormClientAdd = new System.Windows.Forms.Button();
            this.Договора = new System.Windows.Forms.TabPage();
            this.btnFormContractDelete = new System.Windows.Forms.Button();
            this.btnFormContractUpdate = new System.Windows.Forms.Button();
            this.btnFormContractAdd = new System.Windows.Forms.Button();
            this.dataGridViewContract = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Отели = new System.Windows.Forms.TabPage();
            this.btnFormHotelDelete = new System.Windows.Forms.Button();
            this.btnFormHotelUpdate = new System.Windows.Forms.Button();
            this.btnFormHotelAdd = new System.Windows.Forms.Button();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Экскурсии = new System.Windows.Forms.TabPage();
            this.btnFormExcursionDelete = new System.Windows.Forms.Button();
            this.btnFormExcursionUpdate = new System.Windows.Forms.Button();
            this.btnFormExcursionAdd = new System.Windows.Forms.Button();
            this.dataGridViewExcursion = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TableAdapterTur = new OOP_Course_Work.DBDataSetTableAdapters.TurTableAdapter();
            this.TableAdapterClient = new OOP_Course_Work.DBDataSetTableAdapters.ClientTableAdapter();
            this.TableAdapterContract = new OOP_Course_Work.DBDataSetTableAdapters.ContractTableAdapter();
            this.TableAdapterHotel = new OOP_Course_Work.DBDataSetTableAdapters.HotelTableAdapter();
            this.TableAdapterExcursion = new OOP_Course_Work.DBDataSetTableAdapters.ExcursionTableAdapter();
            this.btnInfo = new System.Windows.Forms.Button();
            this.turIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain.SuspendLayout();
            this.Туры.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).BeginInit();
            this.Клиенты.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.Договора.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            this.Отели.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.Экскурсии.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(981, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.Туры);
            this.tabControlMain.Controls.Add(this.Клиенты);
            this.tabControlMain.Controls.Add(this.Договора);
            this.tabControlMain.Controls.Add(this.Отели);
            this.tabControlMain.Controls.Add(this.Экскурсии);
            this.tabControlMain.Location = new System.Drawing.Point(-1, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1105, 428);
            this.tabControlMain.TabIndex = 8;
            // 
            // Туры
            // 
            this.Туры.Controls.Add(this.btnFormTurDelete);
            this.Туры.Controls.Add(this.btnFormTurUpdate);
            this.Туры.Controls.Add(this.btnFormTurAdd);
            this.Туры.Controls.Add(this.dataGridViewTur);
            this.Туры.Location = new System.Drawing.Point(4, 25);
            this.Туры.Name = "Туры";
            this.Туры.Padding = new System.Windows.Forms.Padding(3);
            this.Туры.Size = new System.Drawing.Size(1097, 399);
            this.Туры.TabIndex = 0;
            this.Туры.Text = "Туры";
            this.Туры.UseVisualStyleBackColor = true;
            // 
            // btnFormTurDelete
            // 
            this.btnFormTurDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormTurDelete.Location = new System.Drawing.Point(628, 338);
            this.btnFormTurDelete.Name = "btnFormTurDelete";
            this.btnFormTurDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormTurDelete.TabIndex = 11;
            this.btnFormTurDelete.Text = "Удалить тур";
            this.btnFormTurDelete.UseVisualStyleBackColor = true;
            this.btnFormTurDelete.Click += new System.EventHandler(this.btnFormTurDelete_Click);
            // 
            // btnFormTurUpdate
            // 
            this.btnFormTurUpdate.Location = new System.Drawing.Point(512, 338);
            this.btnFormTurUpdate.Name = "btnFormTurUpdate";
            this.btnFormTurUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurUpdate.TabIndex = 10;
            this.btnFormTurUpdate.Text = "Обновить тур";
            this.btnFormTurUpdate.UseVisualStyleBackColor = true;
            this.btnFormTurUpdate.Click += new System.EventHandler(this.btnFormTurUpdate_Click);
            // 
            // btnFormTurAdd
            // 
            this.btnFormTurAdd.Location = new System.Drawing.Point(396, 338);
            this.btnFormTurAdd.Name = "btnFormTurAdd";
            this.btnFormTurAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurAdd.TabIndex = 9;
            this.btnFormTurAdd.Text = "Добавить тур";
            this.btnFormTurAdd.UseVisualStyleBackColor = true;
            this.btnFormTurAdd.Click += new System.EventHandler(this.btnFormTurAdd_Click);
            // 
            // dataGridViewTur
            // 
            this.dataGridViewTur.AutoGenerateColumns = false;
            this.dataGridViewTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turIDDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.dateODataGridViewTextBoxColumn,
            this.dateIDataGridViewTextBoxColumn,
            this.dayNightDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridViewTur.DataSource = this.turBindingSource;
            this.dataGridViewTur.Location = new System.Drawing.Point(9, 5);
            this.dataGridViewTur.Name = "dataGridViewTur";
            this.dataGridViewTur.RowTemplate.Height = 24;
            this.dataGridViewTur.Size = new System.Drawing.Size(1079, 300);
            this.dataGridViewTur.TabIndex = 7;
            // 
            // turBindingSource
            // 
            this.turBindingSource.DataMember = "Tur";
            this.turBindingSource.DataSource = this.bindingSourceDB;
            // 
            // bindingSourceDB
            // 
            this.bindingSourceDB.DataSource = this.DBDataSet;
            this.bindingSourceDB.Position = 0;
            // 
            // DBDataSet
            // 
            this.DBDataSet.DataSetName = "DBDataSet";
            this.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Клиенты
            // 
            this.Клиенты.Controls.Add(this.btnFormClientUpdate);
            this.Клиенты.Controls.Add(this.dataGridViewClient);
            this.Клиенты.Controls.Add(this.btnFormClientDelete);
            this.Клиенты.Controls.Add(this.btnFormClientAdd);
            this.Клиенты.Location = new System.Drawing.Point(4, 25);
            this.Клиенты.Name = "Клиенты";
            this.Клиенты.Padding = new System.Windows.Forms.Padding(3);
            this.Клиенты.Size = new System.Drawing.Size(1097, 399);
            this.Клиенты.TabIndex = 1;
            this.Клиенты.Text = "Клиенты";
            this.Клиенты.UseVisualStyleBackColor = true;
            // 
            // btnFormClientUpdate
            // 
            this.btnFormClientUpdate.Location = new System.Drawing.Point(512, 338);
            this.btnFormClientUpdate.Name = "btnFormClientUpdate";
            this.btnFormClientUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientUpdate.TabIndex = 10;
            this.btnFormClientUpdate.Text = "Изменить клиента";
            this.btnFormClientUpdate.UseVisualStyleBackColor = true;
            this.btnFormClientUpdate.Click += new System.EventHandler(this.btnFormClientUpdate_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.passportDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.clientBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(9, 6);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(1079, 299);
            this.dataGridViewClient.TabIndex = 7;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "ФИО";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 300;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Пасспортные данные";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 400;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 300;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSourceDB;
            // 
            // btnFormClientDelete
            // 
            this.btnFormClientDelete.Location = new System.Drawing.Point(628, 338);
            this.btnFormClientDelete.Name = "btnFormClientDelete";
            this.btnFormClientDelete.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientDelete.TabIndex = 11;
            this.btnFormClientDelete.Text = "Удалить клиента";
            this.btnFormClientDelete.UseVisualStyleBackColor = true;
            this.btnFormClientDelete.Click += new System.EventHandler(this.btnFormClientDelete_Click);
            // 
            // btnFormClientAdd
            // 
            this.btnFormClientAdd.Location = new System.Drawing.Point(396, 338);
            this.btnFormClientAdd.Name = "btnFormClientAdd";
            this.btnFormClientAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientAdd.TabIndex = 9;
            this.btnFormClientAdd.Text = "Добавить клиента";
            this.btnFormClientAdd.UseVisualStyleBackColor = true;
            this.btnFormClientAdd.Click += new System.EventHandler(this.btnFormClientAdd_Click);
            // 
            // Договора
            // 
            this.Договора.Controls.Add(this.btnFormContractDelete);
            this.Договора.Controls.Add(this.btnFormContractUpdate);
            this.Договора.Controls.Add(this.btnFormContractAdd);
            this.Договора.Controls.Add(this.dataGridViewContract);
            this.Договора.Location = new System.Drawing.Point(4, 25);
            this.Договора.Name = "Договора";
            this.Договора.Size = new System.Drawing.Size(1097, 399);
            this.Договора.TabIndex = 2;
            this.Договора.Text = "Договора";
            this.Договора.UseVisualStyleBackColor = true;
            // 
            // btnFormContractDelete
            // 
            this.btnFormContractDelete.Location = new System.Drawing.Point(628, 341);
            this.btnFormContractDelete.Name = "btnFormContractDelete";
            this.btnFormContractDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractDelete.TabIndex = 8;
            this.btnFormContractDelete.Text = "Удалить договор";
            this.btnFormContractDelete.UseVisualStyleBackColor = true;
            this.btnFormContractDelete.Click += new System.EventHandler(this.btnFormContractDelete_Click);
            // 
            // btnFormContractUpdate
            // 
            this.btnFormContractUpdate.Location = new System.Drawing.Point(507, 341);
            this.btnFormContractUpdate.Name = "btnFormContractUpdate";
            this.btnFormContractUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractUpdate.TabIndex = 7;
            this.btnFormContractUpdate.Text = "Обновить договор";
            this.btnFormContractUpdate.UseVisualStyleBackColor = true;
            this.btnFormContractUpdate.Click += new System.EventHandler(this.btnFormContractUpdate_Click);
            // 
            // btnFormContractAdd
            // 
            this.btnFormContractAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractAdd.Location = new System.Drawing.Point(386, 341);
            this.btnFormContractAdd.Name = "btnFormContractAdd";
            this.btnFormContractAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractAdd.TabIndex = 6;
            this.btnFormContractAdd.Text = "Добавить договор";
            this.btnFormContractAdd.UseVisualStyleBackColor = true;
            this.btnFormContractAdd.Click += new System.EventHandler(this.btnFormContractAdd_Click);
            // 
            // dataGridViewContract
            // 
            this.dataGridViewContract.AutoGenerateColumns = false;
            this.dataGridViewContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn1,
            this.turIDDataGridViewTextBoxColumn1,
            this.hotelIDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn1,
            this.totalCostDataGridViewTextBoxColumn,
            this.contractIDDataGridViewTextBoxColumn});
            this.dataGridViewContract.DataSource = this.contractBindingSource;
            this.dataGridViewContract.Location = new System.Drawing.Point(9, 3);
            this.dataGridViewContract.Name = "dataGridViewContract";
            this.dataGridViewContract.RowTemplate.Height = 24;
            this.dataGridViewContract.Size = new System.Drawing.Size(1079, 302);
            this.dataGridViewContract.TabIndex = 0;
            // 
            // clientIDDataGridViewTextBoxColumn1
            // 
            this.clientIDDataGridViewTextBoxColumn1.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn1.HeaderText = "Клиент";
            this.clientIDDataGridViewTextBoxColumn1.Name = "clientIDDataGridViewTextBoxColumn1";
            this.clientIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // turIDDataGridViewTextBoxColumn1
            // 
            this.turIDDataGridViewTextBoxColumn1.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn1.HeaderText = "Тур";
            this.turIDDataGridViewTextBoxColumn1.Name = "turIDDataGridViewTextBoxColumn1";
            this.turIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "Отель";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Количество путевок";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 140;
            // 
            // costDataGridViewTextBoxColumn1
            // 
            this.costDataGridViewTextBoxColumn1.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn1.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn1.Name = "costDataGridViewTextBoxColumn1";
            this.costDataGridViewTextBoxColumn1.Width = 140;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Итоговая стоимость";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.Width = 160;
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            this.contractIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.contractIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.bindingSourceDB;
            // 
            // Отели
            // 
            this.Отели.Controls.Add(this.btnFormHotelDelete);
            this.Отели.Controls.Add(this.btnFormHotelUpdate);
            this.Отели.Controls.Add(this.btnFormHotelAdd);
            this.Отели.Controls.Add(this.dataGridViewHotel);
            this.Отели.Location = new System.Drawing.Point(4, 25);
            this.Отели.Name = "Отели";
            this.Отели.Size = new System.Drawing.Size(1097, 399);
            this.Отели.TabIndex = 3;
            this.Отели.Text = "Отели";
            this.Отели.UseVisualStyleBackColor = true;
            // 
            // btnFormHotelDelete
            // 
            this.btnFormHotelDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelDelete.Location = new System.Drawing.Point(628, 341);
            this.btnFormHotelDelete.Name = "btnFormHotelDelete";
            this.btnFormHotelDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormHotelDelete.TabIndex = 8;
            this.btnFormHotelDelete.Text = "Удалить отель";
            this.btnFormHotelDelete.UseVisualStyleBackColor = true;
            this.btnFormHotelDelete.Click += new System.EventHandler(this.btnFormHotelDelete_Click);
            // 
            // btnFormHotelUpdate
            // 
            this.btnFormHotelUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelUpdate.Location = new System.Drawing.Point(507, 341);
            this.btnFormHotelUpdate.Name = "btnFormHotelUpdate";
            this.btnFormHotelUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormHotelUpdate.TabIndex = 7;
            this.btnFormHotelUpdate.Text = "Обновить отель";
            this.btnFormHotelUpdate.UseVisualStyleBackColor = true;
            this.btnFormHotelUpdate.Click += new System.EventHandler(this.btnFormHotelUpdate_Click);
            // 
            // btnFormHotelAdd
            // 
            this.btnFormHotelAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelAdd.Location = new System.Drawing.Point(391, 341);
            this.btnFormHotelAdd.Name = "btnFormHotelAdd";
            this.btnFormHotelAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelAdd.TabIndex = 6;
            this.btnFormHotelAdd.Text = "Добавить отель";
            this.btnFormHotelAdd.UseVisualStyleBackColor = true;
            this.btnFormHotelAdd.Click += new System.EventHandler(this.btnFormHotelAdd_Click);
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.AutoGenerateColumns = false;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2,
            this.ratingDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn2,
            this.foodDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn1});
            this.dataGridViewHotel.DataSource = this.hotelBindingSource;
            this.dataGridViewHotel.Location = new System.Drawing.Point(9, 3);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(1079, 307);
            this.dataGridViewHotel.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            this.nameDataGridViewTextBoxColumn2.Width = 200;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Рейтинг";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn2
            // 
            this.costDataGridViewTextBoxColumn2.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn2.HeaderText = "Стоимость";
            this.costDataGridViewTextBoxColumn2.Name = "costDataGridViewTextBoxColumn2";
            this.costDataGridViewTextBoxColumn2.Width = 150;
            // 
            // foodDataGridViewTextBoxColumn
            // 
            this.foodDataGridViewTextBoxColumn.DataPropertyName = "Food";
            this.foodDataGridViewTextBoxColumn.HeaderText = "Питание";
            this.foodDataGridViewTextBoxColumn.Name = "foodDataGridViewTextBoxColumn";
            this.foodDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelIDDataGridViewTextBoxColumn1
            // 
            this.hotelIDDataGridViewTextBoxColumn1.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn1.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn1.Name = "hotelIDDataGridViewTextBoxColumn1";
            this.hotelIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.hotelIDDataGridViewTextBoxColumn1.Visible = false;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.bindingSourceDB;
            // 
            // Экскурсии
            // 
            this.Экскурсии.Controls.Add(this.btnFormExcursionDelete);
            this.Экскурсии.Controls.Add(this.btnFormExcursionUpdate);
            this.Экскурсии.Controls.Add(this.btnFormExcursionAdd);
            this.Экскурсии.Controls.Add(this.dataGridViewExcursion);
            this.Экскурсии.Location = new System.Drawing.Point(4, 25);
            this.Экскурсии.Name = "Экскурсии";
            this.Экскурсии.Size = new System.Drawing.Size(1097, 399);
            this.Экскурсии.TabIndex = 4;
            this.Экскурсии.Text = "Экскурсии";
            this.Экскурсии.UseVisualStyleBackColor = true;
            // 
            // btnFormExcursionDelete
            // 
            this.btnFormExcursionDelete.Location = new System.Drawing.Point(628, 341);
            this.btnFormExcursionDelete.Name = "btnFormExcursionDelete";
            this.btnFormExcursionDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionDelete.TabIndex = 8;
            this.btnFormExcursionDelete.Text = "Удалить экскурсию";
            this.btnFormExcursionDelete.UseVisualStyleBackColor = true;
            this.btnFormExcursionDelete.Click += new System.EventHandler(this.btnFormExcursionDelete_Click);
            // 
            // btnFormExcursionUpdate
            // 
            this.btnFormExcursionUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormExcursionUpdate.Location = new System.Drawing.Point(507, 341);
            this.btnFormExcursionUpdate.Name = "btnFormExcursionUpdate";
            this.btnFormExcursionUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionUpdate.TabIndex = 7;
            this.btnFormExcursionUpdate.Text = "Изменить экскурсию";
            this.btnFormExcursionUpdate.UseVisualStyleBackColor = true;
            this.btnFormExcursionUpdate.Click += new System.EventHandler(this.btnFormExcursionUpdate_Click);
            // 
            // btnFormExcursionAdd
            // 
            this.btnFormExcursionAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormExcursionAdd.Location = new System.Drawing.Point(386, 341);
            this.btnFormExcursionAdd.Name = "btnFormExcursionAdd";
            this.btnFormExcursionAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionAdd.TabIndex = 6;
            this.btnFormExcursionAdd.Text = "Добавить экскурсию";
            this.btnFormExcursionAdd.UseVisualStyleBackColor = true;
            this.btnFormExcursionAdd.Click += new System.EventHandler(this.btnFormExcursionAdd_Click);
            // 
            // dataGridViewExcursion
            // 
            this.dataGridViewExcursion.AutoGenerateColumns = false;
            this.dataGridViewExcursion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcursion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3,
            this.ratingDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn3,
            this.noteDataGridViewTextBoxColumn,
            this.excursionIDDataGridViewTextBoxColumn});
            this.dataGridViewExcursion.DataSource = this.excursionBindingSource;
            this.dataGridViewExcursion.Location = new System.Drawing.Point(9, 3);
            this.dataGridViewExcursion.Name = "dataGridViewExcursion";
            this.dataGridViewExcursion.RowTemplate.Height = 24;
            this.dataGridViewExcursion.Size = new System.Drawing.Size(1079, 305);
            this.dataGridViewExcursion.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.Width = 200;
            // 
            // ratingDataGridViewTextBoxColumn1
            // 
            this.ratingDataGridViewTextBoxColumn1.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn1.HeaderText = "Рейтинг";
            this.ratingDataGridViewTextBoxColumn1.Name = "ratingDataGridViewTextBoxColumn1";
            this.ratingDataGridViewTextBoxColumn1.Width = 120;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 120;
            // 
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Продолжительность";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            this.lengthDataGridViewTextBoxColumn.Width = 150;
            // 
            // costDataGridViewTextBoxColumn3
            // 
            this.costDataGridViewTextBoxColumn3.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn3.HeaderText = "Стоимость, руб";
            this.costDataGridViewTextBoxColumn3.Name = "costDataGridViewTextBoxColumn3";
            this.costDataGridViewTextBoxColumn3.Width = 140;
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Заметка";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            this.noteDataGridViewTextBoxColumn.Width = 250;
            // 
            // excursionIDDataGridViewTextBoxColumn
            // 
            this.excursionIDDataGridViewTextBoxColumn.DataPropertyName = "ExcursionID";
            this.excursionIDDataGridViewTextBoxColumn.HeaderText = "ExcursionID";
            this.excursionIDDataGridViewTextBoxColumn.Name = "excursionIDDataGridViewTextBoxColumn";
            this.excursionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.excursionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.bindingSourceDB;
            // 
            // TableAdapterTur
            // 
            this.TableAdapterTur.ClearBeforeFill = true;
            // 
            // TableAdapterClient
            // 
            this.TableAdapterClient.ClearBeforeFill = true;
            // 
            // TableAdapterContract
            // 
            this.TableAdapterContract.ClearBeforeFill = true;
            // 
            // TableAdapterHotel
            // 
            this.TableAdapterHotel.ClearBeforeFill = true;
            // 
            // TableAdapterExcursion
            // 
            this.TableAdapterExcursion.ClearBeforeFill = true;
            // 
            // btnInfo
            // 
            this.btnInfo.Location = new System.Drawing.Point(849, 436);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(115, 55);
            this.btnInfo.TabIndex = 9;
            this.btnInfo.Text = "Справка";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // turIDDataGridViewTextBoxColumn
            // 
            this.turIDDataGridViewTextBoxColumn.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn.HeaderText = "TurID";
            this.turIDDataGridViewTextBoxColumn.Name = "turIDDataGridViewTextBoxColumn";
            this.turIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.turIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            this.countryDataGridViewTextBoxColumn.Width = 200;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateODataGridViewTextBoxColumn
            // 
            this.dateODataGridViewTextBoxColumn.DataPropertyName = "DateO";
            this.dateODataGridViewTextBoxColumn.HeaderText = "Дата отправления";
            this.dateODataGridViewTextBoxColumn.Name = "dateODataGridViewTextBoxColumn";
            this.dateODataGridViewTextBoxColumn.Width = 120;
            // 
            // dateIDataGridViewTextBoxColumn
            // 
            this.dateIDataGridViewTextBoxColumn.DataPropertyName = "DateI";
            this.dateIDataGridViewTextBoxColumn.HeaderText = "Дата прибытия";
            this.dateIDataGridViewTextBoxColumn.Name = "dateIDataGridViewTextBoxColumn";
            this.dateIDataGridViewTextBoxColumn.Width = 120;
            // 
            // dayNightDataGridViewTextBoxColumn
            // 
            this.dayNightDataGridViewTextBoxColumn.DataPropertyName = "Day_Night";
            this.dayNightDataGridViewTextBoxColumn.HeaderText = "Дни/Ночи";
            this.dayNightDataGridViewTextBoxColumn.Name = "dayNightDataGridViewTextBoxColumn";
            this.dayNightDataGridViewTextBoxColumn.Width = 110;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Стоимость, руб";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 130;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Экскурсия";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1103, 498);
            this.ControlBox = false;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tabControlMain);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tabControlMain.ResumeLayout(false);
            this.Туры.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDataSet)).EndInit();
            this.Клиенты.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.Договора.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            this.Отели.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.Экскурсии.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TabPage Туры;
        public System.Windows.Forms.TabPage Клиенты;
        public System.Windows.Forms.TabPage Договора;
        public System.Windows.Forms.TabPage Отели;
        public System.Windows.Forms.TabPage Экскурсии;
        private System.Windows.Forms.Button btnFormClientUpdate;
        public System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button btnFormClientDelete;
        private System.Windows.Forms.Button btnFormClientAdd;
        private System.Windows.Forms.Button btnFormTurDelete;
        private System.Windows.Forms.Button btnFormTurUpdate;
        private System.Windows.Forms.Button btnFormTurAdd;
        public System.Windows.Forms.DataGridView dataGridViewTur;
        private System.Windows.Forms.Button btnFormExcursionDelete;
        private System.Windows.Forms.Button btnFormExcursionUpdate;
        private System.Windows.Forms.Button btnFormExcursionAdd;
        private System.Windows.Forms.Button btnFormHotelDelete;
        private System.Windows.Forms.Button btnFormHotelUpdate;
        private System.Windows.Forms.Button btnFormHotelAdd;
        private System.Windows.Forms.Button btnFormContractDelete;
        private System.Windows.Forms.Button btnFormContractUpdate;
        private System.Windows.Forms.Button btnFormContractAdd;
        public System.Windows.Forms.DataGridView dataGridViewExcursion;
        public System.Windows.Forms.DataGridView dataGridViewHotel;
        public System.Windows.Forms.DataGridView dataGridViewContract;
        public System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.BindingSource bindingSourceDB;
        private System.Windows.Forms.BindingSource turBindingSource;
        public DBDataSet DBDataSet;
        public DBDataSetTableAdapters.TurTableAdapter TableAdapterTur;
        private System.Windows.Forms.BindingSource clientBindingSource;
        public DBDataSetTableAdapters.ClientTableAdapter TableAdapterClient;
        private System.Windows.Forms.BindingSource contractBindingSource;
        public DBDataSetTableAdapters.ContractTableAdapter TableAdapterContract;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        public DBDataSetTableAdapters.HotelTableAdapter TableAdapterHotel;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        public DBDataSetTableAdapters.ExcursionTableAdapter TableAdapterExcursion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}

