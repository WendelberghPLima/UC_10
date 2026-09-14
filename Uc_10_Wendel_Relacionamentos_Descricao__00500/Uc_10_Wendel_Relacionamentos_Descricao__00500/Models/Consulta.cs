using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Descricao__00500.Models
{
    public class Consulta
    {
        [Key]
        public int ConsultaId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [MaxLength(500)]
        public string? Observacao { get; set; }

        public int PacienteId { get; set; }
        public Paciente? Paciente { get; set; }

        public int MedicoId { get; set; }
        public Medico? Medico { get; set; }

        public int TipoConsultaId { get; set; }
        public TipoConsulta? TipoConsulta { get; set; }
    }
}