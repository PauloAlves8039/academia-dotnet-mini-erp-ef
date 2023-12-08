using System.ComponentModel;

namespace MiniERP.EF.App.ViewModels
{
    public class NotaFiscalViewModel
    {
        [DisplayName("Código")]
        public int CodigoNotaFiscal { get; set; }

        [DisplayName("Emissão")]
        public DateTime DataEmissao { get; set; }

        [DisplayName("Total")]
        public decimal ValorTotal { get; set; }

        [DisplayName("Id do Cliente")]
        public int? ClienteId { get; set; }

        [DisplayName("Nome")]
        public string NomeCliente { get; set; }

        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Telefone")]
        public string TelefoneCliente { get; set; }

        [DisplayName("Email")]
        public string EmailCliente { get; set; }

        [DisplayName("Endereço")]
        public string EnderecoCliente { get; set; }

        [DisplayName("Id do Produto")]
        public int? ProdutoId { get; set; }

        [DisplayName("Produto")]
        public string NomeProduto { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        [DisplayName("Qtde")]
        public int Quantidade { get; set; }

        [DisplayName("Valor Unitário")]
        public decimal ValorUnitario { get; set; }

        public List<ItemNotaFiscalViewModel> ItemNotaFiscals { get; set; }
    }
}
