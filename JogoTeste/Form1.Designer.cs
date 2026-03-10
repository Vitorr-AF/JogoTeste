namespace JogoTeste
{
    partial class Form1
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
            panelMenu = new Panel();
            panelCentroMenu = new Panel();
            btnStartGame = new Button();
            btnExitGame = new Button();
            panelJogo1 = new Panel();
            panelCentroJogo1 = new Panel();
            panelEnemies = new Panel();
            panelItemsMenu = new Panel();
            labelTituloInventario = new Label();
            flowInventario = new FlowLayoutPanel();
            btnVoltar2 = new Button();
            panelSkillsMenu = new Panel();
            btnVoltar1 = new Button();
            panelControls = new Panel();
            panelTurnoInimigo = new Panel();
            labelTurnoInimigo = new Label();
            labelOndaNum = new Label();
            labelDebug = new Label();
            labelVidaInimigo = new Label();
            labelVida = new Label();
            labelEnergia = new Label();
            labelMensagens = new Label();
            labelNomeInimigo = new Label();
            panelPlayerImage = new Panel();
            panelFundoVidaInimigo = new Panel();
            panelFrenteVidaInimigo = new Panel();
            panelFundoEnergia = new Panel();
            panelFrenteEnergia = new Panel();
            panelFundoVida = new Panel();
            panelFrenteVida = new Panel();
            btnStatus = new Button();
            btnItems = new Button();
            btnSkills = new Button();
            btnAttack = new Button();
            panelStatusMenu = new Panel();
            labelAcertoBonus = new Label();
            labelDanoAtaque = new Label();
            labelTaxaAcerto = new Label();
            trackTaxaAcerto = new TrackBar();
            btnVoltar3 = new Button();
            panelMenu.SuspendLayout();
            panelCentroMenu.SuspendLayout();
            panelJogo1.SuspendLayout();
            panelCentroJogo1.SuspendLayout();
            panelItemsMenu.SuspendLayout();
            panelSkillsMenu.SuspendLayout();
            panelControls.SuspendLayout();
            panelTurnoInimigo.SuspendLayout();
            panelFundoVidaInimigo.SuspendLayout();
            panelFundoEnergia.SuspendLayout();
            panelFundoVida.SuspendLayout();
            panelStatusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackTaxaAcerto).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.Controls.Add(panelCentroMenu);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(800, 450);
            panelMenu.TabIndex = 0;
            // 
            // panelCentroMenu
            // 
            panelCentroMenu.Anchor = AnchorStyles.None;
            panelCentroMenu.Controls.Add(btnStartGame);
            panelCentroMenu.Controls.Add(btnExitGame);
            panelCentroMenu.Location = new Point(12, 12);
            panelCentroMenu.Name = "panelCentroMenu";
            panelCentroMenu.Size = new Size(776, 426);
            panelCentroMenu.TabIndex = 2;
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(348, 261);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(75, 23);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Jogar";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // btnExitGame
            // 
            btnExitGame.Location = new Point(348, 328);
            btnExitGame.Name = "btnExitGame";
            btnExitGame.Size = new Size(75, 23);
            btnExitGame.TabIndex = 1;
            btnExitGame.Text = "Sair";
            btnExitGame.UseVisualStyleBackColor = true;
            btnExitGame.Click += btnExitGame_Click;
            // 
            // panelJogo1
            // 
            panelJogo1.Controls.Add(panelCentroJogo1);
            panelJogo1.Dock = DockStyle.Fill;
            panelJogo1.Location = new Point(0, 0);
            panelJogo1.Name = "panelJogo1";
            panelJogo1.Size = new Size(800, 450);
            panelJogo1.TabIndex = 1;
            panelJogo1.Visible = false;
            // 
            // panelCentroJogo1
            // 
            panelCentroJogo1.Controls.Add(panelEnemies);
            panelCentroJogo1.Controls.Add(panelControls);
            panelCentroJogo1.Controls.Add(panelStatusMenu);
            panelCentroJogo1.Controls.Add(panelItemsMenu);
            panelCentroJogo1.Controls.Add(panelSkillsMenu);
            panelCentroJogo1.Location = new Point(0, 0);
            panelCentroJogo1.Name = "panelCentroJogo1";
            panelCentroJogo1.Size = new Size(800, 450);
            panelCentroJogo1.TabIndex = 2;
            // 
            // panelEnemies
            // 
            panelEnemies.Location = new Point(15, 15);
            panelEnemies.Name = "panelEnemies";
            panelEnemies.Size = new Size(770, 238);
            panelEnemies.TabIndex = 3;
            panelEnemies.Click += panelEnemies_Click;
            // 
            // panelItemsMenu
            // 
            panelItemsMenu.Controls.Add(labelTituloInventario);
            panelItemsMenu.Controls.Add(flowInventario);
            panelItemsMenu.Controls.Add(btnVoltar2);
            panelItemsMenu.Location = new Point(9, 259);
            panelItemsMenu.Name = "panelItemsMenu";
            panelItemsMenu.Size = new Size(773, 176);
            panelItemsMenu.TabIndex = 5;
            panelItemsMenu.Visible = false;
            // 
            // labelTituloInventario
            // 
            labelTituloInventario.AutoSize = true;
            labelTituloInventario.Location = new Point(9, 10);
            labelTituloInventario.Name = "labelTituloInventario";
            labelTituloInventario.Size = new Size(63, 15);
            labelTituloInventario.TabIndex = 2;
            labelTituloInventario.Text = "Inventário:";
            // 
            // flowInventario
            // 
            flowInventario.AutoScroll = true;
            flowInventario.Location = new Point(3, 31);
            flowInventario.Name = "flowInventario";
            flowInventario.Size = new Size(358, 142);
            flowInventario.TabIndex = 1;
            // 
            // btnVoltar2
            // 
            btnVoltar2.Location = new Point(698, 153);
            btnVoltar2.Name = "btnVoltar2";
            btnVoltar2.Size = new Size(75, 23);
            btnVoltar2.TabIndex = 0;
            btnVoltar2.Text = "Voltar";
            btnVoltar2.UseVisualStyleBackColor = true;
            btnVoltar2.Click += btnVoltar2_Click;
            // 
            // panelSkillsMenu
            // 
            panelSkillsMenu.Controls.Add(btnVoltar1);
            panelSkillsMenu.Location = new Point(12, 259);
            panelSkillsMenu.Name = "panelSkillsMenu";
            panelSkillsMenu.Size = new Size(773, 176);
            panelSkillsMenu.TabIndex = 4;
            panelSkillsMenu.Visible = false;
            // 
            // btnVoltar1
            // 
            btnVoltar1.Location = new Point(698, 153);
            btnVoltar1.Name = "btnVoltar1";
            btnVoltar1.Size = new Size(75, 23);
            btnVoltar1.TabIndex = 0;
            btnVoltar1.Text = "Voltar";
            btnVoltar1.UseVisualStyleBackColor = true;
            btnVoltar1.Click += btnVoltar1_Click;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(panelTurnoInimigo);
            panelControls.Controls.Add(labelOndaNum);
            panelControls.Controls.Add(labelDebug);
            panelControls.Controls.Add(labelVidaInimigo);
            panelControls.Controls.Add(labelVida);
            panelControls.Controls.Add(labelEnergia);
            panelControls.Controls.Add(labelMensagens);
            panelControls.Controls.Add(labelNomeInimigo);
            panelControls.Controls.Add(panelPlayerImage);
            panelControls.Controls.Add(panelFundoVidaInimigo);
            panelControls.Controls.Add(panelFundoEnergia);
            panelControls.Controls.Add(panelFundoVida);
            panelControls.Controls.Add(btnStatus);
            panelControls.Controls.Add(btnItems);
            panelControls.Controls.Add(btnSkills);
            panelControls.Controls.Add(btnAttack);
            panelControls.Location = new Point(12, 259);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(773, 188);
            panelControls.TabIndex = 2;
            // 
            // panelTurnoInimigo
            // 
            panelTurnoInimigo.Controls.Add(labelTurnoInimigo);
            panelTurnoInimigo.Location = new Point(209, 10);
            panelTurnoInimigo.Name = "panelTurnoInimigo";
            panelTurnoInimigo.Size = new Size(561, 154);
            panelTurnoInimigo.TabIndex = 12;
            panelTurnoInimigo.Visible = false;
            // 
            // labelTurnoInimigo
            // 
            labelTurnoInimigo.AutoSize = true;
            labelTurnoInimigo.Location = new Point(291, 79);
            labelTurnoInimigo.Name = "labelTurnoInimigo";
            labelTurnoInimigo.Size = new Size(0, 15);
            labelTurnoInimigo.TabIndex = 0;
            // 
            // labelOndaNum
            // 
            labelOndaNum.AutoSize = true;
            labelOndaNum.Location = new Point(693, 167);
            labelOndaNum.Name = "labelOndaNum";
            labelOndaNum.Size = new Size(45, 15);
            labelOndaNum.TabIndex = 11;
            labelOndaNum.Text = "Onda 1";
            // 
            // labelDebug
            // 
            labelDebug.AutoSize = true;
            labelDebug.Location = new Point(390, 89);
            labelDebug.Name = "labelDebug";
            labelDebug.Size = new Size(69, 15);
            labelDebug.TabIndex = 0;
            labelDebug.Text = "label debug";
            labelDebug.Visible = false;
            // 
            // labelVidaInimigo
            // 
            labelVidaInimigo.AutoSize = true;
            labelVidaInimigo.BackColor = Color.Red;
            labelVidaInimigo.ForeColor = Color.White;
            labelVidaInimigo.Location = new Point(568, 155);
            labelVidaInimigo.Name = "labelVidaInimigo";
            labelVidaInimigo.Size = new Size(0, 15);
            labelVidaInimigo.TabIndex = 8;
            labelVidaInimigo.Visible = false;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.BackColor = Color.Lime;
            labelVida.ForeColor = Color.White;
            labelVida.Location = new Point(22, 25);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(0, 15);
            labelVida.TabIndex = 8;
            labelVida.Visible = false;
            // 
            // labelEnergia
            // 
            labelEnergia.AutoSize = true;
            labelEnergia.BackColor = Color.DodgerBlue;
            labelEnergia.ForeColor = Color.White;
            labelEnergia.Location = new Point(22, 170);
            labelEnergia.Name = "labelEnergia";
            labelEnergia.Size = new Size(0, 15);
            labelEnergia.TabIndex = 8;
            labelEnergia.Visible = false;
            // 
            // labelMensagens
            // 
            labelMensagens.AutoSize = true;
            labelMensagens.Location = new Point(244, 142);
            labelMensagens.Name = "labelMensagens";
            labelMensagens.Size = new Size(0, 15);
            labelMensagens.TabIndex = 9;
            // 
            // labelNomeInimigo
            // 
            labelNomeInimigo.AutoSize = true;
            labelNomeInimigo.Location = new Point(567, 115);
            labelNomeInimigo.Name = "labelNomeInimigo";
            labelNomeInimigo.Size = new Size(0, 15);
            labelNomeInimigo.TabIndex = 8;
            labelNomeInimigo.Visible = false;
            // 
            // panelPlayerImage
            // 
            panelPlayerImage.Location = new Point(22, 25);
            panelPlayerImage.Name = "panelPlayerImage";
            panelPlayerImage.Size = new Size(181, 160);
            panelPlayerImage.TabIndex = 10;
            // 
            // panelFundoVidaInimigo
            // 
            panelFundoVidaInimigo.BackColor = Color.DimGray;
            panelFundoVidaInimigo.Controls.Add(panelFrenteVidaInimigo);
            panelFundoVidaInimigo.Location = new Point(568, 131);
            panelFundoVidaInimigo.Name = "panelFundoVidaInimigo";
            panelFundoVidaInimigo.Size = new Size(200, 26);
            panelFundoVidaInimigo.TabIndex = 7;
            panelFundoVidaInimigo.Visible = false;
            panelFundoVidaInimigo.MouseEnter += panelFundoVidaInimigo_MouseEnter;
            panelFundoVidaInimigo.MouseLeave += panelFundoVidaInimigo_MouseLeave;
            // 
            // panelFrenteVidaInimigo
            // 
            panelFrenteVidaInimigo.BackColor = Color.Red;
            panelFrenteVidaInimigo.Location = new Point(0, 0);
            panelFrenteVidaInimigo.Name = "panelFrenteVidaInimigo";
            panelFrenteVidaInimigo.Size = new Size(200, 26);
            panelFrenteVidaInimigo.TabIndex = 6;
            panelFrenteVidaInimigo.MouseEnter += panelFrenteVidaInimigo_MouseEnter;
            panelFrenteVidaInimigo.MouseLeave += panelFrenteVidaInimigo_MouseLeave;
            // 
            // panelFundoEnergia
            // 
            panelFundoEnergia.BackColor = Color.DimGray;
            panelFundoEnergia.Controls.Add(panelFrenteEnergia);
            panelFundoEnergia.Location = new Point(3, 25);
            panelFundoEnergia.Name = "panelFundoEnergia";
            panelFundoEnergia.Size = new Size(19, 160);
            panelFundoEnergia.TabIndex = 7;
            panelFundoEnergia.MouseEnter += panelFundoEnergia_MouseEnter;
            panelFundoEnergia.MouseLeave += panelFundoEnergia_MouseLeave;
            // 
            // panelFrenteEnergia
            // 
            panelFrenteEnergia.BackColor = Color.DodgerBlue;
            panelFrenteEnergia.Location = new Point(0, 0);
            panelFrenteEnergia.Name = "panelFrenteEnergia";
            panelFrenteEnergia.Size = new Size(19, 163);
            panelFrenteEnergia.TabIndex = 6;
            panelFrenteEnergia.MouseEnter += panelFrenteEnergia_MouseEnter;
            panelFrenteEnergia.MouseLeave += panelFrenteEnergia_MouseLeave;
            // 
            // panelFundoVida
            // 
            panelFundoVida.BackColor = Color.DimGray;
            panelFundoVida.Controls.Add(panelFrenteVida);
            panelFundoVida.Location = new Point(3, 10);
            panelFundoVida.Name = "panelFundoVida";
            panelFundoVida.Size = new Size(200, 15);
            panelFundoVida.TabIndex = 5;
            panelFundoVida.MouseEnter += panelFundoVida_MouseEnter;
            panelFundoVida.MouseLeave += panelFundoVida_MouseLeave;
            // 
            // panelFrenteVida
            // 
            panelFrenteVida.BackColor = Color.Lime;
            panelFrenteVida.Location = new Point(0, 0);
            panelFrenteVida.Name = "panelFrenteVida";
            panelFrenteVida.Size = new Size(200, 15);
            panelFrenteVida.TabIndex = 6;
            panelFrenteVida.MouseEnter += panelFrenteVida_MouseEnter;
            panelFrenteVida.MouseLeave += panelFrenteVida_MouseLeave;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(637, 14);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(125, 61);
            btnStatus.TabIndex = 4;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(506, 14);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(125, 61);
            btnItems.TabIndex = 3;
            btnItems.Text = "Itens";
            btnItems.UseVisualStyleBackColor = true;
            btnItems.Click += btnItems_Click;
            // 
            // btnSkills
            // 
            btnSkills.Location = new Point(375, 14);
            btnSkills.Name = "btnSkills";
            btnSkills.Size = new Size(125, 61);
            btnSkills.TabIndex = 2;
            btnSkills.Text = "Habilidades";
            btnSkills.UseVisualStyleBackColor = true;
            btnSkills.Click += btnSkills_Click;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(244, 14);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(125, 61);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Atacar";
            btnAttack.UseVisualStyleBackColor = true;
            btnAttack.Click += btnAttack_Click;
            // 
            // panelStatusMenu
            // 
            panelStatusMenu.Controls.Add(labelAcertoBonus);
            panelStatusMenu.Controls.Add(labelDanoAtaque);
            panelStatusMenu.Controls.Add(labelTaxaAcerto);
            panelStatusMenu.Controls.Add(trackTaxaAcerto);
            panelStatusMenu.Controls.Add(btnVoltar3);
            panelStatusMenu.Location = new Point(7, 262);
            panelStatusMenu.Name = "panelStatusMenu";
            panelStatusMenu.Size = new Size(773, 176);
            panelStatusMenu.TabIndex = 6;
            panelStatusMenu.Visible = false;
            // 
            // labelAcertoBonus
            // 
            labelAcertoBonus.AutoSize = true;
            labelAcertoBonus.Location = new Point(164, 110);
            labelAcertoBonus.Name = "labelAcertoBonus";
            labelAcertoBonus.Size = new Size(34, 15);
            labelAcertoBonus.TabIndex = 4;
            labelAcertoBonus.Text = "+ 0%";
            // 
            // labelDanoAtaque
            // 
            labelDanoAtaque.AutoSize = true;
            labelDanoAtaque.Location = new Point(31, 86);
            labelDanoAtaque.Name = "labelDanoAtaque";
            labelDanoAtaque.Size = new Size(120, 15);
            labelDanoAtaque.TabIndex = 3;
            labelDanoAtaque.Text = "20 de dano de ataque";
            // 
            // labelTaxaAcerto
            // 
            labelTaxaAcerto.AutoSize = true;
            labelTaxaAcerto.Location = new Point(31, 110);
            labelTaxaAcerto.Name = "labelTaxaAcerto";
            labelTaxaAcerto.Size = new Size(127, 15);
            labelTaxaAcerto.TabIndex = 2;
            labelTaxaAcerto.Text = "100% de taxa de acerto";
            // 
            // trackTaxaAcerto
            // 
            trackTaxaAcerto.Location = new Point(31, 128);
            trackTaxaAcerto.Maximum = 100;
            trackTaxaAcerto.Name = "trackTaxaAcerto";
            trackTaxaAcerto.Size = new Size(205, 45);
            trackTaxaAcerto.TabIndex = 1;
            trackTaxaAcerto.Value = 100;
            trackTaxaAcerto.Scroll += trackTaxaAcerto_Scroll;
            // 
            // btnVoltar3
            // 
            btnVoltar3.Location = new Point(698, 153);
            btnVoltar3.Name = "btnVoltar3";
            btnVoltar3.Size = new Size(75, 23);
            btnVoltar3.TabIndex = 0;
            btnVoltar3.Text = "Voltar";
            btnVoltar3.UseVisualStyleBackColor = true;
            btnVoltar3.Click += btnVoltar3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelJogo1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Resize += Form1_Resize;
            panelMenu.ResumeLayout(false);
            panelCentroMenu.ResumeLayout(false);
            panelJogo1.ResumeLayout(false);
            panelCentroJogo1.ResumeLayout(false);
            panelItemsMenu.ResumeLayout(false);
            panelItemsMenu.PerformLayout();
            panelSkillsMenu.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            panelTurnoInimigo.ResumeLayout(false);
            panelTurnoInimigo.PerformLayout();
            panelFundoVidaInimigo.ResumeLayout(false);
            panelFundoEnergia.ResumeLayout(false);
            panelFundoVida.ResumeLayout(false);
            panelStatusMenu.ResumeLayout(false);
            panelStatusMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackTaxaAcerto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnExitGame;
        private Button btnStartGame;
        private Panel panelJogo1;
        private Panel panelCentroMenu;
        private Panel panelCentroJogo1;
        private Panel panelEnemies;
        private Panel panelControls;
        private Button btnStatus;
        private Button btnItems;
        private Button btnSkills;
        private Button btnAttack;
        private Panel panelFundoEnergia;
        private Panel panelFrenteEnergia;
        private Panel panelFundoVida;
        private Panel panelFrenteVida;
        private Label labelVida;
        private Label labelEnergia;
        private Panel panelSkillsMenu;
        private Button btnVoltar1;
        private Panel panelItemsMenu;
        private Button btnVoltar2;
        private Panel panelStatusMenu;
        private Button btnVoltar3;
        private Panel panelFundoVidaInimigo;
        private Panel panelFrenteVidaInimigo;
        private Label labelVidaInimigo;
        private Label labelNomeInimigo;
        private Label labelMensagens;
        private TrackBar trackTaxaAcerto;
        private Label labelTaxaAcerto;
        private Label labelDanoAtaque;
        private Panel panelPlayerImage;
        private Label labelDebug;
        private Label labelOndaNum;
        private Panel panelTurnoInimigo;
        private Label labelTurnoInimigo;
        private Label labelAcertoBonus;
        private FlowLayoutPanel flowInventario;
        private Label labelTituloInventario;
    }
}
