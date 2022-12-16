using Microsoft.AspNetCore.Http.Metadata;

namespace Clientes.Models
{
    public class ClienteModel
    {
        public int ID { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
    }
}
