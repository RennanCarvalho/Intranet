using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Secao")]
    public class Secao : Base
    {
        public int? IdAndar { get; set; }
        [ForeignKey("IdAndar")]
        public Andar? Andar { get; set; }
        public virtual ICollection<Colaborador> Colaboradores { get; set; }
    }
}
