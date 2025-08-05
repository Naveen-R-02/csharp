using System.Security.Cryptography.X509Certificates;

namespace pno
{
    public class Program
    {
        static void Main(string[] args)
        {
            number Number = new number();
            int m = 5;
            int x = -10;
            int y = 0;
            Number.calc(m);
            Number.calc(x);
            Number.calc(y);
        }
    }
}
