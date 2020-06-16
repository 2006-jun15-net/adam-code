using System;

namespace ExcerseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!: ");

            String userInput = Console.ReadLine();

            int number = int.Parse(userInput);
            for (int x = 0; x<=number; x++)
            {
                for(int y = 0;y<=(number-x); y++)
                {
                    Console.Write(" ");
                }
                for (int z = number; z>+(number-x); z--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

        }
    }
}