using LP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Domain.Entities
{
    /// <summary>
    /// Класс заведующего кафедрой
    /// </summary>
    public class HeadOfDepartment:Person
    {
        /// <summary>
        /// Кафедра, которой заведует
        /// </summary>
        public string Department { get; set; }
        /// <summary>
        /// Количество сотрудников в подчинении
        /// </summary>
        public long? NumOfEmployees { get; set; }
        /// <summary>
        /// Стаж работы
        /// </summary>
        public int? WorkExperience { get; set; }
    }
}
