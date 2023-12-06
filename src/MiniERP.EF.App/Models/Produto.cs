using System.ComponentModel;

namespace MiniERP.EF.App.Models
{
    public partial class Produto
    {
        public Produto()
        {
            ItemNotaFiscals = new HashSet<ItemNotaFiscal>();
        }

        public int CodigoProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
        public int? FornecedorId { get; set; }

        [Browsable(false)]
        public virtual Fornecedor Fornecedor { get; set; }

        [Browsable(false)]
        public virtual ICollection<ItemNotaFiscal> ItemNotaFiscals { get; set; }
    }
}
