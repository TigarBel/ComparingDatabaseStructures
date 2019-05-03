using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using DatabaseComparisonLogic.Connector;
using DatabaseComparisonLogic.Comparison;
using DatabaseComparisonLogic.Comparison.Writers;

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

            ConnectorSQlite firstConnectorSQlite;
            ConnectorSQlite secondConnectorSQlite;
            if (File.Exists(firstDataBaseFileName) && File.Exists(secondDataBaseFileName))
            {
                firstConnectorSQlite = new ConnectorSQlite(firstDataBaseFileName);
                secondConnectorSQlite = new ConnectorSQlite(secondDataBaseFileName);

                ComparisonTables comparisonTables = new ComparisonTables(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);
                ComparisonColumns comparisonColumns = new ComparisonColumns(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);

                DifferenceTableWriter differenceTableWriter = new DifferenceTableWriter(comparisonColumns, firstDataBaseFileName, secondDataBaseFileName);
                differenceTableWriter.Write(11);

                ComparisonViews comparisonViews = new ComparisonViews(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);

                differenceTableWriter.Comparable = comparisonViews;
                differenceTableWriter.Write(11);

                ComparisonIndexes comparisonIndexes = new ComparisonIndexes(firstConnectorSQlite.DataBase, secondConnectorSQlite.DataBase);

                differenceTableWriter.Comparable = comparisonIndexes;
                differenceTableWriter.Write(11);
            }
            else
            {
                Console.WriteLine("These databases are missing!");
            }

            Console.ReadKey();
        }

        static void ReadDataBase(SQLiteConnection dataBase)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            sqlQuery = "SELECT * FROM DRIVERS";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, dataBase);
            adapter.Fill(dTable);
            if (dTable.Rows.Count > 0)
            {
                for (int i = 0; i < dTable.Rows.Count; i++)
                {
                    Console.Write(dTable.Rows[i].ItemArray[0]);
                    Console.WriteLine(dTable.Rows[i].ItemArray[1]);
                }
            }
            else
                Console.WriteLine("Database is empty");


            //m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, author TEXT, book TEXT)";
            //m_sqlCmd.ExecuteNonQuery();
        }
    }
}
