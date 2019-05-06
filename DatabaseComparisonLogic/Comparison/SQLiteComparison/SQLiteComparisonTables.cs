using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения таблиц двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonTables : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonTables(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
        {
            ElementName = "table";
            Compare();
        }
    }
}
