using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Services
{
    public class FornecedorService
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();

        public FornecedorService() { }

        public async Task<List<Fornecedor>> ObterTodosOsFornecedores()
        {
            return await _contexto.Fornecedors.ToListAsync();
        }

        public async Task<Fornecedor> ObterFornecedorPorCodigo(int codigo)
        {
            return await _contexto.Fornecedors.FindAsync(codigo);
        }

        public async Task<Fornecedor> ObterFornecedorPorRazaoSocial(string razaoSocial)
        {
            return await _contexto.Fornecedors.FirstOrDefaultAsync(f => f.RazaoSocial == razaoSocial);
        }

        public async Task<Fornecedor> ObterFornecedorPorCnpj(string cnpj)
        {
            return await _contexto.Fornecedors.FirstOrDefaultAsync(f => f.Cnpj == cnpj);
        }

        public async Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor)
        {
            _contexto.Fornecedors.Add(fornecedor);
            await _contexto.SaveChangesAsync();
            return fornecedor;
        }

        public async Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor)
        {
            _contexto.Entry(fornecedor).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return fornecedor;
        }

        public async Task RemoverFornecedor(int codigo)
        {
            var fornecedor = await _contexto.Fornecedors.FindAsync(codigo);
            if (fornecedor != null)
            {
                _contexto.Fornecedors.Remove(fornecedor);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}
