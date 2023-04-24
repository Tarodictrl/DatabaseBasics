namespace DatabaseBasics.View.Forms
{
    partial class SickLeaveForm
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
            System.Windows.Forms.Label начало_больничногоLabel;
            System.Windows.Forms.Label конец_больничногоLabel;
            System.Windows.Forms.Label врачLabel;
            System.Windows.Forms.Label номер_карточкиLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickLeaveForm));
            this.hospitalDataSet = new DatabaseBasics.Databases.HospitalDataSet();
            this.больничный_листBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.больничный_листTableAdapter = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.Больничный_листTableAdapter();
            this.tableAdapterManager = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager();
            this.больничный_листBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.больничный_листBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.начало_больничногоDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.конец_больничногоDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.врачTextBox = new System.Windows.Forms.TextBox();
            this.номер_карточкиTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            начало_больничногоLabel = new System.Windows.Forms.Label();
            конец_больничногоLabel = new System.Windows.Forms.Label();
            врачLabel = new System.Windows.Forms.Label();
            номер_карточкиLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничный_листBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничный_листBindingNavigator)).BeginInit();
            this.больничный_листBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(4, 38);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // начало_больничногоLabel
            // 
            начало_больничногоLabel.AutoSize = true;
            начало_больничногоLabel.Location = new System.Drawing.Point(4, 71);
            начало_больничногоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            начало_больничногоLabel.Name = "начало_больничногоLabel";
            начало_больничногоLabel.Size = new System.Drawing.Size(148, 16);
            начало_больничногоLabel.TabIndex = 3;
            начало_больничногоLabel.Text = "Начало больничного:";
            // 
            // конец_больничногоLabel
            // 
            конец_больничногоLabel.AutoSize = true;
            конец_больничногоLabel.Location = new System.Drawing.Point(4, 103);
            конец_больничногоLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            конец_больничногоLabel.Name = "конец_больничногоLabel";
            конец_больничногоLabel.Size = new System.Drawing.Size(138, 16);
            конец_больничногоLabel.TabIndex = 5;
            конец_больничногоLabel.Text = "Конец больничного:";
            // 
            // врачLabel
            // 
            врачLabel.AutoSize = true;
            врачLabel.Location = new System.Drawing.Point(4, 134);
            врачLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            врачLabel.Name = "врачLabel";
            врачLabel.Size = new System.Drawing.Size(43, 16);
            врачLabel.TabIndex = 7;
            врачLabel.Text = "Врач:";
            // 
            // номер_карточкиLabel
            // 
            номер_карточкиLabel.AutoSize = true;
            номер_карточкиLabel.Location = new System.Drawing.Point(4, 166);
            номер_карточкиLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_карточкиLabel.Name = "номер_карточкиLabel";
            номер_карточкиLabel.Size = new System.Drawing.Size(117, 16);
            номер_карточкиLabel.TabIndex = 9;
            номер_карточкиLabel.Text = "Номер карточки:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // больничный_листBindingSource
            // 
            this.больничный_листBindingSource.DataMember = "Больничный лист";
            this.больничный_листBindingSource.DataSource = this.hospitalDataSet;
            // 
            // больничный_листTableAdapter
            // 
            this.больничный_листTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Больничный_листTableAdapter = this.больничный_листTableAdapter;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.Карточка_пациентаTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = null;
            this.tableAdapterManager.Сведение_о_посещаемостяхTableAdapter = null;
            // 
            // больничный_листBindingNavigator
            // 
            this.больничный_листBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.больничный_листBindingNavigator.BindingSource = this.больничный_листBindingSource;
            this.больничный_листBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.больничный_листBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.больничный_листBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.больничный_листBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.больничный_листBindingNavigatorSaveItem});
            this.больничный_листBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.больничный_листBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.больничный_листBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.больничный_листBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.больничный_листBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.больничный_листBindingNavigator.Name = "больничный_листBindingNavigator";
            this.больничный_листBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.больничный_листBindingNavigator.Size = new System.Drawing.Size(451, 31);
            this.больничный_листBindingNavigator.TabIndex = 0;
            this.больничный_листBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // больничный_листBindingNavigatorSaveItem
            // 
            this.больничный_листBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.больничный_листBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("больничный_листBindingNavigatorSaveItem.Image")));
            this.больничный_листBindingNavigatorSaveItem.Name = "больничный_листBindingNavigatorSaveItem";
            this.больничный_листBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.больничный_листBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.больничный_листBindingNavigatorSaveItem.Click += new System.EventHandler(this.больничный_листBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничный_листBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(164, 34);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(265, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // начало_больничногоDateTimePicker
            // 
            this.начало_больничногоDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.больничный_листBindingSource, "Начало больничного", true));
            this.начало_больничногоDateTimePicker.Location = new System.Drawing.Point(164, 66);
            this.начало_больничногоDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.начало_больничногоDateTimePicker.Name = "начало_больничногоDateTimePicker";
            this.начало_больничногоDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.начало_больничногоDateTimePicker.TabIndex = 4;
            // 
            // конец_больничногоDateTimePicker
            // 
            this.конец_больничногоDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.больничный_листBindingSource, "Конец больничного", true));
            this.конец_больничногоDateTimePicker.Location = new System.Drawing.Point(164, 98);
            this.конец_больничногоDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.конец_больничногоDateTimePicker.Name = "конец_больничногоDateTimePicker";
            this.конец_больничногоDateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.конец_больничногоDateTimePicker.TabIndex = 6;
            // 
            // врачTextBox
            // 
            this.врачTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничный_листBindingSource, "Врач", true));
            this.врачTextBox.Location = new System.Drawing.Point(164, 130);
            this.врачTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.врачTextBox.Name = "врачTextBox";
            this.врачTextBox.Size = new System.Drawing.Size(265, 22);
            this.врачTextBox.TabIndex = 8;
            // 
            // номер_карточкиTextBox
            // 
            this.номер_карточкиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.больничный_листBindingSource, "Номер карточки", true));
            this.номер_карточкиTextBox.Location = new System.Drawing.Point(164, 162);
            this.номер_карточкиTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.номер_карточкиTextBox.Name = "номер_карточкиTextBox";
            this.номер_карточкиTextBox.Size = new System.Drawing.Size(265, 22);
            this.номер_карточкиTextBox.TabIndex = 10;
            // 
            // SickLeaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 222);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(начало_больничногоLabel);
            this.Controls.Add(this.начало_больничногоDateTimePicker);
            this.Controls.Add(конец_больничногоLabel);
            this.Controls.Add(this.конец_больничногоDateTimePicker);
            this.Controls.Add(врачLabel);
            this.Controls.Add(this.врачTextBox);
            this.Controls.Add(номер_карточкиLabel);
            this.Controls.Add(this.номер_карточкиTextBox);
            this.Controls.Add(this.больничный_листBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(466, 259);
            this.Name = "SickLeaveForm";
            this.ShowIcon = false;
            this.Text = "Больничные листы";
            this.Load += new System.EventHandler(this.SickLeaveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничный_листBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.больничный_листBindingNavigator)).EndInit();
            this.больничный_листBindingNavigator.ResumeLayout(false);
            this.больничный_листBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Databases.HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource больничный_листBindingSource;
        private Databases.HospitalDataSetTableAdapters.Больничный_листTableAdapter больничный_листTableAdapter;
        private Databases.HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator больничный_листBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton больничный_листBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker начало_больничногоDateTimePicker;
        private System.Windows.Forms.DateTimePicker конец_больничногоDateTimePicker;
        private System.Windows.Forms.TextBox врачTextBox;
        private System.Windows.Forms.TextBox номер_карточкиTextBox;
    }
}