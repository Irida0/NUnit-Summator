using NUnit.Framework;

namespace Summator.NUniteTests
{
    public class SummatorTests
    {

        [Test]
        public void Test_Summator_SumTwoPositiveNumbers() 
        {
            //Arrange
            var nums = new double[] { 1, 2 };
            var expected = 3;
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(expected));  
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            var nums = new double[] { -1, -2 };
            var expected = -3;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            var nums = new double[] { 3 };
            var expected = 3;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            var nums = new double[] { 2000000000, 5000000000 };
            var expected = 7000000000;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumZeroNumber()
        {
            var nums = new double[] { 0 };
            var expected = 0;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumTwoDecimalNumbers()
        {
            var nums = new double[] { 2.5, 1.2 };
            var expected = 3.7;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_SumEmptyArray()
        {
            var nums = new double[] { };
            var expected = 0;

            var actual = Summator.Sum(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }
  
    }
}