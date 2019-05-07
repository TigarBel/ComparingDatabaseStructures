using DatabaseComparisonLogic.Comparison.Querys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison.SQLiteComparison
{
    /// <summary>
    /// Класс сравнения структуры определенного элемента
    /// </summary>
    public abstract class BaseSQLiteComparison : BaseComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="firstSQLiteConnection">Коннектор первой сравниваемой базы</param>
        /// <param name="secondSQLiteConnection">Коннектор второй сравниваемой базы</param>
        public BaseSQLiteComparison(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection)
        {
            FirstBaseComparison = firstSQLiteConnection;
            SecondBaseComparison = secondSQLiteConnection;
        }
        /// <summary>
        /// Сравнение структур
        /// </summary>
        public void Compare()
        {
            List<string> firstItemName = GetListName(new SQLiteQueryStruct(ElementName).SqlQuery, FirstBaseComparison);
            List<string> secondItemName = GetListName(new SQLiteQueryStruct(ElementName).SqlQuery, SecondBaseComparison);

            CompareListOfAllItems(firstItemName, secondItemName);
        }
        /// <summary>
        /// Выгрузка названий таблиц
        /// </summary>
        /// <param name="baseComparison">Коннектор к базе</param>
        /// <returns>Список таблиц</returns>
        protected List<string> GetListName(string query, SQLiteConnection baseComparison)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, baseComparison);
            adapter.Fill(dataTable);
            List<string> tableName = new List<string>();

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    tableName.Add((string)dataTable.Rows[i].ItemArray[0]);
                }
            }
            else Console.WriteLine("Database(" + baseComparison.DataSource + ") is empty: " + query);
            tableName.Sort();
            return tableName;
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
        public Boolean StructureIsDifferent
        {
            get
            {
                if (FirstListOfDifferences.Count == 0 || SecondListOfDifferences.Count == 0)
                {
                    return true;
                }
                for (int i = 0; i < FirstListOfDifferences.Count; i++)
                {
                    if (FirstListOfDifferences[i] != true || SecondListOfDifferences[i] != true)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        /// <summary>
        /// Наименование структуры
        /// </summary>
        protected string ElementName { get; set; }
    }
}
