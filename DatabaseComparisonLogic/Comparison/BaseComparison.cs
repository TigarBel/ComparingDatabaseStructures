using System;
using System.Collections.Generic;

namespace DatabaseComparisonLogic.Comparison
{
    /// <summary>
    /// Класс списка различий двух баз данных
    /// </summary>
    public abstract class BaseComparison
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        public BaseComparison()
        {
            ListOfAllItems = new List<string>();
            FirstListOfDifferences = new List<bool>();
            SecondListOfDifferences = new List<bool>();
        }
        /// <summary>
        /// Список названия элементов
        /// </summary>
        public List<string> ListOfAllItems { get; private set; }
        /// <summary>
        /// Первый списоксопоставления
        /// </summary>
        public List<bool> FirstListOfDifferences { get; private set; }
        /// <summary>
        /// Второй список сопоставления
        /// </summary>
        public List<bool> SecondListOfDifferences { get; private set; }
        /// <summary>
        /// Сравнение структур
        /// </summary>
        protected void CompareListOfAllItems(List<string> firstListOfAllItems, List<string> secondListOfAllItems)
        {
            foreach (string item in firstListOfAllItems)
            {
                ListOfAllItems.Add(item);
            }
            foreach (string item in secondListOfAllItems)
            {
                if (ListOfAllItems.Find(str => str == item) != item)
                {
                    ListOfAllItems.Add(item);
                }
            }

            ListOfAllItems.Sort();

            foreach (string item in ListOfAllItems)
            {
                if (firstListOfAllItems.Find(str => str == item) == item)
                {
                    FirstListOfDifferences.Add(true);
                }
                else
                {
                    FirstListOfDifferences.Add(false);
                }

                if (secondListOfAllItems.Find(str => str == item) == item)
                {
                    SecondListOfDifferences.Add(true);
                }
                else
                {
                    SecondListOfDifferences.Add(false);
                }
            }
        }
    }
}
