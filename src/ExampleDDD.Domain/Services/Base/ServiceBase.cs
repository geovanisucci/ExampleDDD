using ExampleDDD.Domain.Interfaces.IRepositories.Base;
using ExampleDDD.Domain.Interfaces.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.Services.Base
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public void Create(TEntity entity)
        {
            _repositoryBase.Create(entity);
        }

        public void Delete(object id)
        {
            _repositoryBase.Delete(id);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }

        public TEntity Get(object id)
        {
            return _repositoryBase.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return _repositoryBase.GetAll(expression);
        }

        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }
    }
}
