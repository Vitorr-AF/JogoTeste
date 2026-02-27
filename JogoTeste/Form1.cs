namespace JogoTeste
{
    public partial class Form1 : Form
    {
        int vidaJogador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = false;
            panelJogo1.Visible = true;
            IniciarJogo();
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarJogo()
        {
            vidaJogador = 100;
            progressVida.Value = vidaJogador;
        }

        private void Centralizar(Panel interno, Panel pai)
        {
            interno.Left = (pai.Width - interno.Width) / 2;
            interno.Top = (pai.Height - interno.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Centralizar(panelCentroMenu, panelMenu);
        }
    }
}
