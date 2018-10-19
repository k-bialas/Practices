using System;
using System.Text;

namespace Practices
{
    public class DelegatesPractise
    {
        private delegate int NumberChanger(int numberFirst, int numberSecond);
        private int OperationCounter;

        private int AddNumber(int a, int b)
        {
            Console.WriteLine(".....Addition");
            OperationCounter++;
            return a + b;
        }

        private int MultiplyNumber(int a, int b)
        {
            Console.WriteLine(".....Multiplication");
            OperationCounter++;
            return a * b;
        }

        public string CallDelegates(int numberFirst, int numberSecond)
        {
            StringBuilder stringBuilder = new StringBuilder();
            NumberChanger numberAddition = new NumberChanger(AddNumber);
            NumberChanger numberMultipy = new NumberChanger(MultiplyNumber);
            NumberChanger addAndMultiply;

            // + composing the delegate; - remove the compostied delegate
            addAndMultiply = numberAddition + numberMultipy;

            var additionResult = numberAddition(numberFirst, numberSecond);
            stringBuilder.Append("\nAddition no." + OperationCounter + " : ");
            stringBuilder.Append(additionResult);
            var multiplicationResult = numberMultipy(numberFirst, numberSecond);
            stringBuilder.Append("\nMultiplication no." + OperationCounter + " : ");
            stringBuilder.Append(multiplicationResult);
            var addAndMultiplyResult = addAndMultiply(numberFirst, numberSecond);
            stringBuilder.Append("\nAddition and Multiplication no. " + OperationCounter + " : ");
            stringBuilder.Append(addAndMultiplyResult);

            return stringBuilder.ToString();
        }
    }
}
