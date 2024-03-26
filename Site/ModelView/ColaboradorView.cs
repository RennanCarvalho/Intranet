using Model;

namespace Intranet.Get
{
    public class ColaboradorView : BaseView
    {
        public ColaboradorView()
        {
            ColaboradoresAtivos = Colaboradores.Where(x => x.Ativo)?.ToList();
            GruposAtivos = Grupos.Where(x => x.Ativo)?.ToList();

        }
        List<Colaborador>? ColaboradoresAtivos { get; set; }
        List<Grupo>? GruposAtivos { get; set; }
    }
}
