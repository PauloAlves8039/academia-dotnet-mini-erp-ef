using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Repositories.Implementations
{
    public class NotaFiscalRepository : INotaFiscalRepository
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();
        private string _errorMessage = "";

        public NotaFiscalRepository() { }

        public async Task<List<NotaFiscalViewModel>> PesquisarNotasFiscaisComClienteEItem()
        {
            try
            {
                var notasFiscais = await _contexto.NotaFiscals
                    .Include(n => n.Cliente)
                    .Include(n => n.ItemNotaFiscals)
                        .ThenInclude(i => i.Produto)
                    .AsNoTracking()
                    .ToListAsync();

                var resultado = new List<NotaFiscalViewModel>();

                foreach (var notaFiscal in notasFiscais)
                {
                    foreach (var item in notaFiscal.ItemNotaFiscals)
                    {
                        var notaFiscalViewModel = new NotaFiscalViewModel
                        {
                            CodigoNotaFiscal = notaFiscal.CodigoNotaFiscal,
                            DataEmissao = notaFiscal.DataEmissao,
                            ValorTotal = notaFiscal.ValorTotal,
                            ClienteId = notaFiscal.ClienteId,
                            NomeCliente = notaFiscal.Cliente.Nome,
                            Cpf = notaFiscal.Cliente.Cpf,
                            TelefoneCliente = notaFiscal.Cliente.Telefone,
                            EmailCliente = notaFiscal.Cliente.Email,
                            EnderecoCliente = notaFiscal.Cliente.Endereco,
                            ProdutoId = item.ProdutoId,
                            Quantidade = item.Quantidade,
                            ValorUnitario = item.ValorUnitario,
                            NomeProduto = item.Produto?.Nome ?? string.Empty,
                            Descricao = item.Produto?.Descricao ?? string.Empty
                        };

                        resultado.Add(notaFiscalViewModel);
                    }
                }

                return resultado;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar nota fiscal view model por item: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<NotaFiscalViewModel> PesquisarNotaFiscalViewModelPorCodigo(int codigoNotaFiscal)
        {
            try
            {
                var notaFiscal = await PesquisarNotaFiscalPorCodigo(codigoNotaFiscal);

                if (notaFiscal != null)
                {
                    var notaFiscalViewModel = new NotaFiscalViewModel
                    {
                        CodigoNotaFiscal = notaFiscal.CodigoNotaFiscal,
                        DataEmissao = notaFiscal.DataEmissao,
                        ValorTotal = notaFiscal.ValorTotal,
                        ClienteId = notaFiscal.ClienteId,
                        NomeCliente = notaFiscal.Cliente.Nome,
                        Cpf = notaFiscal.Cliente.Cpf,
                        TelefoneCliente = notaFiscal.Cliente.Telefone,
                        EmailCliente = notaFiscal.Cliente.Email,
                        EnderecoCliente = notaFiscal.Cliente.Endereco,
                        ItemNotaFiscals = notaFiscal.ItemNotaFiscals.Select(item => new ItemNotaFiscalViewModel
                        {
                            ProdutoId = item.ProdutoId,
                            Quantidade = item.Quantidade,
                            ValorUnitario = item.ValorUnitario,
                            NomeProduto = item.Produto?.Nome ?? string.Empty,
                            Descricao = item.Produto?.Descricao ?? string.Empty,
                        }).ToList()
                    };

                    return notaFiscalViewModel;
                }

                return null;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar nota fiscal view model por código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        public async Task<NotaFiscal> SalvarNotaFiscal(NotaFiscal notaFiscal)
        {
            try
            {
                _contexto.NotaFiscals.Add(notaFiscal);
                await _contexto.SaveChangesAsync();
                return notaFiscal;
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao salvar nota fiscal: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }

        private async Task<NotaFiscal> PesquisarNotaFiscalPorCodigo(int codigoNotaFiscal)
        {
            try
            {
                return await _contexto.NotaFiscals
                    .Include(n => n.Cliente)
                    .Include(n => n.ItemNotaFiscals)
                        .ThenInclude(i => i.Produto)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(n => n.CodigoNotaFiscal == codigoNotaFiscal);
            }
            catch (SqlException exception)
            {
                _errorMessage = $"Erro ao pesquisar nota fiscal por código: {exception.Message}";
                throw new Exception(_errorMessage);
            }
        }
    }
}
