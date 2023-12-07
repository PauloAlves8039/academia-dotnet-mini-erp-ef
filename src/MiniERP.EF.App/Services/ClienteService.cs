using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Services
{
    public class ClienteService
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();

        public ClienteService() {}

        public async Task<List<Cliente>> ObeterTodosOsClientes()
        {
            return await _contexto.Clientes.ToListAsync();
        }

        public async Task<Cliente> ObterClientePorCodigo(int codigo)
        {
            return await _contexto.Clientes.FindAsync(codigo);
        }

        public async Task<Cliente> ObterClientePorNome(string nome)
        {
            return await _contexto.Clientes.FirstOrDefaultAsync(c => c.Nome == nome);
        }

        public async Task<Cliente> ObterClientePorCpf(string cpf)
        {
            return await _contexto.Clientes.FirstOrDefaultAsync(c => c.Cpf == cpf);
        }

        public async Task<Cliente> AdicionarCliente(Cliente cliente)
        {
            _contexto.Clientes.Add(cliente);
            await _contexto.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> AtualizarCliente(Cliente cliente)
        {
            _contexto.Entry(cliente).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return cliente;
        }

        public async Task RemoverCliente(int codigo)
        {
            var cliente = await _contexto.Clientes.FindAsync(codigo);
            if (cliente != null)
            {
                _contexto.Clientes.Remove(cliente);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}
