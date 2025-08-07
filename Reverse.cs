using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace reverse
{
    public class Reverse
    {
        public void rev(int number)
        {
            int rem, reverse = 0;
            while (number > 0)
            {  
                rem = number % 10;
                reverse = (reverse * 10) + rem;
                number = number / 10;
            }
            Console.WriteLine($"Reverse of number is {reverse}");
        }
    }
}
