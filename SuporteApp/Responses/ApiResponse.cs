namespace SuporteApp.Responses
{
    public class ApiResponse<T>
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; } = string.Empty;
        public T? dados { get; set; }
        public List<string>? erros { get; set; }
    }
}