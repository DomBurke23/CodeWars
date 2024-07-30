namespace DidYouMean
{
    public class DidYouMeanProgram
    {
        private IList<string> words;

        public DidYouMeanProgram(IList<string> words)
        {
            this.words = words;
        }

        // calculates the Levenshtein distance between two strings and use it to find the most similar word from the dictionary. 
        public static string FindMostSimilar(DidYouMeanProgram instance, string term)
        {
            return instance.words
            .OrderBy(word => LevenshteinDistance(term, word))
            .First();
        }

        private static int LevenshteinDistance(string userInput, string disctionaryWord)
        {
            if (string.IsNullOrEmpty(userInput))
                return disctionaryWord.Length;
            if (string.IsNullOrEmpty(disctionaryWord))
                return userInput.Length;

            int[] previousRow = new int[disctionaryWord.Length + 1];
            int[] currentRow = new int[disctionaryWord.Length + 1];

            for (int j = 0; j <= disctionaryWord.Length; j++)
                previousRow[j] = j;

            for (int i = 1; i <= userInput.Length; i++)
            {
                currentRow[0] = i;

                for (int j = 1; j <= disctionaryWord.Length; j++)
                {
                    int cost = (userInput[i - 1] == disctionaryWord[j - 1]) ? 0 : 1;
                    currentRow[j] = Math.Min(
                        Math.Min(previousRow[j] + 1, currentRow[j - 1] + 1),
                        previousRow[j - 1] + cost
                    );
                }

                var temp = previousRow;
                previousRow = currentRow;
                currentRow = temp;
            }

            return previousRow[disctionaryWord.Length];
        }

        static void Main(string[] args)
        {

        }
    }
}