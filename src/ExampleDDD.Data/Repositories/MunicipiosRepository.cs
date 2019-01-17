using ExampleDDD.Data.Repositories.Base;
using ExampleDDD.Domain.Entities;
using ExampleDDD.Domain.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Data.Repositories
{
    public class MunicipiosRepository : RepositoryBase<Municipios>, IMunicipiosRepository
    {
    }
}
