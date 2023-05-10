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
    public partial class PatientForm : Form
    {
        private static PatientForm _instance;

        public PatientForm()
        {
            InitializeComponent();
        }

        public static PatientForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new PatientForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void карточка_пациентаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.карточка_пациентаBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.hospitalDataSet);
                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Карточка_пациента". При необходимости она может быть перемещена или удалена.
            this.карточка_пациентаTableAdapter.Fill(this.hospitalDataSet.Карточка_пациента);

        }

        private void карточка_пациентаDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var sex = карточка_пациентаDataGridView.Rows[e.RowIndex].Cells["dataGridViewComboBoxColumn"].Value;
            switch (sex)
            {
                case "Мужской":
                    e.CellStyle.BackColor = Color.SkyBlue;
                    break;
                case "Женский":
                    e.CellStyle.BackColor = Color.Pink;
                    break;
                default:
                    e.CellStyle.BackColor = Color.LightGreen;
                    break;
    
            }
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
                        карточка_пациентаBindingSource.Filter = GetSelectedFieldName() + "='" + toolStripTextBox1.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" + err.Message);
                    }
            }
            else
                карточка_пациентаBindingSource.Filter = "";
            if (карточка_пациентаBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                карточка_пациентаBindingSource.Filter = "";
                checkBox1.Checked = false;
            }
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
                indexPos = карточка_пациентаBindingSource.Find(GetSelectedFieldName(), toolStripTextBox1.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                карточка_пациентаBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких пациентов нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                карточка_пациентаBindingSource.Position = 0;
            }
        }

        string GetSelectedFieldName()
        {
            return карточка_пациентаDataGridView.Columns[карточка_пациентаDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }
    }
}
