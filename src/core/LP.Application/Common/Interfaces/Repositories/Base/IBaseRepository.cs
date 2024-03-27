using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Application.Common.Interfaces.Repositories.Base
{
    public interface IBaseRepository<T>
    {
        T Add(T person);
        T Update(T person);
        void Remove(T person);
        T? GetById(Guid Id);
    }
}
