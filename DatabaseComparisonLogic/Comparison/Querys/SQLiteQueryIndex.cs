using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс для хранения запроса вызова индексов таблицы
    /// </summary>
    public class SQLiteQueryIndex
    {
        /// <summary>
        /// Конструктор пустого объекта
        /// </summary>
        public SQLiteQueryIndex()
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('table') WHERE pk = 1";
        }
        /// <summary>
        /// Конструктор заполненного объекта
        /// </summary>
        /// <param name="table">Название таблицы</param>
        public SQLiteQueryIndex(string table)
        {
            SqlQuery = "SELECT name FROM PRAGMA_TABLE_INFO('" + table + "') WHERE pk = 1";
        }
        /// <summary>
        /// Запрос
        /// </summary>
        public string SqlQuery { get; set; }
    }
}
