using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services
{
    public interface IProdutoService
    {
        Task<List<ProdutoViewModel>> ObterTodosOsProdutosViewModel();

        Task<Produto> ObterProdutoPorCodigo(int codigo);

        Task<Produto> ObterProdutoPorNome(string nome);

        Task<Produto> AdicionarProduto(Produto produto);

        Task<Produto> AtualizarProduto(Produto produto);

        Task RemoverProduto(int codigo);
    }
}
