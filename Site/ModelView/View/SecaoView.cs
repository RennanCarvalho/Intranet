using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class SecaoView : BaseView<Secao>
    {
        public SecaoView(IRepo<Secao> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Secao, bool>>>
            {
                e => e.Ativo,
            };
            
            orderBys = new List<Func<IQueryable<Secao>, IOrderedQueryable<Secao>>>
            {
                query => query.OrderBy(e => e.Ordem)
            };

            includes = new Expression<Func<Secao, object>>[]
            {
                e => e.Andar
            };
        }
    }
}
