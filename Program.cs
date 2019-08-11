using System;

namespace ASCIIconverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a word : ");
            void Emptyline()
            {
                Console.WriteLine("");
            }
            string input = Console.ReadLine();

            Console.WriteLine("Your Input : {0}", input);
            Emptyline();
            Console.WriteLine("Output : ");
            foreach(char c in input)
            {
                Console.WriteLine(System.Convert.ToInt32(c));
            }
        }
    }
}
