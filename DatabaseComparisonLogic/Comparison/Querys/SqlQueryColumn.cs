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
    public class SqlQueryColumn
    {
        /// <summary>
        /// Конструктор пустого объекта
        /// </summary>
        public SqlQueryColumn()
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('table')";
        }
        /// <summary>
        /// Конструктор заполненного объекта
        /// </summary>
        /// <param name="table">Название таблицы</param>
        public SqlQueryColumn(string table)
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('" + table + "')";
        }
        /// <summary>
        /// Запрос для вывода колонок из таблицы
        /// </summary>
        public string SqlQuery { get; set; }
    }
}
