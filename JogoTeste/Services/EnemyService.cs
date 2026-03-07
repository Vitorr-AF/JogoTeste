using JogoTeste.Models;
using System.Text.Json;

namespace JogoTeste.Services
{
    public class EnemyService
    {
        public static Dictionary<int, List<Inimigo>> CarregarInimigos()
        {
            string json = File.ReadAllText("inimigos.json");


            return JsonSerializer.Deserialize<Dictionary<int, List<Inimigo>>>(json);
        }

        public static void GerarInimigos(
            int dificuldade,
            Random random,
            Dictionary<int, List<Inimigo>> inimigosPorNivel,
            List<Inimigo> inimigos)
        {
            int quantidadeInimigos = random.Next(1, dificuldade + 2);

            var banco = inimigosPorNivel[dificuldade];

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
        }

        public static int CalcularDificuldade(int ondaAtual)
        {
            int dificuldade = (ondaAtual / 5) + 1;

            if (dificuldade > 5)
            {
                dificuldade = 5;
            }

            return dificuldade;
        }
    }
}