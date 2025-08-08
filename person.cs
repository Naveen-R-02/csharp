using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    public class person
    {
        string name;
        public void names()
        {
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();

        }
        public void display()
        {
            Console.WriteLine("Your name ="+ name);
        }
    }
}
