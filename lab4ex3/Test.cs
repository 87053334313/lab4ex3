using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4ex3
{
    public class Utils
    { 
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            if (n < 0)
            {
                ok = false;
            }
            try
            {
                checked
                {
                    for (k = 2; k <= n; k = k + 1)
                    {
                        f = f * k;
                    }
                    answer = f;
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;

        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            bool ok;
            int f;
            Console.WriteLine("Введи х");
            int x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok == true)
            {
                Console.WriteLine("x= " + x + "  f = " + f);
            }
            else 
            {
                Console.WriteLine("Произошла ошибка");
            }
            Console.ReadKey();
        }

    }
    
}
