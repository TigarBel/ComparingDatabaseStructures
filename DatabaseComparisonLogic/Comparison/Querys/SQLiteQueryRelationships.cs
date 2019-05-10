namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс для хранения запроса вызова связей таблицы
    /// </summary>
    public class SQLiteQueryRelationships
    {
        /// <summary>
        /// Конструктор пустого объекта
        /// </summary>
        public SQLiteQueryRelationships()
        {
            SqlQuery = "SELECT \"table\", \"from\", \"to\" FROM PRAGMA_foreign_key_list('table')";
        }
        /// <summary>
        /// Конструктор заполненного объекта
        /// </summary>
        /// <param name="table">Название таблицы</param>
        public SQLiteQueryRelationships(string table)
        {
            SqlQuery = "SELECT \"table\", \"from\", \"to\" FROM PRAGMA_foreign_key_list('" + table + "')";
        }
        /// <summary>
        /// Запрос
        /// </summary>
        public string SqlQuery { get; set; }
    }
}
