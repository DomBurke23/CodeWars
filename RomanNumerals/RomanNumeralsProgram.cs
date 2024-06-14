namespace RomanNumerals
{
    public class RomanNumeralsProgram
    {
        public static Dictionary<int, string> romanDict = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        static void Main(string[] args)
        {
        }

        public static string ConvertToRomanNumerals(int input)
        {
            if (input < 1 || input > 3999) throw new ArgumentOutOfRangeException(input.ToString(), "Input must be between 1 and 3999");

            // The dictionary must be in descending order to work, if we put { 1, "I" } first then all tests fail 
            string result = "";
            foreach (var pair in romanDict)
            {
                while (input >= pair.Key)
                {
                    // add the value from dictionary to create the converted value 
                    result += pair.Value;
                    // take off the key value from the input value 
                    input -= pair.Key;
                }
            }
            return result;
        }

        public static int ConvertFromRomanNumerals(string input)
        {
            int result = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string romanChar = input[i].ToString();
                string romanChars = "" ;
                if (i + 1 < input.Length) { romanChars = romanChar + input[i + 1].ToString(); }

                if (romanDict.ContainsValue(romanChar) || romanDict.ContainsValue(romanChars))
                {
                    var key = romanDict.Where(x => x.Value == romanChars || x.Value == romanChar).Select(x => x.Key).FirstOrDefault();
                    result = result + key;
                }
                if (romanDict.ContainsValue(romanChars)) i++;
            }
            return result;
        }
    }
}