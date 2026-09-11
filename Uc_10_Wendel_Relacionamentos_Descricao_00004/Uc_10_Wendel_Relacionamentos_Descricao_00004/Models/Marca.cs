using System.ComponentModel.DataAnnotations;
using Uc_10_Wendel_Relacionamentos_Descricao_00004.Models;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Models
{
    public class Marca
    {
        [Key]
        public int MarcaID { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Nome { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataCriacao { get; set; }
        public ICollection<Automovel>? Automoveis { get; set; }
    }
}