using System.ComponentModel;

namespace MiniERP.EF.App.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            NotaFiscals = new HashSet<NotaFiscal>();
        }

        public int CodigoCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }

        [Browsable(false)]
        public virtual ICollection<NotaFiscal> NotaFiscals { get; set; }
    }
}
