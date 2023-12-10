using MiniERP.EF.App.Models;
using MiniERP.EF.App.Repositories.Implementations;

namespace MiniERP.EF.App.Services.Implementations
{
    public class ClienteService : IClienteService
    {
        private readonly ClienteRepository _clienteRepository = new ClienteRepository();

        public ClienteService() { }

        public async Task<List<Cliente>> ObeterTodosOsClientes()
        {
            return await _clienteRepository.BuscarListaDeClientes();
        }

        public async Task<Cliente> ObterClientePorCodigo(int codigo)
        {
            return await _clienteRepository.PesquisarClientePorCodigo(codigo);
        }

        public async Task<Cliente> ObterClientePorNome(string nome)
        {
            return await _clienteRepository.PesquisarClientePorNome(nome);
        }

        public async Task<Cliente> ObterClientePorCpf(string cpf)
        {
            return await _clienteRepository.PesquisarClientePorCpf(cpf);
        }

        public async Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            return await _clienteRepository.CadastrarCliente(cliente);
        }

        public async Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            return await _clienteRepository.AlterarCliente(cliente);
        }

        public async Task RemoverCliente(int codigo)
        {
            await _clienteRepository.ExcluirCliente(codigo);
        }
    }
}
