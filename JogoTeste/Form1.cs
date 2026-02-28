namespace JogoTeste
{
    public partial class Form1 : Form
    {
        // Definição do Form
        public Form1()
        {
            InitializeComponent();
        }

        // Funções de Centralização do form com tela cheia
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

        // Definição das classes
        private Player player;
        List<Inimigo> inimigos = new List<Inimigo>();

        public class Player
        {
            public int VidaMax;
            public int VidaAtual;
            public int EnergiaMax;
            public int EnergiaAtual;
        }
        public class Inimigo
        {
            public int Vida { get; set; }
            public string Nome { get; set; }
        }

        // Botões do Menu de Inicio, e suas funções
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
            player = new Player
            {
                VidaMax = 100,
                VidaAtual = 100,
                EnergiaMax = 100,
                EnergiaAtual = 100,
            };
            AtualizarRecursos();
        }

        // Barra de Vida e de Energia, e suas funções
        private void panelFrenteVida_MouseEnter(object sender, EventArgs e)
        {
            labelVida.Text = $"{player.VidaAtual}/{player.VidaMax}";

            labelVida.Visible = true;
        }

        private void panelFrenteVida_MouseLeave(object sender, EventArgs e)
        {
            labelVida.Visible = false;
        }

        private void panelFrenteEnergia_MouseEnter(object sender, EventArgs e)
        {
            labelEnergia.Text = $"{player.EnergiaAtual}/{player.EnergiaMax}";

            labelEnergia.Visible = true;
        }

        private void panelFrenteEnergia_MouseLeave(object sender, EventArgs e)
        {
            labelEnergia.Visible = false;
        }

        private void AtualizarRecursos()
        {
            if (player.VidaAtual < (player.VidaMax * 0.3))
            {
                panelFrenteVida.BackColor = Color.Red;
            }
            else
            {
                panelFrenteVida.BackColor = Color.LimeGreen;
            }

            int larguraVida = (int)((player.VidaAtual / (float)player.VidaMax) * panelFundoVida.Width);
            int larguraEnergia = (int)((player.EnergiaAtual / (float)player.EnergiaMax) * panelFundoEnergia.Width);

            panelFrenteVida.Width = larguraVida;
            panelFrenteEnergia.Width = larguraEnergia;
        }

        //Botões de Voltar para o Menu de Jogo Principal
        private void VoltarMenuControles()
        {
            panelSkillsMenu.Visible = false;
            panelItemsMenu.Visible = false;
            panelStatusMenu.Visible = false;
            panelControls.Visible = true;
        }
        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            VoltarMenuControles();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            VoltarMenuControles();
        }

        private void btnVoltar3_Click(object sender, EventArgs e)
        {
            VoltarMenuControles();
        }
        
        // Botões do Menu de Jogo Principal
        private void btnSkills_Click(object sender, EventArgs e)
        {
            panelControls.Visible = false;
            panelSkillsMenu.Visible = true;
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            panelControls.Visible = false;
            panelItemsMenu.Visible = true;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            panelControls.Visible=false;
            panelStatusMenu.Visible=true;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        // Funções de Combate
        private void DanoAoPlayer(int dano)
        {
            player.VidaAtual -= dano;
            AtualizarRecursos();
        }

        private void AtacarAlvo(int alvoId, int dano)
        {

        }
        



    }
}
