using System;   
using System.Windows.Forms;

namespace DatabaseBasics.View.Forms
{
    public partial class MedicForm : Form
    {
        private static MedicForm _instance;

        public MedicForm()
        {
            InitializeComponent();
        }

        public static MedicForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new MedicForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void врачиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.врачиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MedicForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.hospitalDataSet.Врачи);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox1.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos = врачиBindingSource.Find(GetSelectedFieldName(), toolStripTextBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                врачиBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких врачей нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                врачиBindingSource.Position = 0;
            }
        }

        string GetSelectedFieldName()
        {
            return врачиDataGridView.Columns[врачиDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (toolStripTextBox1.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        врачиBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBox1.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
            }
            else
                врачиBindingSource.Filter = "";
            if (врачиBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                врачиBindingSource.Filter = "";
                checkBox1.Checked = false;
            }
        }
    }
}
