using ATTCoreWebApp;
using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //jjadeja
            var objPrimeService = new PrimeService();
            bool value = objPrimeService.IsPrime(16);
            Assert.IsFalse(value);
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            //jjadeja
            var objPrimeService = new PrimeService();
            bool value = objPrimeService.IsPrime(9);
            Assert.IsFalse(value);
            Assert.Pass();
        }
        [Test]
        public void Test3()
        {
            //test
            var objPrimeService = new PrimeService();
            bool value = objPrimeService.IsPrime(1);
            Assert.IsFalse(value);
            Assert.Pass();
        }
        [Test]
        public void Test4()
        {
            //test
            var objPrimeService = new PrimeService();
            bool value = objPrimeService.IsPrime(5);
            Assert.IsTrue(value);
            Assert.Pass();
        }
    }
}
