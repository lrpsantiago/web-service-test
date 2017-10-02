using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebServiceTest.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public DbSet<T> Entities { get; private set; }

        public Repository(DbContext context)
        {
            this.Entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            this.Entities.Add(entity);
        }

        public void AddRange(IEnumerable<T> entitites)
        {
            this.Entities.AddRange(entitites);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return this.Entities.Where(predicate).ToList();
        }

        public T Get(params object[] primaryKeys)
        {
            return this.Entities.Find(primaryKeys);
        }

        public IEnumerable<T> GetAll()
        {
            return this.Entities.ToList();
        }

        public void Remove(T entity)
        {
            this.Entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entitites)
        {
            this.Entities.RemoveRange(entitites);
        }
    }
}
