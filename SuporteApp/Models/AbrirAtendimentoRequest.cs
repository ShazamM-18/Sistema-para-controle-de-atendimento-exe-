namespace SuporteApp.Models
{
    public class AbrirAtendimentoRequest
    {
        public string? protocolo_externo { get; set; }
        public string? origem_atendimento { get; set; }
        public int id_cliente { get; set; }
        public int id_prioridade_atendimento { get; set; }
        public int id_canal_atendimento { get; set; }
        public int? id_categoria_atendimento { get; set; }
        public string assunto { get; set; } = string.Empty;
        public string descricao_inicial { get; set; } = string.Empty;
        public string? sistema_afetado { get; set; }
        public string? tela_afetada { get; set; }
    }
}