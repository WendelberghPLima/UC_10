using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_00002.Models
{
    public class Cliente
    {

        [Key]
        public int ClienteId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }
        [MaxLength(150)]
        public string? Email { get; set; }
        public virtual ICollection<Pedido>? Pedidos { get; set; }
    }
}
