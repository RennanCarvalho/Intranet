using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Cargo")]
        public int? IdCargo { get; set; }
        [Display(Name = "Seção")]
        public int? IdSecao { get; set; }
        [Required]
        [Display(Name = "Nome completo")]
        public string? Nome { get; set; }
        public string? UrlImagem { get; set; }
        public string? Email { get; set; }
        public string? Ramal { get; set; }
        [Display(Name = "Data de nascimento")]
        public DateTime? DataNascimento { get; set; }
        public virtual bool Ativo { get; set; } = true;
        public virtual DateTime DataInsercao { get; set; } = DateTime.Now;
        public virtual DateTime DataAtualizacao { get; set; } = DateTime.Now;
        public int Ordem { get; set; } = 0;

        [ForeignKey("IdCargo")]
        public Cargo? Cargo { get; set; }
        [ForeignKey("IdSecao")]
        public Secao? Secao { get; set; }
    }
}
