using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс для хранения запроса для конкретной таблицы
    /// </summary>
    public class SQLiteQueryColumn
    {
        /// <summary>
        /// Конструктор пустого объекта
        /// </summary>
        public SQLiteQueryColumn()
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('table')";
        }
        /// <summary>
        /// Конструктор заполненного объекта
        /// </summary>
        /// <param name="table">Название таблицы</param>
        public SQLiteQueryColumn(string table)
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('" + table + "')";
        }
        /// <summary>
        /// Запрос для вывода колонок из таблицы
        /// </summary>
        public string SqlQuery { get; set; }
    }
}
