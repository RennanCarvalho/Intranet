using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Grupo")]
    public class Grupo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Email { get; set; }
        public string? Descricao { get; set; }
        public bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public int Ordem { get; set; } = 0;
    }
}
