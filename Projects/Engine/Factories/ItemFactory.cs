using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Actions;
using Engine.Models;

namespace Engine.Factories
{
    public static class ItemFactory
    {
        private static readonly List<GameItem> _standardGameItems = new List<GameItem>();

        static ItemFactory()
        {
            BuildWeapon(1001, "Pointy Stick", 1, 1, 2);
            BuildWeapon(1002, "Metal Baseball Bat", 5, 3, 5);
            BuildWeapon(1003, "Pistol", 10, 5, 8);

            BuildMiscellaneousItem(9001, "Blunt", 1);
            BuildMiscellaneousItem(9002, "40oz", 2);
            BuildMiscellaneousItem(9003, "Gold Chain", 1);
            BuildMiscellaneousItem(9004, "Pair of Sneakers", 2);
            BuildMiscellaneousItem(9005, "Gold grill", 1);
            BuildMiscellaneousItem(9006, "Bandana", 2);
        }

        public static GameItem CreateGameItem(int itemTypeID)
        {
            return _standardGameItems.FirstOrDefault(item => item.ItemTypeID == itemTypeID)?.Clone();
        }

        private static void BuildMiscellaneousItem(int id, string name, int price)
        {
            _standardGameItems.Add(new GameItem(GameItem.ItemCategory.Miscellaneous, id, name, price));
        }

        private static void BuildWeapon(int id, string name, int price, int minimumDamage, int maximumDamage)
        {
            GameItem weapon = new GameItem(GameItem.ItemCategory.Weapon, id, name, price, true);
            weapon.Action = new AttackWithWeapon(weapon, minimumDamage, maximumDamage);
            _standardGameItems.Add(weapon);
        }
    }
}
