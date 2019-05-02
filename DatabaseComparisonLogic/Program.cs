using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using DatabaseComparisonLogic.Connector;

namespace DatabaseComparisonLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read the file nameb of datebase:");
            string dataBaseFileName = Console.ReadLine();

            ConnectorSQlite connectorSQlite = new ConnectorSQlite(dataBaseFileName);

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
