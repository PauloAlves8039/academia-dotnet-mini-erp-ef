using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services
{
    public interface INotaFiscalService
    {
        Task<List<NotaFiscalViewModel>> ObterNotasFiscaisComClienteEItem();

        Task<NotaFiscalViewModel> ObterNotaFiscalViewModelPorCodigo(int codigo);

        Task<NotaFiscal> CadastrarNotaFiscal(NotaFiscal notaFiscal);
    }
}
