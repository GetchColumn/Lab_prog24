using LP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Domain.Entities
{
    /// <summary>
    /// Класс преподавателя
    /// </summary>
    public class Educator:Person
    {
        /// <summary>
        /// Должность преподавателя
        /// </summary>
        public string Appointment { get; set; }
        /// <summary>
        /// Кафедра преподавателя
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Стаж преподавателя
        /// </summary>
        public int? WorkExperience { get; set; }

    }
}
