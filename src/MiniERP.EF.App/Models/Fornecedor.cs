using System.ComponentModel;

namespace MiniERP.EF.App.Models
{
    public partial class Fornecedor
    {
        public Fornecedor()
        {
            Produtos = new HashSet<Produto>();
        }

        public int CodigoFornecedor { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        [Browsable(false)]
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
