namespace MiniERP.EF.App
{
    partial class Form_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu));
            Timer_Menu = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            ConsultarCliente = new ToolStripMenuItem();
            produtoToolStripMenuItem = new ToolStripMenuItem();
            ConsultarProduto = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            ConsultarFornecedor = new ToolStripMenuItem();
            notaFiscalToolStripMenuItem = new ToolStripMenuItem();
            ConsultarNotaFiscal = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            ConsultarInformacoes = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel_Msg = new ToolStripStatusLabel();
            toolStripStatusLabel_Usuario = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgData = new ToolStripStatusLabel();
            toolStripStatusLabel_Data = new ToolStripStatusLabel();
            toolStripStatusLabel_MsgHora = new ToolStripStatusLabel();
            toolStripStatusLabel_Hora = new ToolStripStatusLabel();
            panel_Cliente = new Panel();
            PictureBox_Cliente = new PictureBox();
            panel_Fornedor = new Panel();
            PictureBox_Fornecedor = new PictureBox();
            panel_Produto = new Panel();
            PictureBox_Produto = new PictureBox();
            panel_NotaFiscal = new Panel();
            PictureBox_NotaFiscal = new PictureBox();
            label1 = new Label();
            ToolStrip_Menu = new ToolStrip();
            Btn_Fechar_Menu = new ToolStripButton();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            panel_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Cliente).BeginInit();
            panel_Fornedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Fornecedor).BeginInit();
            panel_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_Produto).BeginInit();
            panel_NotaFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox_NotaFiscal).BeginInit();
            ToolStrip_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Timer_Menu
            // 
            Timer_Menu.Enabled = true;
            Timer_Menu.Tick += Timer_Menu_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Gainsboro;
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, produtoToolStripMenuItem, fornecedorToolStripMenuItem, notaFiscalToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarCliente });
            clienteToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(63, 21);
            clienteToolStripMenuItem.Text = "Cliente";
            // 
            // ConsultarCliente
            // 
            ConsultarCliente.Name = "ConsultarCliente";
            ConsultarCliente.Size = new Size(135, 22);
            ConsultarCliente.Text = "Consultar";
            ConsultarCliente.Click += ConsultarCliente_Click;
            // 
            // produtoToolStripMenuItem
            // 
            produtoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarProduto });
            produtoToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            produtoToolStripMenuItem.Size = new Size(70, 21);
            produtoToolStripMenuItem.Text = "Produto";
            // 
            // ConsultarProduto
            // 
            ConsultarProduto.Name = "ConsultarProduto";
            ConsultarProduto.Size = new Size(135, 22);
            ConsultarProduto.Text = "Consultar";
            ConsultarProduto.Click += ConsultarProduto_Click;
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarFornecedor });
            fornecedorToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.Size = new Size(89, 21);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // ConsultarFornecedor
            // 
            ConsultarFornecedor.Name = "ConsultarFornecedor";
            ConsultarFornecedor.Size = new Size(135, 22);
            ConsultarFornecedor.Text = "Consultar";
            ConsultarFornecedor.Click += ConsultarFornecedor_Click;
            // 
            // notaFiscalToolStripMenuItem
            // 
            notaFiscalToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarNotaFiscal });
            notaFiscalToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            notaFiscalToolStripMenuItem.Name = "notaFiscalToolStripMenuItem";
            notaFiscalToolStripMenuItem.Size = new Size(88, 21);
            notaFiscalToolStripMenuItem.Text = "Nota Fiscal";
            // 
            // ConsultarNotaFiscal
            // 
            ConsultarNotaFiscal.Name = "ConsultarNotaFiscal";
            ConsultarNotaFiscal.Size = new Size(135, 22);
            ConsultarNotaFiscal.Text = "Consultar";
            ConsultarNotaFiscal.Click += ConsultarNotaFiscal_Click;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConsultarInformacoes });
            sobreToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(55, 21);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // ConsultarInformacoes
            // 
            ConsultarInformacoes.Name = "ConsultarInformacoes";
            ConsultarInformacoes.Size = new Size(152, 22);
            ConsultarInformacoes.Text = "Informações";
            ConsultarInformacoes.Click += ConsultarInformacoes_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.Gainsboro;
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel_Msg, toolStripStatusLabel_Usuario, toolStripStatusLabel_MsgData, toolStripStatusLabel_Data, toolStripStatusLabel_MsgHora, toolStripStatusLabel_Hora });
            statusStrip1.Location = new Point(0, 337);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(584, 24);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_Msg
            // 
            toolStripStatusLabel_Msg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Msg.Name = "toolStripStatusLabel_Msg";
            toolStripStatusLabel_Msg.Size = new Size(86, 19);
            toolStripStatusLabel_Msg.Text = "Bem-vindo(a) ";
            // 
            // toolStripStatusLabel_Usuario
            // 
            toolStripStatusLabel_Usuario.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Usuario.ForeColor = Color.DodgerBlue;
            toolStripStatusLabel_Usuario.Name = "toolStripStatusLabel_Usuario";
            toolStripStatusLabel_Usuario.Size = new Size(39, 19);
            toolStripStatusLabel_Usuario.Text = ".....";
            // 
            // toolStripStatusLabel_MsgData
            // 
            toolStripStatusLabel_MsgData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgData.Name = "toolStripStatusLabel_MsgData";
            toolStripStatusLabel_MsgData.Size = new Size(36, 19);
            toolStripStatusLabel_MsgData.Text = "Data ";
            // 
            // toolStripStatusLabel_Data
            // 
            toolStripStatusLabel_Data.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Data.ForeColor = Color.DodgerBlue;
            toolStripStatusLabel_Data.Name = "toolStripStatusLabel_Data";
            toolStripStatusLabel_Data.Size = new Size(39, 19);
            toolStripStatusLabel_Data.Text = ".....";
            // 
            // toolStripStatusLabel_MsgHora
            // 
            toolStripStatusLabel_MsgHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_MsgHora.Name = "toolStripStatusLabel_MsgHora";
            toolStripStatusLabel_MsgHora.Size = new Size(37, 19);
            toolStripStatusLabel_MsgHora.Text = "Hora ";
            // 
            // toolStripStatusLabel_Hora
            // 
            toolStripStatusLabel_Hora.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel_Hora.ForeColor = Color.DodgerBlue;
            toolStripStatusLabel_Hora.Name = "toolStripStatusLabel_Hora";
            toolStripStatusLabel_Hora.Size = new Size(39, 19);
            toolStripStatusLabel_Hora.Text = ".....";
            // 
            // panel_Cliente
            // 
            panel_Cliente.Controls.Add(PictureBox_Cliente);
            panel_Cliente.Location = new Point(79, 121);
            panel_Cliente.Name = "panel_Cliente";
            panel_Cliente.Size = new Size(80, 80);
            panel_Cliente.TabIndex = 3;
            // 
            // PictureBox_Cliente
            // 
            PictureBox_Cliente.Cursor = Cursors.Hand;
            PictureBox_Cliente.Dock = DockStyle.Bottom;
            PictureBox_Cliente.Image = Properties.Resources.clientes;
            PictureBox_Cliente.Location = new Point(0, 0);
            PictureBox_Cliente.Name = "PictureBox_Cliente";
            PictureBox_Cliente.Size = new Size(80, 80);
            PictureBox_Cliente.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Cliente.TabIndex = 0;
            PictureBox_Cliente.TabStop = false;
            PictureBox_Cliente.Click += PictureBox_Cliente_Click;
            // 
            // panel_Fornedor
            // 
            panel_Fornedor.Controls.Add(PictureBox_Fornecedor);
            panel_Fornedor.Location = new Point(297, 121);
            panel_Fornedor.Name = "panel_Fornedor";
            panel_Fornedor.Size = new Size(80, 80);
            panel_Fornedor.TabIndex = 4;
            // 
            // PictureBox_Fornecedor
            // 
            PictureBox_Fornecedor.Cursor = Cursors.Hand;
            PictureBox_Fornecedor.Dock = DockStyle.Fill;
            PictureBox_Fornecedor.Image = Properties.Resources.fornecedor;
            PictureBox_Fornecedor.Location = new Point(0, 0);
            PictureBox_Fornecedor.Name = "PictureBox_Fornecedor";
            PictureBox_Fornecedor.Size = new Size(80, 80);
            PictureBox_Fornecedor.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Fornecedor.TabIndex = 0;
            PictureBox_Fornecedor.TabStop = false;
            PictureBox_Fornecedor.Click += PictureBox_Fornecedor_Click;
            // 
            // panel_Produto
            // 
            panel_Produto.Controls.Add(PictureBox_Produto);
            panel_Produto.Location = new Point(188, 121);
            panel_Produto.Name = "panel_Produto";
            panel_Produto.Size = new Size(80, 80);
            panel_Produto.TabIndex = 5;
            // 
            // PictureBox_Produto
            // 
            PictureBox_Produto.Cursor = Cursors.Hand;
            PictureBox_Produto.Dock = DockStyle.Fill;
            PictureBox_Produto.Image = Properties.Resources.produtos;
            PictureBox_Produto.Location = new Point(0, 0);
            PictureBox_Produto.Name = "PictureBox_Produto";
            PictureBox_Produto.Size = new Size(80, 80);
            PictureBox_Produto.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_Produto.TabIndex = 0;
            PictureBox_Produto.TabStop = false;
            PictureBox_Produto.Click += PictureBox_Produto_Click;
            // 
            // panel_NotaFiscal
            // 
            panel_NotaFiscal.Controls.Add(PictureBox_NotaFiscal);
            panel_NotaFiscal.Location = new Point(408, 121);
            panel_NotaFiscal.Name = "panel_NotaFiscal";
            panel_NotaFiscal.Size = new Size(80, 80);
            panel_NotaFiscal.TabIndex = 6;
            // 
            // PictureBox_NotaFiscal
            // 
            PictureBox_NotaFiscal.Cursor = Cursors.Hand;
            PictureBox_NotaFiscal.Dock = DockStyle.Fill;
            PictureBox_NotaFiscal.Image = Properties.Resources.nota_fiscal;
            PictureBox_NotaFiscal.Location = new Point(0, 0);
            PictureBox_NotaFiscal.Name = "PictureBox_NotaFiscal";
            PictureBox_NotaFiscal.Size = new Size(80, 80);
            PictureBox_NotaFiscal.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox_NotaFiscal.TabIndex = 0;
            PictureBox_NotaFiscal.TabStop = false;
            PictureBox_NotaFiscal.Click += PictureBox_NotaFiscal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(234, 45);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 7;
            label1.Text = "Mini ERP";
            // 
            // ToolStrip_Menu
            // 
            ToolStrip_Menu.BackColor = Color.White;
            ToolStrip_Menu.Dock = DockStyle.Bottom;
            ToolStrip_Menu.ImageScalingSize = new Size(36, 36);
            ToolStrip_Menu.Items.AddRange(new ToolStripItem[] { Btn_Fechar_Menu });
            ToolStrip_Menu.Location = new Point(0, 298);
            ToolStrip_Menu.Name = "ToolStrip_Menu";
            ToolStrip_Menu.Size = new Size(584, 39);
            ToolStrip_Menu.TabIndex = 8;
            ToolStrip_Menu.Text = "toolStrip1";
            // 
            // Btn_Fechar_Menu
            // 
            Btn_Fechar_Menu.Alignment = ToolStripItemAlignment.Right;
            Btn_Fechar_Menu.AutoSize = false;
            Btn_Fechar_Menu.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Fechar_Menu.Image = Properties.Resources.exit;
            Btn_Fechar_Menu.ImageTransparentColor = Color.Magenta;
            Btn_Fechar_Menu.Name = "Btn_Fechar_Menu";
            Btn_Fechar_Menu.Size = new Size(36, 36);
            Btn_Fechar_Menu.Text = "Sair";
            Btn_Fechar_Menu.Click += Btn_Fechar_Menu_Click;
            // 
            // Form_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 361);
            Controls.Add(ToolStrip_Menu);
            Controls.Add(label1);
            Controls.Add(panel_NotaFiscal);
            Controls.Add(panel_Produto);
            Controls.Add(panel_Fornedor);
            Controls.Add(panel_Cliente);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mini ERP";
            FormClosed += Form_Menu_FormClosed;
            Load += Form_Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panel_Cliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_Cliente).EndInit();
            panel_Fornedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_Fornecedor).EndInit();
            panel_Produto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_Produto).EndInit();
            panel_NotaFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox_NotaFiscal).EndInit();
            ToolStrip_Menu.ResumeLayout(false);
            ToolStrip_Menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer Timer_Menu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ConsultarCliente;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripMenuItem ConsultarFornecedor;
        private ToolStripMenuItem produtoToolStripMenuItem;
        private ToolStripMenuItem ConsultarProduto;
        private ToolStripMenuItem notaFiscalToolStripMenuItem;
        private ToolStripMenuItem ConsultarNotaFiscal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel_Msg;
        private ToolStripStatusLabel toolStripStatusLabel_MsgData;
        private ToolStripStatusLabel toolStripStatusLabel_Data;
        private ToolStripStatusLabel toolStripStatusLabel_MsgHora;
        private ToolStripStatusLabel toolStripStatusLabel_Hora;
        private Panel panel_Cliente;
        private PictureBox PictureBox_Cliente;
        private Panel panel_Fornedor;
        private PictureBox PictureBox_Fornecedor;
        private Panel panel_Produto;
        private PictureBox PictureBox_Produto;
        private Panel panel_NotaFiscal;
        private PictureBox PictureBox_NotaFiscal;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem ConsultarInformacoes;
        private Label label1;
        private ToolStrip ToolStrip_Menu;
        private ToolStripButton Btn_Fechar_Menu;
        private ToolStripStatusLabel toolStripStatusLabel_Usuario;
    }
}