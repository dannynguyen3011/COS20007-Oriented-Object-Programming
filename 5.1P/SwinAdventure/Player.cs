using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Player : GameObject, IhaveInventory
    {
        Inventory _inventory;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;


            } return _inventory.Fetch(id);
        }
        public override string FullDescription
        {
            get => "You are " + Name + " a real warrior";
        }
        public Inventory Inventory
        {
            get => _inventory;
        }
    }
}
