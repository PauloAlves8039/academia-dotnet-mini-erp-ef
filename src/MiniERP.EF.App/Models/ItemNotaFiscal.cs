namespace MiniERP.EF.App.Models
{
    public partial class ItemNotaFiscal
    {
        public int CodigoItemNotaFiscal { get; set; }
        public int? NotaFiscalId { get; set; }
        public int? ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }

        public virtual NotaFiscal NotaFiscal { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
