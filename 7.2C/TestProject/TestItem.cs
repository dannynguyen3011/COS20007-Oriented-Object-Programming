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
    public class TestItem
    {
        new Item i = new Item(new string[] {"sword"}, "steel", "A real-killer made of steel");

   [Test]
   public void ItemIsIdentifiableTest() 
        {
            bool actual = i.AreYou("sword");

            Assert.IsTrue(actual, "Test Item AreYou a sword");

        }
    [Test]
        public void TestItemShortDesc() 
        {
            string actual = i.ShortDescription;
            string expected = "asteel sword";

            Assert.That(expected, Is.EqualTo(actual), "Test Item ShortDesc");
            
        }
  
    [Test]
        
        public void TestFullDescription()
        {
            string actual = i.FullDescription;
            string expected = "A real-killer made of steel";

            Assert.That(expected, Is.EqualTo(actual), "Test Item FullDesc");
        }
   }
}
