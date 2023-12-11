using MiniERP.EF.App.Models;
using MiniERP.EF.App.Services.Implementations;
using MiniERP.EF.App.Utils;
using MiniERP.EF.App.ViewModels;

namespace MiniERP.EF.App.Views
{
    public partial class Form_Produto : Form
    {
        private readonly ProdutoService _produtoService = new ProdutoService();
        private readonly FornecedorService _fornecedorService = new FornecedorService();

        public Form_Produto()
        {
            InitializeComponent();
            CarregarFornecedores();
            PreencherDataGridViewProdutos();
        }

        private async void Btn_Salvar_Produto_Click(object sender, EventArgs e)
        {
            string nome = txb_Nome_Produto.Text.Trim();
            string descricao = txb_Descricao_Produto.Text.Trim();
            int estoque = (int)nud_Estoque_Produto.Value;
            decimal preco;
            int codigoFornecedor;

            if (string.IsNullOrWhiteSpace(nome))
            {
                MostrarMensagemCampoObrigatorio("Nome");
                return;
            }

            if (!decimal.TryParse(txb_Preco_Produto.Text.Trim(), out preco))
            {
                MessageBox.Show("Por favor, insira um preço válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (estoque <= 0)
            {
                MessageBox.Show("Por favor, insira um valor de estoque maior que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ValidarComboBox(out codigoFornecedor))
            {
                return;
            }

            if (int.TryParse(txb_Pesquisar_Produto.Text, out int codigoProduto))
            {
                await AtualizarProduto(codigoProduto, nome, preco, estoque, descricao, codigoFornecedor);
            }
            else
            {
                await AdicionarNovoProduto(nome, preco, estoque, descricao, codigoFornecedor);
            }
        }

        private async void Btn_Pesquisar_Produto_Click(object sender, EventArgs e)
        {
            string pesquisa = txb_Pesquisar_Produto.Text.Trim();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                if (int.TryParse(pesquisa, out int codigoProduto))
                {
                    Produto produtoPorCodigo = await _produtoService.ObterProdutoPorCodigo(codigoProduto);

                    if (produtoPorCodigo != null)
                    {
                        List<Produto> listaProdutos = new List<Produto> { produtoPorCodigo };
                        dataGridView_Produto.DataSource = listaProdutos;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado para o código especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    Produto produtoPorNome = await _produtoService.ObterProdutoPorNome(pesquisa);

                    if (produtoPorNome != null)
                    {
                        List<Produto> listaProdutos = new List<Produto> { produtoPorNome };
                        dataGridView_Produto.DataSource = listaProdutos;
                    }
                    else
                    {
                        MessageBox.Show("Nenhum produto encontrado para o termo de pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Btn_Excluir_Produto_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_Pesquisar_Produto.Text, out int codigoProduto))
            {
                try
                {
                    Produto produto = await _produtoService.ObterProdutoPorCodigo(codigoProduto);

                    if (produto != null)
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este produto?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            await _produtoService.RemoverProduto(produto.CodigoProduto);
                            LimparCampoDePesquisa();
                            LimparCamposProduto();
                            PreencherDataGridViewProdutos();
                            MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro ao excluir produto: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código de produto válido para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Limpar_Campo_Produto_Click(object sender, EventArgs e)
        {
            LimparCampoDePesquisa();
        }

        private void Btn_Info_Produto_Click(object sender, EventArgs e)
        {
            Form_Info informacoes = new Form_Info();
            informacoes.Show();
        }

        private void Btn_Limpar_Campos_Produto_Click(object sender, EventArgs e)
        {
            LimparCamposProduto();
        }

        private void Btn_Sair_Fornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task AdicionarNovoProduto(string nome, decimal preco, int estoque, string descricao, int codigoFornecedor)
        {
            try
            {
                Fornecedor fornecedorExistente = await _fornecedorService.ObterFornecedorPorCodigo(codigoFornecedor);

                if (fornecedorExistente != null)
                {
                    Produto novoProduto = new Produto
                    {
                        Nome = nome,
                        Preco = preco,
                        Estoque = estoque,
                        Descricao = descricao,
                        FornecedorId = fornecedorExistente.CodigoFornecedor
                    };

                    await _produtoService.AdicionarProduto(novoProduto);

                    LimparCamposProduto();

                    PreencherDataGridViewProdutos();

                    MessageBox.Show("Novo produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado. Por favor, selecione um fornecedor válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao adicionar novo produto: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarProduto(int codigoProduto, string nome, decimal preco, int estoque, string descricao, int codigoFornecedor)
        {
            try
            {
                Produto produtoExistente = await _produtoService.ObterProdutoPorCodigo(codigoProduto);

                if (produtoExistente != null)
                {
                    produtoExistente.Nome = nome;
                    produtoExistente.Preco = preco;
                    produtoExistente.Estoque = estoque;
                    produtoExistente.Descricao = descricao;
                    produtoExistente.FornecedorId = codigoFornecedor;

                    await _produtoService.AtualizarProduto(produtoExistente);

                    LimparCamposProduto();

                    PreencherDataGridViewProdutos();

                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado para atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao atualizar Produto: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Produto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Produto.Rows.Count)
            {
                DataGridViewRow row = dataGridView_Produto.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["CodigoProduto"].Value.ToString(), out int codigoProduto))
                {
                    PreencherCamposComDadosDoProduto(codigoProduto);
                }
            }
        }

        private async void PreencherDataGridViewProdutos()
        {
            try
            {
                List<ProdutoViewModel> produtos = await _produtoService.ObterTodosOsProdutosViewModel();
                dataGridView_Produto.DataSource = produtos;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao carregar produtos: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PreencherCamposComDadosDoProduto(int codigoProduto)
        {
            try
            {
                Produto produto = await _produtoService.ObterProdutoPorCodigo(codigoProduto);

                if (produto != null)
                {
                    txb_Nome_Produto.Text = produto.Nome;
                    txb_Preco_Produto.Text = produto.Preco.ToString();
                    nud_Estoque_Produto.Value = produto.Estoque;
                    txb_Descricao_Produto.Text = produto.Descricao;

                    cbx_Fornecedor.SelectedItem = produto.FornecedorId;

                    txb_Pesquisar_Produto.Text = produto.CodigoProduto.ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao obter Produto: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CarregarFornecedores()
        {
            try
            {
                List<Fornecedor> fornecedores = await _fornecedorService.ObterTodosOsFornecedores();

                cbx_Fornecedor.Items.Clear();

                foreach (Fornecedor fornecedor in fornecedores)
                {
                    ComboBoxElement item = new ComboBoxElement
                    {
                        Value = fornecedor.CodigoFornecedor,
                        Text = fornecedor.RazaoSocial
                    };

                    cbx_Fornecedor.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Erro ao carregar dados do fornecedor: {exception.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarMensagemCampoObrigatorio(string nomeDoCampo)
        {
            MessageBox.Show($"O campo {nomeDoCampo} é obrigatório. Por favor, preencha-o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ValidarComboBox(out int codigoFornecedor)
        {
            codigoFornecedor = 0;

            if (cbx_Fornecedor.SelectedItem != null)
            {
                var selectedValue = cbx_Fornecedor.SelectedItem;

                if (selectedValue != null && selectedValue is ComboBoxElement)
                {
                    codigoFornecedor = ((ComboBoxElement)selectedValue).Value;
                    return true;
                }
                else
                {
                    MessageBox.Show("O valor selecionado no fornecedor é inválido. Por favor, selecione um fornecedor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um fornecedor.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LimparCampoDePesquisa()
        {
            txb_Pesquisar_Produto.Text = string.Empty;
        }

        private void LimparCamposProduto()
        {
            txb_Nome_Produto.Text = string.Empty;
            txb_Descricao_Produto.Text = string.Empty;
            txb_Preco_Produto.Text = string.Empty;
            nud_Estoque_Produto.Value = 0;
            cbx_Fornecedor.SelectedIndex = -1;
        }
    }
}
