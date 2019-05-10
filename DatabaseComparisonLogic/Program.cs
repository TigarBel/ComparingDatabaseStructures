using System;
using System.Data.SQLite;
using System.IO;
using System.Data;
using DatabaseComparisonLogic.Connector;
using DatabaseComparisonLogic.Comparison.Writers;
using DatabaseComparisonLogic.Comparison.SQLiteComparison;
using DatabaseComparisonLogic.UnitControls;

namespace DatabaseComparisonLogic
{
    public class Program
    {
        static string _exit = "";

        static void Main(string[] args)
        {
            Console.Write("help - подробная информация\n");
            while (_exit != "exit")
            {
                Console.Write("\n>");
                _exit = Console.ReadLine();
                UnitControl unitControl = new UnitControl(_exit);
            }
        }
    }
}
