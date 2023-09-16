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
    public class TestLocation
    {
        Location l;
        Player p;

        [Test]
        public void TestPlayercanlocateLocation()
        {
            p = new Player("Dung", "Handsome Player");
            l = new Location(new string[] { "Classroom" }, "classroom", "A lovely classroom with friends");
            p.Location = l;

            bool actual = l.AreYou("Classroom");
            Assert.IsTrue(actual, "Test Location can define itself");
        }

        [Test] 
        public void TestPlayerHasLocation()
        {
            p = new Player("Danny", "Funny Player");
            l = new Location(new string[] { "Classroom" },"classroom", "A lovely classroom with friends");
            p.Location = l;
            GameObject expected = l;
            GameObject actual = p.Location.Locate("Classroom");

            Assert.That(actual, Is.EqualTo(expected), "Test of player can locate their location");
        }
        [Test]
        public void TestLocationidentifyItems()
        {
            l = new Location(new string[] { "Classroom" }, "classroom", "A lovely classroom with friends");
            Item i = new Item(new string[] { "sword" }, "steel", "A real-killer made of steel");
            l.Inventory.Put(i);

            GameObject expected = i;
            GameObject actual = l.Locate("sword");

            Assert.That(actual, Is.EqualTo(expected), "Test location can identify itself");
        }
    }
}
