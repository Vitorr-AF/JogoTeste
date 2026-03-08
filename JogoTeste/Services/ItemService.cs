using System.Text.Json;
using JogoTeste.Models;

namespace JogoTeste.Services
{
    public class ItemService
    {

        public Dictionary<int, List<Item>> ItensPorRaridade { get; private set; }

        private Dictionary<int, Item> itensPorID = new Dictionary<int, Item>();

        public void CarregarItens(string caminho)
        {
            string json = File.ReadAllText(caminho);

            ItensPorRaridade = JsonSerializer.Deserialize<Dictionary<int, List<Item>>>(json);

            itensPorID.Clear();

            foreach (var lista in ItensPorRaridade.Values)
            {
                foreach (var item in lista)
                {
                    itensPorID[item.ID] = item;
                }
            }
        }

        public Item PegarItemPorID(int id)
        {
            if (itensPorID.TryGetValue(id, out Item item))
                return item;

            return null;
        }

        public void AdicionarItemNoInventario(int id, List<Item> inventario)
        {
            Item item = PegarItemPorID(id);

            if (item != null)
                inventario.Add(item);
        }

        public void AplicarStatusItem(Player player, Item item)
        {
            if (item.Status == null) return;

            player.AcertoBonus += item.Status.AcertoBonus;
        }
    }
}