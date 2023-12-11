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
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MaxLength(64)]
        public string Senha { get; set; }

        public void CriarSenhaCriptografada(string senha)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                string hashString = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                if (hashString.Length > 64)
                {
                    throw new InvalidOperationException($"O comprimento do hash gerado é {hashString.Length}, que excede o tamanho permitido.");
                }

                Senha = hashString;
            }
        }
    }
}
