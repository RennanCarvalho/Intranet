using Interface;
using System.Linq.Expressions;

namespace Site.Models
{
    public class BaseView<T> where T : class
    {
        readonly IRepo<T> _repo;
        internal List<Expression<Func<T, bool>>>? filters { get; set; }
        internal List<Func<IQueryable<T>, IOrderedQueryable<T>>>? orderBys { get; set; }
        internal Expression<Func<T, object>>[]? includes { get; set; }
        internal List<T> List { get; set; } = new List<T>();

        public BaseView(IRepo<T> repo)
        {
            Personalize();
            List = repo.GetAll(filters: filters, orderBys: orderBys, includes: includes).ToList();
        }
        public virtual void Personalize() { }
    }
}
