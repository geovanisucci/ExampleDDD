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
    public class EstadosService : ServiceBase<Estados>, IEstadosService
    {
        private readonly IEstadosRepository _estadosRepository;

        public EstadosService(IEstadosRepository estadosRepository)
            : base(estadosRepository)
        {
            _estadosRepository = estadosRepository;
        }
    }
}
