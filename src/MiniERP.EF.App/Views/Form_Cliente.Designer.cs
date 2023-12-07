namespace MiniERP.EF.App.Views
{
    partial class Form_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cliente));
            dataGridView_Cliente = new DataGridView();
            groupBox_Pesquisar_Cliente = new GroupBox();
            txb_Pesquisar_Cliente = new TextBox();
            label1 = new Label();
            ToolStrip_Pesquisar_Cliente = new ToolStrip();
            Btn_Pesquisar_Cliente = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Limpar_Campo_Cliente = new ToolStripButton();
            groupBox_Formulario_Cliente = new GroupBox();
            ToolStrip_Formulario_Cliente = new ToolStrip();
            Btn_Salvar_Cliente = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            Btn_Limpar_Campos_Cliente = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Btn_Excluir_Cliente = new ToolStripButton();
            txb_Endereco_Cliente = new TextBox();
            txb_Email_Cliente = new TextBox();
            mktb_Telefone_Cliente = new MaskedTextBox();
            mktb_CPF_Cliente = new MaskedTextBox();
            txb_Nome_Cliente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ToolStrip_Cliente = new ToolStrip();
            Btn_Sair_Cliente = new ToolStripButton();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cliente).BeginInit();
            groupBox_Pesquisar_Cliente.SuspendLayout();
            ToolStrip_Pesquisar_Cliente.SuspendLayout();
            groupBox_Formulario_Cliente.SuspendLayout();
            ToolStrip_Formulario_Cliente.SuspendLayout();
            ToolStrip_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Cliente
            // 
            dataGridView_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Cliente.BackgroundColor = Color.White;
            dataGridView_Cliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Cliente.Location = new Point(22, 59);
            dataGridView_Cliente.Name = "dataGridView_Cliente";
            dataGridView_Cliente.RowTemplate.Height = 25;
            dataGridView_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Cliente.Size = new Size(826, 150);
            dataGridView_Cliente.TabIndex = 0;
            dataGridView_Cliente.CellDoubleClick += dataGridView_Cliente_CellDoubleClick;
            // 
            // groupBox_Pesquisar_Cliente
            // 
            groupBox_Pesquisar_Cliente.Controls.Add(txb_Pesquisar_Cliente);
            groupBox_Pesquisar_Cliente.Controls.Add(label1);
            groupBox_Pesquisar_Cliente.Controls.Add(ToolStrip_Pesquisar_Cliente);
            groupBox_Pesquisar_Cliente.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox_Pesquisar_Cliente.Location = new Point(24, 233);
            groupBox_Pesquisar_Cliente.Name = "groupBox_Pesquisar_Cliente";
            groupBox_Pesquisar_Cliente.Size = new Size(300, 120);
            groupBox_Pesquisar_Cliente.TabIndex = 1;
            groupBox_Pesquisar_Cliente.TabStop = false;
            groupBox_Pesquisar_Cliente.Text = "Pesquisar Cliente";
            // 
            // txb_Pesquisar_Cliente
            // 
            txb_Pesquisar_Cliente.Location = new Point(116, 29);
            txb_Pesquisar_Cliente.Name = "txb_Pesquisar_Cliente";
            txb_Pesquisar_Cliente.Size = new Size(180, 23);
            txb_Pesquisar_Cliente.TabIndex = 2;
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
            // ToolStrip_Pesquisar_Cliente
            // 
            ToolStrip_Pesquisar_Cliente.BackColor = Color.Gainsboro;
            ToolStrip_Pesquisar_Cliente.Dock = DockStyle.Bottom;
            ToolStrip_Pesquisar_Cliente.ImageScalingSize = new Size(36, 36);
            ToolStrip_Pesquisar_Cliente.Items.AddRange(new ToolStripItem[] { Btn_Pesquisar_Cliente, toolStripSeparator1, Btn_Limpar_Campo_Cliente });
            ToolStrip_Pesquisar_Cliente.Location = new Point(3, 78);
            ToolStrip_Pesquisar_Cliente.Name = "ToolStrip_Pesquisar_Cliente";
            ToolStrip_Pesquisar_Cliente.Size = new Size(294, 39);
            ToolStrip_Pesquisar_Cliente.TabIndex = 0;
            ToolStrip_Pesquisar_Cliente.Text = "toolStrip1";
            // 
            // Btn_Pesquisar_Cliente
            // 
            Btn_Pesquisar_Cliente.AutoSize = false;
            Btn_Pesquisar_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Pesquisar_Cliente.Image = Properties.Resources.pesquisar;
            Btn_Pesquisar_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Pesquisar_Cliente.Name = "Btn_Pesquisar_Cliente";
            Btn_Pesquisar_Cliente.Size = new Size(36, 36);
            Btn_Pesquisar_Cliente.Text = "Pesquisar Cliente";
            Btn_Pesquisar_Cliente.Click += Btn_Pesquisar_Cliente_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campo_Cliente
            // 
            Btn_Limpar_Campo_Cliente.AutoSize = false;
            Btn_Limpar_Campo_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campo_Cliente.Image = Properties.Resources.brush3;
            Btn_Limpar_Campo_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campo_Cliente.Name = "Btn_Limpar_Campo_Cliente";
            Btn_Limpar_Campo_Cliente.Size = new Size(36, 36);
            Btn_Limpar_Campo_Cliente.Text = "Limpar Campo";
            Btn_Limpar_Campo_Cliente.Click += Btn_Limpar_Campo_Cliente_Click;
            // 
            // groupBox_Formulario_Cliente
            // 
            groupBox_Formulario_Cliente.Controls.Add(ToolStrip_Formulario_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(txb_Endereco_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(txb_Email_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(mktb_Telefone_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(mktb_CPF_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(txb_Nome_Cliente);
            groupBox_Formulario_Cliente.Controls.Add(label6);
            groupBox_Formulario_Cliente.Controls.Add(label5);
            groupBox_Formulario_Cliente.Controls.Add(label4);
            groupBox_Formulario_Cliente.Controls.Add(label3);
            groupBox_Formulario_Cliente.Controls.Add(label2);
            groupBox_Formulario_Cliente.Location = new Point(348, 233);
            groupBox_Formulario_Cliente.Name = "groupBox_Formulario_Cliente";
            groupBox_Formulario_Cliente.Size = new Size(500, 300);
            groupBox_Formulario_Cliente.TabIndex = 2;
            groupBox_Formulario_Cliente.TabStop = false;
            groupBox_Formulario_Cliente.Text = "Formulário Cliente";
            // 
            // ToolStrip_Formulario_Cliente
            // 
            ToolStrip_Formulario_Cliente.BackColor = Color.Gainsboro;
            ToolStrip_Formulario_Cliente.Dock = DockStyle.Bottom;
            ToolStrip_Formulario_Cliente.ImageScalingSize = new Size(36, 36);
            ToolStrip_Formulario_Cliente.Items.AddRange(new ToolStripItem[] { Btn_Salvar_Cliente, toolStripSeparator2, Btn_Limpar_Campos_Cliente, toolStripSeparator3, Btn_Excluir_Cliente });
            ToolStrip_Formulario_Cliente.Location = new Point(3, 258);
            ToolStrip_Formulario_Cliente.Name = "ToolStrip_Formulario_Cliente";
            ToolStrip_Formulario_Cliente.Size = new Size(494, 39);
            ToolStrip_Formulario_Cliente.TabIndex = 10;
            ToolStrip_Formulario_Cliente.Text = "toolStrip1";
            // 
            // Btn_Salvar_Cliente
            // 
            Btn_Salvar_Cliente.AutoSize = false;
            Btn_Salvar_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Salvar_Cliente.Image = Properties.Resources.disk_blue;
            Btn_Salvar_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Salvar_Cliente.Name = "Btn_Salvar_Cliente";
            Btn_Salvar_Cliente.Size = new Size(36, 36);
            Btn_Salvar_Cliente.Text = "Salvar Cliente";
            Btn_Salvar_Cliente.Click += Btn_Salvar_Cliente_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos_Cliente
            // 
            Btn_Limpar_Campos_Cliente.AutoSize = false;
            Btn_Limpar_Campos_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos_Cliente.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos_Cliente.Name = "Btn_Limpar_Campos_Cliente";
            Btn_Limpar_Campos_Cliente.Size = new Size(36, 36);
            Btn_Limpar_Campos_Cliente.Text = "Limpar Campos";
            Btn_Limpar_Campos_Cliente.Click += Btn_Limpar_Campos_Cliente_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // Btn_Excluir_Cliente
            // 
            Btn_Excluir_Cliente.AutoSize = false;
            Btn_Excluir_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Excluir_Cliente.Image = Properties.Resources.lixo;
            Btn_Excluir_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Excluir_Cliente.Name = "Btn_Excluir_Cliente";
            Btn_Excluir_Cliente.Size = new Size(36, 36);
            Btn_Excluir_Cliente.Text = "Excluir Cliente";
            Btn_Excluir_Cliente.Click += Btn_Excluir_Cliente_Click;
            // 
            // txb_Endereco_Cliente
            // 
            txb_Endereco_Cliente.Location = new Point(113, 207);
            txb_Endereco_Cliente.Name = "txb_Endereco_Cliente";
            txb_Endereco_Cliente.Size = new Size(300, 23);
            txb_Endereco_Cliente.TabIndex = 9;
            // 
            // txb_Email_Cliente
            // 
            txb_Email_Cliente.Location = new Point(113, 165);
            txb_Email_Cliente.Name = "txb_Email_Cliente";
            txb_Email_Cliente.Size = new Size(200, 23);
            txb_Email_Cliente.TabIndex = 8;
            // 
            // mktb_Telefone_Cliente
            // 
            mktb_Telefone_Cliente.Location = new Point(113, 123);
            mktb_Telefone_Cliente.Mask = "(##)#####-####";
            mktb_Telefone_Cliente.Name = "mktb_Telefone_Cliente";
            mktb_Telefone_Cliente.Size = new Size(100, 23);
            mktb_Telefone_Cliente.TabIndex = 7;
            // 
            // mktb_CPF_Cliente
            // 
            mktb_CPF_Cliente.Location = new Point(113, 78);
            mktb_CPF_Cliente.Mask = "###########";
            mktb_CPF_Cliente.Name = "mktb_CPF_Cliente";
            mktb_CPF_Cliente.Size = new Size(100, 23);
            mktb_CPF_Cliente.TabIndex = 6;
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
            label6.Location = new Point(19, 215);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 4;
            label6.Text = "Endereço:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 173);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 131);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 86);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 42);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome:";
            // 
            // ToolStrip_Cliente
            // 
            ToolStrip_Cliente.BackColor = Color.Gainsboro;
            ToolStrip_Cliente.Dock = DockStyle.Bottom;
            ToolStrip_Cliente.ImageScalingSize = new Size(36, 36);
            ToolStrip_Cliente.Items.AddRange(new ToolStripItem[] { Btn_Sair_Cliente });
            ToolStrip_Cliente.Location = new Point(0, 572);
            ToolStrip_Cliente.Name = "ToolStrip_Cliente";
            ToolStrip_Cliente.Size = new Size(884, 39);
            ToolStrip_Cliente.TabIndex = 3;
            ToolStrip_Cliente.Text = "toolStrip1";
            // 
            // Btn_Sair_Cliente
            // 
            Btn_Sair_Cliente.Alignment = ToolStripItemAlignment.Right;
            Btn_Sair_Cliente.AutoSize = false;
            Btn_Sair_Cliente.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Sair_Cliente.Image = Properties.Resources.exit;
            Btn_Sair_Cliente.ImageTransparentColor = Color.Magenta;
            Btn_Sair_Cliente.Name = "Btn_Sair_Cliente";
            Btn_Sair_Cliente.Size = new Size(36, 36);
            Btn_Sair_Cliente.Text = "Sair";
            Btn_Sair_Cliente.Click += Btn_Sair_Cliente_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DodgerBlue;
            label7.Location = new Point(367, 23);
            label7.Name = "label7";
            label7.Size = new Size(83, 30);
            label7.TabIndex = 4;
            label7.Text = "Cliente";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clientes;
            pictureBox1.Location = new Point(456, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form_Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 611);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(ToolStrip_Cliente);
            Controls.Add(groupBox_Formulario_Cliente);
            Controls.Add(groupBox_Pesquisar_Cliente);
            Controls.Add(dataGridView_Cliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Cliente).EndInit();
            groupBox_Pesquisar_Cliente.ResumeLayout(false);
            groupBox_Pesquisar_Cliente.PerformLayout();
            ToolStrip_Pesquisar_Cliente.ResumeLayout(false);
            ToolStrip_Pesquisar_Cliente.PerformLayout();
            groupBox_Formulario_Cliente.ResumeLayout(false);
            groupBox_Formulario_Cliente.PerformLayout();
            ToolStrip_Formulario_Cliente.ResumeLayout(false);
            ToolStrip_Formulario_Cliente.PerformLayout();
            ToolStrip_Cliente.ResumeLayout(false);
            ToolStrip_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Cliente;
        private GroupBox groupBox_Pesquisar_Cliente;
        private ToolStrip ToolStrip_Pesquisar_Cliente;
        private ToolStripButton Btn_Pesquisar_Cliente;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Limpar_Campo_Cliente;
        private TextBox txb_Pesquisar_Cliente;
        private Label label1;
        private GroupBox groupBox_Formulario_Cliente;
        private MaskedTextBox mktb_CPF_Cliente;
        private TextBox txb_Nome_Cliente;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox mktb_Telefone_Cliente;
        private ToolStrip ToolStrip_Formulario_Cliente;
        private TextBox txb_Endereco_Cliente;
        private TextBox txb_Email_Cliente;
        private ToolStripButton Btn_Salvar_Cliente;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton Btn_Limpar_Campos_Cliente;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Btn_Excluir_Cliente;
        private ToolStrip ToolStrip_Cliente;
        private ToolStripButton Btn_Sair_Cliente;
        private Label label7;
        private PictureBox pictureBox1;
    }
}