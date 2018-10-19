using System;
using System.Text;

namespace Practices
{
    public class FuncDelegatePractise
    {
        private int OperationCounter;

        private int AddNumber(int a, int b)
        {
            Console.WriteLine(".....Addition");
            OperationCounter++;
            return a + b;
        }

        public string CallDelegates(int numberFirst, int numberSecond)
        {
            StringBuilder stringBuilder = new StringBuilder();

            //Function delegate
            Func<int, int, int> numberAddition = AddNumber;

            //Func with anonymous method
            Func<int, int, int> numberMultiply = delegate(int a, int b)
               {
                   Console.WriteLine(".....Multiplication");
                   OperationCounter++;
                   return a * b;
               };

            //function with lambda
            Func<int> getOperationCounter =()=> OperationCounter;

            Func<int,int,int> addAndMultiply;

            // + composing the delegate; - remove the compostied delegate
            addAndMultiply = numberAddition + numberMultiply;

            var additionResult = numberAddition(numberFirst, numberSecond);
            stringBuilder.Append("\nAddition no." + OperationCounter + " : ");
            stringBuilder.Append(additionResult);
            var multiplicationResult = numberMultiply(numberFirst, numberSecond);
            stringBuilder.Append("\nMultiplication no." + OperationCounter + " : ");
            stringBuilder.Append(multiplicationResult);
            var addAndMultiplyResult = addAndMultiply(numberFirst, numberSecond);
            stringBuilder.Append("\nAddition and Multiplication no. " + OperationCounter + " : ");
            stringBuilder.Append(addAndMultiplyResult);

            return stringBuilder.ToString();
        }
    }
}
