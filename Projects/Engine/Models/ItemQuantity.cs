using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemID { get; }
        public int Quantity { get; }
        public int Weapon { get; }

        public ItemQuantity(int itemID, int quantity, int weapon)
        {
            ItemID = itemID;
            Quantity = quantity;
            Weapon = weapon;
        }
    }
}
