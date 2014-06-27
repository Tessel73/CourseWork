namespace OOP_Course_Work
{
    partial class FormHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHotel));
            this.btnFormHotelExit = new System.Windows.Forms.Button();
            this.dataGridViewHotel = new System.Windows.Forms.DataGridView();
            this.hotelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceHotel = new System.Windows.Forms.BindingSource(this.components);
            this.HotelDataSet = new OOP_Course_Work.HotelDataSet();
            this.bindingNavigatorHotel = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFormHotelAdd = new System.Windows.Forms.Button();
            this.btnFormHotelUpdate = new System.Windows.Forms.Button();
            this.btnFormHotelDelete = new System.Windows.Forms.Button();
            this.HotelTableAdapter = new OOP_Course_Work.HotelDataSetTableAdapters.HotelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHotel)).BeginInit();
            this.bindingNavigatorHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormHotelExit
            // 
            this.btnFormHotelExit.Location = new System.Drawing.Point(535, 369);
            this.btnFormHotelExit.Name = "btnFormHotelExit";
            this.btnFormHotelExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelExit.TabIndex = 0;
            this.btnFormHotelExit.Text = "Выход";
            this.btnFormHotelExit.UseVisualStyleBackColor = true;
            this.btnFormHotelExit.Click += new System.EventHandler(this.btnFormHotelExit_Click);
            // 
            // dataGridViewHotel
            // 
            this.dataGridViewHotel.AutoGenerateColumns = false;
            this.dataGridViewHotel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHotel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hotelIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridViewHotel.DataSource = this.hotelBindingSource;
            this.dataGridViewHotel.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewHotel.Name = "dataGridViewHotel";
            this.dataGridViewHotel.RowTemplate.Height = 24;
            this.dataGridViewHotel.Size = new System.Drawing.Size(487, 216);
            this.dataGridViewHotel.TabIndex = 1;
            // 
            // hotelIDDataGridViewTextBoxColumn
            // 
            this.hotelIDDataGridViewTextBoxColumn.DataPropertyName = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.HeaderText = "HotelID";
            this.hotelIDDataGridViewTextBoxColumn.Name = "hotelIDDataGridViewTextBoxColumn";
            this.hotelIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataMember = "Hotel";
            this.hotelBindingSource.DataSource = this.bindingSourceHotel;
            // 
            // bindingSourceHotel
            // 
            this.bindingSourceHotel.DataSource = this.HotelDataSet;
            this.bindingSourceHotel.Position = 0;
            // 
            // HotelDataSet
            // 
            this.HotelDataSet.DataSetName = "HotelDataSet";
            this.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorHotel
            // 
            this.bindingNavigatorHotel.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorHotel.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHotel.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorHotel.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorHotel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHotel.Location = new System.Drawing.Point(12, 231);
            this.bindingNavigatorHotel.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHotel.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHotel.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHotel.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHotel.Name = "bindingNavigatorHotel";
            this.bindingNavigatorHotel.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHotel.Size = new System.Drawing.Size(275, 27);
            this.bindingNavigatorHotel.TabIndex = 2;
            this.bindingNavigatorHotel.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // btnFormHotelAdd
            // 
            this.btnFormHotelAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelAdd.Location = new System.Drawing.Point(146, 369);
            this.btnFormHotelAdd.Name = "btnFormHotelAdd";
            this.btnFormHotelAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormHotelAdd.TabIndex = 3;
            this.btnFormHotelAdd.Text = "Добавить отель";
            this.btnFormHotelAdd.UseVisualStyleBackColor = true;
            this.btnFormHotelAdd.Click += new System.EventHandler(this.btnFormHotelAdd_Click);
            // 
            // btnFormHotelUpdate
            // 
            this.btnFormHotelUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelUpdate.Location = new System.Drawing.Point(280, 369);
            this.btnFormHotelUpdate.Name = "btnFormHotelUpdate";
            this.btnFormHotelUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormHotelUpdate.TabIndex = 4;
            this.btnFormHotelUpdate.Text = "Обновить отель";
            this.btnFormHotelUpdate.UseVisualStyleBackColor = true;
            this.btnFormHotelUpdate.Click += new System.EventHandler(this.btnFormHotelUpdate_Click);
            // 
            // btnFormHotelDelete
            // 
            this.btnFormHotelDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormHotelDelete.Location = new System.Drawing.Point(404, 369);
            this.btnFormHotelDelete.Name = "btnFormHotelDelete";
            this.btnFormHotelDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormHotelDelete.TabIndex = 5;
            this.btnFormHotelDelete.Text = "Удалить отель";
            this.btnFormHotelDelete.UseVisualStyleBackColor = true;
            this.btnFormHotelDelete.Click += new System.EventHandler(this.btnFormHotelDelete_Click);
            // 
            // HotelTableAdapter
            // 
            this.HotelTableAdapter.ClearBeforeFill = true;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(657, 436);
            this.Controls.Add(this.btnFormHotelDelete);
            this.Controls.Add(this.btnFormHotelUpdate);
            this.Controls.Add(this.btnFormHotelAdd);
            this.Controls.Add(this.bindingNavigatorHotel);
            this.Controls.Add(this.dataGridViewHotel);
            this.Controls.Add(this.btnFormHotelExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormHotel";
            this.Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHotel)).EndInit();
            this.bindingNavigatorHotel.ResumeLayout(false);
            this.bindingNavigatorHotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormHotelExit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHotel;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnFormHotelAdd;
        private System.Windows.Forms.Button btnFormHotelUpdate;
        private System.Windows.Forms.Button btnFormHotelDelete;
        private System.Windows.Forms.BindingSource bindingSourceHotel;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        public HotelDataSet HotelDataSet;
        public HotelDataSetTableAdapters.HotelTableAdapter HotelTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewHotel;
    }
}