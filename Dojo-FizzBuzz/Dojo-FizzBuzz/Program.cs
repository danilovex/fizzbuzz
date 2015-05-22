using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo_FizzBuzz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(escrever());
        }
        public static List<int> escrever()
        {
            List<int> UmACem = new List<int>();
            for (int i = 1; i < 101; i++)
            {
                UmACem.Add(i);
            }

            return UmACem;
        }
        public static bool Divisivel(int n, int div)
        {
            return (n % div) == 0;
        }

        public static string ObterFizzBuzz(int n)
        {
            if (Program.Divisivel(n, 3))
                return "FIZZ";
            else if (Program.Divisivel(n, 5))
                return "BUZZ";

            return n.ToString();
        }
    }
}
