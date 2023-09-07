namespace DatabaseBasics.View.Forms
{
    partial class AttendanceForm
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label дата_посещенияLabel;
            System.Windows.Forms.Label жалобыLabel;
            System.Windows.Forms.Label предварительный_диагнозLabel;
            System.Windows.Forms.Label врачLabel;
            System.Windows.Forms.Label номер_карточкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            this.hospitalDataSet = new DatabaseBasics.Databases.HospitalDataSet();
            this.сведение_о_посещаемостяхBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сведение_о_посещаемостяхTableAdapter = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.Сведение_о_посещаемостяхTableAdapter();
            this.tableAdapterManager = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager();
            this.сведение_о_посещаемостяхBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.дата_посещенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.жалобыTextBox = new System.Windows.Forms.TextBox();
            this.предварительный_диагнозTextBox = new System.Windows.Forms.TextBox();
            this.врачTextBox = new System.Windows.Forms.TextBox();
            this.номер_карточкиTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            дата_посещенияLabel = new System.Windows.Forms.Label();
            жалобыLabel = new System.Windows.Forms.Label();
            предварительный_диагнозLabel = new System.Windows.Forms.Label();
            врачLabel = new System.Windows.Forms.Label();
            номер_карточкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_посещаемостяхBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_посещаемостяхBindingNavigator)).BeginInit();
            this.сведение_о_посещаемостяхBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 47);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // дата_посещенияLabel
            // 
            дата_посещенияLabel.AutoSize = true;
            дата_посещенияLabel.Location = new System.Drawing.Point(16, 80);
            дата_посещенияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_посещенияLabel.Name = "дата_посещенияLabel";
            дата_посещенияLabel.Size = new System.Drawing.Size(116, 16);
            дата_посещенияLabel.TabIndex = 3;
            дата_посещенияLabel.Text = "Дата посещения:";
            // 
            // жалобыLabel
            // 
            жалобыLabel.AutoSize = true;
            жалобыLabel.Location = new System.Drawing.Point(16, 111);
            жалобыLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            жалобыLabel.Name = "жалобыLabel";
            жалобыLabel.Size = new System.Drawing.Size(64, 16);
            жалобыLabel.TabIndex = 5;
            жалобыLabel.Text = "Жалобы:";
            // 
            // предварительный_диагнозLabel
            // 
            предварительный_диагнозLabel.AutoSize = true;
            предварительный_диагнозLabel.Location = new System.Drawing.Point(16, 143);
            предварительный_диагнозLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            предварительный_диагнозLabel.Name = "предварительный_диагнозLabel";
            предварительный_диагнозLabel.Size = new System.Drawing.Size(188, 16);
            предварительный_диагнозLabel.TabIndex = 7;
            предварительный_диагнозLabel.Text = "Предварительный диагноз:";
            // 
            // врачLabel
            // 
            врачLabel.AutoSize = true;
            врачLabel.Location = new System.Drawing.Point(16, 175);
            врачLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            врачLabel.Name = "врачLabel";
            врачLabel.Size = new System.Drawing.Size(43, 16);
            врачLabel.TabIndex = 9;
            врачLabel.Text = "Врач:";
            // 
            // номер_карточкиLabel
            // 
            номер_карточкиLabel.AutoSize = true;
            номер_карточкиLabel.Location = new System.Drawing.Point(16, 207);
            номер_карточкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_карточкиLabel.Name = "номер_карточкиLabel";
            номер_карточкиLabel.Size = new System.Drawing.Size(117, 16);
            номер_карточкиLabel.TabIndex = 11;
            номер_карточкиLabel.Text = "Номер карточки:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сведение_о_посещаемостяхBindingSource
            // 
            this.сведение_о_посещаемостяхBindingSource.DataMember = "Сведение о посещаемостях";
            this.сведение_о_посещаемостяхBindingSource.DataSource = this.hospitalDataSet;
            // 
            // сведение_о_посещаемостяхTableAdapter
            // 
            this.сведение_о_посещаемостяхTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Больничный_листTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.Карточка_пациентаTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = null;
            this.tableAdapterManager.Сведение_о_посещаемостяхTableAdapter = this.сведение_о_посещаемостяхTableAdapter;
            // 
            // сведение_о_посещаемостяхBindingNavigator
            // 
            this.сведение_о_посещаемостяхBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сведение_о_посещаемостяхBindingNavigator.BindingSource = this.сведение_о_посещаемостяхBindingSource;
            this.сведение_о_посещаемостяхBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сведение_о_посещаемостяхBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сведение_о_посещаемостяхBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.сведение_о_посещаемостяхBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem});
            this.сведение_о_посещаемостяхBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.сведение_о_посещаемостяхBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сведение_о_посещаемостяхBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сведение_о_посещаемостяхBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сведение_о_посещаемостяхBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сведение_о_посещаемостяхBindingNavigator.Name = "сведение_о_посещаемостяхBindingNavigator";
            this.сведение_о_посещаемостяхBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сведение_о_посещаемостяхBindingNavigator.Size = new System.Drawing.Size(503, 27);
            this.сведение_о_посещаемостяхBindingNavigator.TabIndex = 0;
            this.сведение_о_посещаемостяхBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // сведение_о_посещаемостяхBindingNavigatorSaveItem
            // 
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сведение_о_посещаемостяхBindingNavigatorSaveItem.Image")));
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.Name = "сведение_о_посещаемостяхBindingNavigatorSaveItem";
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сведение_о_посещаемостяхBindingNavigatorSaveItem.Click += new System.EventHandler(this.сведение_о_посещаемостяхBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_посещаемостяхBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(220, 43);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(265, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // дата_посещенияDateTimePicker
            // 
            this.дата_посещенияDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сведение_о_посещаемостяхBindingSource, "Дата посещения", true));
            this.дата_посещенияDateTimePicker.Location = new System.Drawing.Point(220, 75);
            this.дата_посещенияDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.дата_посещенияDateTimePicker.Name = "дата_посещенияDateTimePicker";
            this.дата_посещенияDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.дата_посещенияDateTimePicker.TabIndex = 4;
            // 
            // жалобыTextBox
            // 
            this.жалобыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_посещаемостяхBindingSource, "Жалобы", true));
            this.жалобыTextBox.Location = new System.Drawing.Point(220, 107);
            this.жалобыTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.жалобыTextBox.Name = "жалобыTextBox";
            this.жалобыTextBox.Size = new System.Drawing.Size(265, 22);
            this.жалобыTextBox.TabIndex = 6;
            // 
            // предварительный_диагнозTextBox
            // 
            this.предварительный_диагнозTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_посещаемостяхBindingSource, "Предварительный диагноз", true));
            this.предварительный_диагнозTextBox.Location = new System.Drawing.Point(220, 139);
            this.предварительный_диагнозTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.предварительный_диагнозTextBox.Name = "предварительный_диагнозTextBox";
            this.предварительный_диагнозTextBox.Size = new System.Drawing.Size(265, 22);
            this.предварительный_диагнозTextBox.TabIndex = 8;
            // 
            // врачTextBox
            // 
            this.врачTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_посещаемостяхBindingSource, "Врач", true));
            this.врачTextBox.Location = new System.Drawing.Point(220, 171);
            this.врачTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.врачTextBox.Name = "врачTextBox";
            this.врачTextBox.Size = new System.Drawing.Size(265, 22);
            this.врачTextBox.TabIndex = 10;
            // 
            // номер_карточкиTextBox
            // 
            this.номер_карточкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_посещаемостяхBindingSource, "Номер карточки", true));
            this.номер_карточкиTextBox.Location = new System.Drawing.Point(220, 203);
            this.номер_карточкиTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.номер_карточкиTextBox.Name = "номер_карточкиTextBox";
            this.номер_карточкиTextBox.Size = new System.Drawing.Size(265, 22);
            this.номер_карточкиTextBox.TabIndex = 12;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 247);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(дата_посещенияLabel);
            this.Controls.Add(this.дата_посещенияDateTimePicker);
            this.Controls.Add(жалобыLabel);
            this.Controls.Add(this.жалобыTextBox);
            this.Controls.Add(предварительный_диагнозLabel);
            this.Controls.Add(this.предварительный_диагнозTextBox);
            this.Controls.Add(врачLabel);
            this.Controls.Add(this.врачTextBox);
            this.Controls.Add(номер_карточкиLabel);
            this.Controls.Add(this.номер_карточкиTextBox);
            this.Controls.Add(this.сведение_о_посещаемостяхBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(518, 285);
            this.Name = "AttendanceForm";
            this.ShowIcon = false;
            this.Text = "Посещаемость";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_посещаемостяхBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_посещаемостяхBindingNavigator)).EndInit();
            this.сведение_о_посещаемостяхBindingNavigator.ResumeLayout(false);
            this.сведение_о_посещаемостяхBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Databases.HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource сведение_о_посещаемостяхBindingSource;
        private Databases.HospitalDataSetTableAdapters.Сведение_о_посещаемостяхTableAdapter сведение_о_посещаемостяхTableAdapter;
        private Databases.HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сведение_о_посещаемостяхBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сведение_о_посещаемостяхBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker дата_посещенияDateTimePicker;
        private System.Windows.Forms.TextBox жалобыTextBox;
        private System.Windows.Forms.TextBox предварительный_диагнозTextBox;
        private System.Windows.Forms.TextBox врачTextBox;
        private System.Windows.Forms.TextBox номер_карточкиTextBox;
    }
}