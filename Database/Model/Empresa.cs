using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Empresa")]
    public class Empresa : Base
    {
        public virtual ICollection<Colaborador>? Colaboradores { get; set; }
    }
}
