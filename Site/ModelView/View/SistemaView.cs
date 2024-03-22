using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class SistemaView : BaseView<Sistema>
    {
        public SistemaView(IRepo<Sistema> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Sistema, bool>>>
            {
                e => e.Ativo,
            };

            orderBys = new List<Func<IQueryable<Sistema>, IOrderedQueryable<Sistema>>>
            {
                query => query.OrderBy(e => e.Ordem)
            };
        }
    }
}
