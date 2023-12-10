using MiniERP.EF.App.Models;
using MiniERP.EF.App.Services.Implementations;
using MiniERP.EF.App.Utils;

namespace MiniERP.EF.App.Views
{
    public partial class Form_Cliente : Form
    {
        private readonly ClienteService _clienteService = new ClienteService();

        public Form_Cliente()
        {
            InitializeComponent();
            PreencherDataGridViewClientes();
        }

        private async void Btn_Pesquisar_Cliente_Click(object sender, EventArgs e)
        {
            string pesquisa = txb_Pesquisar_Cliente.Text.Trim();

            if (string.IsNullOrEmpty(pesquisa))
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(pesquisa, out int codigoCliente))
            {
                Cliente clientePorCodigo = await _clienteService.ObterClientePorCodigo(codigoCliente);
                Utilitario.ExibirResultadoDaPesquisa(clientePorCodigo, "Código", dataGridView_Cliente);
                return;
            }

            if (Utilitario.ValidarQuantidadeCaracteresCpf(pesquisa))
            {
                Cliente clientePorCpf = await _clienteService.ObterClientePorCpf(pesquisa);
                Utilitario.ExibirResultadoDaPesquisa(clientePorCpf, "CPF", dataGridView_Cliente);
                return;
            }

            Cliente clientePorNome = await _clienteService.ObterClientePorNome(pesquisa);
            Utilitario.ExibirResultadoDaPesquisa(clientePorNome, "Nome", dataGridView_Cliente);
        }

        private async void Btn_Salvar_Cliente_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Cliente.Text.Trim();
            string cpf = mktb_CPF_Cliente.Text.Trim();
            string telefone = mktb_Telefone_Cliente.Text.Trim();
            string email = txb_Email_Cliente.Text.Trim();
            string endereco = txb_Endereco_Cliente.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Nome");
                return;
            }

            if (!Utilitario.ValidarNome(nome))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(cpf))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("CPF");
                return;
            }

            if (!Utilitario.ValidarQuantidadeCaracteresCpf(cpf))
            {
                MessageBox.Show("O CPF deve ter pelo menos 11 caracteres numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(telefone))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Telefone");
                return;
            }

            if (!Utilitario.ValidarQuantidadeCaracteresTelefone(telefone))
            {
                MessageBox.Show("O telefone deve ter 10 ou 11 dígitos numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Email");
                return;
            }

            if (!Utilitario.ValidarFormatoDoEmail(email))
            {
                return;
            }

            if (string.IsNullOrWhiteSpace(endereco))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Endereço");
                return;
            }

            if (int.TryParse(txb_Pesquisar_Cliente.Text, out int codigoCliente))
            {
                await AtualizarCliente(codigoCliente, nome, cpf, telefone, email, endereco);
            }
            else
            {
                await AdicionarNovoCliente(nome, cpf, telefone, email, endereco);
            }
        }

        private async void Btn_Excluir_Cliente_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_Pesquisar_Cliente.Text, out int clienteId))
            {
                try
                {
                    Cliente cliente = await _clienteService.ObterClientePorCodigo(clienteId);

                    if (cliente != null)
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este cliente?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            await _clienteService.RemoverCliente(cliente.CodigoCliente);
                            LimparCampoDePesquisa();
                            LimparCamposCliente();
                            PreencherDataGridViewClientes();
                            MessageBox.Show("Cliente excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro ao excluir cliente: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID de cliente válido para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Limpar_Campo_Cliente_Click(object sender, EventArgs e)
        {
            LimparCampoDePesquisa();
        }

        private void Btn_Limpar_Campos_Cliente_Click(object sender, EventArgs e)
        {
            LimparCamposCliente();
        }

        private void Btn_Sair_Cliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task AdicionarNovoCliente(string nome, string cpf, string telefone, string email, string endereco)
        {
            try
            {
                Cliente novoCliente = new Cliente
                {
                    Nome = nome,
                    Cpf = cpf,
                    Telefone = telefone,
                    Email = email,
                    Endereco = endereco
                };

                await _clienteService.AdicionarCliente(novoCliente);

                LimparCamposCliente();

                PreencherDataGridViewClientes();

                MessageBox.Show("Novo cliente adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao adicionar novo cliente: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarCliente(int codigoCliente, string nome, string cpf, string telefone, string email, string endereco)
        {
            try
            {
                Cliente clienteExistente = await _clienteService.ObterClientePorCodigo(codigoCliente);

                if (clienteExistente != null)
                {
                    clienteExistente.Nome = nome;
                    clienteExistente.Cpf = cpf;
                    clienteExistente.Telefone = telefone;
                    clienteExistente.Email = email;
                    clienteExistente.Endereco = endereco;

                    await _clienteService.AtualizarCliente(clienteExistente);

                    LimparCamposCliente();

                    PreencherDataGridViewClientes();

                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado para atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PreencherDataGridViewClientes()
        {
            try
            {
                List<Cliente> listaDeClientes = await _clienteService.ObeterTodosOsClientes();
                dataGridView_Cliente.DataSource = listaDeClientes;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao carregar clientes: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Cliente.Rows.Count)
            {
                DataGridViewRow row = dataGridView_Cliente.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["CodigoCliente"].Value.ToString(), out int codigoCliente))
                {
                    PreencherCamposComDadosDoCliente(codigoCliente);
                }
            }
        }

        private async void PreencherCamposComDadosDoCliente(int codigoCliente)
        {
            try
            {
                Cliente cliente = await _clienteService.ObterClientePorCodigo(codigoCliente);

                if (cliente != null)
                {
                    txb_Nome_Cliente.Text = cliente.Nome;
                    mktb_Telefone_Cliente.Text = cliente.Telefone;
                    mktb_CPF_Cliente.Text = cliente.Cpf;
                    txb_Email_Cliente.Text = cliente.Email;
                    txb_Endereco_Cliente.Text = cliente.Endereco;

                    txb_Pesquisar_Cliente.Text = cliente.CodigoCliente.ToString();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao obter cliente: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampoDePesquisa()
        {
            txb_Pesquisar_Cliente.Text = string.Empty;
        }

        private void LimparCamposCliente()
        {
            txb_Nome_Cliente.Text = string.Empty;
            mktb_CPF_Cliente.Text = string.Empty;
            mktb_Telefone_Cliente.Text = string.Empty;
            txb_Email_Cliente.Text = string.Empty;
            txb_Endereco_Cliente.Text = string.Empty;
        }
    }
}
