using System.Text.RegularExpressions;

namespace CreatePhoneNumber
{
    public class CreatePhoneNumberProgram
    {
        static void Main(string[] args)
        {
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            var format = "(000) 000-0000";
            return long.Parse(string.Concat(numbers)).ToString(format);
        }
    }
}
