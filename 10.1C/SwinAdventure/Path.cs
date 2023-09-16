using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Path : GameObject
    {
        

        Location _source, _destination;
        public Path(string[] idents, string name, string desc, Location source, Location destination) : base(idents, name, desc)
        {
            _source = source;
            _destination = destination;

        }

        public Location Destination
        {
            get { return _destination; }
        }

        public override string ShortDescription
        {
            get { return Name; }
        }

        public void MovePlayer(Player p)
        {
            p.Location = Destination; 
        }

       
    }
}
