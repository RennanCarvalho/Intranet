using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Alerta", Schema = "adm")]
    public class Alerta : Base
    {
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
