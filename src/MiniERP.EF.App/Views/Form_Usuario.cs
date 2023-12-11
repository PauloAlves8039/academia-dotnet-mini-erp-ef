using MiniERP.EF.App.Data;
using MiniERP.EF.App.Models.Account;
using MiniERP.EF.App.Utils;

namespace MiniERP.EF.App.Views
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Usuario_Click_1(object sender, EventArgs e)
        {
            ExecutarCadastro();
        }

        private void Btn_Limpar_Campos_Click_1(object sender, EventArgs e)
        {
            LimparCamposCadastroUsuario();
        }

        private void Btn_Fechar_Login_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void LimparCamposCadastroUsuario()
        {
            txb_Usuario_Adcionado.Text = string.Empty;
            txb_Senha_Adicionada.Text = string.Empty;
        }

        private void ExecutarCadastro()
        {
            var nomeUsuario = txb_Usuario_Adcionado.Text;
            var senha = txb_Senha_Adicionada.Text;

            if (!Utilitario.ValidarOsCamposDoUsuario(nomeUsuario, senha))
            {
                return;
            }

            using (var context = new MiniERP_EFContext())
            {
                var novoUsuario = new Usuario
                {
                    NomeUsuario = nomeUsuario,
                };

                novoUsuario.CriarSenhaCriptografada(senha);

                context.Usuarios.Add(novoUsuario);
                context.SaveChanges();
            }

            MessageBox.Show("Usuário(a) cadastrado(a) com sucesso!");
            LimparCamposCadastroUsuario();
        }
    }
}
