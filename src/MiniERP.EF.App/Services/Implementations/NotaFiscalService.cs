using MiniERP.EF.App.Models;
using MiniERP.EF.App.Repositories.Implementations;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services.Implementations
{
    public class NotaFiscalService : INotaFiscalService
    {
        private readonly NotaFiscalRepository _notaFiscalRepository = new NotaFiscalRepository();

        public NotaFiscalService() { }

        public async Task<List<NotaFiscalViewModel>> ObterNotasFiscaisComClienteEItem()
        {
            return await _notaFiscalRepository.PesquisarNotasFiscaisComClienteEItem();
        }

        public async Task<NotaFiscalViewModel> ObterNotaFiscalViewModelPorCodigo(int codigoNotaFiscal)
        {
            return await _notaFiscalRepository.PesquisarNotaFiscalViewModelPorCodigo(codigoNotaFiscal);
        }

        public async Task<NotaFiscal> CadastrarNotaFiscal(NotaFiscal notaFiscal)
        {
            return await _notaFiscalRepository.SalvarNotaFiscal(notaFiscal);
        }

        public decimal CalcularValorTotal(NotaFiscal notaFiscal)
        {
            var valorTotal = notaFiscal.ItemNotaFiscals.Sum(item => item.Quantidade * item.ValorUnitario);
            return valorTotal;
        }
    }
}
