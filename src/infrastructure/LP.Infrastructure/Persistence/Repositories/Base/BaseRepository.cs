using LP.Application.Common.Interfaces.Repositories.Base;
using LP.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Infrastructure.Persistence.Repositories.Base
{
    public class BaseRepository<T>:IBaseRepository<T> where T : Person
    {
        protected static List<T> _objectList = new List<T>();
        public T Add(T student)
        {
            _objectList.Add(student);
            return student;
        }

        public T? GetById(Guid Id)
        {
            //LINQ
            return _objectList.
                Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(T student)
        {
            _objectList.Remove(student);
        }

        public T Update(T student)
        {
            var index = _objectList.IndexOf(student);
            if (index >= 0)
            {
                return _objectList[index] = student;
            }
            return student;
        }
    }
}
