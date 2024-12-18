using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
 * 
 * 
 * 5 -> Print the sums of the odd and even numbers between 1 and 120 on the screen separately.*/
namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("I believe in myself, I can handle this software!");
                i++;
            }
            Console.WriteLine("------------------------------------------------------");

            int y = 1;
            while (y <= 20)
            {
                Console.WriteLine(y);
                y++;
            }

            Console.WriteLine("------------------------------------------------------");
            int x = 1;

            while (x <= 20)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);

                }
                x++;
            }
            Console.WriteLine("------------------------------------------------------");

            int sum = 0;
            int z = 50;
            while (z <= 150)
            {
                sum += z;
                z++;
            }
            Console.WriteLine(sum);
            Console.WriteLine("------------------------------------------------------");
            int sum_even = 0;
            int sum_odd = 0;
            int L = 0;
            while (L <= 120)
            {
                if (L % 2 == 0)
                {
                    sum_even += L;
                    
                }
                else 
                {
                    sum_odd += L;
                    
                }
                L++;

            }
            Console.WriteLine(sum_even);
            Console.WriteLine(sum_odd);

            Console.ReadLine();
        }
    }
}
