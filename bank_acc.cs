using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_account
{
    public class bank_acc
    {
        public void withdraw(int amount)
        {
            Console.WriteLine($"{amount} withdrawn");
        }
        public void deposit(int amount)
        {
            Console.WriteLine($"{amount} deposited");
        }
    }
    public class sales_acc : bank_acc
    {
        public void interest(int p, int r, int t)
        {
            int si;
            si = p * r * t / 100;
            Console.WriteLine($"Simple Interest: {si}");

        }
    }
}