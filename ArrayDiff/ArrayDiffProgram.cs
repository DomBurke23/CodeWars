namespace ArrayDiff
{
    public class ArrayDiffProgram
    {
        static void Main(string[] args)
        {
        }

        public static int[] ArrayDiffsV1(int[] a, int[] b)
        {
            var list = a.ToList();
            foreach (var i in b)
            {
                list.RemoveAll(x => x == i);
            }

            return list.ToArray();
        }


        public static int[] ArrayDiffs(int[] a, int[] b)
        {
            return a.Where(n => !b.Contains(n)).ToArray();
        }
    }
}
