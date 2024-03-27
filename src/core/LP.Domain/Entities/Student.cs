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
        public short? MajorScore { get; set; }
        /// <summary>
        /// Группа
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// Факультет, на котором он обучается
        /// </summary>
        public string Faculty { get; set; }
        /// <summary>
        /// Год обучения (курс)
        /// </summary>
        public int? YearOfStudy { get; set; }

    }
}
