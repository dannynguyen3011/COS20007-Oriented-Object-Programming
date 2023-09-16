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
        Location _location;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            
                return this;

            GameObject obj = _inventory.Fetch(id);
            if (obj != null)
            {
                return obj;
            }
            if (_location != null)
            {
                obj = _location.Locate(id);
                return obj;
            }
            else
            {
                return null;
            }
            
        }
        public override string FullDescription
        {
            get => "You are " + Name + " a real warrior";
        }
        public Inventory Inventory
        {
            get => _inventory;
        }
        public Location Location
        {
            get => _location;
            set => _location = value;
        }

    }
}
