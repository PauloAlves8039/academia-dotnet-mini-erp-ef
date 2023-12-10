namespace MiniERP.EF.App.Views
{
    partial class Form_Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Sobre));
            ToolStrip_Sobre = new ToolStrip();
            Btn_Fechar_Sobre = new ToolStripButton();
            label_InfoDetalhes = new Label();
            label_InfoAmigoSecreto = new Label();
            label_InfoDesenvolvedor = new Label();
            label_Desenvolvedor = new Label();
            label_Sobre = new Label();
            ToolStrip_Sobre.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip_Sobre
            // 
            ToolStrip_Sobre.BackColor = Color.Gainsboro;
            ToolStrip_Sobre.Dock = DockStyle.Bottom;
            ToolStrip_Sobre.ImageScalingSize = new Size(36, 36);
            ToolStrip_Sobre.Items.AddRange(new ToolStripItem[] { Btn_Fechar_Sobre });
            ToolStrip_Sobre.Location = new Point(0, 222);
            ToolStrip_Sobre.Name = "ToolStrip_Sobre";
            ToolStrip_Sobre.Size = new Size(484, 39);
            ToolStrip_Sobre.TabIndex = 9;
            ToolStrip_Sobre.Text = "toolStrip1";
            // 
            // Btn_Fechar_Sobre
            // 
            Btn_Fechar_Sobre.Alignment = ToolStripItemAlignment.Right;
            Btn_Fechar_Sobre.AutoSize = false;
            Btn_Fechar_Sobre.DisplayStyle = ToolStripItemDisplayStyle.Image;
            Btn_Fechar_Sobre.Image = Properties.Resources.exit;
            Btn_Fechar_Sobre.ImageTransparentColor = Color.Magenta;
            Btn_Fechar_Sobre.Name = "Btn_Fechar_Sobre";
            Btn_Fechar_Sobre.Size = new Size(36, 36);
            Btn_Fechar_Sobre.Text = "Sair";
            Btn_Fechar_Sobre.Click += Btn_Fechar_Sobre_Click;
            // 
            // label_InfoDetalhes
            // 
            label_InfoDetalhes.AutoSize = true;
            label_InfoDetalhes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoDetalhes.ForeColor = Color.Black;
            label_InfoDetalhes.Location = new Point(33, 106);
            label_InfoDetalhes.Name = "label_InfoDetalhes";
            label_InfoDetalhes.Size = new Size(337, 15);
            label_InfoDetalhes.TabIndex = 14;
            label_InfoDetalhes.Text = "Aplicação responsável por simular um pequeno ERP simples.";
            // 
            // label_InfoAmigoSecreto
            // 
            label_InfoAmigoSecreto.AutoSize = true;
            label_InfoAmigoSecreto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoAmigoSecreto.ForeColor = Color.Black;
            label_InfoAmigoSecreto.Location = new Point(33, 72);
            label_InfoAmigoSecreto.Name = "label_InfoAmigoSecreto";
            label_InfoAmigoSecreto.Size = new Size(102, 15);
            label_InfoAmigoSecreto.TabIndex = 13;
            label_InfoAmigoSecreto.Text = "Projeto: Mini ERP";
            // 
            // label_InfoDesenvolvedor
            // 
            label_InfoDesenvolvedor.AutoSize = true;
            label_InfoDesenvolvedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_InfoDesenvolvedor.ForeColor = Color.Black;
            label_InfoDesenvolvedor.Location = new Point(33, 170);
            label_InfoDesenvolvedor.Name = "label_InfoDesenvolvedor";
            label_InfoDesenvolvedor.Size = new Size(227, 15);
            label_InfoDesenvolvedor.TabIndex = 12;
            label_InfoDesenvolvedor.Text = "Aluno da 5° academia .NET da UFN 2023";
            // 
            // label_Desenvolvedor
            // 
            label_Desenvolvedor.AutoSize = true;
            label_Desenvolvedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_Desenvolvedor.ForeColor = Color.Black;
            label_Desenvolvedor.Location = new Point(33, 138);
            label_Desenvolvedor.Name = "label_Desenvolvedor";
            label_Desenvolvedor.Size = new Size(174, 15);
            label_Desenvolvedor.TabIndex = 11;
            label_Desenvolvedor.Text = "Desenvolvido por: Paulo Alves";
            // 
            // label_Sobre
            // 
            label_Sobre.AutoSize = true;
            label_Sobre.Font = new Font("Comic Sans MS", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_Sobre.ForeColor = Color.DodgerBlue;
            label_Sobre.Location = new Point(198, 23);
            label_Sobre.Name = "label_Sobre";
            label_Sobre.Size = new Size(71, 29);
            label_Sobre.TabIndex = 10;
            label_Sobre.Text = "Sobre";
            // 
            // Form_Sobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(484, 261);
            Controls.Add(label_InfoDetalhes);
            Controls.Add(label_InfoAmigoSecreto);
            Controls.Add(label_InfoDesenvolvedor);
            Controls.Add(label_Desenvolvedor);
            Controls.Add(label_Sobre);
            Controls.Add(ToolStrip_Sobre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Sobre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sobre";
            ToolStrip_Sobre.ResumeLayout(false);
            ToolStrip_Sobre.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip_Sobre;
        private ToolStripButton Btn_Fechar_Sobre;
        private Label label_InfoDetalhes;
        private Label label_InfoAmigoSecreto;
        private Label label_InfoDesenvolvedor;
        private Label label_Desenvolvedor;
        private Label label_Sobre;
    }
}