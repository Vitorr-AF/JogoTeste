// Imports
using System.IO;
using System.Text.Json;
using static JogoTeste.Form1;
using JogoTeste.Models;
using JogoTeste.Utils;
using JogoTeste.Services;

namespace JogoTeste
{
    public partial class Form1 : Form
    {

        // =========================
        // Definição do Form
        // =========================
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            uiHelper.Centralizar(panelCentroMenu, panelMenu);
            uiHelper.Centralizar(panelCentroJogo1, panelJogo1);
        }



        // =========================
        // Classes, objetos e variáveis
        // =========================
        UIHelper uiHelper = new UIHelper();
        CombatService combatService = new CombatService();
        EnemyService enemyService = new EnemyService();

        private Player player;
        ItemService itemService = new ItemService();
        private Random random = new Random();

        private Dictionary<int, List<Inimigo>> InimigosPorNivel =
            new Dictionary<int, List<Inimigo>>();

        List<Inimigo> inimigos = new List<Inimigo>();
        private List<PictureBox> imagensInimigos = new List<PictureBox>();

        List<Item> inventario = new List<Item>();

        private PictureBox? inimigoSelecionadoPB = null;

        List<object> ordemTurnos = new List<object>();

        int turnoAtual;
        int inimigoSelecionadoIndice = -1;

        bool inimigoSelecionado;
        bool inimigoSelecionadoClicado;

        private const int TAMANHO_NORMAL = 100;
        private const int TAMANHO_HOVER = 110;

        int dificuldadeAtual = 1;
        int ondaAtual = 0;



        // =========================
        // Inicialização do Jogo
        // =========================
        private void IniciarJogo()
        {
            itemService.CarregarItens("itens.json");

            pbPlayer.Image = Image.FromFile("Assets/imagens/player/Idle.png");

            InimigosPorNivel = EnemyService.CarregarInimigos();

            player = new Player
            {
                VidaMax = 100,
                VidaAtual = 100,
                EnergiaMax = 100,
                EnergiaAtual = 100,
                DanoAtaque = 20,
                TaxaAcerto = 100,
            };

            AdicionarItem(1);

            AtualizarRecursos();

            ProximaOnda(dificuldadeAtual);

            ordemTurnos = TurnService.GerarOrdemTurnos(player, inimigos);

            turnoAtual = 0;
        }



        // =========================
        // Botões do menu inicial
        // =========================
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



        // =========================
        // Vida e Energia
        // =========================
        private void panelFrenteVida_MouseEnter(object sender, EventArgs e)
        {
            labelVida.Text = $"{player.VidaAtual}/{player.VidaMax}";
            labelVida.Visible = true;
        }

        private void panelFrenteVida_MouseLeave(object sender, EventArgs e)
        {
            labelVida.Visible = false;
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



        // =========================
        // Controles do menu
        // =========================
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



        // =========================
        // Combate
        // =========================
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

            if (numeroAcerto <= (player.TaxaAcerto + player.AcertoBonus))
            {
                //Calcula o dano
                int dano = player.DanoAtaque + player.DanoBonus;

                //Aplica o dano
                CombatService.DanoAoInimigo(inimigo, dano);

                //Cura caso tenha roubo de vida
                player.VidaAtual += (int)Math.Round(dano * player.RouboVida);


                if (!inimigo.Vivo)
                {
                    inimigoSelecionadoPB.Image = Image.FromFile("Assets/imagens/Dead.png");
                }

                AtualizarRecursos();
                ProximoTurno();
            }
            else
            {
                ExibirMensagem("Ataque errou!!!");
                AtualizarRecursos();
                ProximoTurno();
            }
        }



        // =========================
        // Eventos dos Inimigos
        // =========================
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
                uiHelper.DefinirTamanho(inimigoSelecionadoPB, TAMANHO_NORMAL);
                uiHelper.DefinirTamanho(pb, TAMANHO_HOVER);

                inimigoSelecionadoClicado = false;
            }

            inimigoSelecionadoPB = pb;
            inimigoSelecionadoIndice = (int)pb.Tag;

            inimigoSelecionado = true;

            if (!inimigoSelecionadoClicado)
            {
                uiHelper.DefinirTamanho(pb, TAMANHO_HOVER);
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

                uiHelper.DefinirTamanho(pb, TAMANHO_NORMAL);
            }
        }

        private void panelEnemies_Click(object sender, EventArgs e)
        {
            labelNomeInimigo.Visible = false;
            panelFundoVidaInimigo.Visible = false;

            inimigoSelecionado = false;
            inimigoSelecionadoClicado = false;

            if (inimigoSelecionadoPB != null)
            {
                uiHelper.DefinirTamanho(inimigoSelecionadoPB, TAMANHO_NORMAL);
            }
        }



        // =========================
        // Vida do Inimigo
        // =========================
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



        // =========================
        // Sistema de inimigos
        // =========================
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
                    pb.Top = random.Next(10, 54);
                else
                    pb.Top = random.Next(55, 100);

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

            AtualizarRecursos();

            labelNomeInimigo.Visible = true;
            panelFundoVidaInimigo.Visible = true;
        }

        private void LimparInimigos()
        {
            inimigos.Clear();

            imagensInimigos.Clear();

            panelEnemies.Controls.Clear();

            labelNomeInimigo.Visible = false;
            panelFundoVidaInimigo.Visible = false;

            inimigoSelecionadoIndice = -1;
            inimigoSelecionadoPB = null;

            inimigoSelecionado = false;
            inimigoSelecionadoClicado = false;
        }



        // =========================
        // Recursos / UI
        // =========================
        private void AtualizarRecursos()
        {
            if (player.VidaAtual < (player.VidaMax * 0.3))
            {
                panelFrenteVida.BackColor = Color.Red;
                labelVida.BackColor = Color.Red;
            }
            else
            {
                panelFrenteVida.BackColor = Color.LimeGreen;
                labelVida.BackColor = Color.LimeGreen;
            }

            if (inimigoSelecionadoIndice != -1 && inimigoSelecionadoIndice != null)
            {
                Inimigo inimigo = inimigos[inimigoSelecionadoIndice];

                int larguraVidaInimigo = (int)((inimigo.VidaAtual / (float)inimigo.VidaMax) * panelFundoVidaInimigo.Width);

                panelFrenteVidaInimigo.Width = larguraVidaInimigo;

                if (inimigos.All(i => !i.Vivo))
                {
                    ProximaOnda(dificuldadeAtual);
                }
            }

            if (player.AcertoBonus < 0)
                labelAcertoBonus.Text = $"-{player.AcertoBonus}%";
            else
                labelAcertoBonus.Text = $"+{player.AcertoBonus}%";

            int larguraVida = (int)((player.VidaAtual / (float)player.VidaMax) * panelFundoVida.Width);

            int larguraEnergia = (int)((player.EnergiaAtual / (float)player.EnergiaMax) * panelFundoEnergia.Width);

            panelFrenteVida.Width = larguraVida;

            panelFrenteEnergia.Width = larguraEnergia;
        }

        private void ExibirMensagem(String mensagem)
        {
            labelMensagens.Visible = true;

            labelMensagens.Text = mensagem;
        }

        private void VoltarMenuControles()
        {
            panelSkillsMenu.Visible = false;
            panelItemsMenu.Visible = false;
            panelStatusMenu.Visible = false;

            panelControls.Visible = true;
        }



        // =========================
        // Ondas
        // =========================
        private void ProximaOnda(int dificuldade)
        {
            LimparInimigos();

            EnemyService.GerarInimigos(
                dificuldade,
                random,
                InimigosPorNivel,
                inimigos
            );

            CriarImagensInimigos();

            ondaAtual++;

            labelOndaNum.Text = $"Onda {ondaAtual}";

            dificuldadeAtual = EnemyService.CalcularDificuldade(ondaAtual);
        }



        // =========================
        // Turnos
        // =========================
        private async void ProximoTurno()
        {
            labelNomeInimigo.Visible = false;
            panelFundoVidaInimigo.Visible = false;

            inimigoSelecionado = false;
            inimigoSelecionadoClicado = false;

            if (inimigoSelecionadoPB != null)
            {
                uiHelper.DefinirTamanho(inimigoSelecionadoPB, TAMANHO_NORMAL);
            }

            turnoAtual++;

            if (turnoAtual >= ordemTurnos.Count)
            {
                ordemTurnos = TurnService.GerarOrdemTurnos(player, inimigos);
                turnoAtual = 0;
            }

            var entidade = ordemTurnos[turnoAtual];

            if (entidade is Inimigo inimigo && !inimigo.Vivo)
            {
                ProximoTurno();
                return;
            }

            if (entidade is Player)
            {
                TurnoPlayer();
            }
            else if (entidade is Inimigo inimigo2)
            {
                TurnoInimigo();

                labelTurnoInimigo.Text = $"Turno de {inimigo2.Nome}";

                pbPlayer.Image = Image.FromFile("Assets/imagens/player/Hit.png");

                CombatService.AcaoInimigo(inimigo2, player);

                AtualizarRecursos();

                await Task.Delay(1200);

                pbPlayer.Image = Image.FromFile("Assets/imagens/player/Idle.png");

                ProximoTurno();
            }
        }

        private void TurnoInimigo()
        {
            panelTurnoInimigo.Visible = true;
        }

        private void TurnoPlayer()
        {
            VoltarMenuControles();
            panelTurnoInimigo.Visible = false;
        }



        // =========================
        // Inventário
        // =========================
        void AtualizarInventario()
        {
            flowInventario.Controls.Clear();

            foreach (var item in inventario)
            {
                Button btn = new Button();

                btn.Width = 80;
                btn.Height = 80;

                btn.Text = item.Nome;

                btn.Tag = item;

                btn.Click += Item_Click;

                flowInventario.Controls.Add(btn);
            }
        }

        void Item_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Item item = (Item)btn.Tag;

            MessageBox.Show($"{item.Nome}:\n\n{item.Descricao}");
        }

        void AdicionarItem(int id)
        {
            Item item = itemService.PegarItemPorID(id);

            if (item != null)
            {
                inventario.Add(item);

                AtualizarInventario();

                itemService.AplicarStatusItem(player, item);
            }
        }



        // =========================
        // Outros eventos
        // =========================
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

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

    }
}