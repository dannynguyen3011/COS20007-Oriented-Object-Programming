using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwinAdventure;

namespace TestProject
{
    [TestFixture]
    class TestPlayer
    {
        Item stelsword = new Item(new string[] { "sword" }, "steel", "A real-killer made of steel");

        [Test]
        public void TestPlayerIsIdentifiable()
        {
            Player p = new Player("MD", "The Player");
            bool actual = p.AreYou("me");
            Assert.IsTrue(actual);

            actual = p.AreYou("inventory");
            Assert.IsTrue(actual);
        }
        [Test]
        public void TestPlayerLocateItems() 
        {
            Player p = new Player("MD", "The Player");
            p.Inventory.Put(stelsword);

            GameObject expected = stelsword;
            GameObject actual = p.Locate(stelsword.FirstID);

            Assert.That(actual, Is.EqualTo(expected), "Test Player can locate item");

        }
        [Test]
        public void TestPlayerLocateItself()
        {
            Player p = new Player("MD", "The Player");
            
            GameObject expected = p;
            GameObject actual = p.Locate("me");

            Assert.That(actual, Is.EqualTo(expected), "Test Player Locate to see if they can locate themselves");

        }
        [Test]
        public void TestPlayerLocateNothing() 
        {
            Player p = new Player("MD", "The Player");
            GameObject expected = null;
            GameObject actual = p.Locate(stelsword.FirstID);

            Assert.That(actual, Is.EqualTo(expected), "Test Player can return Null if they can locate anything" );

        }
        [Test]
        public void TestPlayerFullDescription()
        {
            Player p = new Player("MD", "The Player");

            string expected = "You are MD a real warrior";
            string actual = p.FullDescription; 

            Assert.That(actual, Is.EqualTo(expected), "Test Player has correct description");
        }

        
    }
    
    
}
