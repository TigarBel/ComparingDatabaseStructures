using System;
using System.Data.SQLite;
using System.IO;

namespace DatabaseComparisonLogic.Connector
{
    /// <summary>
    /// Класс подключения к базе SQLite
    /// </summary>
    public class ConnectorSQLite
    {
        /// <summary>
        /// Пустой конструктор класса
        /// </summary>
        public ConnectorSQLite()
        {
            DataBaseFileName = "NONE";
            DataBase = new SQLiteConnection();
            Commad = new SQLiteCommand();
        }
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="dbFileName">Имя файла базы данных, с типом</param>
        public ConnectorSQLite(string dbFileName)
        {
            DataBaseFileName = dbFileName;
            Commad = new SQLiteCommand();
            try
            {
                if (File.Exists(dbFileName))
                {
                    DataBase = new SQLiteConnection("Data Source=" + DataBaseFileName + ";Version=3;");
                    Commad.Connection = DataBase;

                    Open();
                    Close();
                }
                else
                {
                    throw new Exception("This database file name not exists!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error connection");
            }
        }
        /// <summary>
        /// Подключится
        /// </summary>
        public void Open()
        {
            DataBase.Open();
            Console.WriteLine("database open");
        }
        /// <summary>
        /// Отключится
        /// </summary>
        public void Close()
        {
            DataBase.Close();
            Console.WriteLine("database close");
        }
        /// <summary>
        /// Имя файла базы данных, с типом
        /// </summary>
        public string DataBaseFileName { get; set; }
        /// <summary>
        /// Коннектор базы SQLite
        /// </summary>
        public SQLiteConnection DataBase { get; set; }
        /// <summary>
        /// Команда SQLite для выполнения запроса
        /// </summary>
        public SQLiteCommand Commad { get; set; }
    }
}
