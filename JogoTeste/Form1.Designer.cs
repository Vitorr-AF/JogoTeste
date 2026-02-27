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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelMenu = new Panel();
            panelCentroMenu = new Panel();
            btnStartGame = new Button();
            btnExitGame = new Button();
            panelJogo1 = new Panel();
            panelCentroJogo1 = new Panel();
            panelEnemies = new Panel();
            pictureEnemy = new PictureBox();
            panelControls = new Panel();
            panelFundoEnergia = new Panel();
            panelFrenteEnergia = new Panel();
            labelEnergia = new Label();
            panelFundoVida = new Panel();
            panelFrenteVida = new Panel();
            labelVida = new Label();
            btnStatus = new Button();
            btnItems = new Button();
            btnSkills = new Button();
            btnAttack = new Button();
            panelSkillsMenu = new Panel();
            panelMenu.SuspendLayout();
            panelCentroMenu.SuspendLayout();
            panelJogo1.SuspendLayout();
            panelCentroJogo1.SuspendLayout();
            panelEnemies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).BeginInit();
            panelControls.SuspendLayout();
            panelFundoEnergia.SuspendLayout();
            panelFrenteEnergia.SuspendLayout();
            panelFundoVida.SuspendLayout();
            panelFrenteVida.SuspendLayout();
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
            panelCentroJogo1.Controls.Add(panelSkillsMenu);
            panelCentroJogo1.Location = new Point(0, 0);
            panelCentroJogo1.Name = "panelCentroJogo1";
            panelCentroJogo1.Size = new Size(800, 450);
            panelCentroJogo1.TabIndex = 2;
            // 
            // panelEnemies
            // 
            panelEnemies.Controls.Add(pictureEnemy);
            panelEnemies.Location = new Point(15, 15);
            panelEnemies.Name = "panelEnemies";
            panelEnemies.Size = new Size(770, 238);
            panelEnemies.TabIndex = 3;
            // 
            // pictureEnemy
            // 
            pictureEnemy.Image = (Image)resources.GetObject("pictureEnemy.Image");
            pictureEnemy.Location = new Point(325, 3);
            pictureEnemy.Name = "pictureEnemy";
            pictureEnemy.Size = new Size(123, 145);
            pictureEnemy.SizeMode = PictureBoxSizeMode.Zoom;
            pictureEnemy.TabIndex = 1;
            pictureEnemy.TabStop = false;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(panelFundoEnergia);
            panelControls.Controls.Add(panelFundoVida);
            panelControls.Controls.Add(btnStatus);
            panelControls.Controls.Add(btnItems);
            panelControls.Controls.Add(btnSkills);
            panelControls.Controls.Add(btnAttack);
            panelControls.Location = new Point(12, 259);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(773, 176);
            panelControls.TabIndex = 2;
            // 
            // panelFundoEnergia
            // 
            panelFundoEnergia.BackColor = Color.DimGray;
            panelFundoEnergia.Controls.Add(panelFrenteEnergia);
            panelFundoEnergia.Location = new Point(570, 150);
            panelFundoEnergia.Name = "panelFundoEnergia";
            panelFundoEnergia.Size = new Size(200, 26);
            panelFundoEnergia.TabIndex = 7;
            // 
            // panelFrenteEnergia
            // 
            panelFrenteEnergia.BackColor = Color.DodgerBlue;
            panelFrenteEnergia.Controls.Add(labelEnergia);
            panelFrenteEnergia.Location = new Point(0, 0);
            panelFrenteEnergia.Name = "panelFrenteEnergia";
            panelFrenteEnergia.Size = new Size(200, 26);
            panelFrenteEnergia.TabIndex = 6;
            panelFrenteEnergia.MouseEnter += panelFrenteEnergia_MouseEnter;
            panelFrenteEnergia.MouseLeave += panelFrenteEnergia_MouseLeave;
            // 
            // labelEnergia
            // 
            labelEnergia.AutoSize = true;
            labelEnergia.Location = new Point(80, 4);
            labelEnergia.Name = "labelEnergia";
            labelEnergia.Size = new Size(0, 15);
            labelEnergia.TabIndex = 8;
            labelEnergia.Visible = false;
            // 
            // panelFundoVida
            // 
            panelFundoVida.BackColor = Color.DimGray;
            panelFundoVida.Controls.Add(panelFrenteVida);
            panelFundoVida.Location = new Point(3, 147);
            panelFundoVida.Name = "panelFundoVida";
            panelFundoVida.Size = new Size(200, 26);
            panelFundoVida.TabIndex = 5;
            // 
            // panelFrenteVida
            // 
            panelFrenteVida.BackColor = Color.Lime;
            panelFrenteVida.Controls.Add(labelVida);
            panelFrenteVida.Location = new Point(0, 0);
            panelFrenteVida.Name = "panelFrenteVida";
            panelFrenteVida.Size = new Size(200, 26);
            panelFrenteVida.TabIndex = 6;
            panelFrenteVida.MouseEnter += panelFrenteVida_MouseEnter;
            panelFrenteVida.MouseLeave += panelFrenteVida_MouseLeave;
            // 
            // labelVida
            // 
            labelVida.AutoSize = true;
            labelVida.Location = new Point(80, 4);
            labelVida.Name = "labelVida";
            labelVida.Size = new Size(0, 15);
            labelVida.TabIndex = 8;
            labelVida.Visible = false;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(516, 53);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(125, 61);
            btnStatus.TabIndex = 4;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(385, 53);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(125, 61);
            btnItems.TabIndex = 3;
            btnItems.Text = "Itens";
            btnItems.UseVisualStyleBackColor = true;
            // 
            // btnSkills
            // 
            btnSkills.Location = new Point(254, 53);
            btnSkills.Name = "btnSkills";
            btnSkills.Size = new Size(125, 61);
            btnSkills.TabIndex = 2;
            btnSkills.Text = "Habilidades";
            btnSkills.UseVisualStyleBackColor = true;
            // 
            // btnAttack
            // 
            btnAttack.Location = new Point(123, 53);
            btnAttack.Name = "btnAttack";
            btnAttack.Size = new Size(125, 61);
            btnAttack.TabIndex = 1;
            btnAttack.Text = "Atacar";
            btnAttack.UseVisualStyleBackColor = true;
            // 
            // panelSkillsMenu
            // 
            panelSkillsMenu.Location = new Point(12, 259);
            panelSkillsMenu.Name = "panelSkillsMenu";
            panelSkillsMenu.Size = new Size(773, 176);
            panelSkillsMenu.TabIndex = 4;
            panelSkillsMenu.Visible = false;
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
            panelEnemies.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureEnemy).EndInit();
            panelControls.ResumeLayout(false);
            panelFundoEnergia.ResumeLayout(false);
            panelFrenteEnergia.ResumeLayout(false);
            panelFrenteEnergia.PerformLayout();
            panelFundoVida.ResumeLayout(false);
            panelFrenteVida.ResumeLayout(false);
            panelFrenteVida.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnExitGame;
        private Button btnStartGame;
        private Panel panelJogo1;
        private PictureBox pictureEnemy;
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
    }
}
