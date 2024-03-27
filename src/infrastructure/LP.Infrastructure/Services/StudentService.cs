using LP.Application.Common.Interfaces.Repositories;
using LP.Application.Common.Interfaces.Services;
using LP.Domain.Entities;
using LP.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Infrastructure.Services
{
    public class StudentService:BaseService<Student>,IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
            : base(studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetList(string name)
        {
            return _studentRepository.
                GetList(name);
        }
    }
}
