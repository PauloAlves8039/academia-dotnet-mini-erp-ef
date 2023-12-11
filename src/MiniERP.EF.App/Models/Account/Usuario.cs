using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace MiniERP.EF.App.Models.Account
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome de Usuário é obrigatório.")]
        [MaxLength(64)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MaxLength(64)]
        public string Senha { get; set; }

        public void ConfigurarCriptografiaNaSenha(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                var hashGerado = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                if (hashGerado.Length > 64)
                {
                    throw new InvalidOperationException($"O comprimento do seu hash gerado é {hashGerado.Length}, excede o tamanho permitido.");
                }

                Senha = hashGerado;
            }
        }
    }
}
