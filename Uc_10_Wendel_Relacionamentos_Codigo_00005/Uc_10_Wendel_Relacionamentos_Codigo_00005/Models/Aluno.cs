using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00005.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        public string ? Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
