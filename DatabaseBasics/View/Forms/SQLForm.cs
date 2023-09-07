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
using DatabaseBasics.SQLCommand;

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

        private void SelectProfitButton_Click(object sender, EventArgs e)
        {
            var sqlMedics = new SQLMedics();

            if (string.IsNullOrEmpty(SecondNameTextBox.Text))
            {
                MessageBox.Show("Необходимо ввести ФИО Врача",
                                "Внимание",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }
            if (SelectMoreCheckBox.Checked && string.IsNullOrEmpty(SelectProfitMoreTextBox.Text))
            {
                MessageBox.Show("Не указано количество посещений в условии",
                                "Внимание",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                SelectMoreCheckBox.Checked = false;

                return;
            }

            if (PerMonthRadioButton.Checked)
            {
                dataGridView1.DataSource
                    = sqlMedics.FillDataGridView(
                        sqlMedics.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "32",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
            else if (PerYearRadioButton.Checked)
            {
                dataGridView1.DataSource
                    = sqlMedics.FillDataGridView(
                        sqlMedics.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "366",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
            else
            {
                dataGridView1.DataSource
                    = sqlMedics.FillDataGridView(
                        sqlMedics.SQlCommandProfitWithParameters(SecondNameTextBox.Text,
                            "9000",
                            SelectMoreCheckBox.Checked,
                            SortDescCheckBox.Checked,
                            SelectProfitMoreTextBox.Text));
            }
        }

        
        private void InsertPatients()
        {
            string sqlInsert = "INSERT INTO [Карточка пациента] (ФИО, Адрес, Пол, Возраст, [Номер страхового полиса], [Дата заполнения]) " +
                "VALUES(@fio, @address, @sex, @age, @number, @date);";

            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.ПоликлиникаConnectionString);

            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.Add("@number", SqlDbType.BigInt).Value =
                                        Int64.Parse(textBox13.Text);
            command.Parameters.AddWithValue("@fio", textBox12.Text);
            command.Parameters.AddWithValue("@address", textBox9.Text);
            command.Parameters.AddWithValue("@sex", textBox11.Text);
            command.Parameters.AddWithValue("@age", textBox10.Text);
            command.Parameters.Add("@date", SqlDbType.Date).Value =
                                        DateTime.Parse(dateTimePicker1.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            connection.Close();
        }

        private void UpdatePatients()
        {
            string sqlUpdate = "Update [Карточка пациента] set {0} Where Id = @id";
            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.ПоликлиникаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
                sqlValues += "ФИО=@fio,";
            if (!String.IsNullOrEmpty(textBox12.Text))
                sqlValues += "Адрес=@address,";
            if (!String.IsNullOrEmpty(textBox11.Text))
                sqlValues += "Пол=@sex,";
            if (!String.IsNullOrEmpty(textBox10.Text))
                sqlValues += "Возраст=@age,";
            if (!String.IsNullOrEmpty(textBox13.Text))
                sqlValues += "[Номер страхового полиса]=@number,";
            if (!String.IsNullOrEmpty(dateTimePicker1.Text))
                sqlValues += "[Дата заполнения]=@date";
            Console.WriteLine(String.Format(sqlUpdate, sqlValues));
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            command.Parameters.AddWithValue("@fio", textBox12.Text);
            command.Parameters.AddWithValue("@address", textBox9.Text);
            command.Parameters.AddWithValue("@sex", textBox11.Text);
            command.Parameters.AddWithValue("@age", textBox10.Text);
            command.Parameters.Add("@number", SqlDbType.BigInt).Value =
                                        Int64.Parse(textBox13.Text);
            command.Parameters.Add("@date", SqlDbType.Date).Value =
                DateTime.Parse(dateTimePicker1.Text);
            
            command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(IdClientsTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Close();
        }

        private void DeletePatients()
        {
            string sqlDelete = "Delete from [Карточка пациента] where Id = @id";

            SqlConnection connection = new
                        SqlConnection(Properties.Settings.Default.ПоликлиникаConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;

            command.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(IdClientsTextBox.Text);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }

            connection.Close();
        }
        
        private void ExecuteRequestButton_Click(object sender, EventArgs e)
        {
            if (InsertRadioButton.Checked)
            {
                InsertPatients();
            }
            else if (UpdateRadioButton.Checked)
            {
                UpdatePatients();
            }
            else if (DeleteRadioButton.Checked)
            {
                DeletePatients();
            }
            else
            {
                MessageBox.Show("Вы не выбрали действие", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sqlPatient = new SQLPatient();
            dataGridView3.DataSource = sqlPatient.FillDataGridView(sqlPatient.SelectAll);
        }
    }
}
