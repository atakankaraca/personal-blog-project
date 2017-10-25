﻿using BlogTemp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogTemp.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        BlogEntities context;
        protected readonly IDbSet<T> _dbset;

        public Repository()
        {
            context = new BlogEntities();
            _dbset = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _dbset.Where(predicate).AsQueryable();
            return query;
        }

        public T GetById(int id)
        {
            return _dbset.Find(id);
        }

        public T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public bool Delete(T entity)
        {
            _dbset.Remove(entity);
            var result = context.SaveChanges();

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
