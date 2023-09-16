using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTask  
{
    public class ClockTest
    {
        Clock _clock;
        [SetUp]
        public void Setup()
        {
            _clock = new Clock();
        }

        [Test]
        public void TestClockTimeFormat()
        {
            Assert.AreEqual("00:00:00", _clock.Time());

        }
        
        [TestCase(0, "00:00:00")]
        [TestCase(3011, "00:50:11")]
        [TestCase(86468, "00:01:08")]

        public void TestCLockTick(int ticks, string expectedResult)
        {
            for(int i = 0; i < ticks; i++)
            {
                _clock.Tick();
            }
            Assert.AreEqual(expectedResult, _clock.Time(), "Clock did not tick correctly.");
        }
        [Test]
        public void TestClockReset() 
        {
            for ( int i = 0; i < 3550; i++)
            {
                _clock.Tick();
            }
            _clock.Reset();
            Assert.AreEqual("00:00:00", _clock.Time(), "Clock reset did not reset to 0.");
        }
    }
}