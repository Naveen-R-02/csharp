using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pno
{
    public class number
    {
        public void calc(int n)
        {
            if (n > 0)
            {
                Console.WriteLine($"{n} is positive");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} is negative");
            }
            else
            {
                Console.WriteLine($"{n} equal to 0");
            }
        }
    }
}
