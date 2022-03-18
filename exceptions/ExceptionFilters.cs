/*
 
💜 C# Exception filters 💜


Allow to make a catch block conditional.


→ catch exceptions only if the condition is true


→ surgically specificy the exceptions to handle


→ don’t unwind the stack if the condition is false

----------------------------------------

*/


using System;

namespace Exceptions
{

    public class MyException : Exception
    {
        public int code;
        public MyException(string message) : base(message)
        {
            if (message == null) code = 43;
        }
    }

    class Program
    {
        public static void DoSomethingThatMightFail(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
        }
        static void Main(string[] args)
        {
			// with filter
            try
            {
                DoSomethingThatMightFail(null);
            }
            catch (MyException ex) when (ex.code == 43)
            {
                Console.WriteLine("Error 43 occurred");
            }
			
			// without filter
            try
            {
                DoSomethingThatMightFail(null);
            }
            catch (MyException ex)
            {
                if (ex.code == 43)
                    Console.WriteLine("Error 43 occurred");
                else
                    throw;
            }

        }
    }
}
