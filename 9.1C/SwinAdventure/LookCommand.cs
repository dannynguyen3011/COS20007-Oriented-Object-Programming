using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class LookCommand : Command
    {
        public LookCommand() : base(new string[] { "look" })
        {

        }

        public override string Excecute(Player p, string[] text)
        {
            IhaveInventory _container;
            string _itemid;
            string error = "Error in look input.";

            if (text[0].ToLower() != "look")
                return error;

            switch (text.Length)
            {
                case 3:
                    if (text[1].ToLower() != "at")
                        return "What do you want to look at?";
                    _container = p;
                    _itemid = text[2];
                    break;

                case 5:
                    _container = FetchContainer(p, text[4]);
                    if (_container == null)
                        return "I cannot find " + text[4] ;
                    _itemid = text[2];
                    break;

                default:
                    return error;
            }
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



