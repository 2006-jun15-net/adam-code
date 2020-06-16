using System;

namespace ExcerseThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number!: ");

            String userInput = Console.ReadLine();

            int number = int.Parse(userInput);
            Console.WriteLine(number);

            while (number != 1)
            {
                if (number % 2 == 0)
            {
                number = number / 2;
                Console.WriteLine(number);
            }
            else
            {
                number = number * 3 + 1;
                Console.WriteLine(number);
            }
        

            }
        }
    }
}
