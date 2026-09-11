using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_00002.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataPedido { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Descricao { get; set; }
        public virtual Cliente? Cliente { get; set; }
        [Required]
        public int ClienteId { get; set; }
    }
}
