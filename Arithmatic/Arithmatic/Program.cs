namespace Arithmatic
{
    public class arithmetic 
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /, %): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter second number: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            switch (op)
            {
                case '+': result = a + b; break;
                case '-': result = a - b; break;
                case '*': result = a * b; break;
                case '/': result = b != 0 ? a / b : double.NaN; break;
                case '%': result = b != 0 ? a % b : double.NaN; break;
                default: Console.WriteLine("Invalid operator!"); return;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}
       

