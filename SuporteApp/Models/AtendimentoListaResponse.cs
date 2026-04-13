namespace SuporteApp.Models
{
    public class AtendimentoListaResponse
    {
        public int pagina { get; set; }
        public int tamanho_pagina { get; set; }
        public int total_registros { get; set; }
        public int total_paginas { get; set; }
        public List<AtendimentoListaItem> registros { get; set; } = new();
    }
}