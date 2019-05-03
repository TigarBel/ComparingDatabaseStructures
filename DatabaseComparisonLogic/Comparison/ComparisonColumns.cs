using DatabaseComparisonLogic.Comparison.Querys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison
{
    public class ComparisonColumns : BaseComparison, IComparable
    {
        private string _sqlQueryTable = "SELECT name FROM sqlite_master WHERE type = 'table'";

        private SqlQueryColumn _sqlQueryColumn = new SqlQueryColumn();

        public ComparisonColumns()
        {
            FirstBaseComparison = new SQLiteConnection();
            SecondBaseComparison = new SQLiteConnection();
            StructureIsDifferent = true;
        }

        public ComparisonColumns(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection)
        {
            FirstBaseComparison = firstSQLiteConnection;
            SecondBaseComparison = secondSQLiteConnection;
            StructureIsDifferent = true;
            Compare();
        }
        /// <summary>
        /// Сравнение структур
        /// </summary>
        public void Compare()
        {
            List<string> firstTableName = GetListName(FirstBaseComparison, _sqlQueryTable);
            List<string> secondTableName = GetListName(SecondBaseComparison, _sqlQueryTable);
            ListOfAllItems = new List<string>();
            List<string> firstColumnName = NameSticking(FirstBaseComparison, firstTableName);
            List<string> secondColumnName = NameSticking(SecondBaseComparison, secondTableName);

            foreach (string columnName in firstColumnName)
            {
                ListOfAllItems.Add(columnName);
            }
            foreach (string columnName in secondColumnName)
            {
                if (ListOfAllItems.Find(str => str == columnName) != columnName)
                {
                    ListOfAllItems.Add(columnName);
                }
            }

            ListOfAllItems.Sort();

            foreach (string columnName in ListOfAllItems)
            {
                if (firstColumnName.Find(str => str == columnName) == columnName)
                {
                    FirstListOfDifferences.Add(true);
                }
                else
                {
                    FirstListOfDifferences.Add(false);
                }

                if (secondColumnName.Find(str => str == columnName) == columnName)
                {
                    SecondListOfDifferences.Add(true);
                }
                else
                {
                    SecondListOfDifferences.Add(false);
                }
            }

            for (int i = 0; i < FirstListOfDifferences.Count; i++)
            {
                if (FirstListOfDifferences[i] != true || SecondListOfDifferences[i] != true)
                {
                    StructureIsDifferent = false;
                    break;
                }
            }
        }
        /// <summary>
        /// Выгрузка названий таблиц
        /// </summary>
        /// <param name="baseComparison">Коннектор к базе</param>
        /// <returns>Список таблиц</returns>
        private List<string> GetListName(SQLiteConnection baseComparison, string sqlQueryTable)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQueryTable, baseComparison);
            adapter.Fill(dataTable);
            List<string> tableName = new List<string>();

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    tableName.Add((string)dataTable.Rows[i].ItemArray[0]);
                }
            }
            else Console.WriteLine("Database is empty");
            tableName.Sort();
            return tableName;
        }
        /// <summary>
        /// Список колонок из таблиц
        /// </summary>
        /// <param name="tableName">Список таблиц</param>
        /// <returns>Список колонок</returns>
        private List<string> NameSticking(SQLiteConnection baseComparison, List<string> tableName)
        {
            List<string> columnName = new List<string>();
            foreach (string table in tableName)
            {
                _sqlQueryColumn = new SqlQueryColumn(table);
                List<string> proxyColumnName = GetListName(baseComparison, _sqlQueryColumn.SqlQuery);
                foreach(string column in proxyColumnName)
                {
                    columnName.Add(table + '.' + column);
                }
            }
            return columnName;
        }
        /// <summary>
        /// Первая база к которой подключаемся
        /// </summary>
        public SQLiteConnection FirstBaseComparison { get; set; }
        /// <summary>
        /// Вторая база к которой подключаемся
        /// </summary>
        public SQLiteConnection SecondBaseComparison { get; set; }
        /// <summary>
        /// Отличается структура базы от другой базы
        /// </summary>
        public Boolean StructureIsDifferent { get; private set; }
    }
}
