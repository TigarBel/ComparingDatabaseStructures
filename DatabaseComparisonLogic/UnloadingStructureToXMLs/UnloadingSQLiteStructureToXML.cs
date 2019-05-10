using DatabaseComparisonLogic.Connector;
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace DatabaseComparisonLogic.UnloadingStructureToXMLs
{
    public class UnloadingSQLiteStructureToXML
    {

        private string _sqlQuery = "SELECT * FROM sqlite_master";

        public UnloadingSQLiteStructureToXML()
        {
            Console.WriteLine("Read the file name of datebase: (database.db)");
            string dataBaseFileName = Console.ReadLine();
            Console.WriteLine("Read the file name there unloading SQLite DB structure into xml:");
            string fileName = Console.ReadLine();

            if (File.Exists(dataBaseFileName))
            {
                ConnectorSQLite connectorSQlite = new ConnectorSQLite(dataBaseFileName);

                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(_sqlQuery, connectorSQlite.DataBase);
                adapter.Fill(dataTable);
                dataTable.TableName = fileName;

                using (StreamWriter fs = new StreamWriter(fileName)) // XML File Path
                {
                    dataTable.WriteXml(fs);
                }
            }
            else
            {
                Console.WriteLine("This databas is missing!");
            }
        }
    }
}
