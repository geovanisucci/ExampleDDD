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
    public class EstadosApplication : ApplicationBase<Estados>, IEstadosApplication
    {
        private readonly IEstadosService _estadosService;

        public EstadosApplication(IEstadosService estadosService)
            : base(estadosService)
        {
            _estadosService = estadosService;
        }
    }
}
