using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinAdventure;
using NUnit.Framework;
using System.IO.Pipes;

namespace TestProject
{
    
    
    [TestFixture]
    public class TestLook
    {
        Command l;
        Player p;
        Bag b;

        Item stelsword = new Item(new string[] { "sword" }, "steel", "A real-killer made of steel");
        Item goldsword = new Item(new string[] { "sword" }, "gold", "A gold sword");
        Item Gem = new Item(new string[] { "gem" }, "kryptonite", "A green crystalline alien mineral.");

        [Test]
        public void TestLookAtMe()
        {
            p = new Player("MD", "The Player");
            l = new LookCommand();

            string expected = "You are MD a real warrior";
            string actual = l.Excecute(p, new string[] { "look", "at", "inventory" });

            Assert.That(actual, Is.EqualTo(expected), "TestLookCommand can look for 'inventory' and return player description");

        }
        [Test]
        public void TestLookAtGem()
        {
            p = new Player("MD", "The player");
            p.Inventory.Put(Gem);
            l = new LookCommand();

            string expected = "A green crystalline alien mineral.";
            string actual = l.Excecute(p, new string[] { "look", "at", "gem" });

            Assert.That (actual, Is.EqualTo(expected), "TestLook for gem in player inventory, should return gem description");
        }
        [Test]
        public void TestLookAtUnk()
        {
            p = new Player("MD", "The Player");
            l = new LookCommand();

            string expected = "I cannot find gem";
            string actual = l.Excecute(p, new string[] { "look", "at", "gem"});

            Assert.That(actual, Is.EqualTo(expected), "TestLook for non-exsit gem inventory");
        }
        [Test]
        public void TestLookAtGemInMe()
        {
            p = new Player("MD", "The player");
            l = new LookCommand();
            p.Inventory.Put(Gem);

            string expected = "A green crystalline alien mineral.";
            string actual = l.Excecute(p, new string[] {"look", "at", "gem", "in", "inventory"});
            
            Assert.That(actual, Is.EqualTo(expected), "TestLook for gem in me");
    
        }
        [Test]
        public void TestLookAtGemInBag() 
        {
            p = new Player("MD", "The player" );
            b = new Bag(new string[] { "medium", "plastic", "bag" }, "bag", "A medium cloth bag");
            l = new LookCommand();
            p.Inventory.Put(Gem);
            p.Inventory.Put(b);
            
            string expected = "I cannot find bag";
            string actual = l.Excecute(p, new string[] { "look", "at", "gem", "in", "bag" });

            Assert.That(actual, Is.EqualTo(expected), "TestLook for gem in 'look at gem in bag'");


        }
        [Test]
        public void TestLookAtGemNoBag()
        {
            p = new Player("MD", "The player");
            p.Inventory.Put(Gem);
            l = new LookCommand();

            string expected = "I cannot find bag";
            string actual = l.Excecute(p, (new string[] { "look", "at", "gem", "in", "bag" }));
            Assert.That (actual, Is.EqualTo(expected), "TestLook for no gem in bag");
        }
        [Test]
        public void TestLookatNoGeminBag()
        {
            p = new Player("MD", "The player");
            b = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag");
            l = new LookCommand();

            string expected = "I cannot find gem";
            string actual = l.Excecute(p, new string[] {"look", "at", "gem", "in", "inventory"});

            Assert.That(actual, Is.EqualTo(expected), "TestLook for no gem in bag");
        }
        [Test]
        public void InvalidLook()
        {
            l = new LookCommand();
            
            string expected = "Error in look input.";
            string actual = l.Excecute(p, new string[] { "stare", "at", "gem", "in", "inventory" });

            Assert.That(actual, Is.EqualTo(expected),"TestLook for invalid look command" );
        }
    }

}
