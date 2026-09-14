using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Descricao__00500.Models
{
    public class Paciente
    {
        [Key]
        public int PacienteId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Nome { get; set; }

        public int Idade { get; set; }

        public string? Telefone { get; set; }

        public ICollection<Consulta>? Consultas { get; set; }
    }
}