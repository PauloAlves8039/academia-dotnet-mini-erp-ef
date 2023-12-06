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
            ToolStrip_Info.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip_Info
            // 
            ToolStrip_Info.BackColor = Color.Gainsboro;
            ToolStrip_Info.Dock = DockStyle.Bottom;
            ToolStrip_Info.ImageScalingSize = new Size(36, 36);
            ToolStrip_Info.Items.AddRange(new ToolStripItem[] { Btn_Fechar_Info });
            ToolStrip_Info.Location = new Point(0, 411);
            ToolStrip_Info.Name = "ToolStrip_Info";
            ToolStrip_Info.Size = new Size(800, 39);
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
            // Form_Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ToolStrip_Info);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form_Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informações";
            ToolStrip_Info.ResumeLayout(false);
            ToolStrip_Info.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip_Info;
        private ToolStripButton Btn_Fechar_Info;
    }
}