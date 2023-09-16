using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace IdentifiableObject_MAIN
{
    [TestFixture]
    internal class IdentifiableObjectTest
    {
        IdentifiableObject testObject, testCase, testNull;

        [SetUp]
        public void Setup()
        {
            testObject = new IdentifiableObject(new string[] { "hello", "Dung" });
            testCase = new IdentifiableObject(new string[] { "Hello", "Danny" });
            testNull = new IdentifiableObject(new string[] { });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(testObject.AreYou("hello"));
            Assert.IsTrue(testObject.AreYou("Dung"));
        }

        [Test]
        public void TestNotAreYou()
        {
            Assert.IsFalse(testObject.AreYou("whatsup"));
            Assert.IsFalse(testObject.AreYou("me"));
        }
        [Test]
        public void TestCaseSensitive()
        {
            Assert.IsTrue(testCase.AreYou("Hello"));
            Assert.IsTrue(testCase.AreYou("DaNny"));
        }

        [Test]
        public void TestFirstID()
        {
            StringAssert.AreEqualIgnoringCase("hello", testObject.FirstID);
        }

        public void TestNullFirstID()
        {
            StringAssert.AreEqualIgnoringCase("", testNull.FirstID);
        }

        [Test]
        public void TestAddID()
        {
            testObject.AddIdentifier("Nguyen");
            Assert.IsTrue(testObject.AreYou("hello"));
            Assert.IsTrue(testObject.AreYou("Dung"));
            Assert.IsTrue(testObject.AreYou("Nguyen"));
        }
    }
}
