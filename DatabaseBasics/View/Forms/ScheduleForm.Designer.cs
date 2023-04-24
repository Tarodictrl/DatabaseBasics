namespace DatabaseBasics.View.Forms
{
    partial class ScheduleForm
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
            System.Windows.Forms.Label время_работыLabel;
            System.Windows.Forms.Label участокLabel;
            System.Windows.Forms.Label дни_приёмаLabel;
            System.Windows.Forms.Label часы_приёмаLabel;
            System.Windows.Forms.Label номер_кабинетаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.hospitalDataSet = new DatabaseBasics.Databases.HospitalDataSet();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.расписаниеTableAdapter = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.РасписаниеTableAdapter();
            this.tableAdapterManager = new DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager();
            this.расписаниеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.расписаниеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.время_работыTextBox = new System.Windows.Forms.TextBox();
            this.участокTextBox = new System.Windows.Forms.TextBox();
            this.дни_приёмаTextBox = new System.Windows.Forms.TextBox();
            this.часы_приёмаTextBox = new System.Windows.Forms.TextBox();
            this.номер_кабинетаTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            время_работыLabel = new System.Windows.Forms.Label();
            участокLabel = new System.Windows.Forms.Label();
            дни_приёмаLabel = new System.Windows.Forms.Label();
            часы_приёмаLabel = new System.Windows.Forms.Label();
            номер_кабинетаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingNavigator)).BeginInit();
            this.расписаниеBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(16, 43);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // время_работыLabel
            // 
            время_работыLabel.AutoSize = true;
            время_работыLabel.Location = new System.Drawing.Point(16, 75);
            время_работыLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            время_работыLabel.Name = "время_работыLabel";
            время_работыLabel.Size = new System.Drawing.Size(102, 16);
            время_работыLabel.TabIndex = 3;
            время_работыLabel.Text = "Время работы:";
            // 
            // участокLabel
            // 
            участокLabel.AutoSize = true;
            участокLabel.Location = new System.Drawing.Point(16, 107);
            участокLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            участокLabel.Name = "участокLabel";
            участокLabel.Size = new System.Drawing.Size(64, 16);
            участокLabel.TabIndex = 5;
            участокLabel.Text = "Участок:";
            // 
            // дни_приёмаLabel
            // 
            дни_приёмаLabel.AutoSize = true;
            дни_приёмаLabel.Location = new System.Drawing.Point(16, 139);
            дни_приёмаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дни_приёмаLabel.Name = "дни_приёмаLabel";
            дни_приёмаLabel.Size = new System.Drawing.Size(87, 16);
            дни_приёмаLabel.TabIndex = 7;
            дни_приёмаLabel.Text = "Дни приёма:";
            // 
            // часы_приёмаLabel
            // 
            часы_приёмаLabel.AutoSize = true;
            часы_приёмаLabel.Location = new System.Drawing.Point(16, 171);
            часы_приёмаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            часы_приёмаLabel.Name = "часы_приёмаLabel";
            часы_приёмаLabel.Size = new System.Drawing.Size(95, 16);
            часы_приёмаLabel.TabIndex = 9;
            часы_приёмаLabel.Text = "Часы приёма:";
            // 
            // номер_кабинетаLabel
            // 
            номер_кабинетаLabel.AutoSize = true;
            номер_кабинетаLabel.Location = new System.Drawing.Point(16, 203);
            номер_кабинетаLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            номер_кабинетаLabel.Name = "номер_кабинетаLabel";
            номер_кабинетаLabel.Size = new System.Drawing.Size(118, 16);
            номер_кабинетаLabel.TabIndex = 11;
            номер_кабинетаLabel.Text = "Номер кабинета:";
            // 
            // hospitalDataSet
            // 
            this.hospitalDataSet.DataSetName = "HospitalDataSet";
            this.hospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.hospitalDataSet;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DatabaseBasics.Databases.HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Больничный_листTableAdapter = null;
            this.tableAdapterManager.ВрачиTableAdapter = null;
            this.tableAdapterManager.Карточка_пациентаTableAdapter = null;
            this.tableAdapterManager.РасписаниеTableAdapter = this.расписаниеTableAdapter;
            this.tableAdapterManager.Сведение_о_посещаемостяхTableAdapter = null;
            // 
            // расписаниеBindingNavigator
            // 
            this.расписаниеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.расписаниеBindingNavigator.BindingSource = this.расписаниеBindingSource;
            this.расписаниеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.расписаниеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.расписаниеBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.расписаниеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.расписаниеBindingNavigatorSaveItem});
            this.расписаниеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.расписаниеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.расписаниеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.расписаниеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.расписаниеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.расписаниеBindingNavigator.Name = "расписаниеBindingNavigator";
            this.расписаниеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.расписаниеBindingNavigator.Size = new System.Drawing.Size(405, 31);
            this.расписаниеBindingNavigator.TabIndex = 0;
            this.расписаниеBindingNavigator.Text = "bindingNavigator1";
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
            // расписаниеBindingNavigatorSaveItem
            // 
            this.расписаниеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.расписаниеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("расписаниеBindingNavigatorSaveItem.Image")));
            this.расписаниеBindingNavigatorSaveItem.Name = "расписаниеBindingNavigatorSaveItem";
            this.расписаниеBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 28);
            this.расписаниеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.расписаниеBindingNavigatorSaveItem.Click += new System.EventHandler(this.расписаниеBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(149, 39);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(221, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // время_работыTextBox
            // 
            this.время_работыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "Время работы", true));
            this.время_работыTextBox.Location = new System.Drawing.Point(149, 71);
            this.время_работыTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.время_работыTextBox.Name = "время_работыTextBox";
            this.время_работыTextBox.Size = new System.Drawing.Size(221, 22);
            this.время_работыTextBox.TabIndex = 4;
            // 
            // участокTextBox
            // 
            this.участокTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "Участок", true));
            this.участокTextBox.Location = new System.Drawing.Point(149, 103);
            this.участокTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.участокTextBox.Name = "участокTextBox";
            this.участокTextBox.Size = new System.Drawing.Size(221, 22);
            this.участокTextBox.TabIndex = 6;
            // 
            // дни_приёмаTextBox
            // 
            this.дни_приёмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "Дни приёма", true));
            this.дни_приёмаTextBox.Location = new System.Drawing.Point(149, 135);
            this.дни_приёмаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.дни_приёмаTextBox.Name = "дни_приёмаTextBox";
            this.дни_приёмаTextBox.Size = new System.Drawing.Size(221, 22);
            this.дни_приёмаTextBox.TabIndex = 8;
            // 
            // часы_приёмаTextBox
            // 
            this.часы_приёмаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "Часы приёма", true));
            this.часы_приёмаTextBox.Location = new System.Drawing.Point(149, 167);
            this.часы_приёмаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.часы_приёмаTextBox.Name = "часы_приёмаTextBox";
            this.часы_приёмаTextBox.Size = new System.Drawing.Size(221, 22);
            this.часы_приёмаTextBox.TabIndex = 10;
            // 
            // номер_кабинетаTextBox
            // 
            this.номер_кабинетаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.расписаниеBindingSource, "Номер кабинета", true));
            this.номер_кабинетаTextBox.Location = new System.Drawing.Point(149, 199);
            this.номер_кабинетаTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.номер_кабинетаTextBox.Name = "номер_кабинетаTextBox";
            this.номер_кабинетаTextBox.Size = new System.Drawing.Size(221, 22);
            this.номер_кабинетаTextBox.TabIndex = 12;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 241);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(время_работыLabel);
            this.Controls.Add(this.время_работыTextBox);
            this.Controls.Add(участокLabel);
            this.Controls.Add(this.участокTextBox);
            this.Controls.Add(дни_приёмаLabel);
            this.Controls.Add(this.дни_приёмаTextBox);
            this.Controls.Add(часы_приёмаLabel);
            this.Controls.Add(this.часы_приёмаTextBox);
            this.Controls.Add(номер_кабинетаLabel);
            this.Controls.Add(this.номер_кабинетаTextBox);
            this.Controls.Add(this.расписаниеBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ScheduleForm";
            this.ShowIcon = false;
            this.Text = "Расписание";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingNavigator)).EndInit();
            this.расписаниеBindingNavigator.ResumeLayout(false);
            this.расписаниеBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Databases.HospitalDataSet hospitalDataSet;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private Databases.HospitalDataSetTableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private Databases.HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator расписаниеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton расписаниеBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox время_работыTextBox;
        private System.Windows.Forms.TextBox участокTextBox;
        private System.Windows.Forms.TextBox дни_приёмаTextBox;
        private System.Windows.Forms.TextBox часы_приёмаTextBox;
        private System.Windows.Forms.TextBox номер_кабинетаTextBox;
    }
}