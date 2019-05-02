using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.Connector
{
    public class ConnectorSQlite
    {
        public ConnectorSQlite()
        {
            DataBaseFileName = "NONE";
            DataBase = new SQLiteConnection();
            Commad = new SQLiteCommand();
        }

        public ConnectorSQlite(string dbFileName)
        {
            DataBaseFileName = dbFileName;
            try
            {
                DataBase = new SQLiteConnection("Data Source=" + DataBaseFileName + ";Version=3;");
                DataBase.Open();
                Commad.Connection = DataBase;
                Console.WriteLine("database open");

                DataBase.Close();
                Console.WriteLine("database close");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error connection");
            }
        }

        public string DataBaseFileName { get; set; }

        public SQLiteConnection DataBase { get; set; }

        public SQLiteCommand Commad { get; set; }
    }
}
