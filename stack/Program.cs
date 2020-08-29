using System;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            void Populate()
            {
                Console.WriteLine("populating stack");
                stack.Push(1);
                stack.Push("mosh");
                stack.Push(DateTime.Now);
            }
            Populate();

            Console.WriteLine("popping from stack...");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(stack.Pop());

            Populate();
            Console.WriteLine("clearing stack");
            stack.Clear();
            stack.Clear();


            try
            {
                Console.WriteLine(stack.Pop());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
