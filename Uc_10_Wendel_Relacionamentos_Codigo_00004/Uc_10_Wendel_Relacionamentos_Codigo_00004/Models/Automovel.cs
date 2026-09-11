using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Models
{
    public class Automovel
    {
        [Key]
        public int AutomovelID { get; set; }
        public string? Nome { get; set; }
        public int MarcaID { get; set; }
        public Marca? Marca { get; set; }
    }
}