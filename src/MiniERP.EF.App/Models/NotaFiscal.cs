namespace MiniERP.EF.App.Models
{
    public partial class NotaFiscal
    {
        public NotaFiscal()
        {
            ItemNotaFiscals = new HashSet<ItemNotaFiscal>();
        }

        public int CodigoNotaFiscal { get; set; }
        public DateTime DataEmissao { get; set; }
        public decimal ValorTotal { get; set; }
        public int? ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<ItemNotaFiscal> ItemNotaFiscals { get; set; }
    }
}
