namespace MiniERP.EF.App.Views
{
    partial class Form_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Produto));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ToolStrip_Produto = new ToolStrip();
            Btn_Sair_Fornecedor = new ToolStripButton();
            groupBox_Formulario_Produto = new GroupBox();
            cbx_Fornecedor = new ComboBox();
            label3 = new Label();
            nud_Estoque_Produto = new NumericUpDown();
            ToolStrip_Formulario_Produto = new ToolStrip();
            Btn_Salvar_Produto = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Btn_Limpar_Campos_Produto = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Btn_Excluir_Produto = new ToolStripButton();
            txb_Preco_Produto = new TextBox();
            txb_Nome_Produto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            groupBox_Pesquisar_Produto = new GroupBox();
            txb_Pesquisar_Produto = new TextBox();
            label1 = new Label();
            ToolStrip_Pesquisar_Produto = new ToolStrip();
            Btn_Pesquisar_Produto = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Limpar_Campo_Produto = new ToolStripButton();
            dataGridView_Produto = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ToolStrip_Produto.SuspendLayout();
            groupBox_Formulario_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Estoque_Produto).BeginInit();
            ToolStrip_Formulario_Produto.SuspendLayout();
            groupBox_Pesquisar_Produto.SuspendLayout();
            ToolStrip_Pesquisar_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produto).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.produtos;
            pictureBox1.Location = new Point(451, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(351, 10);
            label7.Name = "label7";
            label7.Size = new Size(89, 30);
            label7.TabIndex = 16;
            label7.Text = "Produto";
            // 
            // ToolStrip_Produto
            // 
            ToolStrip_Produto.BackColor = Color.Gainsboro;
            ToolStrip_Produto.Dock = DockStyle.Bottom;
            ToolStrip_Produto.ImageScalingSize = new Size(36, 36);
            ToolStrip_Produto.Items.AddRange(new ToolStripItem[] { Btn_Sair_Fornecedor });
            ToolStrip_Produto.Location = new Point(0, 572);
            ToolStrip_Produto.Name = "ToolStrip_Produto";
            ToolStrip_Produto.Size = new Size(884, 39);
            ToolStrip_Produto.TabIndex = 15;
            ToolStrip_Produto.Text = "toolStrip1";
            // 
            // Btn_Sair_Fornecedor
            // 
            Btn_Sair_Fornecedor.Alignment = ToolStripItemAlignment.Right;
            Btn_Sair_Fornecedor.AutoSize = false;
            Btn_Sair_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Sair_Fornecedor.Image = Properties.Resources.exit;
            Btn_Sair_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Sair_Fornecedor.Name = "Btn_Sair_Fornecedor";
            Btn_Sair_Fornecedor.Size = new Size(36, 36);
            Btn_Sair_Fornecedor.Text = "Sair";
            Btn_Sair_Fornecedor.Click += Btn_Sair_Fornecedor_Click;
            // 
            // groupBox_Formulario_Produto
            // 
            groupBox_Formulario_Produto.Controls.Add(cbx_Fornecedor);
            groupBox_Formulario_Produto.Controls.Add(label3);
            groupBox_Formulario_Produto.Controls.Add(nud_Estoque_Produto);
            groupBox_Formulario_Produto.Controls.Add(ToolStrip_Formulario_Produto);
            groupBox_Formulario_Produto.Controls.Add(txb_Preco_Produto);
            groupBox_Formulario_Produto.Controls.Add(txb_Nome_Produto);
            groupBox_Formulario_Produto.Controls.Add(label6);
            groupBox_Formulario_Produto.Controls.Add(label5);
            groupBox_Formulario_Produto.Controls.Add(label2);
            groupBox_Formulario_Produto.Location = new Point(348, 241);
            groupBox_Formulario_Produto.Name = "groupBox_Formulario_Produto";
            groupBox_Formulario_Produto.Size = new Size(500, 300);
            groupBox_Formulario_Produto.TabIndex = 14;
            groupBox_Formulario_Produto.TabStop = false;
            groupBox_Formulario_Produto.Text = "Formulário Produto";
            // 
            // cbx_Fornecedor
            // 
            cbx_Fornecedor.FormattingEnabled = true;
            cbx_Fornecedor.Location = new Point(112, 172);
            cbx_Fornecedor.Name = "cbx_Fornecedor";
            cbx_Fornecedor.Size = new Size(120, 23);
            cbx_Fornecedor.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 180);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 12;
            label3.Text = "Fornecedor:";
            // 
            // nud_Estoque_Produto
            // 
            nud_Estoque_Produto.Location = new Point(113, 126);
            nud_Estoque_Produto.Name = "nud_Estoque_Produto";
            nud_Estoque_Produto.Size = new Size(120, 23);
            nud_Estoque_Produto.TabIndex = 11;
            // 
            // ToolStrip_Formulario_Produto
            // 
            ToolStrip_Formulario_Produto.BackColor = Color.Gainsboro;
            ToolStrip_Formulario_Produto.Dock = DockStyle.Bottom;
            ToolStrip_Formulario_Produto.ImageScalingSize = new Size(36, 36);
            ToolStrip_Formulario_Produto.Items.AddRange(new ToolStripItem[] { Btn_Salvar_Produto, toolStripSeparator2, Btn_Limpar_Campos_Produto, toolStripSeparator3, Btn_Excluir_Produto });
            ToolStrip_Formulario_Produto.Location = new Point(3, 258);
            ToolStrip_Formulario_Produto.Name = "ToolStrip_Formulario_Produto";
            ToolStrip_Formulario_Produto.Size = new Size(494, 39);
            ToolStrip_Formulario_Produto.TabIndex = 10;
            ToolStrip_Formulario_Produto.Text = "toolStrip1";
            // 
            // Btn_Salvar_Produto
            // 
            Btn_Salvar_Produto.AutoSize = false;
            Btn_Salvar_Produto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Salvar_Produto.Image = Properties.Resources.disk_blue;
            Btn_Salvar_Produto.ImageTransparentColor = Color.Magenta;
            Btn_Salvar_Produto.Name = "Btn_Salvar_Produto";
            Btn_Salvar_Produto.Size = new Size(36, 36);
            Btn_Salvar_Produto.Text = "Salvar Produto";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos_Produto
            // 
            Btn_Limpar_Campos_Produto.AutoSize = false;
            Btn_Limpar_Campos_Produto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos_Produto.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos_Produto.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos_Produto.Name = "Btn_Limpar_Campos_Produto";
            Btn_Limpar_Campos_Produto.Size = new Size(36, 36);
            Btn_Limpar_Campos_Produto.Text = "Limpar Campos";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // Btn_Excluir_Produto
            // 
            Btn_Excluir_Produto.AutoSize = false;
            Btn_Excluir_Produto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Excluir_Produto.Image = Properties.Resources.lixo;
            Btn_Excluir_Produto.ImageTransparentColor = Color.Magenta;
            Btn_Excluir_Produto.Name = "Btn_Excluir_Produto";
            Btn_Excluir_Produto.Size = new Size(36, 36);
            Btn_Excluir_Produto.Text = "Excluir Produto";
            // 
            // txb_Preco_Produto
            // 
            txb_Preco_Produto.Location = new Point(113, 78);
            txb_Preco_Produto.Name = "txb_Preco_Produto";
            txb_Preco_Produto.Size = new Size(100, 23);
            txb_Preco_Produto.TabIndex = 8;
            // 
            // txb_Nome_Produto
            // 
            txb_Nome_Produto.Location = new Point(113, 34);
            txb_Nome_Produto.Name = "txb_Nome_Produto";
            txb_Nome_Produto.Size = new Size(200, 23);
            txb_Nome_Produto.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 134);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 4;
            label6.Text = "Estoque:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 86);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Preço:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 37);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // groupBox_Pesquisar_Produto
            // 
            groupBox_Pesquisar_Produto.Controls.Add(txb_Pesquisar_Produto);
            groupBox_Pesquisar_Produto.Controls.Add(label1);
            groupBox_Pesquisar_Produto.Controls.Add(ToolStrip_Pesquisar_Produto);
            groupBox_Pesquisar_Produto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Pesquisar_Produto.Location = new Point(24, 241);
            groupBox_Pesquisar_Produto.Name = "groupBox_Pesquisar_Produto";
            groupBox_Pesquisar_Produto.Size = new Size(300, 120);
            groupBox_Pesquisar_Produto.TabIndex = 13;
            groupBox_Pesquisar_Produto.TabStop = false;
            groupBox_Pesquisar_Produto.Text = "Pesquisar Produto";
            // 
            // txb_Pesquisar_Produto
            // 
            txb_Pesquisar_Produto.Location = new Point(116, 29);
            txb_Pesquisar_Produto.Name = "txb_Pesquisar_Produto";
            txb_Pesquisar_Produto.Size = new Size(180, 23);
            txb_Pesquisar_Produto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 37);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Código/Nome:";
            // 
            // ToolStrip_Pesquisar_Produto
            // 
            ToolStrip_Pesquisar_Produto.BackColor = Color.Gainsboro;
            ToolStrip_Pesquisar_Produto.Dock = DockStyle.Bottom;
            ToolStrip_Pesquisar_Produto.ImageScalingSize = new Size(36, 36);
            ToolStrip_Pesquisar_Produto.Items.AddRange(new ToolStripItem[] { Btn_Pesquisar_Produto, toolStripSeparator1, Btn_Limpar_Campo_Produto });
            ToolStrip_Pesquisar_Produto.Location = new Point(3, 78);
            ToolStrip_Pesquisar_Produto.Name = "ToolStrip_Pesquisar_Produto";
            ToolStrip_Pesquisar_Produto.Size = new Size(294, 39);
            ToolStrip_Pesquisar_Produto.TabIndex = 0;
            ToolStrip_Pesquisar_Produto.Text = "toolStrip1";
            // 
            // Btn_Pesquisar_Produto
            // 
            Btn_Pesquisar_Produto.AutoSize = false;
            Btn_Pesquisar_Produto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Pesquisar_Produto.Image = Properties.Resources.pesquisar;
            Btn_Pesquisar_Produto.ImageTransparentColor = Color.Magenta;
            Btn_Pesquisar_Produto.Name = "Btn_Pesquisar_Produto";
            Btn_Pesquisar_Produto.Size = new Size(36, 36);
            Btn_Pesquisar_Produto.Text = "Pesquisar Produto";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campo_Produto
            // 
            Btn_Limpar_Campo_Produto.AutoSize = false;
            Btn_Limpar_Campo_Produto.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campo_Produto.Image = Properties.Resources.brush3;
            Btn_Limpar_Campo_Produto.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campo_Produto.Name = "Btn_Limpar_Campo_Produto";
            Btn_Limpar_Campo_Produto.Size = new Size(36, 36);
            Btn_Limpar_Campo_Produto.Text = "Limpar Campo";
            // 
            // dataGridView_Produto
            // 
            dataGridView_Produto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Produto.BackgroundColor = Color.White;
            dataGridView_Produto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Produto.Location = new Point(19, 51);
            dataGridView_Produto.Name = "dataGridView_Produto";
            dataGridView_Produto.RowTemplate.Height = 25;
            dataGridView_Produto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Produto.Size = new Size(826, 160);
            dataGridView_Produto.TabIndex = 12;
            // 
            // Form_Produto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(ToolStrip_Produto);
            Controls.Add(groupBox_Formulario_Produto);
            Controls.Add(groupBox_Pesquisar_Produto);
            Controls.Add(dataGridView_Produto);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Produto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ToolStrip_Produto.ResumeLayout(false);
            ToolStrip_Produto.PerformLayout();
            groupBox_Formulario_Produto.ResumeLayout(false);
            groupBox_Formulario_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Estoque_Produto).EndInit();
            ToolStrip_Formulario_Produto.ResumeLayout(false);
            ToolStrip_Formulario_Produto.PerformLayout();
            groupBox_Pesquisar_Produto.ResumeLayout(false);
            groupBox_Pesquisar_Produto.PerformLayout();
            ToolStrip_Pesquisar_Produto.ResumeLayout(false);
            ToolStrip_Pesquisar_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Produto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private ToolStrip ToolStrip_Produto;
        private ToolStripButton Btn_Sair_Fornecedor;
        private GroupBox groupBox_Formulario_Produto;
        private MaskedTextBox maskedTextBox1;
        private ToolStrip ToolStrip_Formulario_Produto;
        private ToolStripButton Btn_Salvar_Produto;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Btn_Limpar_Campos_Produto;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Btn_Excluir_Produto;
        private TextBox txb_Endereco_Fornecedor;
        private TextBox txb_Preco_Produto;
        private MaskedTextBox mktb_Telefone_Fornecedor;
        private TextBox txb_Nome_Produto;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private GroupBox groupBox_Pesquisar_Produto;
        private TextBox txb_Pesquisar_Produto;
        private Label label1;
        private ToolStrip ToolStrip_Pesquisar_Produto;
        private ToolStripButton Btn_Pesquisar_Produto;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Limpar_Campo_Produto;
        private DataGridView dataGridView_Produto;
        private Label label3;
        private NumericUpDown nud_Estoque_Produto;
        private ComboBox cbx_Fornecedor;
    }
}