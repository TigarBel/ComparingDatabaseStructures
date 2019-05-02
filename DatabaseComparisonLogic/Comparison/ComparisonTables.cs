﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison
{
    public class ComparisonTables : Comparison, IComparable
    {
        private string _sqlQuery = "select * from sqlite_master where type = 'table'";

        public ComparisonTables()
        {
            FirstBaseComparison = new SQLiteConnection();
            SecondBaseComparison = new SQLiteConnection();
            StructureIsDifferent = true;
        }

        public ComparisonTables(SQLiteConnection firstSQLiteConnection, SQLiteConnection secondSQLiteConnection)
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
            List<string> firstTableName = GetListNameTables(FirstBaseComparison);
            List<string> secondTableName = GetListNameTables(SecondBaseComparison);
            ListOfAllItems = new List<string>();

            foreach (string tableName in firstTableName)
            {
                ListOfAllItems.Add(tableName);
            }
            foreach (string tableName in secondTableName)
            {
                if (ListOfAllItems.Find(str => str == tableName) != tableName)
                {
                    ListOfAllItems.Add(tableName);
                }
            }

            ListOfAllItems.Sort();

            foreach (string tableName in ListOfAllItems)
            {
                if (firstTableName.Find(str => str == tableName) == tableName)
                {
                    FirstListOfDifferences.Add(true);
                }
                else
                {
                    FirstListOfDifferences.Add(false);
                }

                if (secondTableName.Find(str => str == tableName) == tableName)
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
        private List<string> GetListNameTables(SQLiteConnection baseComparison)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(_sqlQuery, baseComparison);
            adapter.Fill(dataTable);
            List<string> tableName = new List<string>();

            if (dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    tableName.Add((string)dataTable.Rows[i].ItemArray[1]);
                }
            }
            else Console.WriteLine("Database is empty");
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
        public Boolean StructureIsDifferent { get; private set; }
    }
}