using MiniERP.EF.App.Models;
using MiniERP.EF.App.Services;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Views
{
    public partial class Form_NotaFiscal : Form
    {
        private readonly NotaFiscalService _notaFiscalService = new NotaFiscalService();
        private readonly ClienteService _clientelService = new ClienteService();
        private readonly ProdutoService _produtolService = new ProdutoService();

        public Form_NotaFiscal()
        {
            InitializeComponent();
            CarregarClientes();
            CarregarProdutos();
            PreencherDataGridViewNotaFiscal();
        }

        private async void Btn_Salvar_NotaFiscal_Click(object sender, EventArgs e)
        {
            if (!ValidarCamposNotaFiscal())
            {
                return;
            }

            int codigoCliente = (int)cbx_Cliente_NotaFiscal.SelectedItem;
            NotaFiscal novaNotaFiscal = CriarNovaNotaFiscal(codigoCliente);

            if (!int.TryParse(cbx_Produto_NotaFiscal.SelectedItem?.ToString(), out int codigoProduto) ||
                !int.TryParse(nud_Quantidade_NotaFiscal.Text, out int quantidade))
            {
                MessageBox.Show("Por favor, preencha os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Produto produto = await _produtolService.ObterProdutoPorCodigo(codigoProduto);

            AdicionarItemNotaFiscal(novaNotaFiscal, produto, quantidade);

            try
            {
                await _notaFiscalService.CadastrarNotaFiscal(novaNotaFiscal);

                PreencherDataGridViewNotaFiscal();

                LimparCamposNotaFiscal();

                MessageBox.Show("Nota fiscal cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar nota fiscal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_Pesquisar_NotaFiscal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_Pesquisar_NotaFiscal.Text, out int codigoNotaFiscal))
            {
                try
                {
                    List<NotaFiscalViewModel> notaFiscal = await _notaFiscalService.ObterNotasFiscaisComClienteEItem();

                    notaFiscal = notaFiscal.Where(n => n.CodigoNotaFiscal == codigoNotaFiscal).ToList();

                    if (notaFiscal.Any())
                    {
                        dataGridView_NotaFiscal.DataSource = notaFiscal;

                        MessageBox.Show("Nota fiscal encontrada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nota fiscal não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao pesquisar nota fiscal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de nota fiscal válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Limpar_Campo_NotaFiscal_Click(object sender, EventArgs e)
        {
            LimparCampoDePesquisa();
        }

        private void Btn_Limpar_Campos_NotaFiscal_Click(object sender, EventArgs e)
        {
            LimparCamposNotaFiscal();
        }

        private void Btn_Sair_Fornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool ValidarCamposNotaFiscal()
        {
            if (cbx_Cliente_NotaFiscal.SelectedItem == null ||
                cbx_Produto_NotaFiscal.SelectedItem == null ||
                nud_Quantidade_NotaFiscal.Value == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos da nota fiscal.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async void PreencherDataGridViewNotaFiscal()
        {
            try
            {
                List<NotaFiscalViewModel> notaFiscal = await _notaFiscalService.ObterNotasFiscaisComClienteEItem();

                dataGridView_NotaFiscal.DataSource = notaFiscal;

                dataGridView_NotaFiscal.Columns["CodigoNotaFiscal"].DisplayIndex = 0;
                dataGridView_NotaFiscal.Columns["DataEmissao"].DisplayIndex = 1;
                dataGridView_NotaFiscal.Columns["ClienteId"].DisplayIndex = 2;
                dataGridView_NotaFiscal.Columns["NomeCliente"].DisplayIndex = 3;
                dataGridView_NotaFiscal.Columns["Cpf"].DisplayIndex = 4;
                dataGridView_NotaFiscal.Columns["TelefoneCliente"].DisplayIndex = 5;
                dataGridView_NotaFiscal.Columns["EmailCliente"].DisplayIndex = 6;
                dataGridView_NotaFiscal.Columns["EnderecoCliente"].DisplayIndex = 7;
                dataGridView_NotaFiscal.Columns["ProdutoId"].DisplayIndex = 8;
                dataGridView_NotaFiscal.Columns["NomeProduto"].DisplayIndex = 9;
                dataGridView_NotaFiscal.Columns["Descricao"].DisplayIndex = 10;
                dataGridView_NotaFiscal.Columns["Quantidade"].DisplayIndex = 11;
                dataGridView_NotaFiscal.Columns["ValorUnitario"].DisplayIndex = 12;
                dataGridView_NotaFiscal.Columns["ValorTotal"].DisplayIndex = 13;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private NotaFiscal CriarNovaNotaFiscal(int clienteId)
        {
            NotaFiscal novaNotaFiscal = new NotaFiscal
            {
                DataEmissao = DateTime.Now,
                ClienteId = clienteId,
                ItemNotaFiscals = new List<ItemNotaFiscal>()
            };

            return novaNotaFiscal;
        }

        private void AdicionarItemNotaFiscal(NotaFiscal notaFiscal, Produto produto, int quantidade)
        {
            if (notaFiscal != null && produto != null && quantidade > 0)
            {
                ItemNotaFiscal novoItem = new ItemNotaFiscal
                {
                    ProdutoId = produto.CodigoProduto,
                    Quantidade = quantidade,
                    ValorUnitario = produto.Preco
                };

                notaFiscal.ItemNotaFiscals.Add(novoItem);
                notaFiscal.ValorTotal = _notaFiscalService.CalcularValorTotal(notaFiscal);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto e insira uma quantidade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_NotaFiscal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_NotaFiscal.Rows.Count)
            {
                DataGridViewRow row = dataGridView_NotaFiscal.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["CodigoNotaFiscal"].Value.ToString(), out int condigoNotaFiscal))
                {
                    Form_DetalhesNotaFiscal formDetalhesNotaFiscal = new Form_DetalhesNotaFiscal(condigoNotaFiscal);
                    formDetalhesNotaFiscal.ShowDialog();
                }
            }
        }

        private async void CarregarClientes()
        {
            try
            {
                List<Cliente> clientes = await _clientelService.ObeterTodosOsClientes();

                cbx_Cliente_NotaFiscal.Items.Clear();

                foreach (Cliente cliente in clientes)
                {
                    cbx_Cliente_NotaFiscal.Items.Add(cliente.CodigoCliente);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro ao carregar dados do cliente: {exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CarregarProdutos()
        {
            try
            {
                List<Produto> produtos = await _produtolService.ObterTodosOsProdutos();

                cbx_Produto_NotaFiscal.Items.Clear();

                foreach (Produto produto in produtos)
                {
                    cbx_Produto_NotaFiscal.Items.Add(produto.CodigoProduto);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro ao carregar dados do produto: {exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampoDePesquisa()
        {
            txb_Pesquisar_NotaFiscal.Text = string.Empty;
        }

        private void LimparCamposNotaFiscal()
        {
            cbx_Cliente_NotaFiscal.SelectedItem = null;
            cbx_Produto_NotaFiscal.SelectedItem = null;
            nud_Quantidade_NotaFiscal.Value = 0;
        }
    }
}
