namespace MiniERP.EF.App.Views
{
    partial class Form_NotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NotaFiscal));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ToolStrip_NotaFiscal = new ToolStrip();
            Btn_Sair_Fornecedor = new ToolStripButton();
            groupBox_Formulario_Produto = new GroupBox();
            nud_Quantidade_NotaFiscal = new NumericUpDown();
            label4 = new Label();
            cbx_Produto_NotaFiscal = new ComboBox();
            label2 = new Label();
            cbx_Cliente_NotaFiscal = new ComboBox();
            label3 = new Label();
            ToolStrip_Formulario_NotaFiscal = new ToolStrip();
            Btn_Salvar_NotaFiscal = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Btn_Limpar_Campos_NotaFiscal = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            groupBox_Pesquisar_NotaFiscal = new GroupBox();
            txb_Pesquisar_NotaFiscal = new TextBox();
            label1 = new Label();
            ToolStrip_Pesquisar_NotaFiscal = new ToolStrip();
            Btn_Pesquisar_NotaFiscal = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Limpar_Campo_NotaFiscal = new ToolStripButton();
            Btn_Info_NotasFiscais = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Btn_Abrir_NotaFiscal = new ToolStripButton();
            dataGridView_NotaFiscal = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ToolStrip_NotaFiscal.SuspendLayout();
            groupBox_Formulario_Produto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade_NotaFiscal).BeginInit();
            ToolStrip_Formulario_NotaFiscal.SuspendLayout();
            groupBox_Pesquisar_NotaFiscal.SuspendLayout();
            ToolStrip_Pesquisar_NotaFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NotaFiscal).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nota_fiscal;
            pictureBox1.Location = new Point(581, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(330, 9);
            label7.Name = "label7";
            label7.Size = new Size(245, 30);
            label7.TabIndex = 22;
            label7.Text = "Formulário Nota Fiscal";
            // 
            // ToolStrip_NotaFiscal
            // 
            ToolStrip_NotaFiscal.BackColor = Color.Gainsboro;
            ToolStrip_NotaFiscal.Dock = DockStyle.Bottom;
            ToolStrip_NotaFiscal.ImageScalingSize = new Size(36, 36);
            ToolStrip_NotaFiscal.Items.AddRange(new ToolStripItem[] { Btn_Sair_Fornecedor });
            ToolStrip_NotaFiscal.Location = new Point(0, 572);
            ToolStrip_NotaFiscal.Name = "ToolStrip_NotaFiscal";
            ToolStrip_NotaFiscal.Size = new Size(984, 39);
            ToolStrip_NotaFiscal.TabIndex = 21;
            ToolStrip_NotaFiscal.Text = "toolStrip1";
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
            groupBox_Formulario_Produto.Controls.Add(nud_Quantidade_NotaFiscal);
            groupBox_Formulario_Produto.Controls.Add(label4);
            groupBox_Formulario_Produto.Controls.Add(cbx_Produto_NotaFiscal);
            groupBox_Formulario_Produto.Controls.Add(label2);
            groupBox_Formulario_Produto.Controls.Add(cbx_Cliente_NotaFiscal);
            groupBox_Formulario_Produto.Controls.Add(label3);
            groupBox_Formulario_Produto.Controls.Add(ToolStrip_Formulario_NotaFiscal);
            groupBox_Formulario_Produto.Location = new Point(462, 329);
            groupBox_Formulario_Produto.Name = "groupBox_Formulario_Produto";
            groupBox_Formulario_Produto.Size = new Size(500, 222);
            groupBox_Formulario_Produto.TabIndex = 20;
            groupBox_Formulario_Produto.TabStop = false;
            groupBox_Formulario_Produto.Text = "Formulário Nota Fiscal";
            // 
            // nud_Quantidade_NotaFiscal
            // 
            nud_Quantidade_NotaFiscal.Location = new Point(106, 122);
            nud_Quantidade_NotaFiscal.Name = "nud_Quantidade_NotaFiscal";
            nud_Quantidade_NotaFiscal.Size = new Size(120, 23);
            nud_Quantidade_NotaFiscal.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(8, 130);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 16;
            label4.Text = "Quantidade:";
            // 
            // cbx_Produto_NotaFiscal
            // 
            cbx_Produto_NotaFiscal.FormattingEnabled = true;
            cbx_Produto_NotaFiscal.Location = new Point(106, 78);
            cbx_Produto_NotaFiscal.Name = "cbx_Produto_NotaFiscal";
            cbx_Produto_NotaFiscal.Size = new Size(250, 23);
            cbx_Produto_NotaFiscal.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Produto:";
            // 
            // cbx_Cliente_NotaFiscal
            // 
            cbx_Cliente_NotaFiscal.FormattingEnabled = true;
            cbx_Cliente_NotaFiscal.Location = new Point(106, 34);
            cbx_Cliente_NotaFiscal.Name = "cbx_Cliente_NotaFiscal";
            cbx_Cliente_NotaFiscal.Size = new Size(250, 23);
            cbx_Cliente_NotaFiscal.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 42);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 12;
            label3.Text = "Cliente:";
            // 
            // ToolStrip_Formulario_NotaFiscal
            // 
            ToolStrip_Formulario_NotaFiscal.BackColor = Color.Gainsboro;
            ToolStrip_Formulario_NotaFiscal.Dock = DockStyle.Bottom;
            ToolStrip_Formulario_NotaFiscal.ImageScalingSize = new Size(36, 36);
            ToolStrip_Formulario_NotaFiscal.Items.AddRange(new ToolStripItem[] { Btn_Salvar_NotaFiscal, toolStripSeparator2, Btn_Limpar_Campos_NotaFiscal, toolStripSeparator3 });
            ToolStrip_Formulario_NotaFiscal.Location = new Point(3, 180);
            ToolStrip_Formulario_NotaFiscal.Name = "ToolStrip_Formulario_NotaFiscal";
            ToolStrip_Formulario_NotaFiscal.Size = new Size(494, 39);
            ToolStrip_Formulario_NotaFiscal.TabIndex = 10;
            ToolStrip_Formulario_NotaFiscal.Text = "toolStrip1";
            // 
            // Btn_Salvar_NotaFiscal
            // 
            Btn_Salvar_NotaFiscal.AutoSize = false;
            Btn_Salvar_NotaFiscal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Salvar_NotaFiscal.Image = Properties.Resources.gerar_nota;
            Btn_Salvar_NotaFiscal.ImageTransparentColor = Color.Magenta;
            Btn_Salvar_NotaFiscal.Name = "Btn_Salvar_NotaFiscal";
            Btn_Salvar_NotaFiscal.Size = new Size(36, 36);
            Btn_Salvar_NotaFiscal.Text = "Salvar Nota Fiscal";
            Btn_Salvar_NotaFiscal.Click += Btn_Salvar_NotaFiscal_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos_NotaFiscal
            // 
            Btn_Limpar_Campos_NotaFiscal.AutoSize = false;
            Btn_Limpar_Campos_NotaFiscal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos_NotaFiscal.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos_NotaFiscal.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos_NotaFiscal.Name = "Btn_Limpar_Campos_NotaFiscal";
            Btn_Limpar_Campos_NotaFiscal.Size = new Size(36, 36);
            Btn_Limpar_Campos_NotaFiscal.Text = "Limpar Campos";
            Btn_Limpar_Campos_NotaFiscal.Click += Btn_Limpar_Campos_NotaFiscal_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // groupBox_Pesquisar_NotaFiscal
            // 
            groupBox_Pesquisar_NotaFiscal.Controls.Add(txb_Pesquisar_NotaFiscal);
            groupBox_Pesquisar_NotaFiscal.Controls.Add(label1);
            groupBox_Pesquisar_NotaFiscal.Controls.Add(ToolStrip_Pesquisar_NotaFiscal);
            groupBox_Pesquisar_NotaFiscal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Pesquisar_NotaFiscal.Location = new Point(24, 329);
            groupBox_Pesquisar_NotaFiscal.Name = "groupBox_Pesquisar_NotaFiscal";
            groupBox_Pesquisar_NotaFiscal.Size = new Size(350, 120);
            groupBox_Pesquisar_NotaFiscal.TabIndex = 19;
            groupBox_Pesquisar_NotaFiscal.TabStop = false;
            groupBox_Pesquisar_NotaFiscal.Text = "Pesquisar Nota Fiscal";
            // 
            // txb_Pesquisar_NotaFiscal
            // 
            txb_Pesquisar_NotaFiscal.Location = new Point(116, 29);
            txb_Pesquisar_NotaFiscal.Name = "txb_Pesquisar_NotaFiscal";
            txb_Pesquisar_NotaFiscal.Size = new Size(230, 23);
            txb_Pesquisar_NotaFiscal.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Código da Nota:";
            // 
            // ToolStrip_Pesquisar_NotaFiscal
            // 
            ToolStrip_Pesquisar_NotaFiscal.BackColor = Color.Gainsboro;
            ToolStrip_Pesquisar_NotaFiscal.Dock = DockStyle.Bottom;
            ToolStrip_Pesquisar_NotaFiscal.ImageScalingSize = new Size(36, 36);
            ToolStrip_Pesquisar_NotaFiscal.Items.AddRange(new ToolStripItem[] { Btn_Pesquisar_NotaFiscal, toolStripSeparator1, Btn_Limpar_Campo_NotaFiscal, Btn_Info_NotasFiscais, toolStripSeparator4, Btn_Abrir_NotaFiscal });
            ToolStrip_Pesquisar_NotaFiscal.Location = new Point(3, 78);
            ToolStrip_Pesquisar_NotaFiscal.Name = "ToolStrip_Pesquisar_NotaFiscal";
            ToolStrip_Pesquisar_NotaFiscal.Size = new Size(344, 39);
            ToolStrip_Pesquisar_NotaFiscal.TabIndex = 0;
            ToolStrip_Pesquisar_NotaFiscal.Text = "toolStrip1";
            // 
            // Btn_Pesquisar_NotaFiscal
            // 
            Btn_Pesquisar_NotaFiscal.AutoSize = false;
            Btn_Pesquisar_NotaFiscal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Pesquisar_NotaFiscal.Image = Properties.Resources.pesquisar;
            Btn_Pesquisar_NotaFiscal.ImageTransparentColor = Color.Magenta;
            Btn_Pesquisar_NotaFiscal.Name = "Btn_Pesquisar_NotaFiscal";
            Btn_Pesquisar_NotaFiscal.Size = new Size(36, 36);
            Btn_Pesquisar_NotaFiscal.Text = "Pesquisar Nota Fiscal";
            Btn_Pesquisar_NotaFiscal.Click += Btn_Pesquisar_NotaFiscal_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campo_NotaFiscal
            // 
            Btn_Limpar_Campo_NotaFiscal.AutoSize = false;
            Btn_Limpar_Campo_NotaFiscal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campo_NotaFiscal.Image = Properties.Resources.brush3;
            Btn_Limpar_Campo_NotaFiscal.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campo_NotaFiscal.Name = "Btn_Limpar_Campo_NotaFiscal";
            Btn_Limpar_Campo_NotaFiscal.Size = new Size(36, 36);
            Btn_Limpar_Campo_NotaFiscal.Text = "Limpar Campo";
            Btn_Limpar_Campo_NotaFiscal.Click += Btn_Limpar_Campo_NotaFiscal_Click;
            // 
            // Btn_Info_NotasFiscais
            // 
            Btn_Info_NotasFiscais.Alignment = ToolStripItemAlignment.Right;
            Btn_Info_NotasFiscais.AutoSize = false;
            Btn_Info_NotasFiscais.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Info_NotasFiscais.Image = Properties.Resources.info;
            Btn_Info_NotasFiscais.ImageTransparentColor = Color.Magenta;
            Btn_Info_NotasFiscais.Name = "Btn_Info_NotasFiscais";
            Btn_Info_NotasFiscais.Size = new Size(36, 36);
            Btn_Info_NotasFiscais.Text = "Informações";
            Btn_Info_NotasFiscais.Click += Btn_Info_NotasFiscais_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // Btn_Abrir_NotaFiscal
            // 
            Btn_Abrir_NotaFiscal.AutoSize = false;
            Btn_Abrir_NotaFiscal.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Abrir_NotaFiscal.Image = Properties.Resources.abrir_nota;
            Btn_Abrir_NotaFiscal.ImageTransparentColor = Color.Magenta;
            Btn_Abrir_NotaFiscal.Name = "Btn_Abrir_NotaFiscal";
            Btn_Abrir_NotaFiscal.Size = new Size(36, 36);
            Btn_Abrir_NotaFiscal.Text = "Abrir Nota Fiscal";
            Btn_Abrir_NotaFiscal.Click += Btn_Abrir_NotaFiscal_Click;
            // 
            // dataGridView_NotaFiscal
            // 
            dataGridView_NotaFiscal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_NotaFiscal.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_NotaFiscal.BackgroundColor = Color.White;
            dataGridView_NotaFiscal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NotaFiscal.Location = new Point(9, 57);
            dataGridView_NotaFiscal.Name = "dataGridView_NotaFiscal";
            dataGridView_NotaFiscal.RowTemplate.Height = 25;
            dataGridView_NotaFiscal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_NotaFiscal.Size = new Size(950, 250);
            dataGridView_NotaFiscal.TabIndex = 18;
            dataGridView_NotaFiscal.CellDoubleClick += dataGridView_NotaFiscal_CellDoubleClick;
            // 
            // Form_NotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(ToolStrip_NotaFiscal);
            Controls.Add(groupBox_Formulario_Produto);
            Controls.Add(groupBox_Pesquisar_NotaFiscal);
            Controls.Add(dataGridView_NotaFiscal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_NotaFiscal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nota Fiscal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ToolStrip_NotaFiscal.ResumeLayout(false);
            ToolStrip_NotaFiscal.PerformLayout();
            groupBox_Formulario_Produto.ResumeLayout(false);
            groupBox_Formulario_Produto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nud_Quantidade_NotaFiscal).EndInit();
            ToolStrip_Formulario_NotaFiscal.ResumeLayout(false);
            ToolStrip_Formulario_NotaFiscal.PerformLayout();
            groupBox_Pesquisar_NotaFiscal.ResumeLayout(false);
            groupBox_Pesquisar_NotaFiscal.PerformLayout();
            ToolStrip_Pesquisar_NotaFiscal.ResumeLayout(false);
            ToolStrip_Pesquisar_NotaFiscal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NotaFiscal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private ToolStrip ToolStrip_NotaFiscal;
        private ToolStripButton Btn_Sair_Fornecedor;
        private GroupBox groupBox_Formulario_Produto;
        private ComboBox cbx_Cliente_NotaFiscal;
        private Label label3;
        private ToolStrip ToolStrip_Formulario_NotaFiscal;
        private ToolStripButton Btn_Salvar_NotaFiscal;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Btn_Limpar_Campos_NotaFiscal;
        private ToolStripSeparator toolStripSeparator3;
        private GroupBox groupBox_Pesquisar_NotaFiscal;
        private TextBox txb_Pesquisar_NotaFiscal;
        private Label label1;
        private ToolStrip ToolStrip_Pesquisar_NotaFiscal;
        private ToolStripButton Btn_Pesquisar_NotaFiscal;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Limpar_Campo_NotaFiscal;
        private DataGridView dataGridView_NotaFiscal;
        private Label label4;
        private ComboBox cbx_Produto_NotaFiscal;
        private Label label2;
        private NumericUpDown nud_Quantidade_NotaFiscal;
        private ToolStripButton Btn_Abrir_NotaFiscal;
        private ToolStripButton Btn_Info_NotasFiscais;
        private ToolStripSeparator toolStripSeparator4;
    }
}