using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00005.Models
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }
        public string? Nome { get; set; }
        public int CargaHorario { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public ICollection<Aluno>? Alunos { get; set; }
    }
}
