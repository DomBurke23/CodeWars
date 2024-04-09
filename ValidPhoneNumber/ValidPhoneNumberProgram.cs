using System.Text.RegularExpressions;

namespace ValidPhoneNumber
{
    /*
     * Write a function that accepts a string, and returns true if it is in the form of a phone number.
     * Assume that any integer from 0-9 in any of the spots will produce a valid phone number.
     * Only worry about the following format:
     * (123) 456-7890 (don't forget the space after the close parentheses)
     */

    public partial class ValidPhoneNumberProgram
    {
        static void Main(string[] args)
        {
        }

        public static bool ValidPhoneNumberCheck(string phoneNumber)
        {
            return MyRegex().IsMatch(phoneNumber);
        }

        [GeneratedRegex(@"^\(\d{3}\)\s\d{3}-\d{4}$")]
        private static partial Regex MyRegex();
    }
}