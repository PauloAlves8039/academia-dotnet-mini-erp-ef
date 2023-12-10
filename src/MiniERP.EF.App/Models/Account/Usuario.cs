using System.ComponentModel.DataAnnotations;

namespace MiniERP.EF.App.Models.Account
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string NomeUsuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string Senha { get; set; }
    }
}
