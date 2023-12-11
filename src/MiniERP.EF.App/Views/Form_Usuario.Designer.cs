namespace MiniERP.EF.App.Views
{
    partial class Form_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuario));
            pictureBox_Login = new PictureBox();
            label1 = new Label();
            txb_Usuario_Adcionado = new TextBox();
            txb_Senha_Adicionada = new TextBox();
            label2 = new Label();
            label3 = new Label();
            toolStrip_Usuario = new ToolStrip();
            Btn_Cadastrar_Usuario = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Btn_Limpar_Campos = new ToolStripButton();
            Btn_Fechar_Login = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Login).BeginInit();
            toolStrip_Usuario.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Login
            // 
            pictureBox_Login.Image = Properties.Resources.usuaria;
            pictureBox_Login.Location = new Point(256, 20);
            pictureBox_Login.Name = "pictureBox_Login";
            pictureBox_Login.Size = new Size(40, 40);
            pictureBox_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Login.TabIndex = 12;
            pictureBox_Login.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(45, 33);
            label1.Name = "label1";
            label1.Size = new Size(205, 27);
            label1.TabIndex = 10;
            label1.Text = "Cadastrar Usuário(a)";
            // 
            // txb_Usuario_Adcionado
            // 
            txb_Usuario_Adcionado.Location = new Point(104, 80);
            txb_Usuario_Adcionado.Name = "txb_Usuario_Adcionado";
            txb_Usuario_Adcionado.Size = new Size(200, 23);
            txb_Usuario_Adcionado.TabIndex = 15;
            // 
            // txb_Senha_Adicionada
            // 
            txb_Senha_Adicionada.Location = new Point(104, 123);
            txb_Senha_Adicionada.Name = "txb_Senha_Adicionada";
            txb_Senha_Adicionada.PasswordChar = '*';
            txb_Senha_Adicionada.Size = new Size(200, 23);
            txb_Senha_Adicionada.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 88);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 13;
            label2.Text = "Usuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 131);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 14;
            label3.Text = "Senha:";
            // 
            // toolStrip_Usuario
            // 
            toolStrip_Usuario.BackColor = Color.Gainsboro;
            toolStrip_Usuario.Dock = DockStyle.Bottom;
            toolStrip_Usuario.ImageScalingSize = new Size(36, 36);
            toolStrip_Usuario.Items.AddRange(new ToolStripItem[] { Btn_Cadastrar_Usuario, toolStripSeparator1, Btn_Limpar_Campos, Btn_Fechar_Login });
            toolStrip_Usuario.Location = new Point(0, 202);
            toolStrip_Usuario.Name = "toolStrip_Usuario";
            toolStrip_Usuario.Size = new Size(334, 39);
            toolStrip_Usuario.TabIndex = 17;
            toolStrip_Usuario.Text = "toolStrip1";
            // 
            // Btn_Cadastrar_Usuario
            // 
            Btn_Cadastrar_Usuario.AutoSize = false;
            Btn_Cadastrar_Usuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Cadastrar_Usuario.Image = Properties.Resources.confirmacao2;
            Btn_Cadastrar_Usuario.ImageTransparentColor = Color.Magenta;
            Btn_Cadastrar_Usuario.Name = "Btn_Cadastrar_Usuario";
            Btn_Cadastrar_Usuario.Size = new Size(36, 36);
            Btn_Cadastrar_Usuario.Text = "Cadastrar Usuário";
            Btn_Cadastrar_Usuario.Click += Btn_Cadastrar_Usuario_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos
            // 
            Btn_Limpar_Campos.AutoSize = false;
            Btn_Limpar_Campos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos.Name = "Btn_Limpar_Campos";
            Btn_Limpar_Campos.Size = new Size(36, 36);
            Btn_Limpar_Campos.Text = "Fechar";
            Btn_Limpar_Campos.Click += Btn_Limpar_Campos_Click_1;
            // 
            // Btn_Fechar_Login
            // 
            Btn_Fechar_Login.Alignment = ToolStripItemAlignment.Right;
            Btn_Fechar_Login.AutoSize = false;
            Btn_Fechar_Login.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Fechar_Login.Image = Properties.Resources.exit;
            Btn_Fechar_Login.ImageTransparentColor = Color.Magenta;
            Btn_Fechar_Login.Name = "Btn_Fechar_Login";
            Btn_Fechar_Login.Size = new Size(36, 36);
            Btn_Fechar_Login.Text = "Fechar";
            Btn_Fechar_Login.Click += Btn_Fechar_Login_Click_1;
            // 
            // Form_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 241);
            Controls.Add(toolStrip_Usuario);
            Controls.Add(txb_Usuario_Adcionado);
            Controls.Add(txb_Senha_Adicionada);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox_Login);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Usuário(a)";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Login).EndInit();
            toolStrip_Usuario.ResumeLayout(false);
            toolStrip_Usuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Login;
        private Label label1;
        private TextBox txb_Usuario_Adcionado;
        private TextBox txb_Senha_Adicionada;
        private Label label2;
        private Label label3;
        private ToolStrip toolStrip_Usuario;
        private ToolStripButton Btn_Cadastrar_Usuario;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Btn_Limpar_Campos;
        private ToolStripButton Btn_Fechar_Login;
    }
}