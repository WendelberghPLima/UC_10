using System.ComponentModel.DataAnnotations;

namespace Uc_10_Wendel_0001_Razor.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o modelo")]
        public string? Modelo { get; set; }

        [Required(ErrorMessage = "Informe a marca")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "Informe o ano")]
        public int Ano { get; set; }

        public string? Cor { get; set; }

        public decimal Preco { get; set; }
    }
}