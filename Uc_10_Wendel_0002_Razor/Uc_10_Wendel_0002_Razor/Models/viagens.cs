using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_0002_Razor.Models
{
    public class viagens
    {

        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Destino { get; set; }

        public DateTime Data { get; set; } = DateTime.Now;

        public string? Tipo { get; set; }
    }
}
