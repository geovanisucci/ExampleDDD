using ExampleDDD.Application.Interfaces.IApplication.Base;
using ExampleDDD.Domain.Interfaces.IServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Application.Application.Base
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity>
        where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }
        public void Create(TEntity entity)
        {
            _serviceBase.Create(entity);
        }

        public void Delete(object id)
        {
            _serviceBase.Delete(id);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public TEntity Get(object id)
        {
            return _serviceBase.Get(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return _serviceBase.GetAll(expression);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }
    }
}
