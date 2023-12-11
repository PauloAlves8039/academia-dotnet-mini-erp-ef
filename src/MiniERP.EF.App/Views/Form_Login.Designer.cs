namespace MiniERP.EF.App.Views
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            pictureBox_Login = new PictureBox();
            label1 = new Label();
            toolStrip_Login = new ToolStrip();
            Btn_Login = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            Btn_Limpar_Campos_Login = new ToolStripButton();
            Btn_Fechar_Login = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            Btn_Cadastrar_Usuario = new ToolStripButton();
            txb_Usuario_Login = new TextBox();
            txb_Senha_login = new TextBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Login).BeginInit();
            toolStrip_Login.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Login
            // 
            pictureBox_Login.Image = Properties.Resources.usuarios;
            pictureBox_Login.Location = new Point(185, 17);
            pictureBox_Login.Name = "pictureBox_Login";
            pictureBox_Login.Size = new Size(40, 40);
            pictureBox_Login.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Login.TabIndex = 9;
            pictureBox_Login.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DeepSkyBlue;
            label1.Location = new Point(115, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 30);
            label1.TabIndex = 7;
            label1.Text = "Login";
            // 
            // toolStrip_Login
            // 
            toolStrip_Login.BackColor = Color.Gainsboro;
            toolStrip_Login.Dock = DockStyle.Bottom;
            toolStrip_Login.ImageScalingSize = new Size(36, 36);
            toolStrip_Login.Items.AddRange(new ToolStripItem[] { Btn_Login, toolStripSeparator3, Btn_Limpar_Campos_Login, Btn_Fechar_Login, toolStripSeparator4, Btn_Cadastrar_Usuario });
            toolStrip_Login.Location = new Point(0, 202);
            toolStrip_Login.Name = "toolStrip_Login";
            toolStrip_Login.Size = new Size(334, 39);
            toolStrip_Login.TabIndex = 14;
            toolStrip_Login.Text = "toolStrip1";
            // 
            // Btn_Login
            // 
            Btn_Login.AutoSize = false;
            Btn_Login.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Login.Image = Properties.Resources.confirmacao2;
            Btn_Login.ImageTransparentColor = Color.Magenta;
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(36, 36);
            Btn_Login.Text = "Entrar";
            Btn_Login.Click += Btn_Login_Click_1;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 39);
            // 
            // Btn_Limpar_Campos_Login
            // 
            Btn_Limpar_Campos_Login.AutoSize = false;
            Btn_Limpar_Campos_Login.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Limpar_Campos_Login.Image = Properties.Resources.brush3;
            Btn_Limpar_Campos_Login.ImageTransparentColor = Color.Magenta;
            Btn_Limpar_Campos_Login.Name = "Btn_Limpar_Campos_Login";
            Btn_Limpar_Campos_Login.Size = new Size(36, 36);
            Btn_Limpar_Campos_Login.Text = "Limpar Campos";
            Btn_Limpar_Campos_Login.Click += Btn_Limpar_Campos_Login_Click;
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
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 39);
            // 
            // Btn_Cadastrar_Usuario
            // 
            Btn_Cadastrar_Usuario.AutoSize = false;
            Btn_Cadastrar_Usuario.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Cadastrar_Usuario.Image = Properties.Resources.usuaria;
            Btn_Cadastrar_Usuario.ImageTransparentColor = Color.Magenta;
            Btn_Cadastrar_Usuario.Name = "Btn_Cadastrar_Usuario";
            Btn_Cadastrar_Usuario.Size = new Size(36, 36);
            Btn_Cadastrar_Usuario.Text = "Novo Usuário";
            Btn_Cadastrar_Usuario.Click += Btn_Cadastrar_Usuario_Click;
            // 
            // txb_Usuario_Login
            // 
            txb_Usuario_Login.Location = new Point(97, 81);
            txb_Usuario_Login.Name = "txb_Usuario_Login";
            txb_Usuario_Login.Size = new Size(200, 23);
            txb_Usuario_Login.TabIndex = 12;
            // 
            // txb_Senha_login
            // 
            txb_Senha_login.Location = new Point(97, 124);
            txb_Senha_login.Name = "txb_Senha_login";
            txb_Senha_login.PasswordChar = '*';
            txb_Senha_login.Size = new Size(200, 23);
            txb_Senha_login.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 89);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 10;
            label4.Text = "Usuário:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(27, 132);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 11;
            label5.Text = "Senha:";
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 241);
            Controls.Add(toolStrip_Login);
            Controls.Add(txb_Usuario_Login);
            Controls.Add(txb_Senha_login);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(pictureBox_Login);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Login).EndInit();
            toolStrip_Login.ResumeLayout(false);
            toolStrip_Login.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Login;
        private Label label1;
        private ToolStrip toolStrip_Login;
        private ToolStripButton Btn_Login;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Btn_Fechar_Login;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton Btn_Cadastrar_Usuario;
        private TextBox txb_Usuario_Login;
        private TextBox txb_Senha_login;
        private Label label4;
        private Label label5;
        private ToolStripButton toolStripButton1;
        private ToolStripButton Btn_Limpar_Campos_Login;
    }
}