namespace ReverseWords
{
    public class ReverseWordsProgram
    {
        static void Main(string[] args)
        {
        }

        public static string ReverseWords(string stringToReverse) => string.Join(" ", stringToReverse.Split(' ').Select(x=> new string(x.Reverse().ToArray())));
    }
}
