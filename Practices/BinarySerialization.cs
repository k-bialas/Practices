using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practices
{
    public class BinarySerialization
    {
        public void Serialize()
        {
            var obj = new ExampleObject()
            {
                Name = "Jan",
                Surname = "Kowalski",
                Age = 35,
                AmountOfCars = 2,
                DateOfBirth = new DateTime(1983, 12, 12)
            };

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFileBinarySerialization.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public void Deserialize()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("MyFileBinarySerialization.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            var obj = (ExampleObject)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine(obj.ToString());
        }
    }
}
