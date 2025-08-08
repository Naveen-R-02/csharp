using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEncapsulation
{
    public class DataenCapsule
    {
        private string name;
        private int age;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
            public int Age{
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    Console.WriteLine("Age should be between 0 to 100");
            }
        }
        public void display()
        {
            Console.WriteLine($"Name and Age of the person is {name},{age}");
        }
    }
    }

