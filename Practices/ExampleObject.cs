using System;
using System.Text;

namespace Practices
{
    [Serializable]
    public class ExampleObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int AmountOfCars { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("");
            stringBuilder.AppendLine("Name: " + Name);
            stringBuilder.AppendLine("Surname: " + Surname);
            stringBuilder.AppendLine("Age: " + Age);
            stringBuilder.AppendLine("Amount of cars: " + AmountOfCars);
            stringBuilder.AppendLine("DateOfBirth: " + DateOfBirth);

            return stringBuilder.ToString();
        }
    }
}
