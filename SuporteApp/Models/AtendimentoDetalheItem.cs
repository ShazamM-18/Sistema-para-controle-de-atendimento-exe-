namespace SuporteApp.Models
{
    public class AtendimentoDetalheItem
    {
        public int id_atendimento { get; set; }
        public string protocolo { get; set; } = string.Empty;
        public string? protocolo_externo { get; set; }
        public string? origem_atendimento { get; set; }
        public int id_cliente { get; set; }
        public int id_colaborador_abertura { get; set; }
        public int? id_colaborador_responsavel { get; set; }
        public int id_status_atendimento { get; set; }
        public int id_prioridade_atendimento { get; set; }
        public int id_canal_atendimento { get; set; }
        public int? id_categoria_atendimento { get; set; }
        public string assunto { get; set; } = string.Empty;
        public string descricao_inicial { get; set; } = string.Empty;
        public string? sistema_afetado { get; set; }
        public string? tela_afetada { get; set; }
        public DateTime data_abertura { get; set; }
        public DateTime? data_inicio_atendimento { get; set; }
        public DateTime? data_fechamento { get; set; }
        public string? solucao_final { get; set; }
    }
}