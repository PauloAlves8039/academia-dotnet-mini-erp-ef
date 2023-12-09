using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services
{
    public class ProdutoService
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();

        public ProdutoService() {}

        public async Task<List<ProdutoViewModel>> ObterTodosOsProdutosViewModel()
        {
            var produtos = await _contexto.Produtos
                .Include(p => p.Fornecedor)
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

        public async Task<Produto> ObterProdutoPorCodigo(int codigo)
        {
            return await _contexto.Produtos.FindAsync(codigo);
        }

        public async Task<Produto> ObterProdutoPorNome(string nome)
        {
            return await _contexto.Produtos.FirstOrDefaultAsync(p => p.Nome == nome);
        }

        public async Task<Produto> AdicionarProduto(Produto produto)
        {
            _contexto.Produtos.Add(produto);
            await _contexto.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            _contexto.Entry(produto).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();
            return produto;
        }

        public async Task RemoverProduto(int codigo)
        {
            var produto = await _contexto.Produtos.FindAsync(codigo);
            if (produto != null)
            {
                _contexto.Produtos.Remove(produto);
                await _contexto.SaveChangesAsync();
            }
        }
    }
}
