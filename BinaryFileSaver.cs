using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Homework_07_03
{
    public class BinaryFileSaver
    {
        private BinaryFormatter formatter;
        public BinaryFileSaver()
        {
            formatter = new BinaryFormatter();
        }
        public void Save<T>(List<T> objectsList, string fileName)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(stream, objectsList);
            }
            Console.WriteLine("Файл сохранен");
        }

        public List<T> Load<T>(string fileName)
        {
            List<T> result = new List<T>();
            using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                result = (List<T>)formatter.Deserialize(stream);
            }
            Console.WriteLine($"List<{typeof(T).Name}> Загружен из файла\n");
            return result;
        }
    }
}
