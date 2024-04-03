using FizzBuzzApp;

namespace FizzBuzzTests
{
    public class FizzBuzzUnitTests
    {
        private FizzBuzz _sutFizzBuzz;
        public FizzBuzzUnitTests() 
        {
            _sutFizzBuzz = new FizzBuzz();
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "7")]
        [InlineData(1, "1")]
        [InlineData(2001, "Fizz")]
        [InlineData(110, "Buzz")]
        [InlineData(105, "FizzBuzz")]
        [InlineData(5314, "5314")]
        public void GivenAValidNumber_FizzBuzz_ReturnsTheExpectedResult(int number, string expectedResult)
        {
            string result = _sutFizzBuzz.GetFizzBuzzAnswer(number);
            Assert.True(result == expectedResult, $"Returned result was not expected {expectedResult} but was {result}");
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, 
            new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        [InlineData(new int[] { 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 },
            new string[] { "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz" })]
        [InlineData(new int[] { 111, 7, 200, 52, 201, 555 },
            new string[] { "Fizz", "7", "Buzz", "52", "Fizz", "FizzBuzz" })]
        public void GivenAValidList_FizzBuzz_ReturnsAExpectedResult(int[] numbers, string[] expectedResult)
        {
            Assert.True(_sutFizzBuzz.GetFizzBuzzAnswer(numbers.ToList()) == expectedResult.ToList(), "Number list was not as expected");
        }

        [Theory]
        [InlineData(1, 15, new string[]{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        [InlineData(16, 30, new string[]{ "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz" })]
        public void GivenAValidPairOfNumber_FizzBuzz_ReturnsAExpectedResult(int lowerBound, int upperBound, string[] expectedResult)
        {
            Assert.True(_sutFizzBuzz.GenerateFizzBuzz(lowerBound, upperBound) == expectedResult.ToList(), "Number list was not as expected");
        }
    }
}