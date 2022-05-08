using NUnit.Framework; // import class / library

namespace Summator.Tests // simulator test

{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            long expected = 12;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });
            long expected = 5;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Sum_TwoNegativeNumber()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });
            long expected = -16;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] {  });
            long expected = 0;
            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000, 2000000, 2000000, 2000000 });
            
            Assert.AreEqual(8000000, actual);
        }
        public void Test_Average_TwoPossitiveNumbers()
        {
            int actual = Summator.Average(new int[] { 5, 7 });
            int expected = 6;


            Assert.That(expected == actual);
        }
    }
}
