using ExampleDDD.Application.Application;
using ExampleDDD.Application.Application.Base;
using ExampleDDD.Application.Interfaces;
using ExampleDDD.Application.Interfaces.IApplication.Base;
using ExampleDDD.Data.Repositories;
using ExampleDDD.Data.Repositories.Base;
using ExampleDDD.Domain.Interfaces.IRepositories;
using ExampleDDD.Domain.Interfaces.IRepositories.Base;
using ExampleDDD.Domain.Interfaces.IServices;
using ExampleDDD.Domain.Interfaces.IServices.Base;
using ExampleDDD.Domain.Services;
using ExampleDDD.Domain.Services.Base;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.CrossCutting.DependencyInjection
{
    public class LoadInjection : NinjectModule
    {
        public override void Load()
        {
            /*
             * Configuração de injeção de dependência das classes Bases
             * */
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind(typeof(IApplicationBase<>)).To(typeof(ApplicationBase<>));

            Bind<IEstadosRepository>().To<EstadosRepository>();
            Bind<IEstadosService>().To<EstadosService>();
            Bind<IEstadosApplication>().To<EstadosApplication>();


        }
    }
}
