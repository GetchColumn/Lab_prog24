using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Presentation.Utilities
{
    public class EducatorUtilities
    {
        public static Educator Create(string name)
        {
            return new Domain.Entities.Educator()
            {
                Name = name,
                Id = Guid.NewGuid(),
                Address = "Unknown",
                Age = null,

                Appointment = "Unknown",
                Department = "Unknown",
                WorkExperience = null
            };
        }
        public static Educator Create(string name, int age, string address, string appointment, string department
            , int workexperience)
        {
            return new Domain.Entities.Educator()
            {
                Name = name,
                Id = Guid.NewGuid(),
                Address = address,
                Age = age,

                Appointment = appointment,
                Department = department,
                WorkExperience = workexperience
            };
        }
    }
}
