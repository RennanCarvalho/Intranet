using Interface;
using Model;
using System.Linq.Expressions;

namespace Site.Models
{
    public class AniversarianteView : BaseView<Colaborador>
    {
        public AniversarianteView(IRepo<Colaborador> repo) : base(repo) { }
        public override void Personalize()
        {
            filters = new List<Expression<Func<Colaborador, bool>>>
            {
                e => e.Ativo,
                e => e.DataNascimento.Value.Month == DateTime.Now.Month
            };

            orderBys = new List<Func<IQueryable<Colaborador>, IOrderedQueryable<Colaborador>>>
            {
                query => query.OrderBy(e => e.DataNascimento.Value.Day).ThenBy(e => e.Nome)
            };
        }
    }
}
