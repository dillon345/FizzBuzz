using FizzBuzz.Library;
using Xunit;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzzService FizzBuzz;

        public FizzBuzzTests()
        {
            FizzBuzz = new FizzBuzzService();
        }

        [Fact]
        public void ShouldReturnNumber()
        {
            Assert.Equal("1", FizzBuzz.Print(1));

            Assert.Equal("2", FizzBuzz.Print(2));
        }

        [Fact]
        public void ShouldReturnFizz()
        {
            Assert.Equal("Fizz", FizzBuzz.Print(3));
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            Assert.Equal("Buzz", FizzBuzz.Print(5));
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            Assert.Equal("FizzBuzz", FizzBuzz.Print(15));
        }
    }
}