using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Wst.IRepository
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Add(IEnumerable<T> entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);
        void DeleteByID(int ID);
        IEnumerable<T> Get(Expression<Func<T, bool>> where);
        IEnumerable<T> GetAll();
        int Commit();
    }
}