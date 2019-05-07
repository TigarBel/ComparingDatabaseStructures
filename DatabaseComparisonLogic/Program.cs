using System;
using System.Data.SQLite;
using System.IO;
using System.Data;
using DatabaseComparisonLogic.Connector;
using DatabaseComparisonLogic.Comparison.Writers;
using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.Comparison.Querys;

namespace DatabaseComparisonLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the file name of datebase: (database.db)");
            string firstDataBaseFileName = Console.ReadLine();
            Console.WriteLine("Read the file name of datebase: (database.db)");
            string secondDataBaseFileName = Console.ReadLine();

            ConnectorSQLite firstConnectorSQlite;
            ConnectorSQLite secondConnectorSQlite;
            if (File.Exists(firstDataBaseFileName) && File.Exists(secondDataBaseFileName))
            {
                firstConnectorSQlite = new ConnectorSQLite(firstDataBaseFileName);
                secondConnectorSQlite = new ConnectorSQLite(secondDataBaseFileName);

                SQLiteComparisonColumns sQLiteComparisonColumns = new SQLiteComparisonColumns(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);
                DifferenceTableWriter differenceTableWriter = new DifferenceTableWriter(sQLiteComparisonColumns, firstDataBaseFileName, secondDataBaseFileName);
                differenceTableWriter.Write(11);

                SQLiteComparisonIndexs sQLiteComparisonIndexs = new SQLiteComparisonIndexs(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);
                differenceTableWriter = new DifferenceTableWriter(sQLiteComparisonIndexs, firstDataBaseFileName, secondDataBaseFileName);
                differenceTableWriter.Write(11);

                SQLiteComparisonConstraints sQLiteComparisonConstraints = new SQLiteComparisonConstraints(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);
                differenceTableWriter = new DifferenceTableWriter(sQLiteComparisonConstraints, firstDataBaseFileName, secondDataBaseFileName);

                //string str = @"D:\Downloads\gnivc\DatabaseComparisonLogic\DatabaseComparisonLogic\bin\Debug\db11.xml";//Заменить
                //UnloadingStructureToXML unloading = new UnloadingStructureToXML(secondConnectorSQlite.DataBase, str);
            }
            else
            {
                Console.WriteLine("These databases are missing!");
            }

            Console.ReadKey();
        }

        //static void ReadDataBase(SQLiteConnection dataBase)
        //{
        //    DataTable dTable = new DataTable();
        //    String sqlQuery;

        //    sqlQuery = "SELECT * FROM DRIVERS";
        //    SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dataBase);
        //    adapter.Fill(dTable);
        //    if (dTable.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dTable.Rows.Count; i++)
        //        {
        //            Console.Write(dTable.Rows[i].ItemArray[0]);
        //            Console.WriteLine(dTable.Rows[i].ItemArray[1]);
        //        }
        //    }
        //    else
        //        Console.WriteLine("Database is empty");
        //}
    }
}
