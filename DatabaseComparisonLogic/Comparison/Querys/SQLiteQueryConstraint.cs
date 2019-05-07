using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс для хранения запроса вызова ограничения колонок таблицы
    /// </summary>
    public class SQLiteQueryConstraint
    {
        /// <summary>
        /// Название таблицы
        /// </summary>
        private string _table;
        /// <summary>
        /// Название столбца
        /// </summary>
        private string _column;
        /// <summary>
        /// Конструктор пустого объекта
        /// </summary>
        public SQLiteQueryConstraint()
        {
            _table = "table";
        }
        /// <summary>
        /// Конструктор заполненного объекта
        /// </summary>
        /// <param name="table">Название таблицы</param>
        /// <param name="column">Название столбца</param>
        public SQLiteQueryConstraint(string table, string column)
        {
            _table = table;
            _column = column;
        }
        /// <summary>
        /// Запрос ограничения не нулевое
        /// </summary>
        public string SqlQueryNotNull
        {
            get { return "SELECT " + '"' + "notnull" + '"' + " FROM PRAGMA_TABLE_INFO('" + _table + "') WHERE name = '" + _column + "'"; }
        }
        /// <summary>
        /// Запрос ограничения поумолчанию
        /// </summary>
        public string SqlQueryDefault
        {
            get { return "SELECT " + '"' + "dflt_value" + '"' + " FROM PRAGMA_TABLE_INFO('" + _table + "') WHERE name = '" + _column + "'"; }
        }
        /// <summary>
        /// Запрос ограничения первичный ключ
        /// </summary>
        public string SqlQueryPK
        {
            get { return "SELECT " + '"' + "pk" + '"' + " FROM PRAGMA_TABLE_INFO('" + _table + "') WHERE name = '" + _column + "'"; }
        }
    }
}
