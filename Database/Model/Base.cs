using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class Base
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int Id { get; set; }
        [Column(Order = 1)]
        public string? Titulo { get; set; }
        [Column(Order = 2)]
        public string? Descricao { get; set; }
        public virtual bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public int Ordem { get; set; } = 0;

    }
}
