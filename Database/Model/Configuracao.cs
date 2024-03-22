using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Configuracao", Schema = "adm")]
    public class Configuracao
    {
        [Key]
        public string Parametro { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }

    }
}
