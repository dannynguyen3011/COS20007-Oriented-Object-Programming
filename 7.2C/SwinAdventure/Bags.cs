using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Bag : Item
    {
        Inventory _inventory;

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;

            }
            return _inventory.Fetch(id);    
        }
        public string FullDescription
        {
            get => "A bag with a big swoosh on top";
        }

        public Inventory Inventory
        { get => _inventory; }
    }
}
