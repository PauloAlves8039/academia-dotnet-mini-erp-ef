namespace MiniERP.EF.App
{
    partial class Form_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            Timer_Inicio = new System.Windows.Forms.Timer(components);
            ProgressBar_Inicio = new ProgressBar();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Timer_Inicio
            // 
            Timer_Inicio.Enabled = true;
            Timer_Inicio.Tick += Timer_Inicio_Tick;
            // 
            // ProgressBar_Inicio
            // 
            ProgressBar_Inicio.Dock = DockStyle.Bottom;
            ProgressBar_Inicio.Location = new Point(0, 238);
            ProgressBar_Inicio.Name = "ProgressBar_Inicio";
            ProgressBar_Inicio.Size = new Size(384, 23);
            ProgressBar_Inicio.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.mini_erp;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(384, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form_Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(pictureBox1);
            Controls.Add(ProgressBar_Inicio);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form_Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Início";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer_Inicio;
        private ProgressBar ProgressBar_Inicio;
        private PictureBox pictureBox1;
    }
}