using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Andar")]
    public class Andar : Base
    {
        public virtual ICollection<Secao> Secoes { get; set; }
    }
}
