using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Log", Schema = "adm")]
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }
        public bool Erro { get; set; } = false;

    }
}
