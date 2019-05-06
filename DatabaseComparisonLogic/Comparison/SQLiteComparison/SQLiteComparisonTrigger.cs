using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения тригеров двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonTrigger : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonTrigger(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
        {
            ElementName = "trigger";
            Compare();
        }
    }
}
