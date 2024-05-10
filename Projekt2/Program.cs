using System.Text;

namespace Projekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
        
            var dictionary = new Dictionary<dynamic, dynamic>
            {
                { "apple", "яблуко" },
                { "banana", "банан" },
                { "car", "автомобіль" },
                { "house", "будинок" },
                { "dog", "собака" },
                { "cat", "кіт" },
                { "tree", "дерево" },
                { "sun", "сонце" },
                { "moon", "місяць" },
                { "computer", "комп'ютер" }
            };

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }

            Console.ReadLine();
        }
    }
}
