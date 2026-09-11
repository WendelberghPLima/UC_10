namespace Uc_10_Wendel_Relacionamento_00001.Models
{
    public class Cidade
    {

        public int CidadeId { get; set; }
        public string? Nome { get; set; }
        public string? Estado { get; set; }
        public ICollection<Cliente>? Clientes { get; set; } // Propriedade de navegação para os clientes associados à cidade
    }
}
