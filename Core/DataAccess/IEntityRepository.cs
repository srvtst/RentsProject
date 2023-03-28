using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, new()
    {
        //Linq yapısında expression var. Yani p=>p.categoryıd==2 yazılışı linq de Expression<Func<T,bool>> filter=null bunu ifade eder.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}