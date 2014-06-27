namespace OOP_Course_Work
{
    partial class FormTur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTur));
            this.btnFormTurExit = new System.Windows.Forms.Button();
            this.dataGridViewTur = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorTur = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnFormTurAdd = new System.Windows.Forms.Button();
            this.btnFormTurUpdate = new System.Windows.Forms.Button();
            this.btnFormTurDelete = new System.Windows.Forms.Button();
            this.bindingSourceTur = new System.Windows.Forms.BindingSource(this.components);
            this.TurDataSet = new OOP_Course_Work.TurDataSet();
            this.turBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TurTableAdapter = new OOP_Course_Work.TurDataSetTableAdapters.TurTableAdapter();
            this.turIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTur)).BeginInit();
            this.bindingNavigatorTur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFormTurExit
            // 
            this.btnFormTurExit.Location = new System.Drawing.Point(859, 345);
            this.btnFormTurExit.Name = "btnFormTurExit";
            this.btnFormTurExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurExit.TabIndex = 0;
            this.btnFormTurExit.Text = "Выход";
            this.btnFormTurExit.UseVisualStyleBackColor = true;
            this.btnFormTurExit.Click += new System.EventHandler(this.btnFormTurExit_Click);
            // 
            // dataGridViewTur
            // 
            this.dataGridViewTur.AutoGenerateColumns = false;
            this.dataGridViewTur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.turIDDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.dateODataGridViewTextBoxColumn,
            this.dateIDataGridViewTextBoxColumn,
            this.dayNightDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridViewTur.DataSource = this.turBindingSource;
            this.dataGridViewTur.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTur.Name = "dataGridViewTur";
            this.dataGridViewTur.RowTemplate.Height = 24;
            this.dataGridViewTur.Size = new System.Drawing.Size(957, 235);
            this.dataGridViewTur.TabIndex = 1;
            // 
            // bindingNavigatorTur
            // 
            this.bindingNavigatorTur.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorTur.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorTur.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorTur.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorTur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorTur.Location = new System.Drawing.Point(12, 250);
            this.bindingNavigatorTur.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorTur.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorTur.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorTur.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorTur.Name = "bindingNavigatorTur";
            this.bindingNavigatorTur.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorTur.Size = new System.Drawing.Size(275, 27);
            this.bindingNavigatorTur.TabIndex = 2;
            this.bindingNavigatorTur.Text = "bindingNavigator1";
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
            // btnFormTurAdd
            // 
            this.btnFormTurAdd.Location = new System.Drawing.Point(214, 345);
            this.btnFormTurAdd.Name = "btnFormTurAdd";
            this.btnFormTurAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurAdd.TabIndex = 3;
            this.btnFormTurAdd.Text = "Добавить тур";
            this.btnFormTurAdd.UseVisualStyleBackColor = true;
            this.btnFormTurAdd.Click += new System.EventHandler(this.btnFormTurAdd_Click);
            // 
            // btnFormTurUpdate
            // 
            this.btnFormTurUpdate.Location = new System.Drawing.Point(425, 345);
            this.btnFormTurUpdate.Name = "btnFormTurUpdate";
            this.btnFormTurUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormTurUpdate.TabIndex = 4;
            this.btnFormTurUpdate.Text = "Обновить тур";
            this.btnFormTurUpdate.UseVisualStyleBackColor = true;
            this.btnFormTurUpdate.Click += new System.EventHandler(this.btnFormTurUpdate_Click);
            // 
            // btnFormTurDelete
            // 
            this.btnFormTurDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormTurDelete.Location = new System.Drawing.Point(642, 345);
            this.btnFormTurDelete.Name = "btnFormTurDelete";
            this.btnFormTurDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormTurDelete.TabIndex = 5;
            this.btnFormTurDelete.Text = "Удалить тур";
            this.btnFormTurDelete.UseVisualStyleBackColor = true;
            this.btnFormTurDelete.Click += new System.EventHandler(this.btnFormTurDelete_Click);
            // 
            // bindingSourceTur
            // 
            this.bindingSourceTur.DataSource = this.TurDataSet;
            this.bindingSourceTur.Position = 0;
            // 
            // TurDataSet
            // 
            this.TurDataSet.DataSetName = "TurDataSet";
            this.TurDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turBindingSource
            // 
            this.turBindingSource.DataMember = "Tur";
            this.turBindingSource.DataSource = this.bindingSourceTur;
            // 
            // TurTableAdapter
            // 
            this.TurTableAdapter.ClearBeforeFill = true;
            // 
            // turIDDataGridViewTextBoxColumn
            // 
            this.turIDDataGridViewTextBoxColumn.DataPropertyName = "TurID";
            this.turIDDataGridViewTextBoxColumn.HeaderText = "TurID";
            this.turIDDataGridViewTextBoxColumn.Name = "turIDDataGridViewTextBoxColumn";
            this.turIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // dateODataGridViewTextBoxColumn
            // 
            this.dateODataGridViewTextBoxColumn.DataPropertyName = "DateO";
            this.dateODataGridViewTextBoxColumn.HeaderText = "DateO";
            this.dateODataGridViewTextBoxColumn.Name = "dateODataGridViewTextBoxColumn";
            // 
            // dateIDataGridViewTextBoxColumn
            // 
            this.dateIDataGridViewTextBoxColumn.DataPropertyName = "DateI";
            this.dateIDataGridViewTextBoxColumn.HeaderText = "DateI";
            this.dateIDataGridViewTextBoxColumn.Name = "dateIDataGridViewTextBoxColumn";
            // 
            // dayNightDataGridViewTextBoxColumn
            // 
            this.dayNightDataGridViewTextBoxColumn.DataPropertyName = "Day_Night";
            this.dayNightDataGridViewTextBoxColumn.HeaderText = "Day_Night";
            this.dayNightDataGridViewTextBoxColumn.Name = "dayNightDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // FormTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(990, 412);
            this.Controls.Add(this.btnFormTurDelete);
            this.Controls.Add(this.btnFormTurUpdate);
            this.Controls.Add(this.btnFormTurAdd);
            this.Controls.Add(this.bindingNavigatorTur);
            this.Controls.Add(this.dataGridViewTur);
            this.Controls.Add(this.btnFormTurExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTur";
            this.Text = "Tur";
            this.Load += new System.EventHandler(this.FormTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorTur)).EndInit();
            this.bindingNavigatorTur.ResumeLayout(false);
            this.bindingNavigatorTur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceTur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormTurExit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorTur;
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
        private System.Windows.Forms.Button btnFormTurAdd;
        private System.Windows.Forms.Button btnFormTurUpdate;
        private System.Windows.Forms.Button btnFormTurDelete;
        public System.Windows.Forms.DataGridView dataGridViewTur;
        public System.Windows.Forms.BindingSource bindingSourceTur;
        private System.Windows.Forms.BindingSource turBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn turIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        public TurDataSet TurDataSet;
        public TurDataSetTableAdapters.TurTableAdapter TurTableAdapter;
    }
}