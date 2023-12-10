using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Repositories.Implementations
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();
        private string _errorMessage = "";

        public FornecedorRepository() { }

        public async Task<List<Fornecedor>> BuscarListaDeFornecedores()
        {
            try
            {
                return await _contexto.Fornecedors.AsNoTracking().ToListAsync();
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao obter lista de fornecedores: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Fornecedor> PesquisarFornecedorPorCodigo(int codigo)
        {
            try
            {
                return await _contexto.Fornecedors.AsNoTracking().FirstOrDefaultAsync(f => f.CodigoFornecedor == codigo);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar fornecedor por código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Fornecedor> PesquisarFornecedorPorRazaoSocial(string razaoSocial)
        {
            try
            {
                return await _contexto.Fornecedors.AsNoTracking().FirstOrDefaultAsync(f => f.RazaoSocial == razaoSocial);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar fornecedor por razão social: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Fornecedor> PesquisarFornecedorPorCnpj(string cnpj)
        {
            try
            {
                return await _contexto.Fornecedors.AsNoTracking().FirstOrDefaultAsync(f => f.Cnpj == cnpj);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar fornecedor por CNPJ: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                _contexto.Fornecedors.Add(fornecedor);
                await _contexto.SaveChangesAsync();
                return fornecedor;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao cadastrar fornecedor: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Fornecedor> AlterarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                _contexto.Entry(fornecedor).State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
                return fornecedor;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao alterar fornecedor: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task ExcluirFornecedor(int codigo)
        {
            try
            {
                var fornecedor = await _contexto.Fornecedors.FindAsync(codigo);
                if (fornecedor != null)
                {
                    _contexto.Fornecedors.Remove(fornecedor);
                    await _contexto.SaveChangesAsync();
                }
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao excluir fornecedor: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }
    }
}
