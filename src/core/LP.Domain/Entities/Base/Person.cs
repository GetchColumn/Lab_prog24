using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Domain.Entities.Base
{
    /// <summary>
    /// Базовый класс - человек
    /// </summary>
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
            FirstName = "Fname";
            LastName = "Lname";
            Address = "Unknown";
            Age = null;
        }
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        public required string FirstName { get; set; }
        /// <summary>
        /// Имя человека
        /// </summary>
        public required string LastName { get; set; }
        /// <summary>
        /// Адрес проживания
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Возраст человека
        /// </summary>
        public int? Age { get; set; }
    }
}
