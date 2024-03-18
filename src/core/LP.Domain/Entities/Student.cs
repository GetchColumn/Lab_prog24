using LP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Domain.Entities
{
    /// <summary>
    /// Класс студента
    /// </summary>
    public class Student:Person
    {
        /// <summary>
        /// Основная оценка: 2- неуспевающий ... 5- отличник
        /// </summary>
        public int MajorScore { get; set; }
        /// <summary>
        /// Степень ленивости студента (в %)
        /// </summary>
        public float? LazyCoefficient { get; set; }
        /// <summary>
        /// Факультет, на котором он обучается
        /// </summary>
        public required string Faculty { get; set; }
        /// <summary>
        /// Год обучения (курс)
        /// </summary>
        public required int YearOfStudy { get; set; }

    }
}
