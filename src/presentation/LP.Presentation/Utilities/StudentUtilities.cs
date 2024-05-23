using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
        public static Student Create(string name, int age,
            string address, string faculty, int yearofstudy, short majorscore, string group)
        {
            return new Domain.Entities.Student()
            {
                Name = name,
                Id = Guid.NewGuid(),
                Address = address,
                Age = age,

                Faculty = faculty,
                YearOfStudy = yearofstudy,
                MajorScore = majorscore,
                Group = group
            };
        }
    }
}
