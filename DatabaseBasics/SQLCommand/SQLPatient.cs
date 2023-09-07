using DatabaseBasics.SQLCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseBasics.SQLCommand
{
    public class SQLPatient : SQlBase
    {
        public string SQlCommand { get; }
            = "Select " +
              "ФИО, Адрес, Пол, Возраст, [Номер страхового полиса], [Дата заполнения]" +
              "From [Карточка пациента]";

        public string SelectAll { get; } = "select * from [Карточка пациента]";
    }
}
