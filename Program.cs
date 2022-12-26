using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers to get the perfect numbers between them : ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; ++i) {
                int cnt = 1;
                for (int j = i / 2; j >= 2; j--) {
                    if (i % j == 0) cnt += j;
                }
                if (cnt == i) Console.WriteLine(i);
            }
        }
    }
}
