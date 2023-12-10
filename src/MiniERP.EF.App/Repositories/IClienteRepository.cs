using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Repositories
{
    public interface IClienteRepository
    {
        Task<List<Cliente>> BuscarListaDeClientes();

        Task<Cliente> PesquisarClientePorCodigo(int codigo);

        Task<Cliente> PesquisarClientePorNome(string nome);

        Task<Cliente> PesquisarClientePorCpf(string cpf);

        Task<Cliente> CadastrarCliente(Cliente cliente);

        Task<Cliente> AlterarCliente(Cliente cliente);

        Task ExcluirCliente(int codigo);
    }
}
