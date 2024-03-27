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
    }
}
