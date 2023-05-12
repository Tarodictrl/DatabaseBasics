using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseBasics.View.Forms
{
    public partial class SQLForm : Form
    {
        private static SQLForm _instance;

        public SQLForm()
        {
            InitializeComponent();
        }

        public static SQLForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed) _instance = new SQLForm();
                return _instance;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void PatientsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM [Карточка пациента]";
            SelectDataGridView.DataSource = FillDataGridView(sql);
        }

        private void DoctorsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sql = "SELECT * FROM Врачи INNER JOIN Расписание ON Расписание.id = Врачи.Расписание ";
            SelectDataGridView.DataSource = FillDataGridView(sql);
        }

        private void AttendanceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var sql = "SELECT sp.id," +
                    "[Дата посещения]," +
                    "Жалобы," +
                    "[Предварительный диагноз]," +
                    "dc.ФИО AS Врач," +
                    "cp.ФИО AS Пациент" +
                    " FROM [Сведение о посещаемостях] as sp" +
                    " INNER JOIN Врачи AS dc ON dc.id = sp.Врач" +
                    " INNER JOIN [Карточка пациента] AS cp ON cp.id = sp.[Номер карточки]";
            SelectDataGridView.DataSource = FillDataGridView(sql);
        }

        DataTable FillDataGridView(string sqlSelect)
        {
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.ПоликлиникаConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
