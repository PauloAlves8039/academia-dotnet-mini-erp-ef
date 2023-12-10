using MiniERP.EF.App.Models;
using MiniERP.EF.App.Repositories.Implementations;

namespace MiniERP.EF.App.Services.Implementations
{
    public class FornecedorService : IFornecedorService
    {
        private readonly FornecedorRepository _fornecedorRepository = new FornecedorRepository();

        public FornecedorService() { }

        public async Task<List<Fornecedor>> ObterTodosOsFornecedores()
        {
            return await _fornecedorRepository.BuscarListaDeFornecedores();
        }

        public async Task<Fornecedor> ObterFornecedorPorCodigo(int codigo)
        {
            return await _fornecedorRepository.PesquisarFornecedorPorCodigo(codigo);
        }

        public async Task<Fornecedor> ObterFornecedorPorRazaoSocial(string razaoSocial)
        {
            return await _fornecedorRepository.PesquisarFornecedorPorRazaoSocial(razaoSocial);
        }

        public async Task<Fornecedor> ObterFornecedorPorCnpj(string cnpj)
        {
            return await _fornecedorRepository.PesquisarFornecedorPorCnpj(cnpj);
        }

        public async Task<Fornecedor> AdicionarFornecedor(Fornecedor fornecedor)
        {
            return await _fornecedorRepository.CadastrarFornecedor(fornecedor);
        }

        public async Task<Fornecedor> AtualizarFornecedor(Fornecedor fornecedor)
        {
            return await _fornecedorRepository.AlterarFornecedor(fornecedor);
        }

        public async Task RemoverFornecedor(int codigo)
        {
            await _fornecedorRepository.ExcluirFornecedor(codigo);
        }
    }
}
