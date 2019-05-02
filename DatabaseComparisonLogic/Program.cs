using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;

namespace DatabaseComparisonLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLiteConnection _dataBase = new SQLiteConnection();
            SQLiteCommand __dataBaseCommand = new SQLiteCommand();
            string _dbFileName;

            Console.WriteLine("Read the file nameb of datebase:");
            _dbFileName = Console.ReadLine();

            try
            {
                _dataBase = new SQLiteConnection("Data Source=" + _dbFileName + ";Version=3;");
                _dataBase.Open();
                __dataBaseCommand.Connection = _dataBase;
                Console.WriteLine("database open");

                ReadDataBase(_dataBase);

                _dataBase.Close();
                Console.WriteLine("database close");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Error connection");
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
