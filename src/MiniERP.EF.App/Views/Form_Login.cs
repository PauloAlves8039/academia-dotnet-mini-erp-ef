using MiniERP.EF.App.Data;
using MiniERP.EF.App.Utils;
using System.Security.Cryptography;
using System.Text;

namespace MiniERP.EF.App.Views
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click_1(object sender, EventArgs e)
        {
            ExecutarLogin();
        }

        private void Btn_Limpar_Campos_Login_Click(object sender, EventArgs e)
        {
            LimparCamposLogin();
        }

        private void Btn_Cadastrar_Usuario_Click(object sender, EventArgs e)
        {
            Form_Usuario novoUsuario = new Form_Usuario();
            novoUsuario.Show();
        }

        private void Btn_Fechar_Login_Click_1(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void ExecutarLogin()
        {
            var username = txb_Usuario_Login.Text;
            var password = txb_Senha_login.Text;

            Utilitario.ValidarOsCamposDoUsuario(username, password);

            using (var context = new MiniERP_EFContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.NomeUsuario == username);

                if (usuario != null && VerificarSenha(password, usuario.Senha))
                {
                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Close();

                    Form_Menu formMenu = new Form_Menu(usuario.NomeUsuario);
                    formMenu.NomeUsuario = usuario.NomeUsuario;
                    formMenu.Show();
                }
                else
                {
                    MessageBox.Show("Falha no login. Verifique suas credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerificarSenha(string senha, string hashArmazenado)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                string hashSenhaDigitada = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashSenhaDigitada == hashArmazenado;
            }
        }

        private void LimparCamposLogin()
        {
            txb_Usuario_Login.Text = string.Empty;
            txb_Senha_login.Text = string.Empty;
        }
    }
}
