namespace JogoTeste.Models
{
    public class Player
    {
        public int VidaMax;
        public int VidaAtual
        {
            get { return VidaAtual; }
            set
            {
                int vidaMaxTotal = VidaMax + VidaBonus;

                if (value > vidaMaxTotal)
                    VidaAtual = vidaMaxTotal;
                else if (value < 0)
                    VidaAtual = 0;
                else
                    VidaAtual = value;
            }
        }
        public int EnergiaMax;
        public int EnergiaAtual
        {
            get { return EnergiaAtual; }
            set
            {
                int energiaMaxTotal = EnergiaMax + EnergiaBonus;

                if (value > energiaMaxTotal)
                    EnergiaAtual = energiaMaxTotal;
                else if (value < 0)
                    EnergiaAtual = 0;
                else
                    EnergiaAtual = value;
            }
        }
        public int DanoAtaque;
        public int TaxaAcerto;
        public int Velocidade;
        public int AcertoBonus = 0;
        public int VidaBonus = 0;
        public int DanoBonus = 0;
        public int EnergiaBonus = 0;
        public float RouboVida = 0;
    }
}