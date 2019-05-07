using DatabaseComparisonLogic.Comparison.Querys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения ограничений двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonConstraints : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonConstraints(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
        {
            ElementName = "table";
            Compare();
        }
        /// <summary>
        /// Сравнение структур
        /// </summary>
        public new void Compare()
        {
            List<string> firstItemName = GetListName(new SQLiteQueryStruct("table").SqlQuery, FirstBaseComparison);
            List<string> secondItemName = GetListName(new SQLiteQueryStruct("table").SqlQuery, SecondBaseComparison);

            firstItemName = NameSticking(FirstBaseComparison, firstItemName);
            secondItemName = NameSticking(SecondBaseComparison, secondItemName);

            CompareListOfAllItems(firstItemName, secondItemName);
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
                    if (GetConstraint(new SQLiteQueryConstraint(table, column).SqlQueryNotNull, baseComparison) == "1")
                    {
                        columnName.Add(table + '.' + column + " NOTNULL");
                    }
                    if (GetConstraint(new SQLiteQueryConstraint(table, column).SqlQueryDefault, baseComparison) != "")
                    {
                        columnName.Add(table + '.' + column + " DEFAULT " + GetConstraint(new SQLiteQueryConstraint(table, column).SqlQueryDefault, baseComparison));
                    }
                    if (GetConstraint(new SQLiteQueryConstraint(table, column).SqlQueryPK, baseComparison) == "1")
                    {
                        columnName.Add(table + '.' + column + " PK");
                    }
                }
            }
            return columnName;
        }
        /// <summary>
        /// Выдать ограничение
        /// </summary>
        /// <param name="query">Запрос вызова ограничения</param>
        /// <param name="baseComparison">Конектор базы</param>
        /// <returns>Ограничение</returns>
        private string GetConstraint(string query, SQLiteConnection baseComparison)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, baseComparison);
            adapter.Fill(dataTable);

            return Convert.ToString(dataTable.Rows[0].ItemArray[0]);
        }
    }
}
