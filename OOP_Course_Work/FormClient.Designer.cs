namespace OOP_Course_Work
{
    partial class FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClient));
            this.btnFormClientExit = new System.Windows.Forms.Button();
            this.btnFormClientAdd = new System.Windows.Forms.Button();
            this.btnFormClientDelete = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceClient = new System.Windows.Forms.BindingSource(this.components);
            this.clientDataSet = new OOP_Course_Work.ClientDataSet();
            this.bindingNavigatorClient = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientTableAdapter = new OOP_Course_Work.ClientDataSetTableAdapters.ClientTableAdapter();
            this.btnFormClientUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClient)).BeginInit();
            this.bindingNavigatorClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormClientExit
            // 
            this.btnFormClientExit.Location = new System.Drawing.Point(684, 351);
            this.btnFormClientExit.Name = "btnFormClientExit";
            this.btnFormClientExit.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientExit.TabIndex = 0;
            this.btnFormClientExit.Text = "Выход";
            this.btnFormClientExit.UseVisualStyleBackColor = true;
            this.btnFormClientExit.Click += new System.EventHandler(this.btnFormClientExit_Click);
            // 
            // btnFormClientAdd
            // 
            this.btnFormClientAdd.Location = new System.Drawing.Point(195, 351);
            this.btnFormClientAdd.Name = "btnFormClientAdd";
            this.btnFormClientAdd.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientAdd.TabIndex = 3;
            this.btnFormClientAdd.Text = "Добавить клиента";
            this.btnFormClientAdd.UseVisualStyleBackColor = true;
            this.btnFormClientAdd.Click += new System.EventHandler(this.btnFormClientAdd_Click);
            // 
            // btnFormClientDelete
            // 
            this.btnFormClientDelete.Location = new System.Drawing.Point(534, 351);
            this.btnFormClientDelete.Name = "btnFormClientDelete";
            this.btnFormClientDelete.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientDelete.TabIndex = 5;
            this.btnFormClientDelete.Text = "Удалить клиента";
            this.btnFormClientDelete.UseVisualStyleBackColor = true;
            this.btnFormClientDelete.Click += new System.EventHandler(this.btnFormClientDelete_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AutoGenerateColumns = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewClient.DataSource = this.clientBindingSource;
            this.dataGridViewClient.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(782, 256);
            this.dataGridViewClient.TabIndex = 1;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            this.passportDataGridViewTextBoxColumn.Width = 250;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Электронная почта";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 180;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.bindingSourceClient;
            // 
            // bindingSourceClient
            // 
            this.bindingSourceClient.DataSource = this.clientDataSet;
            this.bindingSourceClient.Position = 0;
            // 
            // clientDataSet
            // 
            this.clientDataSet.DataSetName = "ClientDataSet";
            this.clientDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorClient
            // 
            this.bindingNavigatorClient.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigatorClient.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorClient.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorClient.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigatorClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorClient.Location = new System.Drawing.Point(12, 271);
            this.bindingNavigatorClient.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorClient.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorClient.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorClient.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorClient.Name = "bindingNavigatorClient";
            this.bindingNavigatorClient.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorClient.Size = new System.Drawing.Size(275, 27);
            this.bindingNavigatorClient.TabIndex = 2;
            this.bindingNavigatorClient.Text = "bindingNavigator1";
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
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnFormClientUpdate
            // 
            this.btnFormClientUpdate.Location = new System.Drawing.Point(373, 351);
            this.btnFormClientUpdate.Name = "btnFormClientUpdate";
            this.btnFormClientUpdate.Size = new System.Drawing.Size(110, 55);
            this.btnFormClientUpdate.TabIndex = 4;
            this.btnFormClientUpdate.Text = "Изменить клиента";
            this.btnFormClientUpdate.UseVisualStyleBackColor = true;
            this.btnFormClientUpdate.Click += new System.EventHandler(this.btnFormClientUpdate_Click);
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(825, 418);
            this.Controls.Add(this.btnFormClientUpdate);
            this.Controls.Add(this.bindingNavigatorClient);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.btnFormClientDelete);
            this.Controls.Add(this.btnFormClientAdd);
            this.Controls.Add(this.btnFormClientExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormClient";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.FormClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorClient)).EndInit();
            this.bindingNavigatorClient.ResumeLayout(false);
            this.bindingNavigatorClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormClientExit;
        private System.Windows.Forms.Button btnFormClientAdd;
        private System.Windows.Forms.Button btnFormClientDelete;
        private System.Windows.Forms.BindingNavigator bindingNavigatorClient;
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
        private System.Windows.Forms.BindingSource bindingSourceClient;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnFormClientUpdate;
        public System.Windows.Forms.DataGridView dataGridViewClient;
        public ClientDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        public ClientDataSet clientDataSet;
    }
}