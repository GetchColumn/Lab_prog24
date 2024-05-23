using LP.Application.Common.Interfaces.Repositories;
using LP.Domain.Entities;
using LP.Infrastructure.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Infrastructure.Persistence.Repositories
{
    public class StudentRepository:BaseRepository<Student>,IStudentRepository
    {
        public List<Student> GetList(string name)
        {
            //if (string.IsNullOrEmpty(name))
            //{
            //    return new List<Student>();
            //}
            //LINQ
            return _objectList.
                Where(student => student.
            Name.ToLower().StartsWith((name ?? "").ToLower())).ToList();
        }
    }
}
