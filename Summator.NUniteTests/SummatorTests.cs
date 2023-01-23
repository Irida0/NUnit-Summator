using NUnit.Framework;
using System.ComponentModel.DataAnnotations;

namespace Summator.NUniteTests
{
    public class SummatorTests
    {

        //Sum tests

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
        public void Test_Summator_SumWithZeroNumber()
        {
            var nums = new double[] { 0, 6 };
            var expected = 6;

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

        //Average tests

        [Test]
        public void Test_Summator_AveragePositiveNumbers()
        {
            var nums = new double[] { 5, 5, 5 };
            var expected = 5;

            var actual = Summator.Average(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AverageNegativeNumbers()
        {
            var nums = new double[] { -5, -5, -5 };
            var expected = -5;

            var actual = Summator.Average(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_AverageDecimalNumbers()
        {
            var nums = new double[] { 5, 4, 5.2, 5.2 };
            var expected = 4.85;

            var actual = Summator.Average(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyTwoPositiveNumbers()
        {
            var nums = new double[] { 5, 4 };
            var expected = 20;

            var actual = Summator.Multiply(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyTwoNegativeNumbers()
        {
            var nums = new double[] { -5, -4 };
            var expected = 20;

            var actual = Summator.Multiply(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyTwoDecimalNumbers()
        {
            var nums = new double[] { 2.5, 1.5 };
            var expected = 3.75;

            var actual = Summator.Multiply(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyWithZeroNumber()
        {
            var nums = new double[] { 0, 5 };
            var expected = 0;

            var actual = Summator.Multiply(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Test_Summator_MultiplyEmptyArray()
        {
            var nums = new double[] { };
            var expected = 0;

            var actual = Summator.Multiply(nums);

            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}