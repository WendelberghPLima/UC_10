using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Models
{
    public class Automovel
    {
        [Key]
        public int AutomovelID { get; set; }
        [Required]
        public string? Nome { get; set; }
        [Required]
        public int MarcaID { get; set; }
        public Marca? Marca { get; set; }
    }
}