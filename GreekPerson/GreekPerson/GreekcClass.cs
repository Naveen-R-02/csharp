using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreekPerson
{
    public class GreekClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
 "Enter name:");
            String name = Console.
 Readline();
            Greek g = new Greek(name);
            g.greek();

        }
    }
}
