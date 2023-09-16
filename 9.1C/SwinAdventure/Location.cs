
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Location : GameObject, IhaveInventory
    {
        Inventory _inventory;
        List<Path> _paths;
        public Location(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }

        public Inventory Inventory { get { return _inventory; } }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return Inventory.Fetch(id);
            }
        }
        public void AddPath(Path path)
        {
            _paths.Add(path);
        }

        public Path LocatePath(string id)
        {
            foreach (Path p in _paths)
            {
                if (p.AreYou(id))
                {
                    return p;
                }
            }
            return null;
        }

        public override string FullDescription
        {
            get
            {
                return "You are standing at " + Name + ", " + base.FullDescription + ". At here, you can see:\n" + _inventory.ItemList;
            }
        }

    }
}
