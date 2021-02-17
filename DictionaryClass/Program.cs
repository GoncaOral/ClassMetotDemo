using System;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int , string> colors = new MyDictionary<int, string>();
            colors.Add(1, "Black");
            colors.Add(2, "White");
            colors.Add(3, "Green");
            colors.Add(4, "Red");

            foreach (var item in colors.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (var item in colors.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(".............................................................");
            colors.List();
        }
    }
}
