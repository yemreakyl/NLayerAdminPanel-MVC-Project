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
            _context.SaveChanges();
        }

        public void DeleteOne(T entity)
        {
            if (entity != null)
            {
                _set.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void DeleteOne(object entityKey)
        {
            if (entityKey != null)
            {
                DeleteOne(ReadOne(entityKey));
                _context.SaveChanges();
            }
        }

        public bool Exists(object entityKey)
        {
            return entityKey != null && ReadOne(entityKey) != null;
        }

        public bool Exists(T entity)
        {
            return entity != null && _set.Any(x => x.Equals(entity));
        }

        public void InsertMany(IQueryable<T> entities)
        {

            if (entities.Count() > 0)
            {
                _set.AddRange(entities);
                _context.SaveChanges();
            }
        }

        public void InsertOne(T entity)
        {
            if (entity != null)
            {
                _set.Add(entity);
                _context.SaveChanges();
            }

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
            if (entities.Count() > 0)
            {
                foreach (var entity in entities)
                {
                    _context.Entry(entity).State = EntityState.Modified;
                    _context.SaveChanges();
                }
            }
        }

        public void UpdateOne(object entityKey, T entity)
        {
            var orj_entity = ReadOne(entity);
            _context.Entry(orj_entity).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
