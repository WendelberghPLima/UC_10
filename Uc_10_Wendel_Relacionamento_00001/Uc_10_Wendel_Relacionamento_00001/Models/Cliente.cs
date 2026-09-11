namespace Uc_10_Wendel_Relacionamento_00001.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public int CidadeId { get; set; } // Chave estrangeira para a cidade
        public Cidade? Cidade { get; set; } // Propriedade de navegação para a cidade associada
    }
}
