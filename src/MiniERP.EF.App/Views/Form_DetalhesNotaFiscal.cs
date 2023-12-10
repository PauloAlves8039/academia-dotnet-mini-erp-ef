using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using MiniERP.EF.App.Services.Implementations;

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

        private void Btn_Salvar_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                GerarPdfNotaFiscal();
                MessageBox.Show("Nota baixada como PDF.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao baixar nota fiscal como PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerarPdfNotaFiscal()
        {
            try
            {
                string caminhoDoPDF = @"C:\DetalhesNotaFiscal.pdf";

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                saveFileDialog.Title = "PDF Nota Fiscal - Mini ERP";
                saveFileDialog.FileName = caminhoDoPDF;

                using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        document.Add(new Paragraph("Mini ERP").SetBold().SetTextAlignment(TextAlignment.CENTER));

                        document.Add(new Paragraph("\n"));

                        document.Add(new Paragraph("Detalhes da Nota Fiscal").SetBold().SetTextAlignment(TextAlignment.CENTER));

                        Table tabelaCliente = CriarTabelaCliente();
                        document.Add(tabelaCliente);

                        document.Add(new Paragraph("\n"));

                        Table tabelaProdutos = CriarTabelaProduto();
                        document.Add(tabelaProdutos);

                        document.Add(new Paragraph("\n"));

                        Table tabelaValorTotal = CriarTabelaValorTotal();
                        document.Add(tabelaValorTotal);

                        document.Add(new Paragraph("\n"));

                        AdicionarLinhaHorizontal(document);

                        document.Add(new Paragraph("Desenvolvido por: Paulo Alves").SetBold().SetTextAlignment(TextAlignment.CENTER));

                        MessageBox.Show("Nota fiscal salva como PDF.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar nota fiscal como PDF: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Table CriarTabelaCliente()
        {
            Table tabela = new Table(2);

            tabela.AddCell(new Cell(1, 2).Add(new Paragraph("Dados do Cliente")).SetBold().SetTextAlignment(TextAlignment.CENTER));

            AdicionarLinhaNaTabela(tabela, "Código do Cliente:", lbl_Codigo_Cliente.Text);
            AdicionarLinhaNaTabela(tabela, "Cliente:", lbl_Nome_Cliente.Text);
            AdicionarLinhaNaTabela(tabela, "CPF:", lbl_CPF_Cliente.Text);
            AdicionarLinhaNaTabela(tabela, "Telefone:", lbl_Telefone_Cliente.Text);
            AdicionarLinhaNaTabela(tabela, "Email:", lbl_Email_Cliente.Text);
            AdicionarLinhaNaTabela(tabela, "Endereço:", lbl_Endereco_Cliente.Text);

            return tabela;
        }

        private Table CriarTabelaProduto()
        {
            Table tabela = new Table(2);

            tabela.AddCell(new Cell(1, 2).Add(new Paragraph("Dados do Produto")).SetBold().SetTextAlignment(TextAlignment.CENTER));

            AdicionarLinhaNaTabela(tabela, "Código do Produto:", lbl_Codigo_Produto.Text);
            AdicionarLinhaNaTabela(tabela, "Produto:", lbl_Nome_Produto.Text);
            AdicionarLinhaNaTabela(tabela, "Descrição:", lbl_Descricao_Produto.Text);
            AdicionarLinhaNaTabela(tabela, "Quantidade:", lbl_Quantidade_Produto.Text);
            AdicionarLinhaNaTabela(tabela, "Valor Unitário:", lbl_ValorUnitario_Produto.Text);

            return tabela;
        }

        private Table CriarTabelaValorTotal()
        {
            Table tabela = new Table(2);

            tabela.AddCell(new Cell(1, 2).Add(new Paragraph("Valor Total")).SetBold().SetTextAlignment(TextAlignment.CENTER));

            AdicionarLinhaNaTabela(tabela, "Valor Total:", lbl_ValorTotal_NotaFiscal.Text);

            return tabela;
        }

        private void AdicionarLinhaNaTabela(Table table, params string[] valores)
        {
            foreach (var valor in valores)
            {
                table.AddCell(new Cell().Add(new Paragraph(valor)));
            }
        }

        private void AdicionarLinhaHorizontal(Document document)
        {
            document.Add(new LineSeparator(new SolidLine()));
        }
    }
}
