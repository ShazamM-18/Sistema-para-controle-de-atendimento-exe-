namespace SuporteApp.Models
{
    public class AdicionarInteracaoInternaRequest
    {
        public string descricao_interacao { get; set; } = string.Empty;
        public string? solucao_aplicada { get; set; }
    }
}