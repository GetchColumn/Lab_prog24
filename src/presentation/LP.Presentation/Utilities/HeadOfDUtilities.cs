using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Presentation.Utilities
{
    public class HeadOfDUtilities
    {
        public static HeadOfDepartment Create(string name)
        {
            return new Domain.Entities.HeadOfDepartment()
            {
                Name = name,
                Id = Guid.NewGuid(),
                Address = "Unknown",
                Age = null,

                Department = "Unknown",
                NumOfEmployees = null,
                WorkExperience = null
            };
        }
    }
}
