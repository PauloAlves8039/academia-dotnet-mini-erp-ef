using System.ComponentModel;

namespace MiniERP.EF.App.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        [DisplayName("Código")]
        public int CodigoFornecedor { get; set; }

        [DisplayName("Fornecedor")]
        public string RazaoSocial { get; set; }

        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Browsable(false)]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
