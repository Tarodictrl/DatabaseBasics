using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DatabaseBasics.SQLCommand
{
    public class SQLMedics : SQlBase
    {
        public string SQlCommandProfit { get; set; }
            = $"SELECT Врачи.id, Врачи.ФИО, [Карточка пациента].ФИО, COUNT([Карточка пациента].ФИО) [Количество посещений] " +
            "FROM Врачи INNER JOIN [Сведение о посещаемостях] ON [Сведение о посещаемостях].Врач = Врачи.id " +
            "INNER JOIN [Карточка пациента] ON [Карточка пациента].id = [Сведение о посещаемостях].[Номер карточки] " +
            "WHERE Врачи.ФИО LIKE @fio and DATEDIFF(day, [Сведение о посещаемостях].[Дата посещения], GetDate()) < @Countdays " +
            "GROUP BY Врачи.id, Врачи.ФИО, [Карточка пациента].ФИО, [Дата рождения] ";

        public SqlCommand SQlCommandProfitWithParameters(string fio,
                                                     string countDays,
                                                     bool flag1,
                                                     bool flag2,
                                                     string value)
        {
            if (flag1)
            {
                SQlCommandProfit += " HAVING COUNT([Карточка пациента].ФИО) > @Amount";
            }

            if (flag2)
            {
                SQlCommandProfit += " ORDER BY COUNT([Карточка пациента].ФИО) DESC";
            }

            SqlCommand command = connection.CreateCommand();

            command.CommandText = SQlCommandProfit;
            command.Parameters.AddWithValue("@fio", fio + '%');
            command.Parameters.AddWithValue("@Countdays", countDays);

            if (flag1)
                try
                {
                    command.Parameters.Add("@amount", SqlDbType.Money).Value =
                    Double.Parse(value);
                }
                catch
                {
                    MessageBox.Show("Прибыль в условии должна быть задана числом",
                    "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            return command;
        }
    }
}
