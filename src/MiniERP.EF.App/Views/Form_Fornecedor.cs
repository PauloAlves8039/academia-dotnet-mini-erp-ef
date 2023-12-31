﻿using MiniERP.EF.App.Models;
using MiniERP.EF.App.Services.Implementations;
using MiniERP.EF.App.Utils;

namespace MiniERP.EF.App.Views
{
    public partial class Form_Fornecedor : Form
    {
        private readonly FornecedorService _fornecedorService = new FornecedorService();

        public Form_Fornecedor()
        {
            InitializeComponent();
            PreencherDataGridViewFornecedores();
        }

        private async void Btn_Pesquisar_Fornecedor_Click(object sender, EventArgs e)
        {
            string pesquisa = txb_Pesquisar_Fornecedor.Text.Trim();

            if (string.IsNullOrEmpty(pesquisa))
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(pesquisa, out int codigoFornecedor))
            {
                Fornecedor fornecedorPorCodigo = await _fornecedorService.ObterFornecedorPorCodigo(codigoFornecedor);
                Utilitario.ExibirResultadoDaPesquisa(fornecedorPorCodigo, "Código", dataGridView_Fornecedor);
                return;
            }

            if (Utilitario.ValidarQuantidadeCaracteresCnpj(pesquisa))
            {
                Fornecedor fornecedorPorCnpj = await _fornecedorService.ObterFornecedorPorCnpj(pesquisa);
                Utilitario.ExibirResultadoDaPesquisa(fornecedorPorCnpj, "CNPJ", dataGridView_Fornecedor);
                return;
            }

            Fornecedor fornecedorPorRazaoSocial = await _fornecedorService.ObterFornecedorPorRazaoSocial(pesquisa);
            Utilitario.ExibirResultadoDaPesquisa(fornecedorPorRazaoSocial, "Razão Social", dataGridView_Fornecedor);
        }

        private async void Btn_Salvar_Fornecedor_Click(object sender, EventArgs e)
        {
            string razaoSocial = txb_RazaoSocial_Fornecedor.Text.Trim();
            string cnpj = mktb_CNPJ_Fornecedor.Text.Trim();
            string telefone = mktb_Telefone_Fornecedor.Text.Trim();
            string email = txb_Email_Fornecedor.Text.Trim();
            string endereco = txb_Endereco_Fornecedor.Text.Trim();

            if (string.IsNullOrWhiteSpace(razaoSocial))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Razão Social");
                return;
            }

            if (string.IsNullOrWhiteSpace(cnpj))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("CNPJ");
                return;
            }

            if (!Utilitario.ValidarQuantidadeCaracteresCnpj(cnpj))
            {
                MessageBox.Show("O CNPJ deve ter pelo menos 14 caracteres numéricos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (string.IsNullOrWhiteSpace(endereco))
            {
                Utilitario.MostrarMensagemCampoObrigatorio("Endereço");
                return;
            }

            if (int.TryParse(txb_Pesquisar_Fornecedor.Text, out int codigoFornecedor))
            {
                await AtualizarFornecedor(codigoFornecedor, razaoSocial, cnpj, telefone, email, endereco);
            }
            else
            {
                await AdicionarNovoFornecedor(razaoSocial, cnpj, telefone, email, endereco);
            }
        }

        private async void Btn_Excluir_Fornecedor_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txb_Pesquisar_Fornecedor.Text, out int codigoFornecedor))
            {
                try
                {
                    Fornecedor fornecedor = await _fornecedorService.ObterFornecedorPorCodigo(codigoFornecedor);

                    if (fornecedor != null)
                    {
                        DialogResult resultado = MessageBox.Show("Tem certeza que deseja excluir este fornecedor?", "Confirmação de Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            await _fornecedorService.RemoverFornecedor(codigoFornecedor);
                            LimparCampoDePesquisa();
                            LimparCamposFornecedor();
                            PreencherDataGridViewFornecedores();
                            MessageBox.Show("Fornecedor excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Fornecedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Erro ao excluir fornecedor: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um código do fornecedor válido para exclusão.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Limpar_Campo_Fornecedor_Click(object sender, EventArgs e)
        {
            LimparCampoDePesquisa();
        }

        private void Btn_Info_Fornecedor_Click(object sender, EventArgs e)
        {
            Form_Info informacoes = new Form_Info();
            informacoes.Show();
        }

        private void Btn_Limpar_Campos_Fornecedor_Click(object sender, EventArgs e)
        {
            LimparCamposFornecedor();
        }

        private void Btn_Sair_Fornecedor_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async Task AdicionarNovoFornecedor(string razaoSocial, string cnpj, string telefone, string email, string endereco)
        {
            try
            {
                Fornecedor novoFornecedor = new Fornecedor
                {
                    RazaoSocial = razaoSocial,
                    Cnpj = cnpj,
                    Telefone = telefone,
                    Email = email,
                    Endereco = endereco
                };

                await _fornecedorService.AdicionarFornecedor(novoFornecedor);

                LimparCamposFornecedor();

                PreencherDataGridViewFornecedores();

                MessageBox.Show("Novo fornecedor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao adicionar novo fornecdor: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task AtualizarFornecedor(int codigoFornecedor, string razaoSocial, string cnpj, string telefone, string email, string endereco)
        {
            try
            {
                Fornecedor fornecedorExistente = await _fornecedorService.ObterFornecedorPorCodigo(codigoFornecedor);

                if (fornecedorExistente != null)
                {
                    fornecedorExistente.RazaoSocial = razaoSocial;
                    fornecedorExistente.Cnpj = cnpj;
                    fornecedorExistente.Telefone = telefone;
                    fornecedorExistente.Email = email;
                    fornecedorExistente.Endereco = endereco;

                    await _fornecedorService.AtualizarFornecedor(fornecedorExistente);

                    LimparCamposFornecedor();

                    PreencherDataGridViewFornecedores();

                    MessageBox.Show("Fornecedor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado para atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao atualizar Fornecedor: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_Fornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView_Fornecedor.Rows.Count)
            {
                DataGridViewRow row = dataGridView_Fornecedor.Rows[e.RowIndex];

                if (int.TryParse(row.Cells["CodigoFornecedor"].Value.ToString(), out int codigoFornecedor))
                {
                    PreencherCamposComDadosDoFornecedor(codigoFornecedor);
                }
            }
        }

        private async void PreencherDataGridViewFornecedores()
        {
            try
            {
                List<Fornecedor> fornecedores = await _fornecedorService.ObterTodosOsFornecedores();
                dataGridView_Fornecedor.DataSource = fornecedores;
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PreencherCamposComDadosDoFornecedor(int codigoFornecedor)
        {
            try
            {
                Fornecedor fornecedor = await _fornecedorService.ObterFornecedorPorCodigo(codigoFornecedor);

                if (fornecedor != null)
                {
                    txb_RazaoSocial_Fornecedor.Text = fornecedor.RazaoSocial;
                    mktb_CNPJ_Fornecedor.Text = fornecedor.Cnpj;
                    mktb_Telefone_Fornecedor.Text = fornecedor.Telefone;
                    txb_Email_Fornecedor.Text = fornecedor.Email;
                    txb_Endereco_Fornecedor.Text = fornecedor.Endereco;

                    txb_Pesquisar_Fornecedor.Text = fornecedor.CodigoFornecedor.ToString();
                }
                else
                {
                    MessageBox.Show("Fornecedor não encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Erro ao obter Fornecedor: " + exception.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampoDePesquisa()
        {
            txb_Pesquisar_Fornecedor.Text = string.Empty;
        }

        private void LimparCamposFornecedor()
        {
            txb_RazaoSocial_Fornecedor.Text = string.Empty;
            mktb_CNPJ_Fornecedor.Text = string.Empty;
            mktb_Telefone_Fornecedor.Text = string.Empty;
            txb_Email_Fornecedor.Text = string.Empty;
            txb_Endereco_Fornecedor.Text = string.Empty;
        }
    }
}
