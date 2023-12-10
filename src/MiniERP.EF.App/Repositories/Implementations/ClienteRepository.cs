using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Repositories.Implementations
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();
        private string _errorMessage = "";

        public ClienteRepository() { }

        public async Task<List<Cliente>> BuscarListaDeClientes()
        {
            try
            {
                return await _contexto.Clientes.AsNoTracking().ToListAsync();
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao buscar lista de clientes: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Cliente> PesquisarClientePorCodigo(int codigo)
        {
            try
            {
                return await _contexto.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.CodigoCliente == codigo);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesqusiar cliente por código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Cliente> PesquisarClientePorNome(string nome)
        {
            try
            {
                return await _contexto.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.Nome == nome);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar cliente por nome: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Cliente> PesquisarClientePorCpf(string cpf)
        {
            try
            {
                return await _contexto.Clientes.AsNoTracking().FirstOrDefaultAsync(c => c.Cpf == cpf);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar cliente por CPF: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Cliente> CadastrarCliente(Cliente cliente)
        {
            try
            {
                _contexto.Clientes.Add(cliente);
                await _contexto.SaveChangesAsync();
                return cliente;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao cadastrar cliente: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Cliente> AlterarCliente(Cliente cliente)
        {
            try
            {
                _contexto.Entry(cliente).State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
                return cliente;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao alterar cliente: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task ExcluirCliente(int codigo)
        {
            try
            {
                var cliente = await _contexto.Clientes.FindAsync(codigo);
                if (cliente != null)
                {
                    _contexto.Clientes.Remove(cliente);
                    await _contexto.SaveChangesAsync();
                }
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao excluir cliente: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }
    }
}
