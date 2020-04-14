using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

            static QuestFactory()
        {
            //Declared the items need to complete the quest, and its reward itmes
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(9001, 5));
            rewardItems.Add(new ItemQuantity(1003, 1));

            //Create the quest
            _quests.Add(new Quest(1,
                "Baby, cause I'm a thug",
                "Defeat the neighborhood gang",
                itemsToComplete,
                100, 50,
                rewardItems));

            //Create Second quest
            _quests.Add(new Quest(2,
                "It's About to go Down",
                "Defeat the hoodpark Gang",
                new List<ItemQuantity> { new ItemQuantity(9003, 5)},
                250, 100,
                new List <ItemQuantity> { new ItemQuantity(1003, 1)}));
        }

        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
