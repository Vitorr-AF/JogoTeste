namespace JogoTeste
{
    public partial class Form1 : Form
    {
        int vidaMax;
        int vidaAtual;
        int energiaMax;
        int energiaAtual;

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
            vidaMax = 100;
            vidaAtual = 100;
            energiaMax = 100;
            energiaAtual = 100;
            AtualizarRecursos();
        }

        private void Centralizar(Panel interno, Panel pai)
        {
            interno.Left = (pai.Width - interno.Width) / 2;
            interno.Top = (pai.Height - interno.Height) / 2;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Centralizar(panelCentroMenu, panelMenu);
            Centralizar(panelCentroJogo1, panelJogo1);
        }

        private void AtualizarRecursos()
        {
            if (vidaAtual < (vidaMax * 0.3))
            {
                panelFrenteVida.BackColor = Color.Red;
            }
            else
            {
                panelFrenteVida.BackColor = Color.LimeGreen;
            }

            int larguraVida = (int)((vidaAtual / (float)vidaMax) * panelFundoVida.Width);
            int larguraEnergia = (int)((energiaAtual / (float)energiaMax) * panelFundoEnergia.Width);

            panelFrenteVida.Width = larguraVida;
            panelFrenteEnergia.Width = larguraEnergia;
        }

        private void panelFrenteVida_MouseEnter(object sender, EventArgs e)
        {
            labelVida.Text = $"{vidaAtual}/{vidaMax}";

            labelVida.Visible = true;
        }

        private void panelFrenteVida_MouseLeave(object sender, EventArgs e)
        {
            labelVida.Visible = false;
        }

        private void panelFrenteEnergia_MouseEnter(object sender, EventArgs e)
        {
            labelEnergia.Text = $"{energiaAtual}/{energiaMax}";

            labelEnergia.Visible = true;
        }

        private void panelFrenteEnergia_MouseLeave(object sender, EventArgs e)
        {
            labelEnergia.Visible = false;
        }
    }
}
