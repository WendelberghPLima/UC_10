using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Descricao_00003.Models
{
    public class Medico
    {
        [Key]
        public int MedicoId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string? Especialidade { get; set; }

        [Required]
        [MaxLength(100)]
        public string? CRM { get; set; }

        public ICollection<Paciente>? Pacientes { get; set; }
    }
}