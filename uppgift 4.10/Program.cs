using System;

namespace uppgift_4_10
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int svar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int svar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad?");
            int svar3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int svar4 = int.Parse(Console.ReadLine());

            for (int i = 0;i < svar4; i++)
            {
                Console.WriteLine("");
                for (int m = 0; m < svar1; m++)
                {
                    Console.Write("X");
                }
                for (int j = 0;j < svar3 ; j++)
                {
                    Console.Write("-");
                    for (int k = 0; k < svar2; k++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                    for (int  l = 0;l < svar1; l++)
                    {
                        Console.Write("X");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
