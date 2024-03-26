using Model;

namespace Intranet.Get
{
    public class InicioView : BaseView
    {
        public InicioView()
        {
            Aniversariantes = Contexto.Colaboradores
                                    .Where(x => x.DataNascimento.Value.Month == Agora.Month && x.Ativo)
                                    .OrderBy(x => x.DataNascimento.Value.Day)
                                    .ThenBy(x => x.Nome)?
                                    .ToList();

            Alertas = Contexto.Alertas
                                    .Where(x => x.DataInicio <= Agora && x.DataFim >= Agora && x.Ativo)
                                    .OrderBy(X => X.DataInicio)
                                    .ThenBy(x => x.Ordem)?
                                    .ToList();

        }

        public List<Colaborador>? Aniversariantes { get; set; }

    }
}
