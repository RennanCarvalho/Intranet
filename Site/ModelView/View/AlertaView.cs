using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class AlertaView : BaseView<Alerta>
    {
        public AlertaView(IRepo<Alerta> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Alerta, bool>>>
            {
                e => e.Ativo,
                e => e.DataInicio >= DateTime.Now,
                e => e.DataFim <= DateTime.Now,
            };

            orderBys = new List<Func<IQueryable<Alerta>, IOrderedQueryable<Alerta>>>
            {
                query => query.OrderBy(e => e.Ordem)
            };
        }
    }
}
