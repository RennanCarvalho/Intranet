using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Usuario", Schema = "adm")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Tentativas { get; set; } = 0;
        public bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public int Ordem { get; set; } = 0;
    }
}
