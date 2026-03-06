namespace JogoTeste.Models
{
    public class Inimigo
    {
        public string Nome { get; set; }
        public int VidaMax { get; set; }
        public int VidaAtual { get; set; }
        public int Dano { get; set; }
        public string CaminhoImagem { get; set; }
        public bool Vivo { get; set; }
    }
}