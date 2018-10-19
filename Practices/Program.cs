using System;

namespace Practices
{
    public class Program
    {
        public static void ResultPrint(string output)
        {
            Console.Write(output);
            Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            Action<string> printOutput = ResultPrint; 

            DelegatesPractise delegatesPractise = new DelegatesPractise();
            printOutput(delegatesPractise.CallDelegates(10, 5));


            FuncDelegatePractise funcDelegatePractise = new FuncDelegatePractise();
            printOutput(funcDelegatePractise.CallDelegates(10, 5));

            //Extension Methods

            int i = 101;

            bool result = i.IsGreaterThan(100);

            Console.WriteLine("\n");
            Console.WriteLine(result);
            Console.ReadKey(); 
        }
    }
}
