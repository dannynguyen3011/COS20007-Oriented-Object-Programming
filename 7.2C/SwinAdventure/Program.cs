using SwinAdventure;
using System;


namespace SwinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _input;
            Console.WriteLine("Welcome to SwinAdventure!\nYou have arrive in the main entrance");
            Console.WriteLine("What's your name");
            string name = Console.ReadLine();
            Console.WriteLine("Describe yourself:");
            string description = Console.ReadLine();
            Console.WriteLine("Welcome" + name + "," + description + " Lets get into the game");

            Player player = new Player(name, description);
            Bag bag = new Bag(new string[] { "medium", "plastic", "bag" }, "bag", "A medium plastic bag");
            Item Gem = new Item(new string[] { "gem" }, "gem", "A green crystalline alien mineral.");
            Item Sword = new Item(new string[] { "sword" }, "sword", "A sword that can be use for kill enemies.");
            Item Sheild = new Item(new string[] { "sheild" }, "sheil", "A sheild used for protect yourself");

            player.Inventory.Put(Sword);
            player.Inventory.Put(Sheild);
            bag.Inventory.Put(Gem);
            player.Inventory.Put(bag);

            Command l = new LookCommand();

            while (true)
            {
                Console.WriteLine("Command -> ");
                _input = Console.ReadLine();
                if (_input.ToLower() != "quit")
                {
                    Console.WriteLine(l.Excecute(player, _input.Split()));
                }
                else
                {
                    Console.WriteLine("Quitting the game...");
                    break;
                }
            }
        }
    }
}
