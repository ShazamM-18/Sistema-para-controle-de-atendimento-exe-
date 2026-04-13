namespace SuporteApp.Models
{
    public class AtendimentoInteracaoItem
    {
        public int id_interacao { get; set; }
        public int id_atendimento { get; set; }
        public int id_colaborador { get; set; }
        public int? id_status_anterior { get; set; }
        public int? id_status_novo { get; set; }
        public string descricao_interacao { get; set; } = string.Empty;
        public string? solucao_aplicada { get; set; }
        public DateTime data_interacao { get; set; }
    }
}