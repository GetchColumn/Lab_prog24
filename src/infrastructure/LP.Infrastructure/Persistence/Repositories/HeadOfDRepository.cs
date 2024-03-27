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
    public class HeadOfDRepository:BaseRepository<HeadOfDepartment>, IHeadOfDRepository
    {
        public List<HeadOfDepartment> GetList(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return new List<HeadOfDepartment>();
            }
            //LINQ
            return _objectList.
                Where(headofd => headofd.
            Name.ToLower().StartsWith(name.ToLower())).ToList();
        }
    }
}
