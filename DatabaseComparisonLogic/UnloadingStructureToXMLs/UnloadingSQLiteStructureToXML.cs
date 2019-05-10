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

        }

        public UnloadingSQLiteStructureToXML(SQLiteConnection sQLiteConnection, string fileName)
        {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(_sqlQuery, sQLiteConnection);
            adapter.Fill(dataTable);
            dataTable.TableName = "DB";////////Заменить

            using (StreamWriter fs = new StreamWriter(fileName)) // XML File Path
            {
                dataTable.WriteXml(fs);
            }
        }
    }
}
