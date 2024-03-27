using LP.Application.Common.Interfaces.Repositories;
using LP.Application.Common.Interfaces.Services;
using LP.Domain.Entities;
using LP.Infrastructure.Persistence.Repositories;
using LP.Infrastructure.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Infrastructure.Services
{
    public class HeadOfDService:BaseService<HeadOfDepartment>,IHeadOfDService
    {
        private readonly IHeadOfDRepository _headofdRepository;
        public HeadOfDService(IHeadOfDRepository headofdRepository)
            : base(headofdRepository)
        {
            _headofdRepository = headofdRepository;
        }
        public List<HeadOfDepartment> GetList(string name)
        {
            return _headofdRepository.
                GetList(name);
        }
    }
}
