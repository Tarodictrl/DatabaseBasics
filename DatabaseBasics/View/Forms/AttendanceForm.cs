﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseBasics.View.Forms
{
    public partial class AttendanceForm : Form
    {
        private static AttendanceForm _instance;

        public AttendanceForm()
        {
            InitializeComponent();
        }

        public static AttendanceForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new AttendanceForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }


        private void сведение_о_посещаемостяхBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сведение_о_посещаемостяхBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Сведение_о_посещаемостях". При необходимости она может быть перемещена или удалена.
            this.сведение_о_посещаемостяхTableAdapter.Fill(this.hospitalDataSet.Сведение_о_посещаемостях);

        }
    }
}
