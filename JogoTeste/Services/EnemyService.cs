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
    }
}