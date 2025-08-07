using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace sumofdigits
{
    public class Sum
    {
        public void sum(int number)
        {
            int rem, sum = 0;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + rem;
                number = number / 10;
            }
            Console.WriteLine($"sum of digits is {sum}");

        }
    }
}
