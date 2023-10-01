using System;

namespace SecondChapter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? isFalse = null;
            switch (isFalse)
            {
                case true:
                    Console.WriteLine("Yes!");
                    break;
                case false:
                    Console.WriteLine("No!");
                    break;
                default:
                    Console.WriteLine("Maybe?");
                    break;
            }

            string[] names = { "Arthur", "Gabriel", "Victor", "João" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
