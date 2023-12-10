using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Repositories
{
    public interface IProdutoRepository
    {
        Task<List<ProdutoViewModel>> BuscarListaDeProdutosViewModel();

        Task<Produto> PesquisarProdutoPorCodigo(int codigo);

        Task<Produto> PesquisarProdutoPorNome(string nome);

        Task<Produto> CadastrarProduto(Produto produto);

        Task<Produto> AlterarProduto(Produto produto);

        Task RemoverProduto(int codigo);
    }
}
