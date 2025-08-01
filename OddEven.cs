using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OddEven
{
    internal class OddEven
    {
        public void Oddeven(int n)
        {

            if (n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
        public void display(int n)
        {
            Console.WriteLine($"The number is {n}");
        }
    }
}