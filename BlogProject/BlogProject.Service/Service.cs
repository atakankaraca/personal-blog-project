using BlogTemp.Data;
using BlogTemp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogTemp.Service
{
    public class Service<T> where T : class
    {
        private BlogEntities context;
        private IRepository<T> _repository;

        public Service()
        {
            context = new BlogEntities();
            _repository = new Repository<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _repository.GetAll(predicate);
            return query;
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public T Add(T entity)
        {
            return _repository.Add(entity);
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public bool Delete(T entity)
        {
          return _repository.Delete(entity);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
