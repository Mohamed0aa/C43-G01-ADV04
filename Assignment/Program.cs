namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);

            //Stack<int> helper = new Stack<int>();
            //foreach (int i in queue)
            //{
            //    helper.Push(i);
            //}
            //foreach (int i in helper)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  q2
            Stack<char> stack = new Stack<char>();
            string q= "[()]{ }";

            for (int i = 0; i < q.Length; i++)
            {
                
                if (q[i] =='(' || q[i]=='[' || q[i]=='{')
                    stack.Push(q[i]);
                else if (q[i]==')' && stack.Peek()=='(' )
                    stack.Pop();
                else if (q[i] == ']' && stack.Peek() == '[' )
                    stack.Pop();
                else if (q[i] == '}' && stack.Peek() == '{' )
                    stack.Pop();
                else
                    break;
            }
            if(stack.Count == 0) 
                Console.WriteLine("balanced");
            else
                Console.WriteLine("not balanced");

            #endregion

        }
    }
}
