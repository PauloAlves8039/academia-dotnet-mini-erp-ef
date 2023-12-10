using MiniERP.EF.App.Views;

namespace MiniERP.EF.App
{
    public partial class Form_Menu : Form
    {
        public string NomeUsuario { get; set; }

        public Form_Menu(string nomeUsuario)
        {
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel_Usuario.Text = NomeUsuario;
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Menu_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_Data.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel_Hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void ConsultarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormCliente();
        }

        private void ConsultarProduto_Click(object sender, EventArgs e)
        {
            AbrirFormProduto();
        }

        private void ConsultarFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormFornecedor();
        }

        private void ConsultarNotaFiscal_Click(object sender, EventArgs e)
        {
            AbrirFormNotaFiscal();
        }

        private void ConsultarInformacoes_Click(object sender, EventArgs e)
        {
            AbrirFormInfo();
        }

        private void PictureBox_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormCliente();
        }

        private void PictureBox_Produto_Click(object sender, EventArgs e)
        {
            AbrirFormProduto();
        }

        private void PictureBox_Fornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormFornecedor();
        }

        private void PictureBox_NotaFiscal_Click(object sender, EventArgs e)
        {
            AbrirFormNotaFiscal();
        }

        private void Btn_Fechar_Menu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AbrirFormCliente()
        {
            Form_Cliente cliente = new Form_Cliente();
            cliente.Show();
        }

        private void AbrirFormProduto()
        {
            Form_Produto produto = new Form_Produto();
            produto.Show();
        }

        private void AbrirFormFornecedor()
        {
            Form_Fornecedor fornecedor = new Form_Fornecedor();
            fornecedor.Show();
        }

        private void AbrirFormNotaFiscal()
        {
            Form_NotaFiscal notaFiscal = new Form_NotaFiscal();
            notaFiscal.Show();
        }

        private void AbrirFormSobre_Click(object sender, EventArgs e)
        {
            Form_Sobre sobre = new Form_Sobre();
            sobre.Show();
        }

        private void AbrirFormInfo()
        {
            Form_Info info = new Form_Info();
            info.Show();
        }
    }
}
