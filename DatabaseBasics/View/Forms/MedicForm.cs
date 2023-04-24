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
            this.Validate();
            this.врачиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalDataSet);

        }

        private void MedicForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalDataSet.Врачи". При необходимости она может быть перемещена или удалена.
            this.врачиTableAdapter.Fill(this.hospitalDataSet.Врачи);

        }
    }
}
