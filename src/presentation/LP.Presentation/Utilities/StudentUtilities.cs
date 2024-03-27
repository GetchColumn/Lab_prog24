using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Presentation.Utilities
{
    public static class StudentUtilities
    {
        public static Student Create(string name)
        {
            return new Domain.Entities.Student()
            {
                Name = name,
                Id = Guid.NewGuid(),
                Address = "Unknown",
                Age = null,

                Faculty = "Unknown",
                YearOfStudy = null,
                MajorScore = null,
                Group = "Unknown"
            };
        }
    }
}
