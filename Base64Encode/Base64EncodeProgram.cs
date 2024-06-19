using System.Text;

namespace Base64Encode
{
    public class Base64EncodeProgram
    {

        static void Main(string[] args)
        {
        }

        public static string Encode(string input)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            string encoded = Convert.ToBase64String(bytes);
            return encoded;
        }

        public static string Decode(string input)
        {
            byte[] bytes = Convert.FromBase64String(input);
            string decodedString = Encoding.UTF8.GetString(bytes);
            return decodedString;
        }
    }
}