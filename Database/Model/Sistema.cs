using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    [Table("Sistema")]
    public class Sistema : Base
    {
        public string? TagIcon { get; set; }
        public string? Url { get; set; }

    }
}
