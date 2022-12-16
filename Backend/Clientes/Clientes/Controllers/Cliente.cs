using Clientes.Models;
using Clientes.Services;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Cliente
    {
        private CadastrandoCliente _clienteServices = new();

        [HttpPost("CadastraCliente")]
        public string CadastroCliente(string Cpf, string Nome, DateTime DataNascimento, string Endereco, string Estado, string Cidade, string Sexo)
        {
            string statusCadastro = "";

            List<ClienteModel> Clientes = ListaClientePorCpf(Cpf);

            if (Clientes.Count > 0 && Clientes[0].Cpf == Cpf)
            {
                ClienteModel clienteAlterado = new();

                clienteAlterado.Cpf = Cpf.Replace(".", "").Replace("-", "");
                clienteAlterado.Nome = Nome;
                clienteAlterado.Data_Nascimento = DataNascimento;
                clienteAlterado.Endereco = Endereco;
                clienteAlterado.Estado = Estado;
                clienteAlterado.Cidade = Cidade;
                clienteAlterado.Sexo = Sexo;

                EditaCliente(clienteAlterado);

            }
            else
            {


                ClienteModel cliente = new();

                cliente.Cpf = Cpf.Replace(".", "").Replace("-", "");
                cliente.Nome = Nome;
                cliente.Data_Nascimento = DataNascimento;
                cliente.Endereco = Endereco;
                cliente.Estado = Estado;
                cliente.Cidade = Cidade;
                cliente.Sexo = Sexo;


                statusCadastro = _clienteServices.CadastroCliente(cliente);
            }
            return statusCadastro;
            
        }
        [HttpGet("ListaCliente")]
        public List<ClienteModel> ListarClientes()
        {
            List<ClienteModel> Clientes = _clienteServices.ListaClientes();

            return Clientes;
        }

        [HttpGet("ListaClientePorCpf")]
        public List<ClienteModel> ListaClientePorCpf(string CPF)
        {
            List<ClienteModel> Clientes = _clienteServices.ListaClientePorCpf(CPF);

            return Clientes;
        }

        [HttpGet("ListaClientePorID")]
        public List<ClienteModel> ListaClientePorID(int ID)
        {
            List<ClienteModel> Clientes = _clienteServices.ListaClientePorID(ID);

            return Clientes;
        }
        [HttpDelete("DeletaCliente")]
        public string DeletaCliente(int ID)
        {
            string Clientes = _clienteServices.DeletaCliente(ID);

            return Clientes;
        }

        [HttpPut("EditaCliente")]
        public string EditaCliente(ClienteModel cliente)
        {
            string retorno = _clienteServices.EditandoCliente(cliente);

            return retorno;
        }

    }
}
