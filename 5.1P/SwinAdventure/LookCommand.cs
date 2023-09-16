using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand(): base(new string[] {"look" })
        {

        }

        public override string Excecute(Player p, string[] text)
        {
            if (text[0].ToLower() != "look")
                return "Error in look input.";

            if (text[1].ToLower() != "at")
                return "What do you want to look at?";

            if (text.Length == 5)
            {
                if (text[3] != "in")
                {
                    return "What do you want to look in?";
                }
            }

            IhaveInventory _container;

            switch (text.Length)
            {
                case 3:
                    _container = p as IhaveInventory;
                    break;

                case 5:
                    _container = FetchContainer(p, text[4]);
                    break;

                default:
                    _container = null;
                    break;
            }

            string _itemid = text[2];
            if (_container == null)
                return "I cannot find " + text[4] ;
            return LookAtIn(_itemid, _container);
        }

        private IhaveInventory FetchContainer(Player p, string containerId)
        {
            return p.Locate(containerId) as IhaveInventory;
        }

        private string LookAtIn(string thingId, IhaveInventory container)
        {
            if (container.Locate(thingId) != null)
                return container.Locate(thingId).FullDescription;

            return "I cannot find " + thingId ;
        }
    }
}



