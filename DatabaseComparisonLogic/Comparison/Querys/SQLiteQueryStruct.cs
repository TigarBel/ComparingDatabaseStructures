namespace DatabaseComparisonLogic.Comparison.Querys
{
    /// <summary>
    /// Класс хранения запроса для SQLite по вызова таблицы структуры
    /// </summary>
    public class SQLiteQueryStruct
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="nameItem">Название элемента структуры</param>
        public SQLiteQueryStruct(string nameItem)
        {
            SqlQuery = "SELECT name FROM sqlite_master WHERE type = '" + nameItem + "'";
        }
        /// <summary>
        /// Запрос
        /// </summary>
        public string SqlQuery { get; private set; }
    }
}
