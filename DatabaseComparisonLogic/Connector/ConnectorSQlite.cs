using System;
using System.Data.SQLite;

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
            Commad = new SQLiteCommand();
            try
            {
                DataBase = new SQLiteConnection("Data Source=" + DataBaseFileName + ";Version=3;");
                Commad.Connection = DataBase;

                Open();
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error connection");
            }
        }

        public void Open()
        {
            DataBase.Open();
            Console.WriteLine("database open");
        }

        public void Close()
        {
            DataBase.Close();
            Console.WriteLine("database close");
        }

        public string DataBaseFileName { get; set; }

        public SQLiteConnection DataBase { get; set; }

        public SQLiteCommand Commad { get; set; }
    }
}
