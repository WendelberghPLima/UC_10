using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Descricao__00500.Models
{
    public class TipoConsulta
    {
        [Key]
        public int TipoConsultaId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [MaxLength(200)]
        public string? Descricao { get; set; }

        public ICollection<Consulta>? Consultas { get; set; }
    }
}