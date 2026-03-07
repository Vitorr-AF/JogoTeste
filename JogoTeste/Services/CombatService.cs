using JogoTeste.Models;

namespace JogoTeste.Services
{
    public class CombatService
    {
        public static void DanoAoPlayer(Player player, int dano)
        {
            player.VidaAtual -= dano;
            if (player.VidaAtual < 0)
            {
                player.VidaAtual = 0;
            }
        }

        // inimigo recebido tem que ser o selecionado atualmente
        public static void DanoAoInimigo(Inimigo inimigo, int dano)
        {
            inimigo.VidaAtual -= dano;
            if (inimigo.VidaAtual <= 0)
            {
                inimigo.VidaAtual = 0;
                inimigo.Vivo = false;

            }
        }
    }
}