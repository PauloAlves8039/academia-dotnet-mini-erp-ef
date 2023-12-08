using MiniERP.EF.App.Services;

namespace MiniERP.EF.App.Views
{
    public partial class Form_DetalhesNotaFiscal : Form
    {
        private readonly NotaFiscalService _notaFiscalService = new NotaFiscalService();
        private readonly int _codigoNotaFiscal;
        Bitmap _bitmap;

        public Form_DetalhesNotaFiscal(int codigoNotaFiscal)
        {
            InitializeComponent();
            _codigoNotaFiscal = codigoNotaFiscal;
            PreencherDetalhesNotaFiscal();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(_bitmap, 0, 0);
        }

        private async void PreencherDetalhesNotaFiscal()
        {
            try
            {
                var notaFiscalViewModel = await _notaFiscalService.ObterNotaFiscalViewModelPorId(_codigoNotaFiscal);

                if (notaFiscalViewModel != null)
                {
                    lbl_Codigo_NotaFiscal.Text = notaFiscalViewModel.CodigoNotaFiscal.ToString();
                    lbl_DataEmissao_NotaFiscal.Text = notaFiscalViewModel.DataEmissao.ToString();

                    lbl_Codigo_Cliente.Text = notaFiscalViewModel.ClienteId.ToString();
                    lbl_Nome_Cliente.Text = notaFiscalViewModel.NomeCliente.ToString();
                    lbl_CPF_Cliente.Text = notaFiscalViewModel.Cpf.ToString();
                    lbl_Telefone_Cliente.Text = notaFiscalViewModel.TelefoneCliente.ToString();
                    lbl_Email_Cliente.Text = notaFiscalViewModel.EmailCliente.ToString();
                    lbl_Endereco_Cliente.Text = notaFiscalViewModel.EnderecoCliente.ToString();

                    foreach (var item in notaFiscalViewModel.ItemNotaFiscals)
                    {
                        lbl_Codigo_Produto.Text = item.ProdutoId.ToString();
                        lbl_Nome_Produto.Text = item.NomeProduto.ToString();
                        lbl_Quantidade_Produto.Text = item.Quantidade.ToString();
                        lbl_ValorUnitario_Produto.Text = item.ValorUnitario.ToString();
                        lbl_Descricao_Produto.Text = item.Descricao.ToString();
                    }

                    lbl_ValorTotal_NotaFiscal.Text = notaFiscalViewModel.ValorTotal.ToString();

                }
                else
                {
                    MessageBox.Show("Nota fiscal não encontrada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao obter detalhes da nota fiscal: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void Btn_Fechar_Detalhes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Imprimir_Nota_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            _bitmap = new Bitmap(this.Size.Width, this.Size.Height, graphics);

            Graphics gpc = Graphics.FromImage(_bitmap);
            gpc.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);

            printPreviewDialog1.ShowDialog();
        }
    }
}
