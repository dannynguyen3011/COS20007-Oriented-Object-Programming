using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    public class Move : Command
    {
        public Move() : base(new string[] { "move" })
        {

        }
        public override string Excecute(Player p, string[] text)
        {
            string error = "Error in input";
            string _moveDirection;

            switch (text.Length)
            {
                case 1:
                    return "Move where?";

                case 2:
                    _moveDirection = text[1].ToLower();
                    break;

                case 3:
                    _moveDirection = text[2].ToLower();
                    break;

                default:
                    return error;
            }

            Path _path = p.Location.LocatePath(_moveDirection);
            if (_path != null)
            {
                
                _path.MovePlayer(p);
                return "You have moved " + _path.FirstID + " through a " + _path.Name + " to the " + p.Location.Name + ".\r\n\n" + p.Location.FullDescription;
            }
            else
            {
                return error;
            }
        }

        }
    }
