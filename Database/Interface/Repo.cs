using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private readonly Context _context;
        private readonly DbSet<T> _dbSet;
        public Repo()
        {
            _context = new Context();
            _dbSet = _context.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.AddAsync(entity);
            _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var register = _dbSet.Find(id);
            if (register != null)
            {
                _dbSet.Remove(register);
                _context.SaveChangesAsync();
            }
        }
        public T GetById(int id, params Expression<Func<T, object>>[]? includes)
        {
            IQueryable<T> query = _dbSet;

            if(includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            return query.FirstOrDefault(e => EF.Property<int>(e, "Id") == id);
        }

        public IEnumerable<T> GetAll
            (IList<Expression<Func<T, bool>>>? filters = null,
             IList<Func<IQueryable<T>, IOrderedQueryable<T>>>? orderBys = null,
             Expression<Func<T, object>>[]? includes = null)
        {
            IQueryable<T> query = _dbSet;

            if(includes != null)
                foreach (var include in includes)
                    query = query.Include(include);

            if (filters != null)
                foreach (var filter in filters)
                    query = query.Where(filter);

            if(orderBys != null)
                foreach (var orderBy in orderBys)
                    query = orderBy(query);

            return query.ToList();
        }
    }
}
