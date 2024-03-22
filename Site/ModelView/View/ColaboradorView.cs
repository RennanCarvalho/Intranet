using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class ColaboradorView : BaseView<Colaborador>
    {
        public ColaboradorView(IRepo<Colaborador> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Colaborador, bool>>>
            {
                e => e.Ativo,
            };
            
            orderBys = new List<Func<IQueryable<Colaborador>, IOrderedQueryable<Colaborador>>>
            {
                query => query.OrderBy(e => e.Ordem).ThenBy(e => e.Nome)
            };

            includes = new Expression<Func<Colaborador, object>>[]
            {
                e => e.Cargo,
                e => e.Secao
            };
        }
    }
}
