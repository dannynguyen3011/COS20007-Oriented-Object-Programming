using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask
{
    
    public class CounterTest
    {
        Counter _testCounter;
        [SetUp]
        public void SetUp() 
        {
            _testCounter = new Counter("Test Counter");

        }
        [Test]
        public void testInitializeCounterToZero() 
        {
            Assert.AreEqual(0, _testCounter.Ticks); 
        }

        [Test]
        public void testCounterName() 
        {
            Assert.AreEqual("Test Counter", _testCounter.Name);
        }
        [TestCase(2, 2)]
        [TestCase(10, 10)]

        public void testIncrementCounter(int increment, int expectingResult)
        {
            for(int i = 0; i < increment; i++)
            {
                _testCounter.Increment();

            }
            Assert.AreEqual(_testCounter.Ticks, expectingResult);
        }
        [Test]
        public void testCounterReset()
        {
            _testCounter.Increment();
            _testCounter.Reset();
            Assert.AreEqual(0, _testCounter.Ticks );
        }
    }
}
