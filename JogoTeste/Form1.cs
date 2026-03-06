// Imports
using System.IO;
using System.Text.Json;
using static JogoTeste.Form1;
using JogoTeste.Models;

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
        private PictureBox? inimigoSelecionadoPB = null;
        int inimigoSelecionadoIndice;
        bool inimigoSelecionado;
        bool inimigoSelecionadoClicado;
        private const int TAMANHO_NORMAL = 100; //mude isso pra mudar o tamanho dos inimigos quando você passa o mouse
        private const int TAMANHO_HOVER = 110;
        int dificuldadeAtual = 1;
        int ondaAtual = 0;
        
        

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
                DanoAtaque = 20,
                TaxaAcerto = 100,
            };
            AtualizarRecursos();
            ProximaOnda(dificuldadeAtual);
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

        private void panelFundoEnergia_MouseEnter(object sender, EventArgs e)
        {
            labelEnergia.Text = $"{player.EnergiaAtual}/{player.EnergiaMax}";

            labelEnergia.Visible = true;
        }

        private void panelFundoEnergia_MouseLeave(object sender, EventArgs e)
        {
            labelEnergia.Visible = false;
        }

        private void panelFundoVida_MouseEnter(object sender, EventArgs e)
        {
            labelVida.Text = $"{player.VidaAtual}/{player.VidaMax}";

            labelVida.Visible = true;
        }

        private void panelFundoVida_MouseLeave(object sender, EventArgs e)
        {
            labelVida.Visible = false;
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
            if (!inimigoSelecionado)
            {
                ExibirMensagem("Selecione um inimigo para atacar");
                return;
            }
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];
            if (!inimigo.Vivo)
            {
                ExibirMensagem("Selecione um inimigo que ainda não esteja morto");
                return;
            }
            ExibirMensagem("");
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


        private void Inimigo_Click(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            inimigoSelecionadoPB = pb;
            inimigoSelecionadoIndice = (int)pb.Tag;
            inimigoSelecionado = true;
            inimigoSelecionadoClicado = true;
            MostrarVidaInimigo();
            VoltarMenuControles();
        }

        private void Inimigo_MouseEnter(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            
            if (inimigoSelecionadoPB != null && inimigoSelecionadoPB != pb && inimigoSelecionadoIndice != (int)pb.Tag)
            {
                DefinirTamanho(inimigoSelecionadoPB, TAMANHO_NORMAL);
                DefinirTamanho(pb, TAMANHO_HOVER);
                inimigoSelecionadoClicado = false;
            }
            inimigoSelecionadoPB = pb;
            
            inimigoSelecionadoIndice = (int)pb.Tag;
            inimigoSelecionado = true;
            if (!inimigoSelecionadoClicado)
            {
                DefinirTamanho(pb, TAMANHO_HOVER);
            }

            MostrarVidaInimigo();
        }
        private void Inimigo_MouseLeave(object? sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (!inimigoSelecionadoClicado)
            {
                labelNomeInimigo.Visible = false;
                panelFundoVidaInimigo.Visible = false;
                inimigoSelecionado = false;
                DefinirTamanho(pb, TAMANHO_NORMAL);
            }
            
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

        private void panelFundoVidaInimigo_MouseEnter(object sender, EventArgs e)
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];

            labelVidaInimigo.Text = $"{inimigo.VidaAtual}/{inimigo.VidaMax}";

            labelVidaInimigo.Visible = true;
        }

        private void panelFundoVidaInimigo_MouseLeave(object sender, EventArgs e)
        {
            labelVidaInimigo.Visible = false;
        }

        private void panelEnemies_Click(object sender, EventArgs e)
        {
            labelNomeInimigo.Visible = false;
            panelFundoVidaInimigo.Visible = false;

            inimigoSelecionado = false;
            inimigoSelecionadoClicado = false;


            if (inimigoSelecionadoPB != null)
            {
                DefinirTamanho(inimigoSelecionadoPB, TAMANHO_NORMAL);

            }
        }

        private void trackTaxaAcerto_Scroll(object sender, EventArgs e)
        {
            float multiplicadorDeDano = 1.15f;
            float taxaBase = 100f;
            float danoBase = 20f;

            player.TaxaAcerto = trackTaxaAcerto.Value;

            float taxaCalculo = Math.Max(player.TaxaAcerto, 10f);

            float multiplicador = (float)Math.Pow(
                taxaBase / (float)taxaCalculo,
                multiplicadorDeDano
                );

            player.DanoAtaque = (int)Math.Round(danoBase * multiplicador);

            labelTaxaAcerto.Text = $"{player.TaxaAcerto}% de taxa de acerto";
            labelDanoAtaque.Text = $"{player.DanoAtaque} de dano de ataque";


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
                pb.MouseEnter += Inimigo_MouseEnter;
                pb.MouseLeave += Inimigo_MouseLeave;

                panelEnemies.Controls.Add(pb);
                imagensInimigos.Add(pb);
            }
        }

        private void MostrarVidaInimigo()
        {
            labelNomeInimigo.Text = $"{inimigos[inimigoSelecionadoIndice].Nome}:";

            AtualizarRecursosInimigo();

            labelNomeInimigo.Visible = true;
            panelFundoVidaInimigo.Visible = true;
        }

        private void DefinirTamanho(PictureBox pb, int tamanho)
        {
            pb.Left = pb.Left + (pb.Width - tamanho) / 2;
            pb.Top = pb.Top + (pb.Height - tamanho) / 2;

            pb.Width = tamanho;
            pb.Height = tamanho;
            // labelDebug.Visible = true
            // labelDebug.Text = $"Left: {pb.Left} Largura: {pb.Width}\nTop: {pb.Top} Altura: {pb.Height}";
        }

        private void LimparInimigos()
        {
            inimigos.Clear();
            imagensInimigos.Clear();
            panelEnemies.Controls.Clear();
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

        
        private void VoltarMenuControles()
        {
            panelSkillsMenu.Visible = false;
            panelItemsMenu.Visible = false;
            panelStatusMenu.Visible = false;
            panelControls.Visible = true;
        }


        private void ExibirMensagem(String mensagem)
        {
            labelMensagens.Visible = true;
            labelMensagens.Text = mensagem;
        }




        
        private void CarregarInimigos()
        {
            string json = File.ReadAllText("inimigos.json");

            InimigosPorNivel =
                JsonSerializer.Deserialize<Dictionary<int, List<Inimigo>>>(json);
        }


        

        

        

        // Funções de Combate do Player
        private void DanoAoPlayer(int dano)
        {
            player.VidaAtual -= dano;
            if (player.VidaAtual < 0)
            {
                player.VidaAtual = 0;
            }
            AtualizarRecursos();
        }


        

        // Funções dos inimigos (mecânica)
        private void ProximaOnda(int dificuldade)
        {
            LimparInimigos();
            labelNomeInimigo.Visible = false;
            panelFundoVidaInimigo.Visible = false;
            inimigoSelecionadoIndice = -1;
            inimigoSelecionadoPB = null;
            inimigoSelecionado = false;
            inimigoSelecionadoClicado = false;

            int quantidadeInimigos = random.Next(1, dificuldade + 2); // Aparentemente o random.next exclui o valor max
            // A linha embaixo dessa é pra mudar diretamente a quantidade, por padrão é pra deixar comentada
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
                    CaminhoImagem = modelo.CaminhoImagem,
                    Vivo = true
                });
            }

            CriarImagensInimigos();
            ondaAtual +=  1;
            labelOndaNum.Text = $"Onda {ondaAtual}";
            dificuldadeAtual = (ondaAtual / 5) + 1;
            if (dificuldadeAtual > 5)
            {
                dificuldadeAtual = 5;
            }
        }
        private void AtualizarRecursosInimigo()
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];

            int larguraVidaInimigo = (int)((inimigo.VidaAtual / (float)inimigo.VidaMax) * panelFundoVidaInimigo.Width);
            panelFrenteVidaInimigo.Width = larguraVidaInimigo;
            if (inimigos.All(i => !i.Vivo)){
                ProximaOnda(dificuldadeAtual);
            }
        }

        private void DanoAoInimigo(int dano)
        {
            Inimigo inimigo = inimigos[inimigoSelecionadoIndice];
            inimigo.VidaAtual -= dano;
            if (inimigo.VidaAtual <= 0)
            {
                inimigo.VidaAtual = 0;
                inimigo.Vivo = false;

            }
            AtualizarRecursosInimigo();
        }
    }
}
