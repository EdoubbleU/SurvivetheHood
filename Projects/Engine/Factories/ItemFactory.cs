using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            _standardGameItems.Add(new Weapon(1001, "Pointy Stick", 1, 1, 2));
            _standardGameItems.Add(new Weapon(1002, "Metal Baseball Bat", 5, 3, 3));
            _standardGameItems.Add(new Weapon(1003, "Pistol", 10, 5, 5));
            _standardGameItems.Add(new GameItem(9001, "Blunt", 1));
            _standardGameItems.Add(new GameItem(9002, "40oz", 2));
            _standardGameItems.Add(new GameItem(9003, "Gold Chain", 1));
            _standardGameItems.Add(new GameItem(9004, "Pair of Sneakers", 2));
            _standardGameItems.Add(new GameItem(9005, "Gold grill", 1));
            _standardGameItems.Add(new GameItem(9006, "Bandana", 2));
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            GameItem standardItem = _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if(standardItem != null)
            {
                if(standardItem is Weapon)
                {
                    return (standardItem as Weapon).Clone();
                }

                return standardItem.Clone();
            }

            return null;
        }
    }
}
