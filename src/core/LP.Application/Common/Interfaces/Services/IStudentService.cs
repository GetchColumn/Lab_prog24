using LP.Application.Common.Interfaces.Services.Base;
using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Application.Common.Interfaces.Services
{
    public interface IStudentService:IBaseService<Student>
    {
        List<Student> GetList(string name);
    }
}
