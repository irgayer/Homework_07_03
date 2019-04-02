using System;

namespace Homework_07_03
{
    [IsProduct(true)]
    [Serializable]
    public class Book
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

    }
}
