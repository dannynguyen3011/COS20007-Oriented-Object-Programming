using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinAdventure;

namespace TestProject
{
    public class TestBag
    {
        Bag b;
        Item stelsword = new Item(new string[] { "sword" }, "steel", "A real-killer made of steel");
        Item goldsword = new Item( new string[] { "sword" }, "gold", "A gold sword");

        [Test]
        public void TestBagLocateItems()
        {
            b = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag" );
            b.Inventory.Put(stelsword);

            GameObject actual = b.Locate(stelsword.FirstID);
            GameObject expected = stelsword;
            Assert.That(actual, Is.EqualTo(expected), "Test if a bag can locate item, stels sword item");

        }

        [Test]
        public void TestBagLocateItself()
        {
            b = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag");

            GameObject actual = b;
            GameObject expected = b.Locate("bag");

            Assert.That(actual, Is.EqualTo(expected), "Test if bag can locate itself");
        }
        [Test]
        public void TestBagLocateNothing()
        {
            b = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag");

            GameObject actual = null;
            GameObject expected = b.Locate("nothing");

            Assert.That(actual, Is.EqualTo(expected), "Test if bag can not locate anything");
        }
        [Test]
        public void TestBagFullDescription()
        {
            b = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag");

            string actual = b.FullDescription;
            string expected = "A bag with a big swoosh on top";

            Assert.That(actual, Is.EqualTo(expected), "Test bag FullDescription");
        }

        [Test]
        public void TestBaginBag() { 
            Bag b1 = new Bag(new string[] { "medium", "rubbon", "bag" }, "bag", "A medium rubbon bag");
            Bag b2 = new Bag(new string[] { "small", "cotton", "bag" }, "bag", "A small cotton bag");

            b1.Inventory.Put(b2);
            b2.Inventory.Put(goldsword);

            GameObject actual = b1.Locate(goldsword.FirstID);
            GameObject expected = goldsword;

            Assert.That(actual, Is.Not.EqualTo(expected), "Test bag in Bag, that parent cannot locate things inside child bag");

            expected = b2;
            actual = b1.Locate(b2.FirstID) as Item;
            Assert.That(actual, Is.EqualTo(expected), "Test bag in Bag, locate b2 in b1" );

            expected = goldsword;
            actual = b2.Locate(goldsword.FirstID);
            Assert.That(actual, Is.EqualTo(expected), "Test bag in Bag, locate goldsword in b2" );
        }
       }

    }
