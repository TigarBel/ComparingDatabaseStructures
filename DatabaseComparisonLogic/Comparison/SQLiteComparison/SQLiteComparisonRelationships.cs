using DatabaseComparisonLogic.Comparison.Querys;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения связей двух баз данны SQLite
    /// </summary>
    public class SQLiteComparisonRelationships : BaseSQLiteComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Конектор первой базы данных</param>
        /// <param name="secondSQLiteConnection">Конектор второй базы данных</param>
        public SQLiteComparisonRelationships(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection) : base(firstSQLiteConnection, secondSQLiteConnection)
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
        /// Список связей из таблиц
        /// </summary>
        /// <param name="baseComparison">Коннектор к базе</param>
        /// <param name="tableName">Список таблиц</param>
        /// <returns>Список колонок</returns>
        private List<string> NameSticking(SQLiteConnection baseComparison, List<string> tableName)
        {
            List<string> columnName = new List<string>();
            foreach (string table in tableName)
            {
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(new SQLiteQueryRelationships(table).SqlQuery, baseComparison);//TODO слабое звено
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count != 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        columnName.Add(table + '.' + dataTable.Rows[i].ItemArray[1] + " REFERENCES " + dataTable.Rows[i].ItemArray[0] + " (" + dataTable.Rows[i].ItemArray[2] + ')');
                    }
                }
            }
            return columnName;
        }
    }
}
