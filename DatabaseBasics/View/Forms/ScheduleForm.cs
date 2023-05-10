using System;
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
    public partial class ScheduleForm : Form
    {
        private static ScheduleForm _instance;

        public ScheduleForm()
        {
            InitializeComponent();
        }

        public static ScheduleForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new ScheduleForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void расписаниеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.расписаниеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Расписание". При необходимости она может быть перемещена или удалена.
            this.расписаниеTableAdapter.Fill(this.hospitalDataSet.Расписание);

        }
    }
}
