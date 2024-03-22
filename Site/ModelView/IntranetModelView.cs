using Interface;
using Model;
using Site.Models;

namespace Site.ModelView
{
    public class IntranetModelView
    {
        public List<Alerta>? Alertas { get; set; } = new List<Alerta>();
        public List<Andar>? Andares { get; set; } = new List<Andar>();
        public List<Colaborador>? Aniversariantes { get; set; } = new List<Colaborador>();
        public List<Colaborador>? Colaboradores { get; set; } = new List<Colaborador>();
        public List<Secao>? Secoes { get; set; } = new List<Secao>();
        public List<Sistema>? Sistemas { get; set; } = new List<Sistema>();
        public Dictionary<string, List<string>>? Suportes { get; set; }
        public IntranetModelView(
            IRepo<Alerta> alertaRepo,
            IRepo<Andar> andarRepo,
            IRepo<Colaborador> colaboradorRepo,
            IRepo<Secao> secaoRepo,
            IRepo<Sistema> sistemaRepo)
        {
            Alertas = new AlertaView(alertaRepo).List;
            Andares = new AndarView(andarRepo).List;
            Aniversariantes = new AniversarianteView(colaboradorRepo).List;
            Colaboradores = new ColaboradorView(colaboradorRepo).List;
            Secoes = new SecaoView(secaoRepo).List;
            Sistemas = new SistemaView(sistemaRepo).List;
            Suportes = new Suporte().Arquivos;
        }
    }
}
