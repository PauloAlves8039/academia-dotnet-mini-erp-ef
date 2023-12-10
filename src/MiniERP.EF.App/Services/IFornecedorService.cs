using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Services
{
    public interface IFornecedorService
    {
        Task<List<Fornecedor>> ObterTodosOsFornecedores();

        Task<Fornecedor> ObterFornecedorPorCodigo(int codigo);

        Task<Fornecedor> ObterFornecedorPorRazaoSocial(string razaoSocial);

        Task<Fornecedor> ObterFornecedorPorCnpj(string cnpj);

        Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor);

        Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor);

        Task RemoverFornecedor(int codigo);
    }
}
