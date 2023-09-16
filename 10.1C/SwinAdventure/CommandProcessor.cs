﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{ 
        public class CommandProcessor : Command
        {
            List<Command> _commands;

            public CommandProcessor() : base(new string[] { "command" })
            {
                _commands = new List<Command>();
                _commands.Add(new LookCommand());
                _commands.Add(new Move());
            }

            public override string Excecute(Player p, string[] text)
            {
                foreach (Command cmd in _commands)
                {
                    if (cmd.AreYou(text[0].ToLower()))
                    {
                        return cmd.Excecute(p, text);
                    }
                }
                return "Error in command input.";
            }
        }
    }


