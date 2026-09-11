using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00005.Models
{
    public class Aluno
    {
        [Key]
        public int AlunoId { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Nome { get; set; }
        [Required]
        public int Idade { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }
        [Required]
        public int CursoId { get; set; }
        public Curso? Curso { get; set; }
    }
}
