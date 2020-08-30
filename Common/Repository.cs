using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Common
{
    public class Repository<T>  where T : class
    {
        protected readonly DbContext Context;
        private readonly DbSet<T> dbSet;

        private readonly IHttpContextAccessor httpContextAccessor;
        public Repository(DbContext context)
        {
            Context = context;
            dbSet = Context.Set<T>();
            httpContextAccessor = new HttpContextAccessor();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
  
        public T Get(params object[] id)
        {
            return dbSet.Find(id);
        }


        public IEnumerable<T> GetAll(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = dbSet;

            if (include != null)
            {
                query = include(query);
            }
            return query.ToList();
        }

       
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        
    }
}
