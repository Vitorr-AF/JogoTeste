using JogoTeste.Models;

namespace JogoTeste.Services
{
    public class TurnService
    {
        public static List<object> GerarOrdemTurnos(Player player, List<Inimigo> inimigos)
        {
            List<object> turnos = new List<object>();

            turnos.Add(player);

            foreach (var inimigo in inimigos)
            {
                if (inimigo.Vivo)
                    turnos.Add(inimigo);
            }

            return turnos
                .OrderByDescending(x =>
                {
                    if (x is Player p) return p.Velocidade;
                    if (x is Inimigo i) return i.Velocidade;
                    return 0;
                })
                .ToList();
        }
    }
}