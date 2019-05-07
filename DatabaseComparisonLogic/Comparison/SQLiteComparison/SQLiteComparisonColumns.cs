using DatabaseComparisonLogic.Comparison.Querys;
using System.Collections.Generic;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения всех колонок двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonColumns : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonColumns(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
        {
            ElementName = "table";
            Compare();
        }
        /// <summary>
        /// Сравнение структур
        /// </summary>
        public new void Compare()
        {
            List<string> firstItemName = GetListName(new SQLiteQueryStruct(ElementName).SqlQuery, FirstBaseComparison);
            List<string> secondItemName = GetListName(new SQLiteQueryStruct(ElementName).SqlQuery, SecondBaseComparison);

            CompareListOfAllItems(NameSticking(FirstBaseComparison, firstItemName), NameSticking(SecondBaseComparison, secondItemName));
        }
        /// <summary>
        /// Список колонок из таблиц
        /// </summary>
        /// <param name="baseComparison">Коннектор к базе</param>
        /// <param name="tableName">Список таблиц</param>
        /// <returns>Список колонок</returns>
        private List<string> NameSticking(SQLiteConnection baseComparison, List<string> tableName)
        {
            List<string> columnName = new List<string>();
            foreach (string table in tableName)
            {
                List<string> proxyColumnName = GetListName(new SQLiteQueryColumn(table).SqlQuery, baseComparison);//TODO слабое звено
                foreach (string column in proxyColumnName)
                {
                    columnName.Add(table + '.' + column);
                }
            }
            return columnName;
        }
    }
}
