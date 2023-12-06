namespace MiniERP.EF.App.Views
{
    partial class Form_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fornecedor));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ToolStrip_Fornecedor = new ToolStrip();
            Btn_Sair_Fornecedor = new ToolStripButton();
            groupBox_Formulario_Fornecedor = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            ToolStrip_Formulario_Fornecedor = new ToolStrip();
            Btn_Salvar_Fornecedor = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Btn_Limpar_Campos_Fornecedor = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Btn_Excluir_Fornecedor = new ToolStripButton();
            txb_Endereco_Fornecedor = new TextBox();
            txb_Email_Fornecedor = new TextBox();
            mktb_Telefone_Fornecedor = new MaskedTextBox();
            txb_Nome_Cliente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox_Pesquisar_Fornecedor = new GroupBox();
            txb_Pesquisar_Fornecedor = new TextBox();
            label1 = new Label();
            ToolStrip_Pesquisar_Fornecedor = new ToolStrip();
            Btn_Pesquisar_Fornecedor = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Limpar_Campo_Fornecedor = new ToolStripButton();
            dataGridView_Fornecedor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ToolStrip_Fornecedor.SuspendLayout();
            groupBox_Formulario_Fornecedor.SuspendLayout();
            ToolStrip_Formulario_Fornecedor.SuspendLayout();
            groupBox_Pesquisar_Fornecedor.SuspendLayout();
            ToolStrip_Pesquisar_Fornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedor).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fornecedor;
            pictureBox1.Location = new Point(483, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(351, 15);
            label7.Name = "label7";
            label7.Size = new Size(126, 30);
            label7.TabIndex = 10;
            label7.Text = "Fornecedor";
            // 
            // ToolStrip_Fornecedor
            // 
            ToolStrip_Fornecedor.BackColor = Color.Gainsboro;
            ToolStrip_Fornecedor.Dock = DockStyle.Bottom;
            ToolStrip_Fornecedor.ImageScalingSize = new Size(36, 36);
            ToolStrip_Fornecedor.Items.AddRange(new ToolStripItem[] { Btn_Sair_Fornecedor });
            ToolStrip_Fornecedor.Location = new Point(0, 572);
            ToolStrip_Fornecedor.Name = "ToolStrip_Fornecedor";
            ToolStrip_Fornecedor.Size = new Size(884, 39);
            ToolStrip_Fornecedor.TabIndex = 9;
            ToolStrip_Fornecedor.Text = "toolStrip1";
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
            // groupBox_Formulario_Fornecedor
            // 
            groupBox_Formulario_Fornecedor.Controls.Add(maskedTextBox1);
            groupBox_Formulario_Fornecedor.Controls.Add(ToolStrip_Formulario_Fornecedor);
            groupBox_Formulario_Fornecedor.Controls.Add(txb_Endereco_Fornecedor);
            groupBox_Formulario_Fornecedor.Controls.Add(txb_Email_Fornecedor);
            groupBox_Formulario_Fornecedor.Controls.Add(mktb_Telefone_Fornecedor);
            groupBox_Formulario_Fornecedor.Controls.Add(txb_Nome_Cliente);
            groupBox_Formulario_Fornecedor.Controls.Add(label6);
            groupBox_Formulario_Fornecedor.Controls.Add(label5);
            groupBox_Formulario_Fornecedor.Controls.Add(label4);
            groupBox_Formulario_Fornecedor.Controls.Add(label3);
            groupBox_Formulario_Fornecedor.Controls.Add(label2);
            groupBox_Formulario_Fornecedor.Location = new Point(357, 248);
            groupBox_Formulario_Fornecedor.Name = "groupBox_Formulario_Fornecedor";
            groupBox_Formulario_Fornecedor.Size = new Size(500, 300);
            groupBox_Formulario_Fornecedor.TabIndex = 8;
            groupBox_Formulario_Fornecedor.TabStop = false;
            groupBox_Formulario_Fornecedor.Text = "Formulário Fornecedor";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(114, 80);
            maskedTextBox1.Mask = "##.###.###/####-##";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(120, 23);
            maskedTextBox1.TabIndex = 11;
            // 
            // ToolStrip_Formulario_Fornecedor
            // 
            ToolStrip_Formulario_Fornecedor.BackColor = Color.Gainsboro;
            ToolStrip_Formulario_Fornecedor.Dock = DockStyle.Bottom;
            ToolStrip_Formulario_Fornecedor.ImageScalingSize = new Size(36, 36);
            ToolStrip_Formulario_Fornecedor.Items.AddRange(new ToolStripItem[] { Btn_Salvar_Fornecedor, toolStripSeparator2, Btn_Limpar_Campos_Fornecedor, toolStripSeparator3, Btn_Excluir_Fornecedor });
            ToolStrip_Formulario_Fornecedor.Location = new Point(3, 258);
            ToolStrip_Formulario_Fornecedor.Name = "ToolStrip_Formulario_Fornecedor";
            ToolStrip_Formulario_Fornecedor.Size = new Size(494, 39);
            ToolStrip_Formulario_Fornecedor.TabIndex = 10;
            ToolStrip_Formulario_Fornecedor.Text = "toolStrip1";
            // 
            // Btn_Salvar_Fornecedor
            // 
            Btn_Salvar_Fornecedor.AutoSize = false;
            Btn_Salvar_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Salvar_Fornecedor.Image = Properties.Resources.disk_blue;
            Btn_Salvar_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Salvar_Fornecedor.Name = "Btn_Salvar_Fornecedor";
            Btn_Salvar_Fornecedor.Size = new Size(36, 36);
            Btn_Salvar_Fornecedor.Text = "Salvar Fornecedor";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos_Fornecedor
            // 
            Btn_Limpar_Campos_Fornecedor.AutoSize = false;
            Btn_Limpar_Campos_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos_Fornecedor.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos_Fornecedor.Name = "Btn_Limpar_Campos_Fornecedor";
            Btn_Limpar_Campos_Fornecedor.Size = new Size(36, 36);
            Btn_Limpar_Campos_Fornecedor.Text = "Limpar Campos";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // Btn_Excluir_Fornecedor
            // 
            Btn_Excluir_Fornecedor.AutoSize = false;
            Btn_Excluir_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Excluir_Fornecedor.Image = Properties.Resources.lixo;
            Btn_Excluir_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Excluir_Fornecedor.Name = "Btn_Excluir_Fornecedor";
            Btn_Excluir_Fornecedor.Size = new Size(36, 36);
            Btn_Excluir_Fornecedor.Text = "Excluir Fornecedor";
            // 
            // txb_Endereco_Fornecedor
            // 
            txb_Endereco_Fornecedor.Location = new Point(113, 212);
            txb_Endereco_Fornecedor.Name = "txb_Endereco_Fornecedor";
            txb_Endereco_Fornecedor.Size = new Size(300, 23);
            txb_Endereco_Fornecedor.TabIndex = 9;
            // 
            // txb_Email_Fornecedor
            // 
            txb_Email_Fornecedor.Location = new Point(113, 171);
            txb_Email_Fornecedor.Name = "txb_Email_Fornecedor";
            txb_Email_Fornecedor.Size = new Size(200, 23);
            txb_Email_Fornecedor.TabIndex = 8;
            // 
            // mktb_Telefone_Fornecedor
            // 
            mktb_Telefone_Fornecedor.Location = new Point(113, 124);
            mktb_Telefone_Fornecedor.Mask = "(##)#####-####";
            mktb_Telefone_Fornecedor.Name = "mktb_Telefone_Fornecedor";
            mktb_Telefone_Fornecedor.Size = new Size(100, 23);
            mktb_Telefone_Fornecedor.TabIndex = 7;
            // 
            // txb_Nome_Cliente
            // 
            txb_Nome_Cliente.Location = new Point(113, 34);
            txb_Nome_Cliente.Name = "txb_Nome_Cliente";
            txb_Nome_Cliente.Size = new Size(200, 23);
            txb_Nome_Cliente.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 220);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 4;
            label6.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 179);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 88);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 1;
            label3.Text = "CNPJ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 42);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 0;
            label2.Text = "Razão Social:";
            // 
            // groupBox_Pesquisar_Fornecedor
            // 
            groupBox_Pesquisar_Fornecedor.Controls.Add(txb_Pesquisar_Fornecedor);
            groupBox_Pesquisar_Fornecedor.Controls.Add(label1);
            groupBox_Pesquisar_Fornecedor.Controls.Add(ToolStrip_Pesquisar_Fornecedor);
            groupBox_Pesquisar_Fornecedor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Pesquisar_Fornecedor.Location = new Point(24, 248);
            groupBox_Pesquisar_Fornecedor.Name = "groupBox_Pesquisar_Fornecedor";
            groupBox_Pesquisar_Fornecedor.Size = new Size(300, 120);
            groupBox_Pesquisar_Fornecedor.TabIndex = 7;
            groupBox_Pesquisar_Fornecedor.TabStop = false;
            groupBox_Pesquisar_Fornecedor.Text = "Pesquisar Fornecedor";
            // 
            // txb_Pesquisar_Fornecedor
            // 
            txb_Pesquisar_Fornecedor.Location = new Point(147, 29);
            txb_Pesquisar_Fornecedor.Name = "txb_Pesquisar_Fornecedor";
            txb_Pesquisar_Fornecedor.Size = new Size(150, 23);
            txb_Pesquisar_Fornecedor.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 37);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 1;
            label1.Text = "Código/Razão Social:";
            // 
            // ToolStrip_Pesquisar_Fornecedor
            // 
            ToolStrip_Pesquisar_Fornecedor.BackColor = Color.Gainsboro;
            ToolStrip_Pesquisar_Fornecedor.Dock = DockStyle.Bottom;
            ToolStrip_Pesquisar_Fornecedor.ImageScalingSize = new Size(36, 36);
            ToolStrip_Pesquisar_Fornecedor.Items.AddRange(new ToolStripItem[] { Btn_Pesquisar_Fornecedor, toolStripSeparator1, Btn_Limpar_Campo_Fornecedor });
            ToolStrip_Pesquisar_Fornecedor.Location = new Point(3, 78);
            ToolStrip_Pesquisar_Fornecedor.Name = "ToolStrip_Pesquisar_Fornecedor";
            ToolStrip_Pesquisar_Fornecedor.Size = new Size(294, 39);
            ToolStrip_Pesquisar_Fornecedor.TabIndex = 0;
            ToolStrip_Pesquisar_Fornecedor.Text = "toolStrip1";
            // 
            // Btn_Pesquisar_Fornecedor
            // 
            Btn_Pesquisar_Fornecedor.AutoSize = false;
            Btn_Pesquisar_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Pesquisar_Fornecedor.Image = Properties.Resources.pesquisar;
            Btn_Pesquisar_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Pesquisar_Fornecedor.Name = "Btn_Pesquisar_Fornecedor";
            Btn_Pesquisar_Fornecedor.Size = new Size(36, 36);
            Btn_Pesquisar_Fornecedor.Text = "Pesquisar Fornecedor";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campo_Fornecedor
            // 
            Btn_Limpar_Campo_Fornecedor.AutoSize = false;
            Btn_Limpar_Campo_Fornecedor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campo_Fornecedor.Image = Properties.Resources.brush3;
            Btn_Limpar_Campo_Fornecedor.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campo_Fornecedor.Name = "Btn_Limpar_Campo_Fornecedor";
            Btn_Limpar_Campo_Fornecedor.Size = new Size(36, 36);
            Btn_Limpar_Campo_Fornecedor.Text = "Limpar Campo";
            // 
            // dataGridView_Fornecedor
            // 
            dataGridView_Fornecedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Fornecedor.BackgroundColor = Color.White;
            dataGridView_Fornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Fornecedor.Location = new Point(27, 55);
            dataGridView_Fornecedor.Name = "dataGridView_Fornecedor";
            dataGridView_Fornecedor.RowTemplate.Height = 25;
            dataGridView_Fornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Fornecedor.Size = new Size(830, 160);
            dataGridView_Fornecedor.TabIndex = 6;
            // 
            // Form_Fornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(ToolStrip_Fornecedor);
            Controls.Add(groupBox_Formulario_Fornecedor);
            Controls.Add(groupBox_Pesquisar_Fornecedor);
            Controls.Add(dataGridView_Fornecedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Fornecedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fornecedor";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ToolStrip_Fornecedor.ResumeLayout(false);
            ToolStrip_Fornecedor.PerformLayout();
            groupBox_Formulario_Fornecedor.ResumeLayout(false);
            groupBox_Formulario_Fornecedor.PerformLayout();
            ToolStrip_Formulario_Fornecedor.ResumeLayout(false);
            ToolStrip_Formulario_Fornecedor.PerformLayout();
            groupBox_Pesquisar_Fornecedor.ResumeLayout(false);
            groupBox_Pesquisar_Fornecedor.PerformLayout();
            ToolStrip_Pesquisar_Fornecedor.ResumeLayout(false);
            ToolStrip_Pesquisar_Fornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Fornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private ToolStrip ToolStrip_Fornecedor;
        private ToolStripButton Btn_Sair_Fornecedor;
        private GroupBox groupBox_Formulario_Fornecedor;
        private ToolStrip ToolStrip_Formulario_Fornecedor;
        private ToolStripButton Btn_Salvar_Fornecedor;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Btn_Limpar_Campos_Fornecedor;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Btn_Excluir_Fornecedor;
        private TextBox txb_Endereco_Fornecedor;
        private TextBox txb_Email_Fornecedor;
        private MaskedTextBox mktb_Telefone_Fornecedor;
        private TextBox txb_Nome_Cliente;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox_Pesquisar_Fornecedor;
        private TextBox txb_Pesquisar_Fornecedor;
        private Label label1;
        private ToolStrip ToolStrip_Pesquisar_Fornecedor;
        private ToolStripButton Btn_Pesquisar_Fornecedor;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Limpar_Campo_Fornecedor;
        private DataGridView dataGridView_Fornecedor;
        private MaskedTextBox maskedTextBox1;
    }
}