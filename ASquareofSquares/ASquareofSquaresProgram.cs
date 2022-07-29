namespace ASquareofSquares
{
    public class ASquareofSquaresProgram
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
}
