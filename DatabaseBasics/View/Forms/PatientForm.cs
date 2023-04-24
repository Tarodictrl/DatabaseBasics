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
            this.Validate();
            this.карточка_пациентаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

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
    }
}
