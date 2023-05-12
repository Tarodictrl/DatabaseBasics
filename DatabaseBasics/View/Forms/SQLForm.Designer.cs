namespace DatabaseBasics.View.Forms
{
    partial class SQLForm
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
            this.SQLTabControl = new System.Windows.Forms.TabControl();
            this.ExampleTabPage = new System.Windows.Forms.TabPage();
            this.SelectDataGridView = new System.Windows.Forms.DataGridView();
            this.RequestsGroupBox = new System.Windows.Forms.GroupBox();
            this.AttendanceRadioButton = new System.Windows.Forms.RadioButton();
            this.DoctorsRadioButton = new System.Windows.Forms.RadioButton();
            this.PatientsRadioButton = new System.Windows.Forms.RadioButton();
            this.SQLTabControl.SuspendLayout();
            this.ExampleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).BeginInit();
            this.RequestsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SQLTabControl
            // 
            this.SQLTabControl.Controls.Add(this.ExampleTabPage);
            this.SQLTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQLTabControl.Location = new System.Drawing.Point(0, 0);
            this.SQLTabControl.Name = "SQLTabControl";
            this.SQLTabControl.SelectedIndex = 0;
            this.SQLTabControl.Size = new System.Drawing.Size(800, 450);
            this.SQLTabControl.TabIndex = 0;
            // 
            // ExampleTabPage
            // 
            this.ExampleTabPage.Controls.Add(this.SelectDataGridView);
            this.ExampleTabPage.Controls.Add(this.RequestsGroupBox);
            this.ExampleTabPage.Location = new System.Drawing.Point(4, 25);
            this.ExampleTabPage.Name = "ExampleTabPage";
            this.ExampleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ExampleTabPage.Size = new System.Drawing.Size(792, 421);
            this.ExampleTabPage.TabIndex = 0;
            this.ExampleTabPage.Text = "Примеры запросов";
            this.ExampleTabPage.UseVisualStyleBackColor = true;
            // 
            // SelectDataGridView
            // 
            this.SelectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectDataGridView.Location = new System.Drawing.Point(3, 103);
            this.SelectDataGridView.Name = "SelectDataGridView";
            this.SelectDataGridView.RowHeadersWidth = 51;
            this.SelectDataGridView.RowTemplate.Height = 24;
            this.SelectDataGridView.Size = new System.Drawing.Size(786, 315);
            this.SelectDataGridView.TabIndex = 1;
            // 
            // RequestsGroupBox
            // 
            this.RequestsGroupBox.Controls.Add(this.AttendanceRadioButton);
            this.RequestsGroupBox.Controls.Add(this.DoctorsRadioButton);
            this.RequestsGroupBox.Controls.Add(this.PatientsRadioButton);
            this.RequestsGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RequestsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.RequestsGroupBox.Name = "RequestsGroupBox";
            this.RequestsGroupBox.Size = new System.Drawing.Size(786, 100);
            this.RequestsGroupBox.TabIndex = 0;
            this.RequestsGroupBox.TabStop = false;
            this.RequestsGroupBox.Text = "Запросы по данным";
            // 
            // AttendanceRadioButton
            // 
            this.AttendanceRadioButton.AutoSize = true;
            this.AttendanceRadioButton.Location = new System.Drawing.Point(326, 49);
            this.AttendanceRadioButton.Name = "AttendanceRadioButton";
            this.AttendanceRadioButton.Size = new System.Drawing.Size(155, 25);
            this.AttendanceRadioButton.TabIndex = 2;
            this.AttendanceRadioButton.TabStop = true;
            this.AttendanceRadioButton.Text = "Посещаемость";
            this.AttendanceRadioButton.UseVisualStyleBackColor = true;
            this.AttendanceRadioButton.CheckedChanged += new System.EventHandler(this.AttendanceRadioButton_CheckedChanged);
            // 
            // DoctorsRadioButton
            // 
            this.DoctorsRadioButton.AutoSize = true;
            this.DoctorsRadioButton.Location = new System.Drawing.Point(181, 50);
            this.DoctorsRadioButton.Name = "DoctorsRadioButton";
            this.DoctorsRadioButton.Size = new System.Drawing.Size(69, 20);
            this.DoctorsRadioButton.TabIndex = 1;
            this.DoctorsRadioButton.TabStop = true;
            this.DoctorsRadioButton.Text = "Врачи";
            this.DoctorsRadioButton.UseVisualStyleBackColor = true;
            this.DoctorsRadioButton.CheckedChanged += new System.EventHandler(this.DoctorsRadioButton_CheckedChanged);
            // 
            // PatientsRadioButton
            // 
            this.PatientsRadioButton.AutoSize = true;
            this.PatientsRadioButton.Location = new System.Drawing.Point(35, 51);
            this.PatientsRadioButton.Name = "PatientsRadioButton";
            this.PatientsRadioButton.Size = new System.Drawing.Size(94, 20);
            this.PatientsRadioButton.TabIndex = 0;
            this.PatientsRadioButton.TabStop = true;
            this.PatientsRadioButton.Text = "Пациенты";
            this.PatientsRadioButton.UseVisualStyleBackColor = true;
            this.PatientsRadioButton.CheckedChanged += new System.EventHandler(this.PatientsRadioButton_CheckedChanged);
            // 
            // SQLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SQLTabControl);
            this.Name = "SQLForm";
            this.Text = "Запросы";
            this.SQLTabControl.ResumeLayout(false);
            this.ExampleTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SelectDataGridView)).EndInit();
            this.RequestsGroupBox.ResumeLayout(false);
            this.RequestsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl SQLTabControl;
        private System.Windows.Forms.TabPage ExampleTabPage;
        private System.Windows.Forms.GroupBox RequestsGroupBox;
        private System.Windows.Forms.DataGridView SelectDataGridView;
        private System.Windows.Forms.RadioButton PatientsRadioButton;
        private System.Windows.Forms.RadioButton DoctorsRadioButton;
        private System.Windows.Forms.RadioButton AttendanceRadioButton;
    }
}