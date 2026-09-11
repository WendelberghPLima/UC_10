using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_0003_Razor.Models
{
    public class jogo
    {

        [Key]
        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? Genero { get; set; }
        public string? Desenvolvedor { get; set; }
        public string? Plataforma { get; set; }
        public DateTime DataLancamento { get; set; }

        public decimal Preco { get; set; }
    }
}
