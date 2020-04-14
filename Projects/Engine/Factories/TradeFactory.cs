using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class TraderFactory
    {
        private static readonly List<Trader> _traders = new List<Trader>();

        static TraderFactory()
        {
            Trader Kiana = new Trader("Kiana");
            Kiana.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader Josh = new Trader("Josh");
            Josh.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            Trader Joseph = new Trader("Joseph");
            Josh.AddItemToInventory(ItemFactory.CreateGameItem(1001));

            AddTraderToList(Kiana);
            AddTraderToList(Josh);
            AddTraderToList(Joseph);
        }

        public static Trader GetTraderByName(string name)
        {
            return _traders.FirstOrDefault(t => t.Name == name);
        }

        private static void AddTraderToList(Trader trader)
        {
            if(_traders.Any(t => t.Name == trader.Name))
            {
                throw new ArgumentException($"There is already a hustler named '{trader.Name}");
            }

            _traders.Add(trader);
        }
    }
}
