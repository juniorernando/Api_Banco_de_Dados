using WebAPiS.Models;


namespace WebAPiS.Models
{
    public class ServiceResponce<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Sucesso { get; set; } = true;
    }
}
