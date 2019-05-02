using System;
using System.Data.SQLite;

namespace DatabaseComparisonLogic.Comparison
{
    public interface IComparable
    {
        /// <summary>
        /// Первая база к которой подключаемся
        /// </summary>
        SQLiteConnection FirstBaseComparison { get; set; }
        /// <summary>
        /// Вторая база к которой подключаемся
        /// </summary>
        SQLiteConnection SecondBaseComparison { get; set; }
        /// <summary>
        /// Отличается структура базы от другой базы
        /// </summary>
        Boolean StructureIsDifferent { get; }
    }
}
