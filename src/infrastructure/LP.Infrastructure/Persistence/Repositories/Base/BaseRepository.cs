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
        public T Add(T person)
        {
            _objectList.Add(person);
            return person;
        }

        public T? GetById(Guid Id)
        {
            //LINQ
            return _objectList.
                Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(T person)
        {
            _objectList.Remove(person);
        }

        public T Update(T person)
        {
            var index = _objectList.IndexOf(person);
            if (index >= 0)
            {
                return _objectList[index] = person;
            }
            return person;
        }
    }
}
