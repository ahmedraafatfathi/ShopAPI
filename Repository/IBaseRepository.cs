using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository<T> where T : IBaseEntity
    {
        int GetCount();
        Task<List<T>> GetAllSkipTake(int pageSize, int page);
        Task<List<T>> GetAllSkipTake(int pageSize, int page, string[] navProperties = null);

        Task<List<T>> GetAll();
        Task<T> GetById(object Id);

        //Task<T> GetByIdNotGuid(object Id);

        Task<List<T>> Where(Expression<Func<T, bool>> exp, string[] navProperties = null);
        Task<List<T>> WhereOrdered(Expression<Func<T, bool>> exp,
            Expression<Func<T, object>> keyselector);
        Task<T> GetFirstWhereOrdered(Expression<Func<T, bool>> exp,
            Expression<Func<T, object>> keyselector);

        Task<bool> Insert(T entity);
        Task<bool> InsertRange(List<T> entities);
        bool Update(T entity);
        bool Delete(T entity);
    }

}
