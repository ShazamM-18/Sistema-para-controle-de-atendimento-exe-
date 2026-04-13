namespace SuporteApp.Models
{
    public class AbrirAtendimentoResponse
    {
        public int id_atendimento { get; set; }
        public string protocolo { get; set; } = string.Empty;
        public string? protocolo_externo { get; set; }
        public string? origem_atendimento { get; set; }
        public int id_cliente { get; set; }
        public int id_status_atendimento { get; set; }
        public int id_prioridade_atendimento { get; set; }
        public int id_canal_atendimento { get; set; }
        public string assunto { get; set; } = string.Empty;
        public DateTime data_abertura { get; set; }
    }
}