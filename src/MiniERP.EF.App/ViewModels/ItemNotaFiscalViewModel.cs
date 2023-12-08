namespace MiniERP.EF.App.ViewModels
{
    public class ItemNotaFiscalViewModel
    {
        public int CodigoItemNotaFiscal { get; set; }
        public int? NotaFiscalId { get; set; }
        public int? ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public string NomeProduto { get; set; }
        public string Descricao { get; set; }
        public decimal PrecoUnitarioProduto { get; set; }
    }
}
