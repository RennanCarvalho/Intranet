using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class AndarView : BaseView<Andar>
    {
        public AndarView(IRepo<Andar> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Andar, bool>>>
            {
                e => e.Ativo,
            };

            orderBys = new List<Func<IQueryable<Andar>, IOrderedQueryable<Andar>>>
            {
                query => query.OrderBy(e => e.Ordem)
            };
        }
    }
}
