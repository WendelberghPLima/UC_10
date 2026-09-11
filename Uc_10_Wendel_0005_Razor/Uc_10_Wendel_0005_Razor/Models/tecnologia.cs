using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_0005_Razor.Models
{
    public class tecnologia
    {

        [Key]

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Url { get; set; }
        public DateTime? Data { get; set; }
    }
}
