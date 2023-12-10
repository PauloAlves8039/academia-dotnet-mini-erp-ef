using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Repositories.Implementations
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();
        private string _errorMessage = "";

        public ProdutoRepository() { }

        public async Task<List<ProdutoViewModel>> BuscarListaDeProdutosViewModel()
        {
            try
            {
                var produtos = await _contexto.Produtos.AsNoTracking()
                    .Include(p => p.Fornecedor)
                    .AsNoTracking()
                    .ToListAsync();

                return produtos.Select(p => new ProdutoViewModel
                {
                    CodigoProduto = p.CodigoProduto,
                    Nome = p.Nome,
                    Preco = p.Preco,
                    Estoque = p.Estoque,
                    Descricao = p.Descricao,
                    FornecedorId = p.FornecedorId,
                    RazaoSocialFornecedor = p.Fornecedor?.RazaoSocial
                }).ToList();
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao buscar lista de produtos: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Produto> PesquisarProdutoPorCodigo(int codigo)
        {
            try
            {
                return await _contexto.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.CodigoProduto == codigo);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar produto pro código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Produto> PesquisarProdutoPorNome(string nome)
        {
            try
            {
                return await _contexto.Produtos.AsNoTracking().FirstOrDefaultAsync(p => p.Nome == nome);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar produto por código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Produto> CadastrarProduto(Produto produto)
        {
            try
            {
                _contexto.Produtos.Add(produto);
                await _contexto.SaveChangesAsync();
                return produto;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao cadastrar produto: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<Produto> AlterarProduto(Produto produto)
        {
            try
            {
                _contexto.Entry(produto).State = EntityState.Modified;
                await _contexto.SaveChangesAsync();
                return produto;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao alterar produto: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task RemoverProduto(int codigo)
        {
            try
            {
                var produto = await _contexto.Produtos.FindAsync(codigo);
                if (produto != null)
                {
                    _contexto.Produtos.Remove(produto);
                    await _contexto.SaveChangesAsync();
                }
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao excluir produto: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }
    }
}
