using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00005.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        [Required]
        [MaxLength(150)]
        public string? Nome { get; set; }
        [Required]
        public int CargaHorario { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataTermino { get; set; }
        public ICollection<Aluno>? Alunos { get; set; }
    }
}
