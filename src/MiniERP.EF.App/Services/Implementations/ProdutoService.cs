using MiniERP.EF.App.Models;
using MiniERP.EF.App.Repositories.Implementations;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services.Implementations
{
    public class ProdutoService : IProdutoService
    {
        private readonly ProdutoRepository _produtoRepository = new ProdutoRepository();

        public ProdutoService() { }

        public async Task<List<ProdutoViewModel>> ObterTodosOsProdutosViewModel()
        {
            return await _produtoRepository.BuscarListaDeProdutosViewModel();
        }

        public async Task<Produto> ObterProdutoPorCodigo(int codigo)
        {
            return await _produtoRepository.PesquisarProdutoPorCodigo(codigo);
        }

        public async Task<Produto> ObterProdutoPorNome(string nome)
        {
            return await _produtoRepository.PesquisarProdutoPorNome(nome);
        }

        public async Task<Produto> AdicionarProduto(Produto produto)
        {
            return await _produtoRepository.CadastrarProduto(produto);
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            return await _produtoRepository.AlterarProduto(produto);
        }

        public async Task RemoverProduto(int codigo)
        {
            await _produtoRepository.RemoverProduto(codigo);
        }
    }
}
