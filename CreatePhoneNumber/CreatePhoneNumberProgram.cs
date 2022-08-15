namespace CreatePhoneNumber
{
    public class CreatePhoneNumberProgram
    {
        static void Main(string[] args)
        {
        }

        public static string CreatePhoneNumber(int[] numbers) => Convert.ToInt64(string.Join("", numbers)).ToString("(000) 000-0000");
    }
}
