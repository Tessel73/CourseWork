namespace OOP_Course_Work
{
    partial class FormContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContract));
            this.btnFormContractExit = new System.Windows.Forms.Button();
            this.dataGridViewContract = new System.Windows.Forms.DataGridView();
            this.contractIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceContract = new System.Windows.Forms.BindingSource(this.components);
            this.ContractDataSet = new OOP_Course_Work.ContractDataSet();
            this.btnFormContractAdd = new System.Windows.Forms.Button();
            this.btnFormContractUpdate = new System.Windows.Forms.Button();
            this.btnFormContractDelete = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorContract = new System.Windows.Forms.BindingNavigator(this.components);
            this.ContractTableAdapter = new OOP_Course_Work.ContractDataSetTableAdapters.ContractTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContract)).BeginInit();
            this.bindingNavigatorContract.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormContractExit
            // 
            this.btnFormContractExit.Location = new System.Drawing.Point(746, 353);
            this.btnFormContractExit.Name = "btnFormContractExit";
            this.btnFormContractExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormContractExit.TabIndex = 0;
            this.btnFormContractExit.Text = "Выход";
            this.btnFormContractExit.UseVisualStyleBackColor = true;
            this.btnFormContractExit.Click += new System.EventHandler(this.btnFormContractExit_Click);
            // 
            // dataGridViewContract
            // 
            this.dataGridViewContract.AutoGenerateColumns = false;
            this.dataGridViewContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contractIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.turIDDataGridViewTextBoxColumn,
            this.hotelIDDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn});
            this.dataGridViewContract.DataSource = this.contractBindingSource;
            this.dataGridViewContract.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewContract.Name = "dataGridViewContract";
            this.dataGridViewContract.RowTemplate.Height = 24;
            this.dataGridViewContract.Size = new System.Drawing.Size(1058, 257);
            this.dataGridViewContract.TabIndex = 1;
            // 
            // contractIDDataGridViewTextBoxColumn
            // 
            this.contractIDDataGridViewTextBoxColumn.DataPropertyName = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.HeaderText = "ContractID";
            this.contractIDDataGridViewTextBoxColumn.Name = "contractIDDataGridViewTextBoxColumn";
            this.contractIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // turIDDataGridViewTextBoxColumn
            // 
            this.turIDDataGridViewTextBoxColumn.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn.HeaderText = "TurID";
            this.turIDDataGridViewTextBoxColumn.Name = "turIDDataGridViewTextBoxColumn";
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataMember = "Contract";
            this.contractBindingSource.DataSource = this.bindingSourceContract;
            // 
            // bindingSourceContract
            // 
            this.bindingSourceContract.DataSource = this.ContractDataSet;
            this.bindingSourceContract.Position = 0;
            // 
            // ContractDataSet
            // 
            this.ContractDataSet.DataSetName = "ContractDataSet";
            this.ContractDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFormContractAdd
            // 
            this.btnFormContractAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormContractAdd.Location = new System.Drawing.Point(207, 353);
            this.btnFormContractAdd.Name = "btnFormContractAdd";
            this.btnFormContractAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractAdd.TabIndex = 3;
            this.btnFormContractAdd.Text = "Добавить договор";
            this.btnFormContractAdd.UseVisualStyleBackColor = true;
            this.btnFormContractAdd.Click += new System.EventHandler(this.btnFormContractAdd_Click);
            // 
            // btnFormContractUpdate
            // 
            this.btnFormContractUpdate.Location = new System.Drawing.Point(391, 353);
            this.btnFormContractUpdate.Name = "btnFormContractUpdate";
            this.btnFormContractUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractUpdate.TabIndex = 4;
            this.btnFormContractUpdate.Text = "Обновить договор";
            this.btnFormContractUpdate.UseVisualStyleBackColor = true;
            this.btnFormContractUpdate.Click += new System.EventHandler(this.btnFormContractUpdate_Click);
            // 
            // btnFormContractDelete
            // 
            this.btnFormContractDelete.Location = new System.Drawing.Point(567, 353);
            this.btnFormContractDelete.Name = "btnFormContractDelete";
            this.btnFormContractDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormContractDelete.TabIndex = 5;
            this.btnFormContractDelete.Text = "Удалить договор";
            this.btnFormContractDelete.UseVisualStyleBackColor = true;
            this.btnFormContractDelete.Click += new System.EventHandler(this.btnFormContractDelete_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorContract
            // 
            this.bindingNavigatorContract.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorContract.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorContract.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorContract.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorContract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigatorContract.Location = new System.Drawing.Point(12, 272);
            this.bindingNavigatorContract.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorContract.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorContract.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorContract.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorContract.Name = "bindingNavigatorContract";
            this.bindingNavigatorContract.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorContract.Size = new System.Drawing.Size(275, 27);
            this.bindingNavigatorContract.TabIndex = 2;
            this.bindingNavigatorContract.Text = "bindingNavigator1";
            // 
            // ContractTableAdapter
            // 
            this.ContractTableAdapter.ClearBeforeFill = true;
            // 
            // FormContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1110, 433);
            this.Controls.Add(this.btnFormContractDelete);
            this.Controls.Add(this.btnFormContractUpdate);
            this.Controls.Add(this.btnFormContractAdd);
            this.Controls.Add(this.bindingNavigatorContract);
            this.Controls.Add(this.dataGridViewContract);
            this.Controls.Add(this.btnFormContractExit);
            this.Name = "FormContract";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.FormContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorContract)).EndInit();
            this.bindingNavigatorContract.ResumeLayout(false);
            this.bindingNavigatorContract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormContractExit;
        private System.Windows.Forms.Button btnFormContractAdd;
        private System.Windows.Forms.Button btnFormContractUpdate;
        private System.Windows.Forms.Button btnFormContractDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorContract;
        private System.Windows.Forms.BindingSource bindingSourceContract;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        public ContractDataSet ContractDataSet;
        public ContractDataSetTableAdapters.ContractTableAdapter ContractTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewContract;
    }
}