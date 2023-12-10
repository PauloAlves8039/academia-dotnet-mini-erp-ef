using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> ObeterTodosOsClientes();

        Task<Cliente> ObterClientePorCodigo(int codigo);

        Task<Cliente> ObterClientePorNome(string nome);

        Task<Cliente> ObterClientePorCpf(string cpf);

        Task<Cliente> AdicionarCliente(Cliente cliente);

        Task<Cliente> AtualizarCliente(Cliente cliente);

        Task RemoverCliente(int codigo);
    }
}
