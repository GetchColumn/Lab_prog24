using LP.Application.Common.Interfaces.Repositories.Base;
using LP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Application.Common.Interfaces.Repositories
{
    public interface IEducatorRepository:IBaseRepository<Educator>
    {
        List<Educator> GetList(string name);
    }
}
