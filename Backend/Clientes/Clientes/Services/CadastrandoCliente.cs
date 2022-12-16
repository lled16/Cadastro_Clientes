using Clientes.DataBase;
using Clientes.Models;
using Microsoft.Data.SqlClient;

namespace Clientes.Services
{
    public class CadastrandoCliente
    {
        string strConnection = "server=DESKTOP-278IVMV;database=IMOBILIARIA;trusted_connection=true;Integrated Security=SSPI;TrustServerCertificate=True;";
        DataContext Cadastro = new();
        public string CadastroCliente(ClienteModel Cliente)
        {

            Cadastro.CADASTRO_CLIENTES.Add(Cliente);
            Cadastro.SaveChanges();

            return "Cadastrado";
        }

        public List<ClienteModel> ListaClientes()
        {
            List<ClienteModel> Clientes = new();

            try
            {
                foreach (var cliente in Cadastro.CADASTRO_CLIENTES)
                {
                    Clientes.Add(cliente);

                }
                return Clientes;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível listar os clientes, contate o administrador.");
            }
        }
        public List<ClienteModel> ListaClientePorCpf(string CPF)
        {
            List<ClienteModel> Clientes = new();

            try
            {
                foreach (var cliente in Cadastro.CADASTRO_CLIENTES)
                {
                    if (cliente.Cpf == CPF)
                    {
                        Clientes.Add(cliente);

                    }
                }
                return Clientes;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível listar os clientes, contate o administrador.");
            }
        }
        public List<ClienteModel> ListaClientePorID(int ID)
        {
            List<ClienteModel> Clientes = new();

            try
            {
                foreach (var cliente in Cadastro.CADASTRO_CLIENTES)
                {
                    if (cliente.ID == ID)
                    {
                        Clientes.Add(cliente);

                    }
                }
                return Clientes;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível listar os clientes, contate o administrador.");
            }
        }

        public string DeletaCliente(int ID)
        {

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand comando = new SqlCommand("USE CLIENTES DELETE FROM CADASTRO_CLIENTES WHERE ID =" + ID, con);
            comando.ExecuteNonQuery();
            con.Close();

            return "Cliente excluído com sucesso !";


            return "OK";
        }

        public string EditandoCliente(ClienteModel Cliente)
        {

            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            SqlCommand comando =
              new SqlCommand(" USE CLIENTES UPDATE CADASTRO_CLIENTES SET CPF = @CPF, " +
                             "NOME = @NOME, " +
                             "ENDERECO = @ENDERECO, " +
                             "ESTADO = @ESTADO, " +
                             "CIDADE = @CIDADE, " +
                             "SEXO = @SEXO " +
                             "WHERE CPF = @CPF", con);

            comando.Parameters.Add(new SqlParameter("@CPF", Cliente.Cpf));
            comando.Parameters.Add(new SqlParameter("@NOME", Cliente.Nome));
            comando.Parameters.Add(new SqlParameter("@ENDERECO", Cliente.Endereco));
            comando.Parameters.Add(new SqlParameter("@ESTADO", Cliente.Estado));
            comando.Parameters.Add(new SqlParameter("@CIDADE", Cliente.Cidade));
            comando.Parameters.Add(new SqlParameter("@SEXO", Cliente.Sexo));


            comando.ExecuteNonQuery();
           
            con.Close();

            return "Cliente alterado com sucesso !";


            return "OK";
        }


    }
}
