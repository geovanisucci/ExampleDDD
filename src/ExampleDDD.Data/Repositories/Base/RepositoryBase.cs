using ExampleDDD.Data.Context;
using ExampleDDD.Domain.Interfaces.IRepositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDDD.Data.Repositories.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable
        where TEntity : class
    {
        public void Create(TEntity entity)
        {
            using (var _context = new DBFullManagementRRSantosContext())
            {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();               
            }
        }

        public void Delete(object id)
        {
            using (var _context = new DBFullManagementRRSantosContext())
            {
                var entity = _context.Set<TEntity>().Find(id);
                _context.Set<TEntity>().Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public TEntity Get(object id)
        {
            TEntity entity = null;
            using (var _context = new DBFullManagementRRSantosContext())
            {
                entity = _context.Set<TEntity>().Find(id);
            }

            return entity;
        }

        public IEnumerable<TEntity> GetAll()
        {
            IEnumerable<TEntity> result = null;
            using (var _context = new DBFullManagementRRSantosContext())
            {
                result = _context.Set<TEntity>().AsNoTracking().ToList();
            }

            return result;
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            IEnumerable<TEntity> result = null;
            using (var _context = new DBFullManagementRRSantosContext())
            {
                result = _context.Set<TEntity>().AsNoTracking().Where(expression).ToList();
            }

            return result;
        }

        public void Update(TEntity entity)
        {
            using (var _context = new DBFullManagementRRSantosContext())
            {
                _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
