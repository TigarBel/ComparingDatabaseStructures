namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс для хранения запроса вызова наименования колонок таблицы
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
        /// Запрос
        /// </summary>
        public string SqlQuery { get; set; }
    }
}
