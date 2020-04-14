using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster streetGang = 
                        new Monster("Street Gang", "street_gang.jpg", 4, 4, 1, 2, 5, 1);

                    AddLootItem(streetGang, 1002, 25);
                    AddLootItem(streetGang, 9001, 50);
                    AddLootItem(streetGang, 9002, 80);

                    return streetGang;

                case 2:
                    Monster hoodGang = 
                        new Monster("Tyrone", "Tyrone_Biggums.jpg", 5, 5, 1, 2, 5, 1);

                    AddLootItem(hoodGang, 1002, 35);
                    AddLootItem(hoodGang, 9003, 50);
                    AddLootItem(hoodGang, 9004, 75);

                    return hoodGang;

                case 3:
                    Monster Tyrone =
                        new Monster("Hood Gang", "hoodpark_gang.jpg", 10, 10, 1, 4, 10, 3);

                    AddLootItem(Tyrone, 1002, 10);
                    AddLootItem(Tyrone, 9001, 15);
                    AddLootItem(Tyrone, 9003, 10);
                    AddLootItem(Tyrone, 9005, 45);
                    AddLootItem(Tyrone, 9006, 75);

                    return Tyrone;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }

        private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if(RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem (itemID));
            }
        }
    }
}
