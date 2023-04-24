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
    public partial class SickLeaveForm : Form
    {
        private static SickLeaveForm _instance;

        public SickLeaveForm()
        {
            InitializeComponent();
        }

        public static SickLeaveForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new SickLeaveForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void больничный_листBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.больничный_листBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void SickLeaveForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Больничный_лист". При необходимости она может быть перемещена или удалена.
            this.больничный_листTableAdapter.Fill(this.hospitalDataSet.Больничный_лист);

        }
    }
}
