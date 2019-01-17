using ExampleDDD.Application.Application.Base;
using ExampleDDD.Application.Interfaces;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Application.Application
{
    public class MunicipiosApplication : ApplicationBase<Municipios>, IMunicipiosApplication
    {
        private readonly IMunicipiosService _municipiosService;

        public MunicipiosApplication(IMunicipiosService municipiosService)
            : base(municipiosService)
        {
            _municipiosService = municipiosService;
        }
    }
}
