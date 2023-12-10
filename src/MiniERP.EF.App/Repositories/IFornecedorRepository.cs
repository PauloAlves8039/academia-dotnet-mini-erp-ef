using MiniERP.EF.App.Models;

namespace MiniERP.EF.App.Repositories
{
    public interface IFornecedorRepository
    {
        Task<List<Fornecedor>> BuscarListaDeFornecedores();

        Task<Fornecedor> PesquisarFornecedorPorCodigo(int codigo);

        Task<Fornecedor> PesquisarFornecedorPorRazaoSocial(string razaoSocial);

        Task<Fornecedor> PesquisarFornecedorPorCnpj(string cnpj);

        Task<Fornecedor> CadastrarFornecedor(Fornecedor fornecedor);

        Task<Fornecedor> AlterarFornecedor(Fornecedor fornecedor);

        Task ExcluirFornecedor(int codigo);
    }
}
