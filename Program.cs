using System;
using System.Collections.Generic;

namespace Homework_07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            BinaryFileSaver fileSaver = new BinaryFileSaver();
            Type type = typeof(Book);
            object[] attributes = type.GetCustomAttributes(false);

            books.Add(new Book() { Name = "Заводной апельсин", Cost = 1100, Author = "Энтони Берджес", Date = new DateTime(1962, 6, 4) });
            books.Add(new Book() { Name = "Бойцовский клуб", Cost = 1984, Author = "Чак Паланик", Date = new DateTime(1996, 08, 17) });

            fileSaver.Save(books, "books.bin");
            List<Book> deserializedBooks = fileSaver.Load<Book>("books.bin");

            Console.WriteLine("Books' attributes:");
            foreach(var attr in attributes)
            {
                Console.WriteLine($"Attribute: {attr.ToString()}");
            }

            Console.WriteLine();
            foreach(var b in deserializedBooks)
            {
                Console.WriteLine($"{b.Name} : {b.Cost}тг");
            }



        }
    }
}
