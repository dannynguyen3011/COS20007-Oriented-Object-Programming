using NUnit.Framework;
using SwinAdventure;


namespace SwinAdventure
{
    [TestFixture]
    public class TestInventory
    {
        Item itm = new Item(new string[] { "sword" }, "steel", "A real - killer made of steel");
        Item itm2 = new Item(new string[] { "sword" }, "gold", "A gold sword");
        [Test]
        public void TestFindItem()
        {
            Inventory i = new Inventory();
            i.Put(itm);
            bool actual = i.HasItem(itm.FirstID);
            Assert.IsTrue(actual, "Test Inventory has Item by First ID");
        }

        [Test]
        public void TestNoItemFind()
        {
            Inventory i = new Inventory();
            i.Put(itm);
            bool actual = i.HasItem("pencil");

            Assert.IsFalse(actual, "Test Inventory does not have item by First ID");

        }

        [Test]

        public void TestFetchItem() 
        {
            Inventory i = new Inventory();

            i.Put(itm);
            Item takeItem = i.Fetch(itm.FirstID);
            Assert.That(itm, Is.EqualTo(takeItem), "Test Inventory Fetch that item is not taken");


        }
        [Test]
        public void TestTakeItem()
        {
            Inventory i = new Inventory();
            i.Put(itm2);

            Item takeItem = i.Take(itm2.FirstID);
            bool actual = i.HasItem(itm2.FirstID);

            Assert.IsFalse(actual, "Test Inventory Item that Item cannot be found");
        }

        [Test]
        public void TestItemList()
        {
            Inventory i = new Inventory();

            i.Put(itm);
            i.Put(itm2);
            string actual = i.ItemList;
            string expected = "   asteel sword\r\n   agold sword\r\n";

            Assert.That(actual, Is.EqualTo(expected), "Test Inventory list, should be a formatted list");
        }
    }
}