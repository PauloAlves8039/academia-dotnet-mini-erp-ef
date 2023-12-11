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
            var novoUsuario = new Form_Usuario();
            novoUsuario.Show();
        }

        private void Btn_Fechar_Login_Click_1(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void ExecutarLogin()
        {
            var nome = txb_Usuario_Login.Text;
            var senha = txb_Senha_login.Text;

            Utilitario.ValidarOsCamposDoUsuario(nome, senha);

            using (var context = new MiniERP_EFContext())
            {
                var usuario = context.Usuarios.FirstOrDefault(u => u.Nome == nome);

                if (usuario != null && AnalisarSenha(senha, usuario.Senha))
                {
                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    var formMenu = new Form_Menu(usuario.Nome);
                    formMenu.NomeUsuario = usuario.Nome;
                    Hide();
                    formMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Falha no login, por favro verifique suas credenciais.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool AnalisarSenha(string senha, string hashArmazenado)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                string hashSenhaInformada = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();

                return hashSenhaInformada == hashArmazenado;
            }
        }

        private void LimparCamposLogin()
        {
            txb_Usuario_Login.Text = string.Empty;
            txb_Senha_login.Text = string.Empty;
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja realmente fechar o sistema?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
