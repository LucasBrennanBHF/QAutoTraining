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
        [InlineData(1, 15, new string[]{ "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
        [InlineData(16, 30, new string[]{ "16", "17", "Fizz", "19", "Buzz", "Fizz", "22", "23", "Fizz", "Buzz", "26", "Fizz", "28", "29", "FizzBuzz" })]
        public void GivenAValidPairOfNumber_FizzBuzz_ReturnsAExpectedResult(int lowerBound, int upperBound, string[] expectedResult)
        {
            Assert.True(_sutFizzBuzz.GenerateFizzBuzz(lowerBound, upperBound) == expectedResult.ToList(), "Number list was not as expected");
        }
    }
}