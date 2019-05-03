using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseComparisonLogic.Comparison.Writers
{
    /// <summary>
    /// Класс описания различия структур в консоли
    /// </summary>
    public class DifferenceTableWriter
    {
        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="comparable">Полученный класс сравнения</param>
        /// <param name="firstFileNameDB">Название первой базы данных</param>
        /// <param name="secondFileNameDB">Название второй базы данных</param>
        public DifferenceTableWriter(BaseComparison comparable, string firstFileNameDB, string secondFileNameDB)
        {
            Comparable = comparable;
            FirstFileNameDB = firstFileNameDB;
            SecondFileNameDB = secondFileNameDB;
        }
        /// <summary>
        /// Выписать список сравнений
        /// </summary>
        /// <param name="indent">Отступ</param>
        public void Write(int indent)
        {
            Console.WriteLine("{0,-" + Convert.ToString(indent * 3) + "} {1," + Convert.ToString(indent) + "} {2," + Convert.ToString(indent) + "}",
                "List of items", FirstFileNameDB, SecondFileNameDB);
            for (int i = 0; i < Comparable.ListOfAllItems.Count; i++)
            {
                Console.WriteLine("{0,-" + Convert.ToString(indent * 3) + "} {1," + Convert.ToString(indent) + "} {2," + Convert.ToString(indent) + "}",
                    Comparable.ListOfAllItems[i], Comparable.FirstListOfDifferences[i], Comparable.SecondListOfDifferences[i]);
            }
        }
        /// <summary>
        /// Полученный класс сравнения
        /// </summary>
        public BaseComparison Comparable { get; set; }
        /// <summary>
        /// Название первой базы данных
        /// </summary>
        public string FirstFileNameDB { get; set; }
        /// <summary>
        /// Название второй базы данных
        /// </summary>
        public string SecondFileNameDB { get; set; }
    }
}
