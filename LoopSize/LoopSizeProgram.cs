namespace LoopSize
{
    public class LoopSizeProgram
    {
        static void Main(string[] args)
        {
        }

        public static void getLoopSize()
        { 
        
        }

        //public static int getLoopSize(LoopDetector.Node startNode)
        //{
        //    LoopDetector.Node slow_pointer = startNode, fast_pointer = startNode;

        //    while (slow_pointer != null && fast_pointer != null
        //      && fast_pointer.next != null)
        //    {
        //        slow_pointer = slow_pointer.next;
        //        fast_pointer = fast_pointer.next.next;

        //        /* If slow_p and fast_p meet at some point
        //        then there is a loop */
        //        if (slow_pointer == fast_pointer)
        //            return countNodes(slow_pointer);
        //    }

        //    /* Return 0 to indicate that there is no loop*/
        //    return 0;
        //}

        //// Returns count of nodes present in loop.
        //static int countNodes(LoopDetector.Node currentNode)
        //{
        //    int res = 1;
        //    LoopDetector.Node node = currentNode;
        //    while (node.next != currentNode)
        //    {
        //        res++;
        //        node = node.next;
        //    }
        //    return res;
        //}
    }
}
