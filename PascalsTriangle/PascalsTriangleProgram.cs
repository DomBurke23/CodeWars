namespace PascalsTriangle
{
    /*
     * Write a function that, given a depth n, returns n top rows of Pascal's Triangle flattened into a one-dimensional list/array. 
     */
    public class PascalsTriangleProgram
    {
        static void Main(string[] args)
        {
        }

        public static List<int> PascalsTriangle(int n)
        {
            var result = new List<int>();

            for (int i = 0; i < n; i++)
            {
                /*
                 * For each row, we create a new array row of size i + 1, where i is the current row index.
                 */
                int[] row = new int[i + 1];
                row[0] = row[i] = 1;

                for (int j = 1; j < i; j++)
                {
                    row[j] = result[(i - 1) * i / 2 + j - 1] + result[(i - 1) * i / 2 + j];
                }

                result.AddRange(row);
            }

            return result;
        }
    }
}
