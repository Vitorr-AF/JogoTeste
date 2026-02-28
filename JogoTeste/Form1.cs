// Imports
using System.IO;
using System.Text.Json;
using static JogoTeste.Form1;

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

        // Definição das classes, objetos e variáveis
        private Player player;
        private Random random = new Random();
        private Dictionary<int, List<Inimigo>> InimigosPorNivel =
            new Dictionary<int, List<Inimigo>>();
        List<Inimigo> inimigos = new List<Inimigo>();
        private List<PictureBox> imagensInimigos = new List<PictureBox>();
        int inimigoSelecionadoIndice;

        public class Player
        {
            public int VidaMax;
            public int VidaAtual;
            public int EnergiaMax;
            public int EnergiaAtual;
            public int DanoAtaque;
            public int TaxaAcerto;
        }
        public class Inimigo
        {
            public string Nome { get; set; }
            public int VidaMax { get; set; }
            public int VidaAtual { get; set; }
            public int Dano { get; set; }
            public string CaminhoImagem { get; set; }
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
            CarregarInimigos();
            player = new Player
            {
                VidaMax = 100,
                VidaAtual = 100,
                EnergiaMax = 100,
                EnergiaAtual = 100,
                DanoAtaque = 100,
                TaxaAcerto = 100,
            };
            AtualizarRecursos();
            ProximaOnda(1);
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
            panelControls.Visible = false;
            panelStatusMenu.Visible = true;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];
            int numeroAcerto = random.Next(1, 101);

            if (numeroAcerto <= player.TaxaAcerto)
            {
                DanoAoInimigo(player.DanoAtaque);
            }
            else
            {
                ExibirMensagem("Ataque errou!!!");
            }
            
        }

        private void ExibirMensagem(String mensagem)
        {
            labelMensagens.Visible = true;
            labelMensagens.Text = mensagem;
        }


        // Funções de Combate do Player
        private void DanoAoPlayer(int dano)
        {
            player.VidaAtual -= dano;
            AtualizarRecursos();
        }

        private void DanoAoInimigo(int dano)
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];
            inimigo.VidaAtual -= dano;
            AtualizarRecursosInimigo();
        }


        // Funções dos inimigos (visual)
        private void CarregarInimigos()
        {
            string json = File.ReadAllText("inimigos.json");

            InimigosPorNivel =
                JsonSerializer.Deserialize<Dictionary<int, List<Inimigo>>>(json);
        }
        private void CriarImagensInimigos()
        {
            for (int i = 0; i < inimigos.Count; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Size = new Size(100, 100);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Image = Image.FromFile(inimigos[i].CaminhoImagem);

                pb.Left = 50 + (i * 120);
                if (i % 2 == 0)
                {
                    pb.Top = random.Next(10, 54);
                }
                else
                {
                    pb.Top = random.Next(55, 100);
                }

                pb.Tag = i;
                pb.Click += Inimigo_Click;

                panelEnemies.Controls.Add(pb);
                imagensInimigos.Add(pb);
            }
        }

        private void AtualizarRecursosInimigo()
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];

            int larguraVidaInimigo = (int)((inimigo.VidaAtual / (float)inimigo.VidaMax) * panelFundoVidaInimigo.Width);
            panelFrenteVidaInimigo.Width = larguraVidaInimigo;
        }

        private void Inimigo_Click(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            inimigoSelecionadoIndice = (int)pb.Tag;
            labelNomeInimigo.Text = $"{inimigos[inimigoSelecionadoIndice].Nome}:";

            AtualizarRecursosInimigo();

            labelNomeInimigo.Visible = true;

            panelFundoVidaInimigo.Visible = true;
        }

        private void LimparInimigos()
        {
            inimigos.Clear();
            imagensInimigos.Clear();
            panelEnemies.Controls.Clear();
        }

        private void panelFrenteVidaInimigo_MouseEnter(object sender, EventArgs e)
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];

            labelVidaInimigo.Text = $"{inimigo.VidaAtual}/{inimigo.VidaMax}";
            
            labelVidaInimigo.Visible = true;
        }

        private void panelFrenteVidaInimigo_MouseLeave(object sender, EventArgs e)
        {
            labelVidaInimigo.Visible = false;
        }

        // Funções dos inimigos (mecânica)
        private void ProximaOnda(int dificuldade)
        {
            LimparInimigos();

            int quantidadeInimigos = random.Next(1, dificuldade + 2); // Aparentemente o random.next exclui o valor max
            // A linha embaixo dessa é mudar diretamente a quantidade, por padrão é pra deixar comentada
            //int quantidadeInimigos = 6;
            var banco = InimigosPorNivel[dificuldade];
            for (int i = 0; i < quantidadeInimigos; i++)
            {
                var modelo = banco[random.Next(banco.Count)];
                inimigos.Add(new Inimigo
                {
                    Nome = modelo.Nome,
                    VidaMax = modelo.VidaMax,
                    VidaAtual = modelo.VidaMax,
                    Dano = modelo.Dano,
                    CaminhoImagem = modelo.CaminhoImagem
                });
            }

            CriarImagensInimigos();
        }
    }
}
