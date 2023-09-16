using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{

    public class GameObject : IdentifiableObject
    {
        string _description, _name;

        public GameObject(string[] ids, string name, string desc) :base(ids)
        {
            _name = name;
            _description = desc;    
        }
        public string Name
        {
            get { return _name; }
        }

        public virtual string ShortDescription
        {
            get => "a" + _name + " " + FirstID;

        }
        public virtual  string FullDescription
        {
            get => _description;
        }
    }
}
