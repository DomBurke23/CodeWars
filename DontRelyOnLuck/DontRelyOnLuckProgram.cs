namespace DontRelyOnLuck
{
    public class DontRelyOnLuckProgram
    {
        public static int Guess = 1;

        static void Main(string[] args)
        {
        }

        public static int DontRelyOnLuck()
        {
            return Guess;
        }
    }
}

namespace UnitTests
{
    public class Random
    {
        public int Next(int min, int max)
        {
            return 1;
        }
    }
}