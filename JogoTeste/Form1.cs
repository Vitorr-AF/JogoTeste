namespace JogoTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
