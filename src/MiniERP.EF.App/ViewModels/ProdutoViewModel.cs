using System.ComponentModel;

namespace MiniERP.EF.App.ViewModels
{
    public class ProdutoViewModel
    {
        [DisplayName("Código")]
        public int CodigoProduto { get; set; }

        [DisplayName("Produto")]
        public string Nome { get; set; }

        [DisplayName("Preço")]
        public decimal Preco { get; set; }

        [DisplayName("Estoque")]
        public int Estoque { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Id Fornecedor")]
        public int? FornecedorId { get; set; }

        [DisplayName("Fornecedor")]
        public string RazaoSocialFornecedor { get; set; }
    }
}
