using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения индексов двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonIndex : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonIndex(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
        {
            ElementName = "trigger";
            //TODO дописать для первичных ключей
            Compare();
        }
    }
}
