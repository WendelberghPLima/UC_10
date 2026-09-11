using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_0004_Razor.Models
{
    public class filme
    {

        [Key]

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Diretor { get; set; }
        public string Genero { get; set; }
        public int Ano { get; set; }
        public int Bio { get; set; }
        public DateTime DataLancamento { get; set; }
    }
}
