using System;

namespace Test_Answer_No._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount of boxes in bucket 1: ");
            int bucket1 = int.Parse(Console.ReadLine());
            Console.Write("Amount of boxes in bucket 2: ");
            int bucket2 = int.Parse(Console.ReadLine());
            Console.Write("Amount of boxes in bucket 3: ");
            int bucket3 = int.Parse(Console.ReadLine());
            int turn = 1;


            while (bucket1 > 0 || bucket2 > 0 || bucket3 > 0)
            {
                if (turn % 2 == 1)
                {
                    Console.Write("Player A take from bucket number: ");
                    int numbucketa = int.Parse(Console.ReadLine());
                    Console.Write("Player A take: ");
                    int amountboxa = int.Parse(Console.ReadLine());
                    switch (numbucketa)
                    {
                        case 1:
                            bucket1 = bucket1 - amountboxa;
                            break;
                        case 2:
                            bucket2 = bucket2 - amountboxa;
                            break;
                        case 3:
                            bucket3 = bucket3 - amountboxa;
                            break;
                    }
                    turn++;
                }
                else if (turn % 2 == 0)
                {
                    Console.Write("Player B take from bucket number: ");
                    int numbucketb = int.Parse(Console.ReadLine());
                    Console.Write("Player B take: ");
                    int amountboxb = int.Parse(Console.ReadLine());
                    switch (numbucketb)
                    {
                        case 1:
                            bucket1 = bucket1 - amountboxb;
                            break;
                        case 2:
                            bucket2 = bucket2 - amountboxb;
                            break;
                        case 3:
                            bucket3 = bucket3 - amountboxb;
                            break;
                    }
                    turn++;
                }
            }
            if (turn % 2 == 1)
            {
                Console.WriteLine("Player A Wins.");
            }
            else if (turn % 2 == 0)
            {
                Console.WriteLine("Player B Wins.");
            }
            Console.ReadLine();
        }
    }
}
