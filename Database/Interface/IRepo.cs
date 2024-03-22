using System.Linq.Expressions;

namespace Interface
{
    public interface IRepo<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id, Expression<Func<T, object>>[]? includes = null);
        IEnumerable<T> GetAll(
            IList<Expression<Func<T, bool>>>? filters = null,
            IList<Func<IQueryable<T>,IOrderedQueryable<T>>>? orderBys = null,
            Expression<Func<T, object>>[]? includes = null);
    }
}
