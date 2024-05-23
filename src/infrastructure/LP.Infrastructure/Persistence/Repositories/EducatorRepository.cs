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
    public class EducatorRepository:BaseRepository<Educator>, IEducatorRepository
    {
        public List<Educator> GetList(string name)
        {
            //if (string.IsNullOrEmpty(name))
            //{
            //    return new List<Educator>();
            //}
            //LINQ
            return _objectList.
                Where(educator => educator.
            Name.ToLower().StartsWith((name ?? "").ToLower())).ToList();
        }
    }
}
