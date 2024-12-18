using System;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i believe in myslef, i can hande this software");
            }
            Console.WriteLine("-------------------------------------------------------");
            for (int i = 1; i <=20; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------------------------");
            for(int i = 1; i <=20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("-------------------------------------------------------");
            int sum = 0;
            for (int i = 50; i <= 150; i++)
            {
                sum += i;
                
            }
            Console.WriteLine(sum);
            Console.WriteLine("-------------------------------------------------------");
            int even = 0;
            int odd = 0;
            for (int i = 1; i <= 120; i++)
            {
                if ((i % 2) == 0) { even += i; }
                else{ odd += i; }
            }
            Console.WriteLine("sum of even numbers are: " + even);
            Console.WriteLine("sum of odd numbers are: " + odd);
            Console.ReadLine();
        }
    }
}
