namespace SuporteApp.Models
{
    public class AtendimentoDetalheResponse
    {
        public AtendimentoDetalheItem? atendimento { get; set; }
        public List<AtendimentoInteracaoItem> interacoes { get; set; } = new();
    }
}