using System.ComponentModel;

namespace MiniERP.EF.App.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            NotaFiscals = new HashSet<NotaFiscal>();
        }

        [DisplayName("Código")]
        public int CodigoCliente { get; set; }

        [DisplayName("Nome")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public string Cpf { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Email")]
        public string Email { get; set; }

        [DisplayName("Endereço")]
        public string Endereco { get; set; }

        [Browsable(false)]
        public virtual ICollection<NotaFiscal> NotaFiscals { get; set; }
    }
}
