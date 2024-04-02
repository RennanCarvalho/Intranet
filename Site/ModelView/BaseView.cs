using Microsoft.EntityFrameworkCore;
using Model;
using System;

namespace Intranet.Get
{
    public class BaseView
    {
        public BaseView()
        {
            Alertas = Contexto.Alertas
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();

            Andares = Contexto.Andares
                                    .Include(x => x.Secoes)
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();

            Cargos = Contexto.Cargos
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();
            Empresas = Contexto.Empresas
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();

            Secoes = Contexto.Secoes
                                    .Include(x => x.Andar)
                                    .Include(x => x.Colaboradores)
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();


            Colaboradores = Contexto.Colaboradores
                                    .Include(x => x.Cargo)
                                    .Include(x => x.Secao)
                                    .Include(x => x.Posto)
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Nome)
                                    .ToList();

            Configuracoes = Contexto.Configuracoes
                                    .ToList();
            Sistemas = Contexto.Sistemas
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();
            Grupos = Contexto.Grupos
                                    .OrderBy(x => x.Ordem)
                                    .ThenBy(x => x.Titulo)
                                    .ToList();
        }

        public readonly Context Contexto = new Context();
        public List<Alerta>? Alertas { get; set; }
        public List<Andar>? Andares { get; set; }
        public List<Cargo>? Cargos { get; set; }
        public List<Empresa>? Empresas { get; set; }
        public List<Secao>? Secoes { get; set; }
        public List<Sistema>? Sistemas { get; set; }
        public List<Colaborador>? Colaboradores { get; set; }
        public List<Configuracao>? Configuracoes { get; set; }
        public List<Grupo>? Grupos { get; set; }
        public DateTime Agora { get; set; } = DateTime.Now;

    }
}
