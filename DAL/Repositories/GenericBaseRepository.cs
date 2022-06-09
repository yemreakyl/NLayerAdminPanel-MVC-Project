using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
 
    public class GenericBaseRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected DbSet<T> _set;

        public GenericBaseRepository(DbContext context)
        {
            _context = context;
            _set =context.Set<T>() ;
        }

        public void DeleteMany(IQueryable<T> entities)
        {
           _set.RemoveRange(entities);
        }

        public void DeleteOne(T entity)
        {
            _set.Remove(entity);
        }

        public void DeleteOne(object entityKey)
        {
            var Entity=ReadOne(entityKey);
            _set.Remove(Entity);
        }

        public bool Exists(object entityKey)
        {
            var Entity = _set.Find(entityKey);
            if (Entity==null)
            {
                return false;
            }
            return true;
        }

        public bool Exists(T entity)
        {
            return _set.Any(x => x.Equals(entity));
        }

        public void InsertMany(IQueryable<T> entities)
        {
            _set.AddRange(entities);
        }

        public void InsertOne(T entity)
        {
            _set.Add(entity);
            
        }

        public IQueryable<T> ReadMany(Expression<Func<T, bool>> expression = null)
        {
            if (expression == null)
            {
                return _set;
            }
            else
            {
                return _set.Where(expression);
            }
        }

        public T ReadOne(object entityKey)
        {
          return _set.Find(entityKey);
        }

        public void UpdateMany(IQueryable<T> entities)
        {
            foreach (var entity in entities)
            {
                _context.Entry(entity).State= EntityState.Modified;
            }
        }

        public void UpdateOne(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
