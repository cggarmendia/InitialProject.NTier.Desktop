using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using IP_NTier.Domain.Entities;

namespace IP_NTier.Domain.Repository
{
    public interface IRepository<TEntity>
        where TEntity : IEntity
    {
        IQueryable<TEntity> AsQueryable();

        void Delete(TEntity entityToDelete);

        IEnumerable<TEntity> GetByFilters (Expression<Func<TEntity, bool>> filter = null, 
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, 
            string includeProperties = "");

        List<TEntity> GetAll();

        TEntity GetByPKs(params object[] keyValues);

        void Add(TEntity entity);

        void Update(TEntity entity);
    }
}
