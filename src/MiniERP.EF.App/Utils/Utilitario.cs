using System.Text.RegularExpressions;

namespace MiniERP.EF.App.Utils
{
    public static class Utilitario
    {
        public static void ExibirResultadoDaPesquisa(object obj, string tipoPesquisa, DataGridView dataGridView)
        {
            if (obj != null)
            {
                dataGridView.DataSource = new List<object> { obj };
            }
            else
            {
                MessageBox.Show($"Nenhum {obj} encontrado para o {tipoPesquisa} especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void MostrarMensagemCampoObrigatorio(string nomeDoCampo)
        {
            MessageBox.Show($"O campo {nomeDoCampo} é obrigatório. Por favor, preencha-o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static bool ValidarNome(string nomeInformado)
        {
            if (!nomeInformado.Contains(" "))
            {
                MessageBox.Show("O nome deve conter pelo menos um espaço para o sobrenome. Por favor, insira um nome completo.", "Aviso");
                return false;
            }

            return true;
        }

        public static bool ValidarFormatoDoEmail(string emailInformado)
        {
            var formatoDoEmail = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

            if (!Regex.IsMatch(emailInformado, formatoDoEmail))
            {
                MessageBox.Show("O formato do email não é válido. Por favor, insira um email válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        public static bool ValidarQuantidadeCaracteresTelefone(string telefone)
        {
            var numerosDoTelefone = new string(telefone.Where(char.IsDigit).ToArray());
            return numerosDoTelefone.Length == 10 || numerosDoTelefone.Length == 11;
        }

        public static bool ValidarQuantidadeCaracteresCpf(string cpf)
        {
            var numerosDoCpf = new string(cpf.Where(char.IsDigit).ToArray());
            return numerosDoCpf.Length >= 11;
        }

        public static bool ValidarQuantidadeCaracteresCnpj(string cnpj)
        {
            var numerosDoCnpj = new string(cnpj.Where(char.IsDigit).ToArray());
            return numerosDoCnpj.Length >= 14;
        }
        public static bool ValidarOsCamposDoUsuario(string nome, string senha)
        {
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
