namespace MiniERP.EF.App
{
    public partial class Form_Inicio : Form
    {
        public Form_Inicio()
        {
            InitializeComponent();
        }

        private void Timer_Inicio_Tick(object sender, EventArgs e)
        {
            if (ProgressBar_Inicio.Value < 100)
            {
                ProgressBar_Inicio.Value = ProgressBar_Inicio.Value + 2;
            }
            else
            {
                Timer_Inicio.Enabled = false;
                Form_Menu formMenu = new Form_Menu();
                formMenu.Show();
                Visible = false;
            }
        }
    }
}