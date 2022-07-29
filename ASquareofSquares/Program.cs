namespace ASquareofSquares
{
    class Program
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

        // TODO: Given an integral number, determine if it's a square number. 
        public static bool Square(int numberToCheck)
        {
            var temp = Math.Sqrt(numberToCheck);
            return temp % 1 == 0;
        }
    }
}
