using System;
using DatabaseComparisonLogic.UnitControls;

namespace DatabaseComparisonLogic
{
    public class Program
    {
        static string _exit = "";

        static void Main(string[] args)
        {
            try
            {
                Console.Write("help - detailed information.");
                while (_exit != "exit")
                {
                    Console.Write("\n>");
                    _exit = Console.ReadLine();
                    UnitControl unitControl = new UnitControl(_exit);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
