using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator.UnitTests
{
    public class SummatorTests
    {
        //Sum of numbers
        [Test]
        public static void TestSumOfTwoPositiveNumbers()
        {
            var numbers = new int[] { 1, 2, };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 3;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestSumOfTwoNegativeNumbers()
        {
            var numbers = new int[] { -1, -99 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = -100;
            Assert.That(actualResult, Is.EqualTo(expectedResult));

        }

        [Test]
        public static void TestSumOfOnePositiveNumber()
        {
            var numbers = new int[] { 6 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 6;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestSumOfZeroNumbers()
        {
            var numbers = new int[] { 0 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 0;
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public static void TestSumOfBigNumbers()
        {
            var numbers = new int[] { 1000000000, 2000000000, 1000000000 };
            var actualResult = Summator.Sum(numbers);
            var expectedResult = 4000000000;
            Assert.That(actualResult, Is.EqualTo(expectedResult));


        }

        //Average of numbers
        [Test]
        public static void TestAverageOfTwoPositiveNumbers()
        {
            var numbers = new int[] { 5, 7 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = 6;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfTwoNegativeNumbers()
        {
            var numbers = new int[] { -10, -340 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = -175;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfOnePositiveNumber()
        {
            var numbers = new int[] { 11 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = 11;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfOneNegativeNumber()
        {
            var numbers = new int[] { -11 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = -11;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfZeroNumbers()
        {
            var numbers = new int[] { 0 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = 0;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public static void TestAverageOfBigPositiveNumbers()
        {
            var numbers = new int[] { 4124215, 123131, 222 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = 1415856;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfBigNegativeNumbers()
        {
            var numbers = new int[] { -4124215, -123131, -33 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = -1415793;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfTwoPositiveNumbersAndOneNegative()
        {
            var numbers = new int[] { -1231, 222, 10 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = -333;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public static void TestAverageOfTwoNegativeNumbersAndOnePositive()
        {
            var numbers = new int[] { 1231, -222, -10 };
            var actualResult = Summator.Average(numbers);
            var expectedResult = 333;
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}