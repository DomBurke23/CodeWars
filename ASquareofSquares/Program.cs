using Xunit;

namespace ASquareofSquares
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var attempt1 = Square(-1);
            var attempt2 = Square(0);
            var attempt3 = Square(3);
            var attempt4 = Square(4);
            var attempt5 = Square(25);
            var attempt26 = Square(25);
        }

        public static bool Square(int numberToCheck) => Math.Sqrt(numberToCheck) % 1 == 0;

    }

    public class XunitTests
    {
        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(25, true)]
        [InlineData(26, false)]
        public static void Tests(int numberToCheck, bool expectedResult)
        {
            var actualResult = Program.Square(numberToCheck);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
