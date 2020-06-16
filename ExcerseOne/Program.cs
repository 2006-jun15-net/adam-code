using System;

namespace ExcerseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x<=8; x++)
            {
                for(int y = 0;y<=(8-x); y++)
                {
                    Console.Write(" ");
                }
                for (int z = 8; z>+(8-x); z--)
                {
                    Console.Write("#");
                }
                Console.WriteLine("");
            }

        }
    }
}
