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
    public class EducatorService:BaseService<Educator>,IEducatorService

    {
        private readonly IEducatorRepository _educatorRepository;
        public EducatorService(IEducatorRepository educatorRepository)
            : base(educatorRepository)
        {
            _educatorRepository = educatorRepository;
        }
        public List<Educator> GetList(string name)
        {
            return _educatorRepository.
                GetList(name);
        }
    }
}
