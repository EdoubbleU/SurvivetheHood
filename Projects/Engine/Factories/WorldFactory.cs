using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(-2, -1, "Crack Room", "The room of a crackhead", "crackheadroom.jpg");

            newWorld.LocationAt(-2, -1).AddMonster(2, 100);

            newWorld.AddLocation(-1, -1, "Crack House", "Runned down building.", "crackhouse.jpg");
            newWorld.LocationAt(-1, -1).TraderHere = TraderFactory.GetTraderByName("Bang on 'em Josh");
            
            newWorld.AddLocation(0, -1, "Home", "This is your crib", "Home.png");

            newWorld.AddLocation(-1, 0, "Gun Store", "Welcome to TayTay Gun Store", "gunstore.jpeg");
            newWorld.LocationAt(-1, 0).TraderHere = TraderFactory.GetTraderByName("Kiana");

            newWorld.AddLocation(0, 0, "Police Station", "The Boys in Blue", "policestation.jpg");

            newWorld.AddLocation(1, 0, "Parking Lot", "You kicking cans", "dirtyparkinglot.jpg");
            newWorld.LocationAt(1, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(2));

            newWorld.AddLocation(2, 0, "Hood Park", "Welcome to Hood!", "hoodpark.jpg");

            newWorld.LocationAt(2, 0).AddMonster(3, 100);

            newWorld.AddLocation(0, 1, "Liquor Store", "Say whats up to Farook behind the glass", "Liquorstore.jpg");
            newWorld.LocationAt(0, 1).TraderHere = TraderFactory.GetTraderByName("Joseph");

            newWorld.LocationAt(0, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(0, 2, "The Streets", "Your at end of the hood, the gate is locked", "hoodstreet.jpg");

            newWorld.LocationAt(0, 2).AddMonster(1, 100);
            
            return newWorld;
        }
    }
}
