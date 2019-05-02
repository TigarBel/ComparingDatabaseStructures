using System;
using System.Collections.Generic;

namespace DatabaseComparisonLogic.Comparison
{
    /// <summary>
    /// Класс списка различий двух баз данных
    /// </summary>
    public abstract class Comparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Comparison()
        {
            ListOfAllItems = new List<string>();
            FirstListOfDifferences = new List<bool>();
            SecondListOfDifferences = new List<bool>();
        }
        /// <summary>
        /// Список названия элементов
        /// </summary>
        public List<string> ListOfAllItems { get; set; }
        /// <summary>
        /// Первый списоксопоставления
        /// </summary>
        public List<Boolean> FirstListOfDifferences { get; set; }
        /// <summary>
        /// Второй список сопоставления
        /// </summary>
        public List<Boolean> SecondListOfDifferences { get; set; }
    }
}
