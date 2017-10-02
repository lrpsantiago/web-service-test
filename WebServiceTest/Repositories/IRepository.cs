using System;
using System.Collections.Generic;

namespace WebServiceTest.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(params object[] primaryKeys);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Func<T, bool> predicate);

        void Add(T entity);
        void AddRange(IEnumerable<T> entitites);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entitites);
    }
}