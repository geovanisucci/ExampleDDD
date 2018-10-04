using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Domain.Interfaces.IRepositories.Base
{
    public interface IRepositoryBase<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Provides the insert command.
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);
        /// <summary>
        /// Provides the update command.
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
        /// <summary>
        /// Provides the delete command.
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);
        /// <summary>
        /// Returns the entity by id using select.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity Get(object id);
        /// <summary>
        /// Returns a collection data with a select command.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Returns a collection data with a select command with a condition.
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        /// <summary>
        /// Provides the Dispose.
        /// </summary>
        void Dispose();
    }
}
