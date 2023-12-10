namespace MiniERP.EF.App.Views
{
    partial class Form_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Info));
            ToolStrip_Info = new ToolStrip();
            Btn_Fechar_Info = new ToolStripButton();
            tabControl_Informacoes = new TabControl();
            tabPage_Pesqusiar_Registros = new TabPage();
            label15 = new Label();
            label14 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            label30 = new Label();
            tabPage_Manipular_Resgistros = new TabPage();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            label36 = new Label();
            label37 = new Label();
            label38 = new Label();
            tabPage_Navegacao = new TabPage();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            tabPage_BaixarNotas = new TabPage();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            ToolStrip_Info.SuspendLayout();
            tabControl_Informacoes.SuspendLayout();
            tabPage_Pesqusiar_Registros.SuspendLayout();
            tabPage_Manipular_Resgistros.SuspendLayout();
            tabPage_Navegacao.SuspendLayout();
            tabPage_BaixarNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ToolStrip_Info
            // 
            ToolStrip_Info.BackColor = Color.Gainsboro;
            ToolStrip_Info.Dock = DockStyle.Bottom;
            ToolStrip_Info.ImageScalingSize = new Size(36, 36);
            ToolStrip_Info.Items.AddRange(new ToolStripItem[] { Btn_Fechar_Info });
            ToolStrip_Info.Location = new Point(0, 572);
            ToolStrip_Info.Name = "ToolStrip_Info";
            ToolStrip_Info.Size = new Size(884, 39);
            ToolStrip_Info.TabIndex = 0;
            ToolStrip_Info.Text = "toolStrip1";
            // 
            // Btn_Fechar_Info
            // 
            Btn_Fechar_Info.Alignment = ToolStripItemAlignment.Right;
            Btn_Fechar_Info.AutoSize = false;
            Btn_Fechar_Info.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Fechar_Info.Image = Properties.Resources.exit;
            Btn_Fechar_Info.ImageTransparentColor = Color.Magenta;
            Btn_Fechar_Info.Name = "Btn_Fechar_Info";
            Btn_Fechar_Info.Size = new Size(36, 36);
            Btn_Fechar_Info.Text = "Sair";
            Btn_Fechar_Info.Click += Btn_Fechar_Info_Click;
            // 
            // tabControl_Informacoes
            // 
            tabControl_Informacoes.Controls.Add(tabPage_Pesqusiar_Registros);
            tabControl_Informacoes.Controls.Add(tabPage_Manipular_Resgistros);
            tabControl_Informacoes.Controls.Add(tabPage_Navegacao);
            tabControl_Informacoes.Controls.Add(tabPage_BaixarNotas);
            tabControl_Informacoes.Location = new Point(12, 76);
            tabControl_Informacoes.Name = "tabControl_Informacoes";
            tabControl_Informacoes.SelectedIndex = 0;
            tabControl_Informacoes.Size = new Size(850, 465);
            tabControl_Informacoes.TabIndex = 3;
            // 
            // tabPage_Pesqusiar_Registros
            // 
            tabPage_Pesqusiar_Registros.Controls.Add(label15);
            tabPage_Pesqusiar_Registros.Controls.Add(label14);
            tabPage_Pesqusiar_Registros.Controls.Add(label20);
            tabPage_Pesqusiar_Registros.Controls.Add(label21);
            tabPage_Pesqusiar_Registros.Controls.Add(label22);
            tabPage_Pesqusiar_Registros.Controls.Add(label23);
            tabPage_Pesqusiar_Registros.Controls.Add(label24);
            tabPage_Pesqusiar_Registros.Controls.Add(label25);
            tabPage_Pesqusiar_Registros.Controls.Add(label26);
            tabPage_Pesqusiar_Registros.Controls.Add(label27);
            tabPage_Pesqusiar_Registros.Controls.Add(label28);
            tabPage_Pesqusiar_Registros.Controls.Add(label29);
            tabPage_Pesqusiar_Registros.Controls.Add(label30);
            tabPage_Pesqusiar_Registros.Location = new Point(4, 24);
            tabPage_Pesqusiar_Registros.Name = "tabPage_Pesqusiar_Registros";
            tabPage_Pesqusiar_Registros.Padding = new Padding(3);
            tabPage_Pesqusiar_Registros.Size = new Size(842, 437);
            tabPage_Pesqusiar_Registros.TabIndex = 0;
            tabPage_Pesqusiar_Registros.Text = "Pesquisar Registros";
            tabPage_Pesqusiar_Registros.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(14, 292);
            label15.Name = "label15";
            label15.Size = new Size(656, 15);
            label15.TabIndex = 23;
            label15.Text = "Em todas as tabelas exceto da Nota Fiscal quando o registro e selecionado o formulário tem seus campos preenchidos.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(14, 260);
            label14.Name = "label14";
            label14.Size = new Size(473, 15);
            label14.TabIndex = 22;
            label14.Text = "Nas tabelas dos registros qualquer um deles podem ser selecionado com duplo click. ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = Color.DodgerBlue;
            label20.Location = new Point(14, 222);
            label20.Name = "label20";
            label20.Size = new Size(355, 15);
            label20.TabIndex = 21;
            label20.Text = "Botão de pesquisa e um botão para limpar o campo de pesquisa";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(14, 188);
            label21.Name = "label21";
            label21.Size = new Size(176, 15);
            label21.TabIndex = 20;
            label21.Text = "Todos os formulários possuem:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label22.ForeColor = Color.DodgerBlue;
            label22.Location = new Point(92, 153);
            label22.Name = "label22";
            label22.Size = new Size(111, 15);
            label22.TabIndex = 19;
            label22.Text = "apenas por Código.";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(14, 153);
            label23.Name = "label23";
            label23.Size = new Size(69, 15);
            label23.TabIndex = 18;
            label23.Text = "Nota Fiscal:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label24.ForeColor = Color.DodgerBlue;
            label24.Location = new Point(92, 121);
            label24.Name = "label24";
            label24.Size = new Size(162, 15);
            label24.TabIndex = 17;
            label24.Text = "Código, CNPJ e Razão Social.";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label25.Location = new Point(14, 121);
            label25.Name = "label25";
            label25.Size = new Size(74, 15);
            label25.TabIndex = 16;
            label25.Text = "Fornecedor:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label26.ForeColor = Color.DodgerBlue;
            label26.Location = new Point(77, 89);
            label26.Name = "label26";
            label26.Size = new Size(95, 15);
            label26.TabIndex = 15;
            label26.Text = "Código e Nome.";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label27.Location = new Point(14, 89);
            label27.Name = "label27";
            label27.Size = new Size(55, 15);
            label27.TabIndex = 14;
            label27.Text = "Produto:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label28.ForeColor = Color.DodgerBlue;
            label28.Location = new Point(65, 59);
            label28.Name = "label28";
            label28.Size = new Size(121, 15);
            label28.TabIndex = 13;
            label28.Text = "Código, CPF e Nome.";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label29.Location = new Point(12, 59);
            label29.Name = "label29";
            label29.Size = new Size(49, 15);
            label29.TabIndex = 12;
            label29.Text = "Cliente:";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label30.Location = new Point(14, 24);
            label30.Name = "label30";
            label30.Size = new Size(569, 21);
            label30.TabIndex = 11;
            label30.Text = "Para todos os formulários existem termos de pesqusias distintos, são eles:";
            // 
            // tabPage_Manipular_Resgistros
            // 
            tabPage_Manipular_Resgistros.Controls.Add(label31);
            tabPage_Manipular_Resgistros.Controls.Add(label32);
            tabPage_Manipular_Resgistros.Controls.Add(label33);
            tabPage_Manipular_Resgistros.Controls.Add(label34);
            tabPage_Manipular_Resgistros.Controls.Add(label35);
            tabPage_Manipular_Resgistros.Controls.Add(label36);
            tabPage_Manipular_Resgistros.Controls.Add(label37);
            tabPage_Manipular_Resgistros.Controls.Add(label38);
            tabPage_Manipular_Resgistros.Location = new Point(4, 24);
            tabPage_Manipular_Resgistros.Name = "tabPage_Manipular_Resgistros";
            tabPage_Manipular_Resgistros.Padding = new Padding(3);
            tabPage_Manipular_Resgistros.Size = new Size(842, 437);
            tabPage_Manipular_Resgistros.TabIndex = 1;
            tabPage_Manipular_Resgistros.Text = "Manipular Registros";
            tabPage_Manipular_Resgistros.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label31.ForeColor = Color.DodgerBlue;
            label31.Location = new Point(152, 191);
            label31.Name = "label31";
            label31.Size = new Size(135, 15);
            label31.TabIndex = 15;
            label31.Text = "salvar e limpar campos.";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label32.Location = new Point(19, 191);
            label32.Name = "label32";
            label32.Size = new Size(133, 15);
            label32.TabIndex = 14;
            label32.Text = "Possuem botôes para:  ";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label33.ForeColor = Color.DodgerBlue;
            label33.Location = new Point(152, 133);
            label33.Name = "label33";
            label33.Size = new Size(282, 15);
            label33.TabIndex = 13;
            label33.Text = "salvar/atualizar, limpar campos e excluir registros.";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label34.Location = new Point(19, 133);
            label34.Name = "label34";
            label34.Size = new Size(133, 15);
            label34.TabIndex = 12;
            label34.Text = "Possuem botôes para:  ";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label35.Location = new Point(19, 165);
            label35.Name = "label35";
            label35.Size = new Size(225, 15);
            label35.TabIndex = 11;
            label35.Text = "O formulário da Nota Fiscal é diferente.";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label36.Location = new Point(19, 101);
            label36.Name = "label36";
            label36.Size = new Size(354, 15);
            label36.TabIndex = 10;
            label36.Text = "Nos formulários de Cliente, Produto e Fronecedor são similares";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label37.Location = new Point(19, 71);
            label37.Name = "label37";
            label37.Size = new Size(371, 15);
            label37.TabIndex = 9;
            label37.Text = "No rodapé dos formulários dos campos existem grupos de botões.";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label38.Location = new Point(19, 36);
            label38.Name = "label38";
            label38.Size = new Size(425, 21);
            label38.TabIndex = 8;
            label38.Text = "A manipulação dos registros é feita da seguinte forma:";
            // 
            // tabPage_Navegacao
            // 
            tabPage_Navegacao.Controls.Add(label3);
            tabPage_Navegacao.Controls.Add(label1);
            tabPage_Navegacao.Controls.Add(label2);
            tabPage_Navegacao.Location = new Point(4, 24);
            tabPage_Navegacao.Name = "tabPage_Navegacao";
            tabPage_Navegacao.Padding = new Padding(3);
            tabPage_Navegacao.Size = new Size(842, 437);
            tabPage_Navegacao.TabIndex = 2;
            tabPage_Navegacao.Text = "Navegação Pelos Formulários";
            tabPage_Navegacao.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(21, 110);
            label3.Name = "label3";
            label3.Size = new Size(504, 15);
            label3.TabIndex = 12;
            label3.Text = "Ainda No formulário de menu exitem ícones clicáveis representando cada tipo do módulo.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 75);
            label1.Name = "label1";
            label1.Size = new Size(409, 15);
            label1.TabIndex = 11;
            label1.Text = "No formulário de menu exite uma barra de navegação no canto superior.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 37);
            label2.Name = "label2";
            label2.Size = new Size(500, 21);
            label2.TabIndex = 10;
            label2.Text = "A navegação pelos formulários podem ser feitas de duas formas:";
            // 
            // tabPage_BaixarNotas
            // 
            tabPage_BaixarNotas.Controls.Add(label13);
            tabPage_BaixarNotas.Controls.Add(label12);
            tabPage_BaixarNotas.Controls.Add(label11);
            tabPage_BaixarNotas.Controls.Add(label10);
            tabPage_BaixarNotas.Controls.Add(label9);
            tabPage_BaixarNotas.Controls.Add(label8);
            tabPage_BaixarNotas.Controls.Add(label7);
            tabPage_BaixarNotas.Controls.Add(label6);
            tabPage_BaixarNotas.Controls.Add(label4);
            tabPage_BaixarNotas.Controls.Add(label5);
            tabPage_BaixarNotas.Location = new Point(4, 24);
            tabPage_BaixarNotas.Name = "tabPage_BaixarNotas";
            tabPage_BaixarNotas.Padding = new Padding(3);
            tabPage_BaixarNotas.Size = new Size(842, 437);
            tabPage_BaixarNotas.TabIndex = 3;
            tabPage_BaixarNotas.Text = "Baixar Notas";
            tabPage_BaixarNotas.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DodgerBlue;
            label13.Location = new Point(17, 354);
            label13.Name = "label13";
            label13.Size = new Size(687, 15);
            label13.TabIndex = 19;
            label13.Text = "Um botão com o símbolo do PDF que ao ser pressionado salva os dados da nota e faz o download automático na unidade C:\\ ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DodgerBlue;
            label12.Location = new Point(17, 318);
            label12.Name = "label12";
            label12.Size = new Size(787, 15);
            label12.TabIndex = 18;
            label12.Text = "Um botão com símbolo de impressora:  ao ser clicado tira um print screen da tela da nota e abre a opção de impressão do sistema operacional.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(17, 282);
            label11.Name = "label11";
            label11.Size = new Size(536, 15);
            label11.TabIndex = 17;
            label11.Text = "Vai ser aberto um outro formulário com os detalhes da nota, em seu rodapé vão ter dois botões.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(17, 247);
            label10.Name = "label10";
            label10.Size = new Size(241, 15);
            label10.TabIndex = 16;
            label10.Text = "A segunda é dando um duplo click na nota.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 211);
            label9.Name = "label9";
            label9.Size = new Size(640, 15);
            label9.TabIndex = 15;
            label9.Text = "A primeira é clicando uma única vez na nota desejada e depois pressionando o botão da nota no rodapé depesquisa.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DodgerBlue;
            label8.Location = new Point(17, 177);
            label8.Name = "label8";
            label8.Size = new Size(199, 15);
            label8.TabIndex = 14;
            label8.Text = "Vão ter duas opões de visualziação:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 143);
            label7.Name = "label7";
            label7.Size = new Size(621, 15);
            label7.TabIndex = 13;
            label7.Text = "Com a nota pronta na lista o usuário precisa fazer a pesquisa pela nota desejada através do código ou navegação";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 110);
            label6.Name = "label6";
            label6.Size = new Size(634, 15);
            label6.TabIndex = 12;
            label6.Text = "Após a criação da nota a mesma será exibida na tabela de notas fiscais, com isso a pesquisa vai poder ser realizada. ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(17, 72);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 11;
            label4.Text = "Formulário Nota Fiscal:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 37);
            label5.Name = "label5";
            label5.Size = new Size(429, 21);
            label5.TabIndex = 10;
            label5.Text = "As notas fiscais podem ser baixados da seguinte forma:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.info;
            pictureBox1.Location = new Point(481, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DodgerBlue;
            label16.Location = new Point(336, 22);
            label16.Name = "label16";
            label16.Size = new Size(139, 30);
            label16.TabIndex = 6;
            label16.Text = "Informações";
            // 
            // Form_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label16);
            Controls.Add(tabControl_Informacoes);
            Controls.Add(ToolStrip_Info);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações";
            ToolStrip_Info.ResumeLayout(false);
            ToolStrip_Info.PerformLayout();
            tabControl_Informacoes.ResumeLayout(false);
            tabPage_Pesqusiar_Registros.ResumeLayout(false);
            tabPage_Pesqusiar_Registros.PerformLayout();
            tabPage_Manipular_Resgistros.ResumeLayout(false);
            tabPage_Manipular_Resgistros.PerformLayout();
            tabPage_Navegacao.ResumeLayout(false);
            tabPage_Navegacao.PerformLayout();
            tabPage_BaixarNotas.ResumeLayout(false);
            tabPage_BaixarNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip_Info;
        private ToolStripButton Btn_Fechar_Info;
        private GroupBox groupBox_Info_Pesquisar;
        private GroupBox groupBox_Info_ManipularRegistro;
        private Label label17;
        private Label label18;
        private Label label19;
        private TabControl tabControl_Informacoes;
        private TabPage tabPage_Pesqusiar_Registros;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private TabPage tabPage_Manipular_Resgistros;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label35;
        private Label label36;
        private Label label37;
        private Label label38;
        private TabPage tabPage_Navegacao;
        private TabPage tabPage_BaixarNotas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label8;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label13;
        private Label label14;
        private Label label15;
        private PictureBox pictureBox1;
        private Label label16;
    }
}