using Microsoft.EntityFrameworkCore;
using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Services
{
    public class NotaFiscalService
    {
        private readonly MiniERP_EFContext _contexto = new MiniERP_EFContext();

        public NotaFiscalService() {}

        public async Task<List<NotaFiscal>> ObterTodasAsNotasFiscais()
        {
            return await _contexto.NotaFiscals
                .Include(n => n.Cliente)
                .Include(n => n.ItemNotaFiscals)
                    .ThenInclude(i => i.Produto)
                .ToListAsync();
        }

        public async Task<NotaFiscalViewModel> ObterNotaFiscalViewModelPorId(int codigoNotaFiscal)
        {
            var notaFiscal = await ObterNotaFiscalPorId(codigoNotaFiscal);

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

        public async Task<List<NotaFiscalViewModel>> ObterNotasFiscaisComClienteEItem()
        {
            var notasFiscais = await _contexto.NotaFiscals
                .Include(n => n.Cliente)
                .Include(n => n.ItemNotaFiscals)
                    .ThenInclude(i => i.Produto)
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

        public async Task<NotaFiscal> CadastrarNotaFiscal(NotaFiscal notaFiscal)
        {
            _contexto.NotaFiscals.Add(notaFiscal);
            await _contexto.SaveChangesAsync();
            return notaFiscal;
        }

        public decimal CalcularValorTotal(NotaFiscal notaFiscal)
        {
            var valorTotal = notaFiscal.ItemNotaFiscals.Sum(item => item.Quantidade * item.ValorUnitario);
            return valorTotal;
        }

        private async Task<NotaFiscal> ObterNotaFiscalPorId(int codigoNotaFiscal)
        {
            return await _contexto.NotaFiscals
                .Include(n => n.Cliente)
                .Include(n => n.ItemNotaFiscals)
                    .ThenInclude(i => i.Produto)
                .FirstOrDefaultAsync(n => n.CodigoNotaFiscal == codigoNotaFiscal);
        }
    }
}
