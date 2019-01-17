using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.IRepositories;
using ExampleDDD.Domain.Interfaces.IServices;
using ExampleDDD.Domain.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.Services
{
    public class MunicipiosService : ServiceBase<Municipios> , IMunicipiosService
    {
        private readonly IMunicipiosRepository _municipiosRepository;

        public MunicipiosService(IMunicipiosRepository municipiosRepository)
            : base(municipiosRepository)
        {
            _municipiosRepository = municipiosRepository;
        }
    }
}
