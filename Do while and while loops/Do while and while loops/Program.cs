using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while_and_while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("choose your limit for the while loop");
            int limit = Convert.ToInt32(Console.ReadLine());

            while (counter <= limit)
            {
                Console.WriteLine("i am a patika student");
                counter++;
            }

            Console.WriteLine("choose your limit again for the do-while loop");
            int limit2 = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("i am a patika student");
                counter++;
            } while (counter <= limit);

            // While döngüsü ile do-while döngüsü arasındaki fark, do-while döngüsünde döngünün koşul kontrolünden önce bir kez çalıştırılmasıdır. Bu yüzden, -5 gibi bir sayı girildiğinde, do-while döngüsü mesajı bir kez yazdırır ve ardından döngüden çıkar. Ancak, while döngüsü önce koşulu kontrol eder ve yalnızca koşul sağlanıyorsa mesajı yazdırır

            Console.ReadLine();
        }
    }
}
