namespace OOP_Course_Work
{
    partial class FormExcursion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExcursion));
            this.btnFormExcursionExit = new System.Windows.Forms.Button();
            this.dataGridViewExcursion = new System.Windows.Forms.DataGridView();
            this.excursionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excursionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceExcursion = new System.Windows.Forms.BindingSource(this.components);
            this.ExcursionDataSet = new OOP_Course_Work.ExcursionDataSet();
            this.bindingNavigatorExcursion = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnFormExcursionAdd = new System.Windows.Forms.Button();
            this.btnFormExcursionUpdate = new System.Windows.Forms.Button();
            this.btnFormExcursionDelete = new System.Windows.Forms.Button();
            this.ExcursionTableAdapter = new OOP_Course_Work.ExcursionDataSetTableAdapters.ExcursionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExcursion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorExcursion)).BeginInit();
            this.bindingNavigatorExcursion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormExcursionExit
            // 
            this.btnFormExcursionExit.Location = new System.Drawing.Point(805, 356);
            this.btnFormExcursionExit.Name = "btnFormExcursionExit";
            this.btnFormExcursionExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormExcursionExit.TabIndex = 0;
            this.btnFormExcursionExit.Text = "Выход";
            this.btnFormExcursionExit.UseVisualStyleBackColor = true;
            this.btnFormExcursionExit.Click += new System.EventHandler(this.btnFormExcursionExit_Click);
            // 
            // dataGridViewExcursion
            // 
            this.dataGridViewExcursion.AutoGenerateColumns = false;
            this.dataGridViewExcursion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExcursion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.excursionIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
            this.dataGridViewExcursion.DataSource = this.excursionBindingSource;
            this.dataGridViewExcursion.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewExcursion.Name = "dataGridViewExcursion";
            this.dataGridViewExcursion.RowTemplate.Height = 24;
            this.dataGridViewExcursion.Size = new System.Drawing.Size(858, 214);
            this.dataGridViewExcursion.TabIndex = 1;
            // 
            // excursionIDDataGridViewTextBoxColumn
            // 
            this.excursionIDDataGridViewTextBoxColumn.DataPropertyName = "ExcursionID";
            this.excursionIDDataGridViewTextBoxColumn.HeaderText = "ExcursionID";
            this.excursionIDDataGridViewTextBoxColumn.Name = "excursionIDDataGridViewTextBoxColumn";
            this.excursionIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // lengthDataGridViewTextBoxColumn
            // 
            this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
            this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
            this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // excursionBindingSource
            // 
            this.excursionBindingSource.DataMember = "Excursion";
            this.excursionBindingSource.DataSource = this.bindingSourceExcursion;
            // 
            // bindingSourceExcursion
            // 
            this.bindingSourceExcursion.DataSource = this.ExcursionDataSet;
            this.bindingSourceExcursion.Position = 0;
            // 
            // ExcursionDataSet
            // 
            this.ExcursionDataSet.DataSetName = "ExcursionDataSet";
            this.ExcursionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorExcursion
            // 
            this.bindingNavigatorExcursion.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorExcursion.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorExcursion.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorExcursion.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorExcursion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorExcursion.Location = new System.Drawing.Point(12, 229);
            this.bindingNavigatorExcursion.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorExcursion.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorExcursion.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorExcursion.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorExcursion.Name = "bindingNavigatorExcursion";
            this.bindingNavigatorExcursion.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorExcursion.Size = new System.Drawing.Size(275, 27);
            this.bindingNavigatorExcursion.TabIndex = 2;
            this.bindingNavigatorExcursion.Text = "bindingNavigator1";
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
            // btnFormExcursionAdd
            // 
            this.btnFormExcursionAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormExcursionAdd.Location = new System.Drawing.Point(209, 356);
            this.btnFormExcursionAdd.Name = "btnFormExcursionAdd";
            this.btnFormExcursionAdd.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionAdd.TabIndex = 3;
            this.btnFormExcursionAdd.Text = "Добавить экскурсию";
            this.btnFormExcursionAdd.UseVisualStyleBackColor = true;
            this.btnFormExcursionAdd.Click += new System.EventHandler(this.btnFormExcursionAdd_Click);
            // 
            // btnFormExcursionUpdate
            // 
            this.btnFormExcursionUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFormExcursionUpdate.Location = new System.Drawing.Point(401, 356);
            this.btnFormExcursionUpdate.Name = "btnFormExcursionUpdate";
            this.btnFormExcursionUpdate.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionUpdate.TabIndex = 4;
            this.btnFormExcursionUpdate.Text = "Изменить экскурсию";
            this.btnFormExcursionUpdate.UseVisualStyleBackColor = true;
            this.btnFormExcursionUpdate.Click += new System.EventHandler(this.btnFormExcursionUpdate_Click);
            // 
            // btnFormExcursionDelete
            // 
            this.btnFormExcursionDelete.Location = new System.Drawing.Point(599, 356);
            this.btnFormExcursionDelete.Name = "btnFormExcursionDelete";
            this.btnFormExcursionDelete.Size = new System.Drawing.Size(115, 55);
            this.btnFormExcursionDelete.TabIndex = 5;
            this.btnFormExcursionDelete.Text = "Удалить экскурсию";
            this.btnFormExcursionDelete.UseVisualStyleBackColor = true;
            this.btnFormExcursionDelete.Click += new System.EventHandler(this.btnFormExcursionDelete_Click);
            // 
            // ExcursionTableAdapter
            // 
            this.ExcursionTableAdapter.ClearBeforeFill = true;
            // 
            // FormExcursion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(927, 423);
            this.Controls.Add(this.btnFormExcursionDelete);
            this.Controls.Add(this.btnFormExcursionUpdate);
            this.Controls.Add(this.btnFormExcursionAdd);
            this.Controls.Add(this.bindingNavigatorExcursion);
            this.Controls.Add(this.dataGridViewExcursion);
            this.Controls.Add(this.btnFormExcursionExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormExcursion";
            this.Text = "Excursion";
            this.Load += new System.EventHandler(this.FormExcursion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExcursion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceExcursion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExcursionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorExcursion)).EndInit();
            this.bindingNavigatorExcursion.ResumeLayout(false);
            this.bindingNavigatorExcursion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormExcursionExit;
        private System.Windows.Forms.BindingNavigator bindingNavigatorExcursion;
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
        private System.Windows.Forms.Button btnFormExcursionAdd;
        private System.Windows.Forms.Button btnFormExcursionUpdate;
        private System.Windows.Forms.Button btnFormExcursionDelete;
        private System.Windows.Forms.BindingSource bindingSourceExcursion;
        private System.Windows.Forms.BindingSource excursionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn excursionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        public ExcursionDataSet ExcursionDataSet;
        public ExcursionDataSetTableAdapters.ExcursionTableAdapter ExcursionTableAdapter;
        public System.Windows.Forms.DataGridView dataGridViewExcursion;
    }
}