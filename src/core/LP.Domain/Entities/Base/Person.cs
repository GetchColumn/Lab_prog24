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
        /// <summary>
        /// Уникальный идентификатор сущности
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Имя человека
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Адрес проживания
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Место работы
        /// </summary>
        public string PlaceOfWork { get; set; }
        /// <summary>
        /// Возраст человека
        /// </summary>
        public int Age { get; set; }
    }
}
