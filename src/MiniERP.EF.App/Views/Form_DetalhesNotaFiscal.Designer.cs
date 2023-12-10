namespace MiniERP.EF.App.Views
{
    partial class Form_DetalhesNotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DetalhesNotaFiscal));
            ToolStrip_Detalhes_NotaFiscal = new ToolStrip();
            Btn_Imprimir_Nota = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Salvar_PDF = new ToolStripButton();
            Btn_Fechar_Detalhes = new ToolStripButton();
            groupBox_ExibirDetalhes_Total = new GroupBox();
            lbl_ValorTotal_NotaFiscal = new Label();
            label13 = new Label();
            groupBox_ExibirDetalhes_Produto = new GroupBox();
            lbl_Descricao_Produto = new Label();
            label15 = new Label();
            lbl_ValorUnitario_Produto = new Label();
            lbl_Quantidade_Produto = new Label();
            lbl_Nome_Produto = new Label();
            lbl_Codigo_Produto = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            groupBox_ExibirDetalhes_Cliente = new GroupBox();
            lbl_CPF_Cliente = new Label();
            label14 = new Label();
            lbl_Endereco_Cliente = new Label();
            lbl_Email_Cliente = new Label();
            lbl_Telefone_Cliente = new Label();
            lbl_Nome_Cliente = new Label();
            lbl_Codigo_Cliente = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox_ExibirDetalhes_Nota = new GroupBox();
            lbl_DataEmissao_NotaFiscal = new Label();
            label2 = new Label();
            lbl_Codigo_NotaFiscal = new Label();
            label3 = new Label();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            pictureBox1 = new PictureBox();
            ToolStrip_Detalhes_NotaFiscal.SuspendLayout();
            groupBox_ExibirDetalhes_Total.SuspendLayout();
            groupBox_ExibirDetalhes_Produto.SuspendLayout();
            groupBox_ExibirDetalhes_Cliente.SuspendLayout();
            groupBox_ExibirDetalhes_Nota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip_Detalhes_NotaFiscal
            // 
            ToolStrip_Detalhes_NotaFiscal.BackColor = Color.Gainsboro;
            ToolStrip_Detalhes_NotaFiscal.Dock = DockStyle.Bottom;
            ToolStrip_Detalhes_NotaFiscal.ImageScalingSize = new Size(36, 36);
            ToolStrip_Detalhes_NotaFiscal.Items.AddRange(new ToolStripItem[] { Btn_Imprimir_Nota, toolStripSeparator1, Btn_Salvar_PDF, Btn_Fechar_Detalhes });
            ToolStrip_Detalhes_NotaFiscal.Location = new Point(0, 773);
            ToolStrip_Detalhes_NotaFiscal.Name = "ToolStrip_Detalhes_NotaFiscal";
            ToolStrip_Detalhes_NotaFiscal.Size = new Size(784, 39);
            ToolStrip_Detalhes_NotaFiscal.TabIndex = 20;
            ToolStrip_Detalhes_NotaFiscal.Text = "toolStrip1";
            // 
            // Btn_Imprimir_Nota
            // 
            Btn_Imprimir_Nota.AutoSize = false;
            Btn_Imprimir_Nota.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Imprimir_Nota.Image = Properties.Resources.imprimir;
            Btn_Imprimir_Nota.ImageTransparentColor = Color.Magenta;
            Btn_Imprimir_Nota.Name = "Btn_Imprimir_Nota";
            Btn_Imprimir_Nota.Size = new Size(36, 36);
            Btn_Imprimir_Nota.Text = "Imprimir Nota";
            Btn_Imprimir_Nota.Click += Btn_Imprimir_Nota_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Salvar_PDF
            // 
            Btn_Salvar_PDF.AutoSize = false;
            Btn_Salvar_PDF.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Salvar_PDF.Image = Properties.Resources.download_pdf;
            Btn_Salvar_PDF.ImageTransparentColor = Color.Magenta;
            Btn_Salvar_PDF.Name = "Btn_Salvar_PDF";
            Btn_Salvar_PDF.Size = new Size(36, 36);
            Btn_Salvar_PDF.Text = "Salvar PDF";
            Btn_Salvar_PDF.Click += Btn_Salvar_PDF_Click;
            // 
            // Btn_Fechar_Detalhes
            // 
            Btn_Fechar_Detalhes.Alignment = ToolStripItemAlignment.Right;
            Btn_Fechar_Detalhes.AutoSize = false;
            Btn_Fechar_Detalhes.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Fechar_Detalhes.Image = Properties.Resources.exit;
            Btn_Fechar_Detalhes.ImageTransparentColor = Color.Magenta;
            Btn_Fechar_Detalhes.Name = "Btn_Fechar_Detalhes";
            Btn_Fechar_Detalhes.Size = new Size(36, 36);
            Btn_Fechar_Detalhes.Text = "Sair";
            Btn_Fechar_Detalhes.Click += Btn_Fechar_Detalhes_Click;
            // 
            // groupBox_ExibirDetalhes_Total
            // 
            groupBox_ExibirDetalhes_Total.Controls.Add(lbl_ValorTotal_NotaFiscal);
            groupBox_ExibirDetalhes_Total.Controls.Add(label13);
            groupBox_ExibirDetalhes_Total.Location = new Point(49, 692);
            groupBox_ExibirDetalhes_Total.Name = "groupBox_ExibirDetalhes_Total";
            groupBox_ExibirDetalhes_Total.Size = new Size(300, 69);
            groupBox_ExibirDetalhes_Total.TabIndex = 19;
            groupBox_ExibirDetalhes_Total.TabStop = false;
            groupBox_ExibirDetalhes_Total.Text = "Valor da Nota";
            // 
            // lbl_ValorTotal_NotaFiscal
            // 
            lbl_ValorTotal_NotaFiscal.AutoSize = true;
            lbl_ValorTotal_NotaFiscal.Location = new Point(63, 32);
            lbl_ValorTotal_NotaFiscal.Name = "lbl_ValorTotal_NotaFiscal";
            lbl_ValorTotal_NotaFiscal.Size = new Size(34, 15);
            lbl_ValorTotal_NotaFiscal.TabIndex = 1;
            lbl_ValorTotal_NotaFiscal.Text = ".........";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(14, 32);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 0;
            label13.Text = "Total:";
            // 
            // groupBox_ExibirDetalhes_Produto
            // 
            groupBox_ExibirDetalhes_Produto.Controls.Add(lbl_Descricao_Produto);
            groupBox_ExibirDetalhes_Produto.Controls.Add(label15);
            groupBox_ExibirDetalhes_Produto.Controls.Add(lbl_ValorUnitario_Produto);
            groupBox_ExibirDetalhes_Produto.Controls.Add(lbl_Quantidade_Produto);
            groupBox_ExibirDetalhes_Produto.Controls.Add(lbl_Nome_Produto);
            groupBox_ExibirDetalhes_Produto.Controls.Add(lbl_Codigo_Produto);
            groupBox_ExibirDetalhes_Produto.Controls.Add(label12);
            groupBox_ExibirDetalhes_Produto.Controls.Add(label11);
            groupBox_ExibirDetalhes_Produto.Controls.Add(label10);
            groupBox_ExibirDetalhes_Produto.Controls.Add(label9);
            groupBox_ExibirDetalhes_Produto.Location = new Point(48, 475);
            groupBox_ExibirDetalhes_Produto.Name = "groupBox_ExibirDetalhes_Produto";
            groupBox_ExibirDetalhes_Produto.Size = new Size(685, 200);
            groupBox_ExibirDetalhes_Produto.TabIndex = 18;
            groupBox_ExibirDetalhes_Produto.TabStop = false;
            groupBox_ExibirDetalhes_Produto.Text = "Detalhe do Produto:";
            // 
            // lbl_Descricao_Produto
            // 
            lbl_Descricao_Produto.AutoSize = true;
            lbl_Descricao_Produto.Location = new Point(102, 152);
            lbl_Descricao_Produto.Name = "lbl_Descricao_Produto";
            lbl_Descricao_Produto.Size = new Size(34, 15);
            lbl_Descricao_Produto.TabIndex = 18;
            lbl_Descricao_Produto.Text = ".........";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(24, 152);
            label15.Name = "label15";
            label15.Size = new Size(64, 15);
            label15.TabIndex = 17;
            label15.Text = "Descrição:";
            // 
            // lbl_ValorUnitario_Produto
            // 
            lbl_ValorUnitario_Produto.AutoSize = true;
            lbl_ValorUnitario_Produto.Location = new Point(365, 99);
            lbl_ValorUnitario_Produto.Name = "lbl_ValorUnitario_Produto";
            lbl_ValorUnitario_Produto.Size = new Size(34, 15);
            lbl_ValorUnitario_Produto.TabIndex = 16;
            lbl_ValorUnitario_Produto.Text = ".........";
            // 
            // lbl_Quantidade_Produto
            // 
            lbl_Quantidade_Produto.AutoSize = true;
            lbl_Quantidade_Produto.Location = new Point(102, 99);
            lbl_Quantidade_Produto.Name = "lbl_Quantidade_Produto";
            lbl_Quantidade_Produto.Size = new Size(34, 15);
            lbl_Quantidade_Produto.TabIndex = 15;
            lbl_Quantidade_Produto.Text = ".........";
            // 
            // lbl_Nome_Produto
            // 
            lbl_Nome_Produto.AutoSize = true;
            lbl_Nome_Produto.Location = new Point(337, 42);
            lbl_Nome_Produto.Name = "lbl_Nome_Produto";
            lbl_Nome_Produto.Size = new Size(34, 15);
            lbl_Nome_Produto.TabIndex = 14;
            lbl_Nome_Produto.Text = ".........";
            // 
            // lbl_Codigo_Produto
            // 
            lbl_Codigo_Produto.AutoSize = true;
            lbl_Codigo_Produto.Location = new Point(149, 44);
            lbl_Codigo_Produto.Name = "lbl_Codigo_Produto";
            lbl_Codigo_Produto.Size = new Size(34, 15);
            lbl_Codigo_Produto.TabIndex = 13;
            lbl_Codigo_Produto.Text = ".........";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(262, 99);
            label12.Name = "label12";
            label12.Size = new Size(86, 15);
            label12.TabIndex = 12;
            label12.Text = "Valor Unitário:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(24, 99);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 11;
            label11.Text = "Quantidade:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(261, 44);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 10;
            label10.Text = "Produto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(24, 44);
            label9.Name = "label9";
            label9.Size = new Size(113, 15);
            label9.TabIndex = 9;
            label9.Text = "Código do Produto:";
            // 
            // groupBox_ExibirDetalhes_Cliente
            // 
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_CPF_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label14);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_Endereco_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_Email_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_Telefone_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_Nome_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(lbl_Codigo_Cliente);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label4);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label5);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label6);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label8);
            groupBox_ExibirDetalhes_Cliente.Controls.Add(label7);
            groupBox_ExibirDetalhes_Cliente.Location = new Point(49, 199);
            groupBox_ExibirDetalhes_Cliente.Name = "groupBox_ExibirDetalhes_Cliente";
            groupBox_ExibirDetalhes_Cliente.Size = new Size(685, 250);
            groupBox_ExibirDetalhes_Cliente.TabIndex = 17;
            groupBox_ExibirDetalhes_Cliente.TabStop = false;
            groupBox_ExibirDetalhes_Cliente.Text = "Detalhes do Cliente";
            // 
            // lbl_CPF_Cliente
            // 
            lbl_CPF_Cliente.AutoSize = true;
            lbl_CPF_Cliente.Location = new Point(73, 97);
            lbl_CPF_Cliente.Name = "lbl_CPF_Cliente";
            lbl_CPF_Cliente.Size = new Size(34, 15);
            lbl_CPF_Cliente.TabIndex = 15;
            lbl_CPF_Cliente.Text = ".........";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(23, 97);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 14;
            label14.Text = "CPF:";
            // 
            // lbl_Endereco_Cliente
            // 
            lbl_Endereco_Cliente.AutoSize = true;
            lbl_Endereco_Cliente.Location = new Point(89, 190);
            lbl_Endereco_Cliente.Name = "lbl_Endereco_Cliente";
            lbl_Endereco_Cliente.Size = new Size(34, 15);
            lbl_Endereco_Cliente.TabIndex = 13;
            lbl_Endereco_Cliente.Text = ".........";
            // 
            // lbl_Email_Cliente
            // 
            lbl_Email_Cliente.AutoSize = true;
            lbl_Email_Cliente.Location = new Point(88, 151);
            lbl_Email_Cliente.Name = "lbl_Email_Cliente";
            lbl_Email_Cliente.Size = new Size(34, 15);
            lbl_Email_Cliente.TabIndex = 12;
            lbl_Email_Cliente.Text = ".........";
            // 
            // lbl_Telefone_Cliente
            // 
            lbl_Telefone_Cliente.AutoSize = true;
            lbl_Telefone_Cliente.Location = new Point(329, 97);
            lbl_Telefone_Cliente.Name = "lbl_Telefone_Cliente";
            lbl_Telefone_Cliente.Size = new Size(34, 15);
            lbl_Telefone_Cliente.TabIndex = 11;
            lbl_Telefone_Cliente.Text = ".........";
            // 
            // lbl_Nome_Cliente
            // 
            lbl_Nome_Cliente.AutoSize = true;
            lbl_Nome_Cliente.Location = new Point(325, 41);
            lbl_Nome_Cliente.Name = "lbl_Nome_Cliente";
            lbl_Nome_Cliente.Size = new Size(34, 15);
            lbl_Nome_Cliente.TabIndex = 10;
            lbl_Nome_Cliente.Text = ".........";
            // 
            // lbl_Codigo_Cliente
            // 
            lbl_Codigo_Cliente.AutoSize = true;
            lbl_Codigo_Cliente.Location = new Point(144, 41);
            lbl_Codigo_Cliente.Name = "lbl_Codigo_Cliente";
            lbl_Codigo_Cliente.Size = new Size(34, 15);
            lbl_Codigo_Cliente.TabIndex = 9;
            lbl_Codigo_Cliente.Text = ".........";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(23, 42);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 4;
            label4.Text = "Código do Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(260, 42);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 5;
            label5.Text = "Cliente:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(260, 98);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 6;
            label6.Text = "Telefone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(20, 190);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 8;
            label8.Text = "Endereço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(23, 151);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 7;
            label7.Text = "Email:";
            // 
            // groupBox_ExibirDetalhes_Nota
            // 
            groupBox_ExibirDetalhes_Nota.Controls.Add(lbl_DataEmissao_NotaFiscal);
            groupBox_ExibirDetalhes_Nota.Controls.Add(label2);
            groupBox_ExibirDetalhes_Nota.Controls.Add(lbl_Codigo_NotaFiscal);
            groupBox_ExibirDetalhes_Nota.Controls.Add(label3);
            groupBox_ExibirDetalhes_Nota.Location = new Point(48, 75);
            groupBox_ExibirDetalhes_Nota.Name = "groupBox_ExibirDetalhes_Nota";
            groupBox_ExibirDetalhes_Nota.Size = new Size(686, 100);
            groupBox_ExibirDetalhes_Nota.TabIndex = 16;
            groupBox_ExibirDetalhes_Nota.TabStop = false;
            groupBox_ExibirDetalhes_Nota.Text = "Detlhes Nota Fiscal";
            // 
            // lbl_DataEmissao_NotaFiscal
            // 
            lbl_DataEmissao_NotaFiscal.AutoSize = true;
            lbl_DataEmissao_NotaFiscal.Location = new Point(384, 43);
            lbl_DataEmissao_NotaFiscal.Name = "lbl_DataEmissao_NotaFiscal";
            lbl_DataEmissao_NotaFiscal.Size = new Size(34, 15);
            lbl_DataEmissao_NotaFiscal.TabIndex = 4;
            lbl_DataEmissao_NotaFiscal.Text = ".........";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 43);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Código da Nota:";
            // 
            // lbl_Codigo_NotaFiscal
            // 
            lbl_Codigo_NotaFiscal.AutoSize = true;
            lbl_Codigo_NotaFiscal.Location = new Point(135, 43);
            lbl_Codigo_NotaFiscal.Name = "lbl_Codigo_NotaFiscal";
            lbl_Codigo_NotaFiscal.Size = new Size(34, 15);
            lbl_Codigo_NotaFiscal.TabIndex = 0;
            lbl_Codigo_NotaFiscal.Text = ".........";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(261, 43);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 3;
            label3.Text = "Data da Emissão:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(285, 20);
            label1.Name = "label1";
            label1.Size = new Size(130, 29);
            label1.TabIndex = 15;
            label1.Text = "Nota Fiscal";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.nota_fiscal;
            pictureBox1.Location = new Point(421, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form_DetalhesNotaFiscal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 812);
            Controls.Add(pictureBox1);
            Controls.Add(ToolStrip_Detalhes_NotaFiscal);
            Controls.Add(groupBox_ExibirDetalhes_Total);
            Controls.Add(groupBox_ExibirDetalhes_Produto);
            Controls.Add(groupBox_ExibirDetalhes_Cliente);
            Controls.Add(groupBox_ExibirDetalhes_Nota);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_DetalhesNotaFiscal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalhes Nota Fiscal";
            ToolStrip_Detalhes_NotaFiscal.ResumeLayout(false);
            ToolStrip_Detalhes_NotaFiscal.PerformLayout();
            groupBox_ExibirDetalhes_Total.ResumeLayout(false);
            groupBox_ExibirDetalhes_Total.PerformLayout();
            groupBox_ExibirDetalhes_Produto.ResumeLayout(false);
            groupBox_ExibirDetalhes_Produto.PerformLayout();
            groupBox_ExibirDetalhes_Cliente.ResumeLayout(false);
            groupBox_ExibirDetalhes_Cliente.PerformLayout();
            groupBox_ExibirDetalhes_Nota.ResumeLayout(false);
            groupBox_ExibirDetalhes_Nota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip_Detalhes_NotaFiscal;
        private ToolStripButton Btn_Imprimir_Nota;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Salvar_PDF;
        private ToolStripButton Btn_Fechar_Detalhes;
        private GroupBox groupBox_ExibirDetalhes_Total;
        private Label lbl_ValorTotal_NotaFiscal;
        private Label label13;
        private GroupBox groupBox_ExibirDetalhes_Produto;
        private Label lbl_ValorUnitario_Produto;
        private Label lbl_Quantidade_Produto;
        private Label lbl_Nome_Produto;
        private Label lbl_Codigo_Produto;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private GroupBox groupBox_ExibirDetalhes_Cliente;
        private Label lbl_Endereco_Cliente;
        private Label lbl_Email_Cliente;
        private Label lbl_Telefone_Cliente;
        private Label lbl_Nome_Cliente;
        private Label lbl_Codigo_Cliente;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label7;
        private GroupBox groupBox_ExibirDetalhes_Nota;
        private Label lbl_DataEmissao_NotaFiscal;
        private Label label2;
        private Label lbl_Codigo_NotaFiscal;
        private Label label3;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private PictureBox pictureBox1;
        private Label lbl_CPF_Cliente;
        private Label label14;
        private Label lbl_Descricao_Produto;
        private Label label15;
    }
}