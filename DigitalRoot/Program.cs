namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            var digitalRoot16 = DigitalRoot(16); // Should return 7 
            var digitalRoot456 = DigitalRoot(456); // Should return 6
            Console.WriteLine($"digitalRoot16 = {digitalRoot16} \n" +
                $"digitalRoot456 = {digitalRoot456}");
        }

        public static int DigitalRoot(long n)
        {
            while (n > 9)
            {
                n = n.ToString().ToCharArray().Sum(x => x - '0');
            }
            return ((int)n);
        }
    }
}
