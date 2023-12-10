using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Repositories
{
    public interface INotaFiscalRepository
    {
        Task<List<NotaFiscalViewModel>> PesquisarNotasFiscaisComClienteEItem();

        Task<NotaFiscalViewModel> PesquisarNotaFiscalViewModelPorCodigo(int codigo);

        Task<NotaFiscal> SalvarNotaFiscal(NotaFiscal notaFiscal);
    }
}
