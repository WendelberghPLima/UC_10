using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Models
{
    public class Marca
    {
        [Key]
        public int MarcaID { get; set; }
        public string? Nome { get; set; }
        public DateTime DataCriacao { get; set; }
        public ICollection<Automovel>? Automoveis { get; set; }
    }
}